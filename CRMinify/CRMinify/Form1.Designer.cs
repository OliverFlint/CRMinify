namespace CRMinify
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.solutionComboBox = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webResourcesGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webResourceListView = new System.Windows.Forms.ListView();
            this.displayNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.logicalNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isManagedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectUnManagedCheckBox = new System.Windows.Forms.CheckBox();
            this.selectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.minifyButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalSettingsTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.bracesComboBox = new System.Windows.Forms.ComboBox();
            this.aspnetCheckBox = new System.Windows.Forms.CheckBox();
            this.jsSettingsTabPage = new System.Windows.Forms.TabPage();
            this.FormatComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EvalTreatmentComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EvalLiteralExpressionsCheckBox = new System.Windows.Forms.CheckBox();
            this.ErrorIfNotInlineSafeCheckBox = new System.Windows.Forms.CheckBox();
            this.ConstStatementsMozillaCheckBox = new System.Windows.Forms.CheckBox();
            this.collapseCheckBox = new System.Windows.Forms.CheckBox();
            this.cssSettingsTabPage = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.asciiCheckBox = new System.Windows.Forms.CheckBox();
            this.IgnoreAllErrorsCheckBox = new System.Windows.Forms.CheckBox();
            this.LocalRenamingComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MacSafariQuirksCheckBox = new System.Windows.Forms.CheckBox();
            this.PreserveFunctionNamesCheckBox = new System.Windows.Forms.CheckBox();
            this.PreserveImportantCommentsCheckBox = new System.Windows.Forms.CheckBox();
            this.QuoteObjectLiteralPropertiesCheckBox = new System.Windows.Forms.CheckBox();
            this.RemoveFunctionExpressionNamesCheckBox = new System.Windows.Forms.CheckBox();
            this.StripDebugStatementsCheckBox = new System.Windows.Forms.CheckBox();
            this.ColorNamesComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CommentModeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CssTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MinifyExpressionsCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.webResourcesGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.generalSettingsTabPage.SuspendLayout();
            this.jsSettingsTabPage.SuspendLayout();
            this.cssSettingsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.solutionComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a solution...";
            // 
            // solutionComboBox
            // 
            this.solutionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.solutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.solutionComboBox.FormattingEnabled = true;
            this.solutionComboBox.Location = new System.Drawing.Point(7, 20);
            this.solutionComboBox.Name = "solutionComboBox";
            this.solutionComboBox.Size = new System.Drawing.Size(444, 21);
            this.solutionComboBox.TabIndex = 0;
            this.solutionComboBox.SelectedIndexChanged += new System.EventHandler(this.solutionComboBox_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.webResourcesGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(790, 538);
            this.splitContainer1.SplitterDistance = 459;
            this.splitContainer1.TabIndex = 2;
            // 
            // webResourcesGroupBox
            // 
            this.webResourcesGroupBox.Controls.Add(this.panel2);
            this.webResourcesGroupBox.Controls.Add(this.panel1);
            this.webResourcesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webResourcesGroupBox.Location = new System.Drawing.Point(0, 55);
            this.webResourcesGroupBox.Name = "webResourcesGroupBox";
            this.webResourcesGroupBox.Size = new System.Drawing.Size(457, 481);
            this.webResourcesGroupBox.TabIndex = 2;
            this.webResourcesGroupBox.TabStop = false;
            this.webResourcesGroupBox.Text = "Select Web Resources...";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webResourceListView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 437);
            this.panel2.TabIndex = 3;
            // 
            // webResourceListView
            // 
            this.webResourceListView.CheckBoxes = true;
            this.webResourceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.displayNameHeader,
            this.logicalNameHeader,
            this.typeHeader,
            this.isManagedHeader});
            this.webResourceListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webResourceListView.Location = new System.Drawing.Point(0, 0);
            this.webResourceListView.Name = "webResourceListView";
            this.webResourceListView.Size = new System.Drawing.Size(451, 437);
            this.webResourceListView.TabIndex = 1;
            this.webResourceListView.UseCompatibleStateImageBehavior = false;
            this.webResourceListView.View = System.Windows.Forms.View.Details;
            this.webResourceListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.webResourceListView_ItemChecked);
            // 
            // displayNameHeader
            // 
            this.displayNameHeader.Text = "Name";
            this.displayNameHeader.Width = 300;
            // 
            // logicalNameHeader
            // 
            this.logicalNameHeader.Text = "Logical Name";
            this.logicalNameHeader.Width = 300;
            // 
            // typeHeader
            // 
            this.typeHeader.Text = "Type";
            this.typeHeader.Width = 150;
            // 
            // isManagedHeader
            // 
            this.isManagedHeader.Text = "Managed";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectUnManagedCheckBox);
            this.panel1.Controls.Add(this.selectAllCheckBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 25);
            this.panel1.TabIndex = 2;
            // 
            // selectUnManagedCheckBox
            // 
            this.selectUnManagedCheckBox.AutoSize = true;
            this.selectUnManagedCheckBox.Location = new System.Drawing.Point(80, 4);
            this.selectUnManagedCheckBox.Name = "selectUnManagedCheckBox";
            this.selectUnManagedCheckBox.Size = new System.Drawing.Size(117, 17);
            this.selectUnManagedCheckBox.TabIndex = 1;
            this.selectUnManagedCheckBox.Text = "Select Unmanaged";
            this.selectUnManagedCheckBox.UseVisualStyleBackColor = true;
            this.selectUnManagedCheckBox.CheckedChanged += new System.EventHandler(this.selectUnManagedCheckBox_CheckedChanged);
            // 
            // selectAllCheckBox
            // 
            this.selectAllCheckBox.AutoSize = true;
            this.selectAllCheckBox.Location = new System.Drawing.Point(3, 3);
            this.selectAllCheckBox.Name = "selectAllCheckBox";
            this.selectAllCheckBox.Size = new System.Drawing.Size(70, 17);
            this.selectAllCheckBox.TabIndex = 0;
            this.selectAllCheckBox.Text = "Select All";
            this.selectAllCheckBox.UseVisualStyleBackColor = true;
            this.selectAllCheckBox.CheckedChanged += new System.EventHandler(this.selectAllCheckBox_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.minifyButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 504);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 32);
            this.panel4.TabIndex = 3;
            // 
            // minifyButton
            // 
            this.minifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.minifyButton.Location = new System.Drawing.Point(247, 6);
            this.minifyButton.Name = "minifyButton";
            this.minifyButton.Size = new System.Drawing.Size(75, 23);
            this.minifyButton.TabIndex = 0;
            this.minifyButton.Text = "Minify!";
            this.minifyButton.UseVisualStyleBackColor = true;
            this.minifyButton.Click += new System.EventHandler(this.minifyButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 536);
            this.panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.generalSettingsTabPage);
            this.tabControl1.Controls.Add(this.jsSettingsTabPage);
            this.tabControl1.Controls.Add(this.cssSettingsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(325, 536);
            this.tabControl1.TabIndex = 1;
            // 
            // generalSettingsTabPage
            // 
            this.generalSettingsTabPage.Controls.Add(this.IgnoreAllErrorsCheckBox);
            this.generalSettingsTabPage.Controls.Add(this.label1);
            this.generalSettingsTabPage.Controls.Add(this.bracesComboBox);
            this.generalSettingsTabPage.Controls.Add(this.aspnetCheckBox);
            this.generalSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalSettingsTabPage.Name = "generalSettingsTabPage";
            this.generalSettingsTabPage.Size = new System.Drawing.Size(317, 472);
            this.generalSettingsTabPage.TabIndex = 2;
            this.generalSettingsTabPage.Text = "General Settings";
            this.generalSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Blocks Start On Same Line";
            this.toolTip1.SetToolTip(this.label1, "when output is set to multiple lines, determines whether opening braces are writt" +
        "en on their own new line, at the end of the previous line, or reflecting what is" +
        " in the source code.");
            // 
            // bracesComboBox
            // 
            this.bracesComboBox.FormattingEnabled = true;
            this.bracesComboBox.Location = new System.Drawing.Point(144, 30);
            this.bracesComboBox.Name = "bracesComboBox";
            this.bracesComboBox.Size = new System.Drawing.Size(121, 21);
            this.bracesComboBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.bracesComboBox, "when output is set to multiple lines, determines whether opening braces are writt" +
        "en on their own new line, at the end of the previous line, or reflecting what is" +
        " in the source code.");
            // 
            // aspnetCheckBox
            // 
            this.aspnetCheckBox.AutoSize = true;
            this.aspnetCheckBox.Location = new System.Drawing.Point(4, 6);
            this.aspnetCheckBox.Name = "aspnetCheckBox";
            this.aspnetCheckBox.Size = new System.Drawing.Size(181, 17);
            this.aspnetCheckBox.TabIndex = 1;
            this.aspnetCheckBox.Text = "Allow Embedded Asp.Net Blocks";
            this.toolTip1.SetToolTip(this.aspnetCheckBox, "turns on or off support for inline ASP.NET <% … %> substitutions.");
            this.aspnetCheckBox.UseVisualStyleBackColor = true;
            // 
            // jsSettingsTabPage
            // 
            this.jsSettingsTabPage.Controls.Add(this.StripDebugStatementsCheckBox);
            this.jsSettingsTabPage.Controls.Add(this.RemoveFunctionExpressionNamesCheckBox);
            this.jsSettingsTabPage.Controls.Add(this.QuoteObjectLiteralPropertiesCheckBox);
            this.jsSettingsTabPage.Controls.Add(this.PreserveImportantCommentsCheckBox);
            this.jsSettingsTabPage.Controls.Add(this.PreserveFunctionNamesCheckBox);
            this.jsSettingsTabPage.Controls.Add(this.MacSafariQuirksCheckBox);
            this.jsSettingsTabPage.Controls.Add(this.LocalRenamingComboBox);
            this.jsSettingsTabPage.Controls.Add(this.label4);
            this.jsSettingsTabPage.Controls.Add(this.asciiCheckBox);
            this.jsSettingsTabPage.Controls.Add(this.FormatComboBox);
            this.jsSettingsTabPage.Controls.Add(this.label3);
            this.jsSettingsTabPage.Controls.Add(this.EvalTreatmentComboBox);
            this.jsSettingsTabPage.Controls.Add(this.label2);
            this.jsSettingsTabPage.Controls.Add(this.EvalLiteralExpressionsCheckBox);
            this.jsSettingsTabPage.Controls.Add(this.ErrorIfNotInlineSafeCheckBox);
            this.jsSettingsTabPage.Controls.Add(this.ConstStatementsMozillaCheckBox);
            this.jsSettingsTabPage.Controls.Add(this.collapseCheckBox);
            this.jsSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.jsSettingsTabPage.Name = "jsSettingsTabPage";
            this.jsSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.jsSettingsTabPage.Size = new System.Drawing.Size(317, 510);
            this.jsSettingsTabPage.TabIndex = 0;
            this.jsSettingsTabPage.Text = "JS Settings";
            this.jsSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // FormatComboBox
            // 
            this.FormatComboBox.FormattingEnabled = true;
            this.FormatComboBox.Location = new System.Drawing.Point(92, 167);
            this.FormatComboBox.Name = "FormatComboBox";
            this.FormatComboBox.Size = new System.Drawing.Size(121, 21);
            this.FormatComboBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Format";
            // 
            // EvalTreatmentComboBox
            // 
            this.EvalTreatmentComboBox.FormattingEnabled = true;
            this.EvalTreatmentComboBox.Location = new System.Drawing.Point(92, 139);
            this.EvalTreatmentComboBox.Name = "EvalTreatmentComboBox";
            this.EvalTreatmentComboBox.Size = new System.Drawing.Size(121, 21);
            this.EvalTreatmentComboBox.TabIndex = 11;
            this.toolTip1.SetToolTip(this.EvalTreatmentComboBox, resources.GetString("EvalTreatmentComboBox.ToolTip"));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Eval Treatment";
            // 
            // EvalLiteralExpressionsCheckBox
            // 
            this.EvalLiteralExpressionsCheckBox.AutoSize = true;
            this.EvalLiteralExpressionsCheckBox.Location = new System.Drawing.Point(6, 109);
            this.EvalLiteralExpressionsCheckBox.Name = "EvalLiteralExpressionsCheckBox";
            this.EvalLiteralExpressionsCheckBox.Size = new System.Drawing.Size(137, 17);
            this.EvalLiteralExpressionsCheckBox.TabIndex = 9;
            this.EvalLiteralExpressionsCheckBox.Text = "Eval Literal Expressions";
            this.toolTip1.SetToolTip(this.EvalLiteralExpressionsCheckBox, "Evaluate expressions containing only literal bool, string, numeric, or null value" +
        "s [true] Leave literal expressions alone and do not evaluate them [false]. Defau" +
        "lt is true.");
            this.EvalLiteralExpressionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ErrorIfNotInlineSafeCheckBox
            // 
            this.ErrorIfNotInlineSafeCheckBox.AutoSize = true;
            this.ErrorIfNotInlineSafeCheckBox.Location = new System.Drawing.Point(6, 75);
            this.ErrorIfNotInlineSafeCheckBox.Name = "ErrorIfNotInlineSafeCheckBox";
            this.ErrorIfNotInlineSafeCheckBox.Size = new System.Drawing.Size(130, 17);
            this.ErrorIfNotInlineSafeCheckBox.TabIndex = 8;
            this.ErrorIfNotInlineSafeCheckBox.Text = "Error If Not Inline Safe";
            this.toolTip1.SetToolTip(this.ErrorIfNotInlineSafeCheckBox, "Throw an error if a source string is not safe for inclusion ");
            this.ErrorIfNotInlineSafeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConstStatementsMozillaCheckBox
            // 
            this.ConstStatementsMozillaCheckBox.AutoSize = true;
            this.ConstStatementsMozillaCheckBox.Location = new System.Drawing.Point(6, 41);
            this.ConstStatementsMozillaCheckBox.Name = "ConstStatementsMozillaCheckBox";
            this.ConstStatementsMozillaCheckBox.Size = new System.Drawing.Size(144, 17);
            this.ConstStatementsMozillaCheckBox.TabIndex = 7;
            this.ConstStatementsMozillaCheckBox.Text = "Const Statements Mozilla";
            this.toolTip1.SetToolTip(this.ConstStatementsMozillaCheckBox, resources.GetString("ConstStatementsMozillaCheckBox.ToolTip"));
            this.ConstStatementsMozillaCheckBox.UseVisualStyleBackColor = true;
            // 
            // collapseCheckBox
            // 
            this.collapseCheckBox.AutoSize = true;
            this.collapseCheckBox.Checked = true;
            this.collapseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.collapseCheckBox.Location = new System.Drawing.Point(6, 7);
            this.collapseCheckBox.Name = "collapseCheckBox";
            this.collapseCheckBox.Size = new System.Drawing.Size(113, 17);
            this.collapseCheckBox.TabIndex = 6;
            this.collapseCheckBox.Text = "Collapse To Literal";
            this.toolTip1.SetToolTip(this.collapseCheckBox, "specifies whether or not to replace certain calls to certain constructors with sm" +
        "aller literal objects. For example, new Object() to {}, and new Array() to [].");
            this.collapseCheckBox.UseVisualStyleBackColor = true;
            // 
            // cssSettingsTabPage
            // 
            this.cssSettingsTabPage.Controls.Add(this.MinifyExpressionsCheckBox);
            this.cssSettingsTabPage.Controls.Add(this.CssTypeComboBox);
            this.cssSettingsTabPage.Controls.Add(this.label7);
            this.cssSettingsTabPage.Controls.Add(this.CommentModeComboBox);
            this.cssSettingsTabPage.Controls.Add(this.label6);
            this.cssSettingsTabPage.Controls.Add(this.ColorNamesComboBox);
            this.cssSettingsTabPage.Controls.Add(this.label5);
            this.cssSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.cssSettingsTabPage.Name = "cssSettingsTabPage";
            this.cssSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cssSettingsTabPage.Size = new System.Drawing.Size(317, 472);
            this.cssSettingsTabPage.TabIndex = 1;
            this.cssSettingsTabPage.Text = "CSS Settings";
            this.cssSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // asciiCheckBox
            // 
            this.asciiCheckBox.AutoSize = true;
            this.asciiCheckBox.Location = new System.Drawing.Point(6, 203);
            this.asciiCheckBox.Name = "asciiCheckBox";
            this.asciiCheckBox.Size = new System.Drawing.Size(146, 17);
            this.asciiCheckBox.TabIndex = 14;
            this.asciiCheckBox.Text = "Always Escape Non Ascii";
            this.asciiCheckBox.UseVisualStyleBackColor = true;
            // 
            // IgnoreAllErrorsCheckBox
            // 
            this.IgnoreAllErrorsCheckBox.AutoSize = true;
            this.IgnoreAllErrorsCheckBox.Location = new System.Drawing.Point(4, 66);
            this.IgnoreAllErrorsCheckBox.Name = "IgnoreAllErrorsCheckBox";
            this.IgnoreAllErrorsCheckBox.Size = new System.Drawing.Size(100, 17);
            this.IgnoreAllErrorsCheckBox.TabIndex = 5;
            this.IgnoreAllErrorsCheckBox.Text = "Ignore All Errors";
            this.IgnoreAllErrorsCheckBox.UseVisualStyleBackColor = true;
            // 
            // LocalRenamingComboBox
            // 
            this.LocalRenamingComboBox.FormattingEnabled = true;
            this.LocalRenamingComboBox.Location = new System.Drawing.Point(91, 234);
            this.LocalRenamingComboBox.Name = "LocalRenamingComboBox";
            this.LocalRenamingComboBox.Size = new System.Drawing.Size(121, 21);
            this.LocalRenamingComboBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Local Renaming";
            // 
            // MacSafariQuirksCheckBox
            // 
            this.MacSafariQuirksCheckBox.AutoSize = true;
            this.MacSafariQuirksCheckBox.Location = new System.Drawing.Point(6, 277);
            this.MacSafariQuirksCheckBox.Name = "MacSafariQuirksCheckBox";
            this.MacSafariQuirksCheckBox.Size = new System.Drawing.Size(110, 17);
            this.MacSafariQuirksCheckBox.TabIndex = 17;
            this.MacSafariQuirksCheckBox.Text = "Mac Safari Quirks";
            this.MacSafariQuirksCheckBox.UseVisualStyleBackColor = true;
            // 
            // PreserveFunctionNamesCheckBox
            // 
            this.PreserveFunctionNamesCheckBox.AutoSize = true;
            this.PreserveFunctionNamesCheckBox.Location = new System.Drawing.Point(6, 309);
            this.PreserveFunctionNamesCheckBox.Name = "PreserveFunctionNamesCheckBox";
            this.PreserveFunctionNamesCheckBox.Size = new System.Drawing.Size(148, 17);
            this.PreserveFunctionNamesCheckBox.TabIndex = 18;
            this.PreserveFunctionNamesCheckBox.Text = "Preserve Function Names";
            this.PreserveFunctionNamesCheckBox.UseVisualStyleBackColor = true;
            // 
            // PreserveImportantCommentsCheckBox
            // 
            this.PreserveImportantCommentsCheckBox.AutoSize = true;
            this.PreserveImportantCommentsCheckBox.Location = new System.Drawing.Point(6, 341);
            this.PreserveImportantCommentsCheckBox.Name = "PreserveImportantCommentsCheckBox";
            this.PreserveImportantCommentsCheckBox.Size = new System.Drawing.Size(167, 17);
            this.PreserveImportantCommentsCheckBox.TabIndex = 19;
            this.PreserveImportantCommentsCheckBox.Text = "Preserve Important Comments";
            this.PreserveImportantCommentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // QuoteObjectLiteralPropertiesCheckBox
            // 
            this.QuoteObjectLiteralPropertiesCheckBox.AutoSize = true;
            this.QuoteObjectLiteralPropertiesCheckBox.Location = new System.Drawing.Point(6, 373);
            this.QuoteObjectLiteralPropertiesCheckBox.Name = "QuoteObjectLiteralPropertiesCheckBox";
            this.QuoteObjectLiteralPropertiesCheckBox.Size = new System.Drawing.Size(170, 17);
            this.QuoteObjectLiteralPropertiesCheckBox.TabIndex = 20;
            this.QuoteObjectLiteralPropertiesCheckBox.Text = "Quote Object Literal Properties";
            this.QuoteObjectLiteralPropertiesCheckBox.UseVisualStyleBackColor = true;
            // 
            // RemoveFunctionExpressionNamesCheckBox
            // 
            this.RemoveFunctionExpressionNamesCheckBox.AutoSize = true;
            this.RemoveFunctionExpressionNamesCheckBox.Checked = true;
            this.RemoveFunctionExpressionNamesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RemoveFunctionExpressionNamesCheckBox.Location = new System.Drawing.Point(6, 405);
            this.RemoveFunctionExpressionNamesCheckBox.Name = "RemoveFunctionExpressionNamesCheckBox";
            this.RemoveFunctionExpressionNamesCheckBox.Size = new System.Drawing.Size(200, 17);
            this.RemoveFunctionExpressionNamesCheckBox.TabIndex = 21;
            this.RemoveFunctionExpressionNamesCheckBox.Text = "Remove Function Expression Names";
            this.RemoveFunctionExpressionNamesCheckBox.UseVisualStyleBackColor = true;
            // 
            // StripDebugStatementsCheckBox
            // 
            this.StripDebugStatementsCheckBox.AutoSize = true;
            this.StripDebugStatementsCheckBox.Checked = true;
            this.StripDebugStatementsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StripDebugStatementsCheckBox.Location = new System.Drawing.Point(6, 437);
            this.StripDebugStatementsCheckBox.Name = "StripDebugStatementsCheckBox";
            this.StripDebugStatementsCheckBox.Size = new System.Drawing.Size(138, 17);
            this.StripDebugStatementsCheckBox.TabIndex = 22;
            this.StripDebugStatementsCheckBox.Text = "Strip Debug Statements";
            this.StripDebugStatementsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ColorNamesComboBox
            // 
            this.ColorNamesComboBox.FormattingEnabled = true;
            this.ColorNamesComboBox.Location = new System.Drawing.Point(91, 11);
            this.ColorNamesComboBox.Name = "ColorNamesComboBox";
            this.ColorNamesComboBox.Size = new System.Drawing.Size(121, 21);
            this.ColorNamesComboBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Color Names";
            // 
            // CommentModeComboBox
            // 
            this.CommentModeComboBox.FormattingEnabled = true;
            this.CommentModeComboBox.Location = new System.Drawing.Point(91, 45);
            this.CommentModeComboBox.Name = "CommentModeComboBox";
            this.CommentModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.CommentModeComboBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Comment Mode";
            // 
            // CssTypeComboBox
            // 
            this.CssTypeComboBox.FormattingEnabled = true;
            this.CssTypeComboBox.Location = new System.Drawing.Point(91, 79);
            this.CssTypeComboBox.Name = "CssTypeComboBox";
            this.CssTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.CssTypeComboBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Css Type";
            // 
            // MinifyExpressionsCheckBox
            // 
            this.MinifyExpressionsCheckBox.AutoSize = true;
            this.MinifyExpressionsCheckBox.Location = new System.Drawing.Point(9, 117);
            this.MinifyExpressionsCheckBox.Name = "MinifyExpressionsCheckBox";
            this.MinifyExpressionsCheckBox.Size = new System.Drawing.Size(112, 17);
            this.MinifyExpressionsCheckBox.TabIndex = 23;
            this.MinifyExpressionsCheckBox.Text = "Minify Expressions";
            this.MinifyExpressionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 562);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CRMinify";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.webResourcesGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.generalSettingsTabPage.ResumeLayout(false);
            this.generalSettingsTabPage.PerformLayout();
            this.jsSettingsTabPage.ResumeLayout(false);
            this.jsSettingsTabPage.PerformLayout();
            this.cssSettingsTabPage.ResumeLayout(false);
            this.cssSettingsTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox solutionComboBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox webResourcesGroupBox;
        private System.Windows.Forms.ListView webResourceListView;
        private System.Windows.Forms.CheckBox selectAllCheckBox;
        private System.Windows.Forms.ColumnHeader displayNameHeader;
        private System.Windows.Forms.ColumnHeader typeHeader;
        private System.Windows.Forms.ColumnHeader logicalNameHeader;
        private System.Windows.Forms.ColumnHeader isManagedHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox selectUnManagedCheckBox;
        private System.Windows.Forms.Button minifyButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage jsSettingsTabPage;
        private System.Windows.Forms.TabPage cssSettingsTabPage;
        private System.Windows.Forms.TabPage generalSettingsTabPage;
        private System.Windows.Forms.CheckBox aspnetCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bracesComboBox;
        private System.Windows.Forms.CheckBox collapseCheckBox;
        private System.Windows.Forms.CheckBox ConstStatementsMozillaCheckBox;
        private System.Windows.Forms.CheckBox ErrorIfNotInlineSafeCheckBox;
        private System.Windows.Forms.CheckBox EvalLiteralExpressionsCheckBox;
        private System.Windows.Forms.ComboBox EvalTreatmentComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FormatComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox asciiCheckBox;
        private System.Windows.Forms.CheckBox IgnoreAllErrorsCheckBox;
        private System.Windows.Forms.ComboBox LocalRenamingComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox MacSafariQuirksCheckBox;
        private System.Windows.Forms.CheckBox PreserveFunctionNamesCheckBox;
        private System.Windows.Forms.CheckBox PreserveImportantCommentsCheckBox;
        private System.Windows.Forms.CheckBox QuoteObjectLiteralPropertiesCheckBox;
        private System.Windows.Forms.CheckBox RemoveFunctionExpressionNamesCheckBox;
        private System.Windows.Forms.CheckBox StripDebugStatementsCheckBox;
        private System.Windows.Forms.ComboBox ColorNamesComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CommentModeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CssTypeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox MinifyExpressionsCheckBox;
    }
}

