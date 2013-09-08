using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using McTools.Xrm.Connection.WinForms;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.IO;
using Microsoft.Ajax.Utilities;

namespace CRMinify
{
    public partial class Form1 : Form
    {
        #region Variables

        /// <summary>
        /// Dynamics CRM 2011 organization service
        /// </summary>
        IOrganizationService service;

        /// <summary>
        /// Connection control
        /// </summary>
        CrmConnectionStatusBar ccsb;

        /// <summary>
        /// Connection manager
        /// </summary>
        ConnectionManager cManager;

        private FormHelper formHelper;

        #endregion Variables

        #region Constructor

        public Form1()
        {
            InitializeComponent();

            // Create the connection manager with its events
            this.cManager = new ConnectionManager();
            this.cManager.ConnectionSucceed += new ConnectionManager.ConnectionSucceedEventHandler(cManager_ConnectionSucceed);
            this.cManager.ConnectionFailed += new ConnectionManager.ConnectionFailedEventHandler(cManager_ConnectionFailed);
            this.cManager.StepChanged += new ConnectionManager.StepChangedEventHandler(cManager_StepChanged);
            this.cManager.RequestPassword += new ConnectionManager.RequestPasswordEventHandler(cManager_RequestPassword);
            this.cManager.UseProxy += new ConnectionManager.UseProxyEventHandler(cManager_UseProxy);
            formHelper = new FormHelper(this, cManager);

            // Instantiate and add the connection control to the form
            ccsb = new CrmConnectionStatusBar(this.cManager, formHelper);
            this.Controls.Add(ccsb);
        }

        void cManager_UseProxy(object sender, UseProxyEventArgs e)
        {
            formHelper.SelectProxy();
        }

        bool cManager_RequestPassword(object sender, RequestPasswordEventArgs e)
        {
            return formHelper.RequestPassword(e.ConnectionDetail);
        }

        #endregion Constructor

        #region Connection event handlers

        /// <summary>
        /// Occurs when the connection manager sends a step change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cManager_StepChanged(object sender, StepChangedEventArgs e)
        {
            this.ccsb.SetMessage(e.CurrentStep);
        }

        /// <summary>
        /// Occurs when the connection to a server failed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cManager_ConnectionFailed(object sender, ConnectionFailedEventArgs e)
        {
            // Set error message
            this.ccsb.SetMessage("Error: " + e.FailureReason);

            // Clear the current organization service
            this.service = null;
        }

        /// <summary>
        /// Occurs when the connection to a server succeed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cManager_ConnectionSucceed(object sender, ConnectionSucceedEventArgs e)
        {
            ccsb.RebuildConnectionList();

            // Store connection Organization Service
            this.service = e.OrganizationService;

            // Displays connection status
            this.ccsb.SetConnectionStatus(true, e.ConnectionDetail);

            // Clear the current action message
            this.ccsb.SetMessage(string.Empty);

            setupFormConnected();
            listCrmSolutions();
        }

        #endregion Connection event handlers

        private void listCrmSolutions()
        {
            QueryByAttribute query = new QueryByAttribute("solution")
            {
                ColumnSet = new ColumnSet(true)
            };
            query.AddAttributeValue("isvisible", true);
            query.AddAttributeValue("ismanaged", true);

            var results = this.service.RetrieveMultiple(query);
            if (results.Entities.Count > 0)
            {
                solutionComboBox.Items.Clear();
            }

            solutionComboBox.DisplayMember = "Text";
            solutionComboBox.ValueMember = "Value";

            solutionComboBox.Items.Add(new SolutionComboBoxItem("Default", Guid.Empty));

            foreach (var item in results.Entities)
            {
                solutionComboBox.Items.Add(new SolutionComboBoxItem(item.GetAttributeValue<string>("friendlyname"), item.Id));
            }
        }

        private void listWebResources()
        {
            SolutionComboBoxItem selectedItem = (SolutionComboBoxItem)solutionComboBox.SelectedItem;
            QueryExpression query = new QueryExpression("webresource")
            {
                ColumnSet = new ColumnSet(true)
            };
            query.AddOrder("displayname", OrderType.Ascending);

            if (selectedItem.Value != Guid.Empty)
            {
                FilterExpression filter1 = new FilterExpression();
                filter1.AddCondition("solutionid", ConditionOperator.Equal, selectedItem.Value);
                query.Criteria.AddFilter(filter1);
            }

            FilterExpression filter2 = new FilterExpression();
            filter2.AddCondition("webresourcetype", ConditionOperator.Equal, 2);
            filter2.AddCondition("webresourcetype", ConditionOperator.Equal, 3);
            filter2.FilterOperator = LogicalOperator.Or;
            query.Criteria.AddFilter(filter2);

            var results = this.service.RetrieveMultiple(query);
            if (results.Entities.Count > 0)
            {
                webResourceListView.Items.Clear();
            }

            webResourceListView.View = View.Details;

            foreach (var item in results.Entities)
            {
                ListViewItem listViewItem = new ListViewItem(item.GetAttributeValue<string>("displayname"));
                listViewItem.SubItems.Add(item.GetAttributeValue<string>("name"));
                listViewItem.SubItems.Add(item.FormattedValues["webresourcetype"]);
                listViewItem.SubItems.Add(item.GetAttributeValue<bool>("ismanaged").ToString());
                listViewItem.Tag = item;
                webResourceListView.Items.Add(listViewItem);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void solutionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setupFormSolutionSelected();
            listWebResources();
        }

        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectAllCheckBox.Checked) { selectUnManagedCheckBox.Checked = false; }
            foreach (var item in webResourceListView.Items)
            {
                ((ListViewItem)item).Checked = selectAllCheckBox.Checked;
            }
        }

        private void selectUnManagedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectUnManagedCheckBox.Checked) { selectAllCheckBox.Checked = false; }
            foreach (var item in webResourceListView.Items)
            {
                if (!((Entity)(((ListViewItem)item).Tag)).GetAttributeValue<bool>("ismanaged"))
                {
                    ((ListViewItem)item).Checked = selectUnManagedCheckBox.Checked;
                }
            }
        }

        private void setupFormConnected()
        {
            solutionComboBox.Enabled = true;
            webResourcesGroupBox.Enabled = false;
            minifyButton.Enabled = false;
        }

        private void setupFormLoad()
        {
            solutionComboBox.Enabled = false;
            webResourcesGroupBox.Enabled = false;
            minifyButton.Enabled = false;

            bracesComboBox.DisplayMember = "Text";
            bracesComboBox.ValueMember = "Value";
            bracesComboBox.Items.Clear();
            bracesComboBox.Items.Add(new ComboBoxItem("New Line", 0));
            bracesComboBox.Items.Add(new ComboBoxItem("Same Line", 1));
            bracesComboBox.Items.Add(new ComboBoxItem("Use Source", 2));
            bracesComboBox.SelectedIndex = 0;

            EvalTreatmentComboBox.DisplayMember = "Text";
            EvalTreatmentComboBox.ValueMember = "Value";
            EvalTreatmentComboBox.Items.Clear();
            EvalTreatmentComboBox.Items.Add(new ComboBoxItem("Ignore", 0));
            EvalTreatmentComboBox.Items.Add(new ComboBoxItem("Make Immediate Safe", 1));
            EvalTreatmentComboBox.Items.Add(new ComboBoxItem("Make All Safe", 2));
            EvalTreatmentComboBox.SelectedIndex = 0;

            FormatComboBox.DisplayMember = "Text";
            FormatComboBox.ValueMember = "Value";
            FormatComboBox.Items.Clear();
            FormatComboBox.Items.Add(new ComboBoxItem("Normal", 0));
            FormatComboBox.Items.Add(new ComboBoxItem("JSON", 1));
            FormatComboBox.SelectedIndex = 0;

            LocalRenamingComboBox.DisplayMember = "Text";
            LocalRenamingComboBox.ValueMember = "Value";
            LocalRenamingComboBox.Items.Clear();
            LocalRenamingComboBox.Items.Add(new ComboBoxItem("Keep All", 0));
            LocalRenamingComboBox.Items.Add(new ComboBoxItem("Keep Localization Vars", 1));
            LocalRenamingComboBox.Items.Add(new ComboBoxItem("Crunch All", 2));
            LocalRenamingComboBox.SelectedIndex = 0;

            ColorNamesComboBox.DisplayMember = "Text";
            ColorNamesComboBox.ValueMember = "Value";
            ColorNamesComboBox.Items.Clear();
            ColorNamesComboBox.Items.Add(new ComboBoxItem("Strict", 0));
            ColorNamesComboBox.Items.Add(new ComboBoxItem("Hex", 1));
            ColorNamesComboBox.Items.Add(new ComboBoxItem("Major", 2));
            ColorNamesComboBox.SelectedIndex = 0;

            CommentModeComboBox.DisplayMember = "Text";
            CommentModeComboBox.ValueMember = "Value";
            CommentModeComboBox.Items.Clear();
            CommentModeComboBox.Items.Add(new ComboBoxItem("Important", 0));
            CommentModeComboBox.Items.Add(new ComboBoxItem("None", 1));
            CommentModeComboBox.Items.Add(new ComboBoxItem("All", 2));
            CommentModeComboBox.Items.Add(new ComboBoxItem("Hacks", 3));
            CommentModeComboBox.SelectedIndex = 0;

            CssTypeComboBox.DisplayMember = "Text";
            CssTypeComboBox.ValueMember = "Value";
            CssTypeComboBox.Items.Clear();
            CssTypeComboBox.Items.Add(new ComboBoxItem("Full Style Sheet", 0));
            CssTypeComboBox.Items.Add(new ComboBoxItem("Declaration List", 1));
            CssTypeComboBox.SelectedIndex = 0;
        }

        private void setupFormSolutionSelected()
        {
            solutionComboBox.Enabled = true;
            webResourcesGroupBox.Enabled = true;
            minifyButton.Enabled = false;
        }

        private void setupFormWebResourceSelected()
        {
            solutionComboBox.Enabled = true;
            webResourcesGroupBox.Enabled = true;
            minifyButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setupFormLoad();
        }

        private void webResourceListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            setupFormWebResourceSelected();
        }

        private void minifyButton_Click(object sender, EventArgs e)
        {
            this.ccsb.SetMessage("Minify in progress...");
            this.Refresh();

            foreach (var item in webResourceListView.CheckedItems)
            {
                var entity = (Entity)((ListViewItem)item).Tag;
                if(entity.GetAttributeValue<OptionSetValue>("webresourcetype").Value == 3)
                {
                    
                    CodeSettings cs = new CodeSettings()
                    {
                        //common
                        AllowEmbeddedAspNetBlocks = aspnetCheckBox.Checked,
                        BlocksStartOnSameLine = (BlockStart)((ComboBoxItem)bracesComboBox.SelectedItem).Value,
                        IgnoreAllErrors = IgnoreAllErrorsCheckBox.Checked,

                        //js specific
                        AlwaysEscapeNonAscii = asciiCheckBox.Checked,
                        CollapseToLiteral = collapseCheckBox.Checked,
                        ConstStatementsMozilla = ConstStatementsMozillaCheckBox.Checked,
                        ErrorIfNotInlineSafe = ErrorIfNotInlineSafeCheckBox.Checked,
                        EvalLiteralExpressions = EvalLiteralExpressionsCheckBox.Checked,
                        EvalTreatment = (EvalTreatment)((ComboBoxItem)EvalTreatmentComboBox.SelectedItem).Value,
                        Format = (JavaScriptFormat)((ComboBoxItem)FormatComboBox.SelectedItem).Value,
                        LocalRenaming = (LocalRenaming)((ComboBoxItem)LocalRenamingComboBox.SelectedItem).Value,
                        MacSafariQuirks = MacSafariQuirksCheckBox.Checked,
                        PreserveFunctionNames = PreserveFunctionNamesCheckBox.Checked,
                        PreserveImportantComments = PreserveImportantCommentsCheckBox.Checked,
                        QuoteObjectLiteralProperties = QuoteObjectLiteralPropertiesCheckBox.Checked,
                        RemoveFunctionExpressionNames = RemoveFunctionExpressionNamesCheckBox.Checked,
                        StripDebugStatements = StripDebugStatementsCheckBox.Checked
                    };

                    minifyJS(entity, cs);
                }
                else if(entity.GetAttributeValue<OptionSetValue>("webresourcetype").Value == 2)
                {
                    CssSettings settings = new CssSettings()
                    {
                        //common
                        AllowEmbeddedAspNetBlocks = aspnetCheckBox.Checked,
                        BlocksStartOnSameLine = (BlockStart)((ComboBoxItem)bracesComboBox.SelectedItem).Value,
                        IgnoreAllErrors = IgnoreAllErrorsCheckBox.Checked,
                        //css specific
                        ColorNames = (CssColor)((ComboBoxItem)ColorNamesComboBox.SelectedItem).Value,
                        CommentMode = (CssComment)((ComboBoxItem)CommentModeComboBox.SelectedItem).Value,
                        CssType = (CssType)((ComboBoxItem)CssTypeComboBox.SelectedItem).Value,
                        MinifyExpressions = MinifyExpressionsCheckBox.Checked
                    };
                    minifyCSS(entity, settings);
                }
            }

            this.ccsb.SetMessage("Minify complete.");
            this.Refresh();
        }

        private void minifyJS(Entity entity, CodeSettings settings)
        {
            Microsoft.Ajax.Utilities.Minifier minifier = new Microsoft.Ajax.Utilities.Minifier();
            string name = entity.GetAttributeValue<string>("displayname");
            byte[] jsFileBytes = Convert.FromBase64String(entity.GetAttributeValue<string>("content"));
            string originalJS = UnicodeEncoding.UTF8.GetString(jsFileBytes);
            string minifiedJs = minifier.MinifyJavaScript(originalJS, settings);
            byte[] minifiedJsBytes = UnicodeEncoding.UTF8.GetBytes(minifiedJs);
            string minifiedJsBytesString = Convert.ToBase64String(minifiedJsBytes);
            Entity updatedWebResource = new Entity(entity.LogicalName);
            updatedWebResource.Attributes.Add("content", minifiedJsBytesString);
            updatedWebResource.Id = entity.Id;
            this.service.Update(updatedWebResource);
        }

        private void minifyCSS(Entity entity, CssSettings settings)
        {
            Microsoft.Ajax.Utilities.Minifier minifier = new Microsoft.Ajax.Utilities.Minifier();
            string name = entity.GetAttributeValue<string>("displayname");
            byte[] cssFileBytes = Convert.FromBase64String(entity.GetAttributeValue<string>("content"));
            string originalCss = UnicodeEncoding.UTF8.GetString(cssFileBytes);
            string minifiedCss = minifier.MinifyStyleSheet(originalCss, settings);
            byte[] minifiedCssBytes = UnicodeEncoding.UTF8.GetBytes(minifiedCss);
            string minifiedCssBytesString = Convert.ToBase64String(minifiedCssBytes);
            Entity updatedWebResource = new Entity(entity.LogicalName);
            updatedWebResource.Attributes.Add("content", minifiedCssBytesString);
            updatedWebResource.Id = entity.Id;
            this.service.Update(updatedWebResource);
        }
        
    }

    public class SolutionComboBoxItem
    {
        public SolutionComboBoxItem(string text, Guid value)
        {
            this.Text = text;
            this.Value = value;
        }

        public string Text { get; set; }
        public Guid Value { get; set; }
    }

    public class ComboBoxItem
    {
        public ComboBoxItem(string text, int value)
        {
            this.Text = text;
            this.Value = value;
        }

        public string Text { get; set; }
        public int Value { get; set; }
    }
}
