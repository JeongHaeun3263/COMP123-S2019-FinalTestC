namespace COMP123_S2019_FinalTestC.Views
{
    partial class CharacterGenerationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterGenerationForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.IdentityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.GenerateNameButton = new System.Windows.Forms.Button();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.AbilityPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DexterityDataLabel = new System.Windows.Forms.Label();
            this.StrengthDataLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.GenerateAbilitiesButton = new System.Windows.Forms.Button();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.EnduranceLabel = new System.Windows.Forms.Label();
            this.IntellectLabel = new System.Windows.Forms.Label();
            this.EducationLabel = new System.Windows.Forms.Label();
            this.SocialStandingLabel = new System.Windows.Forms.Label();
            this.EnduranceDataLabel = new System.Windows.Forms.Label();
            this.IntellectDataLabel = new System.Windows.Forms.Label();
            this.EducationDataLabel = new System.Windows.Forms.Label();
            this.SocialStandingDataLabel = new System.Windows.Forms.Label();
            this.SkillsPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SkillLabel = new System.Windows.Forms.Label();
            this.GenerateSkillsButton = new System.Windows.Forms.Button();
            this.Skill1Label = new System.Windows.Forms.Label();
            this.Skill2Label = new System.Windows.Forms.Label();
            this.Skill3Label = new System.Windows.Forms.Label();
            this.Skill4Label = new System.Windows.Forms.Label();
            this.Skill1DataLabel = new System.Windows.Forms.Label();
            this.Skill2DataLabel = new System.Windows.Forms.Label();
            this.Skill3DataLabel = new System.Windows.Forms.Label();
            this.Skill4DataLabel = new System.Windows.Forms.Label();
            this.ChracterSheetPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LastNameDisplayLabel = new System.Windows.Forms.Label();
            this.StrengthDisplayLabel = new System.Windows.Forms.Label();
            this.EnduranceDisplayLabel = new System.Windows.Forms.Label();
            this.EducationDisplayLabel = new System.Windows.Forms.Label();
            this.DexterityDisplayLabel = new System.Windows.Forms.Label();
            this.IntellectDisplayLabel = new System.Windows.Forms.Label();
            this.SocialStandingDisplayLabel = new System.Windows.Forms.Label();
            this.Skill1DisplayLabel = new System.Windows.Forms.Label();
            this.Skill2DisplayLabel = new System.Windows.Forms.Label();
            this.Skill3DisplayLabel = new System.Windows.Forms.Label();
            this.Skill4DisplayLabel = new System.Windows.Forms.Label();
            this.FirstNameDisplayLabel = new System.Windows.Forms.Label();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CharacterOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CharacterSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainTabControl.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.IdentityTableLayoutPanel.SuspendLayout();
            this.AbilityPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SkillsPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ChracterSheetPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.IdentityPage);
            this.MainTabControl.Controls.Add(this.AbilityPage);
            this.MainTabControl.Controls.Add(this.SkillsPage);
            this.MainTabControl.Controls.Add(this.ChracterSheetPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(782, 447);
            this.MainTabControl.TabIndex = 0;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Controls.Add(this.IdentityTableLayoutPanel);
            this.IdentityPage.Location = new System.Drawing.Point(4, 33);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Padding = new System.Windows.Forms.Padding(3);
            this.IdentityPage.Size = new System.Drawing.Size(774, 410);
            this.IdentityPage.TabIndex = 0;
            this.IdentityPage.Text = "Identity";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // IdentityTableLayoutPanel
            // 
            this.IdentityTableLayoutPanel.ColumnCount = 4;
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.Controls.Add(this.FirstNameLabel, 0, 0);
            this.IdentityTableLayoutPanel.Controls.Add(this.GenerateNameButton, 2, 3);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastNameLabel, 0, 1);
            this.IdentityTableLayoutPanel.Controls.Add(this.FirstNameDataLabel, 1, 0);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastNameDataLabel, 1, 1);
            this.IdentityTableLayoutPanel.Location = new System.Drawing.Point(9, 7);
            this.IdentityTableLayoutPanel.Name = "IdentityTableLayoutPanel";
            this.IdentityTableLayoutPanel.RowCount = 4;
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.Size = new System.Drawing.Size(757, 343);
            this.IdentityTableLayoutPanel.TabIndex = 0;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLabel.Location = new System.Drawing.Point(3, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(183, 85);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenerateNameButton
            // 
            this.GenerateNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentityTableLayoutPanel.SetColumnSpan(this.GenerateNameButton, 2);
            this.GenerateNameButton.Location = new System.Drawing.Point(381, 258);
            this.GenerateNameButton.Name = "GenerateNameButton";
            this.GenerateNameButton.Size = new System.Drawing.Size(373, 82);
            this.GenerateNameButton.TabIndex = 1;
            this.GenerateNameButton.Text = "Generate Name";
            this.GenerateNameButton.UseVisualStyleBackColor = true;
            this.GenerateNameButton.Click += new System.EventHandler(this.GenerateNameButton_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLabel.Location = new System.Drawing.Point(3, 85);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(183, 85);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.FirstNameDataLabel, 3);
            this.FirstNameDataLabel.Location = new System.Drawing.Point(192, 0);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(562, 85);
            this.FirstNameDataLabel.TabIndex = 0;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.LastNameDataLabel, 3);
            this.LastNameDataLabel.Location = new System.Drawing.Point(192, 85);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(562, 85);
            this.LastNameDataLabel.TabIndex = 0;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AbilityPage
            // 
            this.AbilityPage.Controls.Add(this.tableLayoutPanel1);
            this.AbilityPage.Location = new System.Drawing.Point(4, 33);
            this.AbilityPage.Name = "AbilityPage";
            this.AbilityPage.Padding = new System.Windows.Forms.Padding(3);
            this.AbilityPage.Size = new System.Drawing.Size(774, 410);
            this.AbilityPage.TabIndex = 1;
            this.AbilityPage.Text = "Abilities";
            this.AbilityPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.DexterityDataLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.StrengthDataLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.StrengthLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GenerateAbilitiesButton, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.DexterityLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.EnduranceLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.IntellectLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EducationLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.SocialStandingLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.EnduranceDataLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.IntellectDataLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EducationDataLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.SocialStandingDataLabel, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 397);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DexterityDataLabel
            // 
            this.DexterityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DexterityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DexterityDataLabel.Location = new System.Drawing.Point(267, 49);
            this.DexterityDataLabel.Name = "DexterityDataLabel";
            this.DexterityDataLabel.Size = new System.Drawing.Size(145, 49);
            this.DexterityDataLabel.TabIndex = 11;
            this.DexterityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StrengthDataLabel
            // 
            this.StrengthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDataLabel.Location = new System.Drawing.Point(267, 0);
            this.StrengthDataLabel.Name = "StrengthDataLabel";
            this.StrengthDataLabel.Size = new System.Drawing.Size(145, 49);
            this.StrengthDataLabel.TabIndex = 2;
            this.StrengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthLabel.Location = new System.Drawing.Point(3, 0);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(258, 49);
            this.StrengthLabel.TabIndex = 2;
            this.StrengthLabel.Text = "Strength";
            this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenerateAbilitiesButton
            // 
            this.GenerateAbilitiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.GenerateAbilitiesButton, 2);
            this.GenerateAbilitiesButton.Location = new System.Drawing.Point(418, 346);
            this.GenerateAbilitiesButton.Name = "GenerateAbilitiesButton";
            this.GenerateAbilitiesButton.Size = new System.Drawing.Size(336, 48);
            this.GenerateAbilitiesButton.TabIndex = 2;
            this.GenerateAbilitiesButton.Text = "Generate Abilities";
            this.GenerateAbilitiesButton.UseVisualStyleBackColor = true;
            this.GenerateAbilitiesButton.Click += new System.EventHandler(this.GenerateAbilitiesButton_Click);
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityLabel.Location = new System.Drawing.Point(3, 49);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(258, 49);
            this.DexterityLabel.TabIndex = 2;
            this.DexterityLabel.Text = "Dexterity";
            this.DexterityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EnduranceLabel
            // 
            this.EnduranceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceLabel.Location = new System.Drawing.Point(3, 98);
            this.EnduranceLabel.Name = "EnduranceLabel";
            this.EnduranceLabel.Size = new System.Drawing.Size(258, 49);
            this.EnduranceLabel.TabIndex = 3;
            this.EnduranceLabel.Text = "Endurance";
            this.EnduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IntellectLabel
            // 
            this.IntellectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntellectLabel.Location = new System.Drawing.Point(3, 147);
            this.IntellectLabel.Name = "IntellectLabel";
            this.IntellectLabel.Size = new System.Drawing.Size(258, 49);
            this.IntellectLabel.TabIndex = 4;
            this.IntellectLabel.Text = "Intellect";
            this.IntellectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EducationLabel
            // 
            this.EducationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationLabel.Location = new System.Drawing.Point(3, 196);
            this.EducationLabel.Name = "EducationLabel";
            this.EducationLabel.Size = new System.Drawing.Size(258, 49);
            this.EducationLabel.TabIndex = 5;
            this.EducationLabel.Text = "Education";
            this.EducationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SocialStandingLabel
            // 
            this.SocialStandingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialStandingLabel.Location = new System.Drawing.Point(3, 245);
            this.SocialStandingLabel.Name = "SocialStandingLabel";
            this.SocialStandingLabel.Size = new System.Drawing.Size(258, 49);
            this.SocialStandingLabel.TabIndex = 6;
            this.SocialStandingLabel.Text = "SocialStanding";
            this.SocialStandingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EnduranceDataLabel
            // 
            this.EnduranceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnduranceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnduranceDataLabel.Location = new System.Drawing.Point(267, 98);
            this.EnduranceDataLabel.Name = "EnduranceDataLabel";
            this.EnduranceDataLabel.Size = new System.Drawing.Size(145, 49);
            this.EnduranceDataLabel.TabIndex = 9;
            this.EnduranceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IntellectDataLabel
            // 
            this.IntellectDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntellectDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IntellectDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntellectDataLabel.Location = new System.Drawing.Point(267, 147);
            this.IntellectDataLabel.Name = "IntellectDataLabel";
            this.IntellectDataLabel.Size = new System.Drawing.Size(145, 49);
            this.IntellectDataLabel.TabIndex = 12;
            this.IntellectDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EducationDataLabel
            // 
            this.EducationDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EducationDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EducationDataLabel.Location = new System.Drawing.Point(267, 196);
            this.EducationDataLabel.Name = "EducationDataLabel";
            this.EducationDataLabel.Size = new System.Drawing.Size(145, 49);
            this.EducationDataLabel.TabIndex = 10;
            this.EducationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SocialStandingDataLabel
            // 
            this.SocialStandingDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialStandingDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SocialStandingDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SocialStandingDataLabel.Location = new System.Drawing.Point(267, 245);
            this.SocialStandingDataLabel.Name = "SocialStandingDataLabel";
            this.SocialStandingDataLabel.Size = new System.Drawing.Size(145, 49);
            this.SocialStandingDataLabel.TabIndex = 13;
            this.SocialStandingDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SkillsPage
            // 
            this.SkillsPage.Controls.Add(this.tableLayoutPanel2);
            this.SkillsPage.Location = new System.Drawing.Point(4, 33);
            this.SkillsPage.Name = "SkillsPage";
            this.SkillsPage.Size = new System.Drawing.Size(774, 410);
            this.SkillsPage.TabIndex = 2;
            this.SkillsPage.Text = "Skills";
            this.SkillsPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.SkillLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.GenerateSkillsButton, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.Skill1Label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Skill2Label, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Skill3Label, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Skill4Label, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Skill1DataLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Skill2DataLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.Skill3DataLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.Skill4DataLabel, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(757, 391);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // SkillLabel
            // 
            this.SkillLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SkillLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.SkillLabel, 2);
            this.SkillLabel.Location = new System.Drawing.Point(3, 0);
            this.SkillLabel.Name = "SkillLabel";
            this.SkillLabel.Size = new System.Drawing.Size(372, 65);
            this.SkillLabel.TabIndex = 0;
            this.SkillLabel.Text = "Skills";
            this.SkillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GenerateSkillsButton
            // 
            this.GenerateSkillsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.GenerateSkillsButton, 2);
            this.GenerateSkillsButton.Location = new System.Drawing.Point(381, 328);
            this.GenerateSkillsButton.Name = "GenerateSkillsButton";
            this.GenerateSkillsButton.Size = new System.Drawing.Size(373, 60);
            this.GenerateSkillsButton.TabIndex = 2;
            this.GenerateSkillsButton.Text = "Generate Skills ";
            this.GenerateSkillsButton.UseVisualStyleBackColor = true;
            this.GenerateSkillsButton.Click += new System.EventHandler(this.GenerateSkillsButton_Click);
            // 
            // Skill1Label
            // 
            this.Skill1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skill1Label.AutoSize = true;
            this.Skill1Label.Location = new System.Drawing.Point(3, 65);
            this.Skill1Label.Name = "Skill1Label";
            this.Skill1Label.Size = new System.Drawing.Size(183, 65);
            this.Skill1Label.TabIndex = 1;
            this.Skill1Label.Text = "Skill 1";
            this.Skill1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Skill2Label
            // 
            this.Skill2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skill2Label.AutoSize = true;
            this.Skill2Label.Location = new System.Drawing.Point(3, 130);
            this.Skill2Label.Name = "Skill2Label";
            this.Skill2Label.Size = new System.Drawing.Size(183, 65);
            this.Skill2Label.TabIndex = 2;
            this.Skill2Label.Text = "Skill 2";
            this.Skill2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Skill3Label
            // 
            this.Skill3Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skill3Label.AutoSize = true;
            this.Skill3Label.Location = new System.Drawing.Point(3, 195);
            this.Skill3Label.Name = "Skill3Label";
            this.Skill3Label.Size = new System.Drawing.Size(183, 65);
            this.Skill3Label.TabIndex = 3;
            this.Skill3Label.Text = "Skill 3";
            this.Skill3Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Skill4Label
            // 
            this.Skill4Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skill4Label.AutoSize = true;
            this.Skill4Label.Location = new System.Drawing.Point(3, 260);
            this.Skill4Label.Name = "Skill4Label";
            this.Skill4Label.Size = new System.Drawing.Size(183, 65);
            this.Skill4Label.TabIndex = 4;
            this.Skill4Label.Text = "Skill 4";
            this.Skill4Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Skill1DataLabel
            // 
            this.Skill1DataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skill1DataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Skill1DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Skill1DataLabel.Location = new System.Drawing.Point(192, 65);
            this.Skill1DataLabel.Name = "Skill1DataLabel";
            this.Skill1DataLabel.Size = new System.Drawing.Size(183, 65);
            this.Skill1DataLabel.TabIndex = 14;
            this.Skill1DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Skill2DataLabel
            // 
            this.Skill2DataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skill2DataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Skill2DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Skill2DataLabel.Location = new System.Drawing.Point(192, 130);
            this.Skill2DataLabel.Name = "Skill2DataLabel";
            this.Skill2DataLabel.Size = new System.Drawing.Size(183, 65);
            this.Skill2DataLabel.TabIndex = 15;
            this.Skill2DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Skill3DataLabel
            // 
            this.Skill3DataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skill3DataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Skill3DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Skill3DataLabel.Location = new System.Drawing.Point(192, 195);
            this.Skill3DataLabel.Name = "Skill3DataLabel";
            this.Skill3DataLabel.Size = new System.Drawing.Size(183, 65);
            this.Skill3DataLabel.TabIndex = 16;
            this.Skill3DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Skill4DataLabel
            // 
            this.Skill4DataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skill4DataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Skill4DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Skill4DataLabel.Location = new System.Drawing.Point(192, 260);
            this.Skill4DataLabel.Name = "Skill4DataLabel";
            this.Skill4DataLabel.Size = new System.Drawing.Size(183, 65);
            this.Skill4DataLabel.TabIndex = 17;
            this.Skill4DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChracterSheetPage
            // 
            this.ChracterSheetPage.Controls.Add(this.tableLayoutPanel3);
            this.ChracterSheetPage.Controls.Add(this.MainToolStrip);
            this.ChracterSheetPage.Controls.Add(this.MainMenuStrip);
            this.ChracterSheetPage.Location = new System.Drawing.Point(4, 33);
            this.ChracterSheetPage.Name = "ChracterSheetPage";
            this.ChracterSheetPage.Size = new System.Drawing.Size(774, 410);
            this.ChracterSheetPage.TabIndex = 3;
            this.ChracterSheetPage.Text = "Character Sheet";
            this.ChracterSheetPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.LastNameDisplayLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.StrengthDisplayLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.EnduranceDisplayLabel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.EducationDisplayLabel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.DexterityDisplayLabel, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.IntellectDisplayLabel, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.SocialStandingDisplayLabel, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.Skill1DisplayLabel, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.Skill2DisplayLabel, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.Skill3DisplayLabel, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this.Skill4DisplayLabel, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.FirstNameDisplayLabel, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 59);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(763, 348);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // LastNameDisplayLabel
            // 
            this.LastNameDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameDisplayLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameDisplayLabel.Location = new System.Drawing.Point(193, 0);
            this.LastNameDisplayLabel.Name = "LastNameDisplayLabel";
            this.LastNameDisplayLabel.Size = new System.Drawing.Size(184, 57);
            this.LastNameDisplayLabel.TabIndex = 12;
            this.LastNameDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StrengthDisplayLabel
            // 
            this.StrengthDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthDisplayLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrengthDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDisplayLabel.Location = new System.Drawing.Point(3, 114);
            this.StrengthDisplayLabel.Name = "StrengthDisplayLabel";
            this.StrengthDisplayLabel.Size = new System.Drawing.Size(184, 57);
            this.StrengthDisplayLabel.TabIndex = 2;
            this.StrengthDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnduranceDisplayLabel
            // 
            this.EnduranceDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceDisplayLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnduranceDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnduranceDisplayLabel.Location = new System.Drawing.Point(3, 171);
            this.EnduranceDisplayLabel.Name = "EnduranceDisplayLabel";
            this.EnduranceDisplayLabel.Size = new System.Drawing.Size(184, 57);
            this.EnduranceDisplayLabel.TabIndex = 3;
            this.EnduranceDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EducationDisplayLabel
            // 
            this.EducationDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationDisplayLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EducationDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EducationDisplayLabel.Location = new System.Drawing.Point(3, 228);
            this.EducationDisplayLabel.Name = "EducationDisplayLabel";
            this.EducationDisplayLabel.Size = new System.Drawing.Size(184, 57);
            this.EducationDisplayLabel.TabIndex = 4;
            this.EducationDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DexterityDisplayLabel
            // 
            this.DexterityDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityDisplayLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DexterityDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DexterityDisplayLabel.Location = new System.Drawing.Point(193, 114);
            this.DexterityDisplayLabel.Name = "DexterityDisplayLabel";
            this.DexterityDisplayLabel.Size = new System.Drawing.Size(184, 57);
            this.DexterityDisplayLabel.TabIndex = 5;
            this.DexterityDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IntellectDisplayLabel
            // 
            this.IntellectDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntellectDisplayLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IntellectDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntellectDisplayLabel.Location = new System.Drawing.Point(193, 171);
            this.IntellectDisplayLabel.Name = "IntellectDisplayLabel";
            this.IntellectDisplayLabel.Size = new System.Drawing.Size(184, 57);
            this.IntellectDisplayLabel.TabIndex = 6;
            this.IntellectDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SocialStandingDisplayLabel
            // 
            this.SocialStandingDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialStandingDisplayLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SocialStandingDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SocialStandingDisplayLabel.Location = new System.Drawing.Point(193, 228);
            this.SocialStandingDisplayLabel.Name = "SocialStandingDisplayLabel";
            this.SocialStandingDisplayLabel.Size = new System.Drawing.Size(184, 57);
            this.SocialStandingDisplayLabel.TabIndex = 7;
            this.SocialStandingDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Skill1DisplayLabel
            // 
            this.Skill1DisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skill1DisplayLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Skill1DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Skill1DisplayLabel.Location = new System.Drawing.Point(573, 114);
            this.Skill1DisplayLabel.Name = "Skill1DisplayLabel";
            this.Skill1DisplayLabel.Size = new System.Drawing.Size(187, 57);
            this.Skill1DisplayLabel.TabIndex = 8;
            this.Skill1DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Skill2DisplayLabel
            // 
            this.Skill2DisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skill2DisplayLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Skill2DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Skill2DisplayLabel.Location = new System.Drawing.Point(573, 171);
            this.Skill2DisplayLabel.Name = "Skill2DisplayLabel";
            this.Skill2DisplayLabel.Size = new System.Drawing.Size(187, 57);
            this.Skill2DisplayLabel.TabIndex = 9;
            this.Skill2DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Skill3DisplayLabel
            // 
            this.Skill3DisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skill3DisplayLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Skill3DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Skill3DisplayLabel.Location = new System.Drawing.Point(573, 228);
            this.Skill3DisplayLabel.Name = "Skill3DisplayLabel";
            this.Skill3DisplayLabel.Size = new System.Drawing.Size(187, 57);
            this.Skill3DisplayLabel.TabIndex = 10;
            this.Skill3DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Skill4DisplayLabel
            // 
            this.Skill4DisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skill4DisplayLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Skill4DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Skill4DisplayLabel.Location = new System.Drawing.Point(573, 285);
            this.Skill4DisplayLabel.Name = "Skill4DisplayLabel";
            this.Skill4DisplayLabel.Size = new System.Drawing.Size(187, 63);
            this.Skill4DisplayLabel.TabIndex = 11;
            this.Skill4DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstNameDisplayLabel
            // 
            this.FirstNameDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameDisplayLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameDisplayLabel.Location = new System.Drawing.Point(3, 0);
            this.FirstNameDisplayLabel.Name = "FirstNameDisplayLabel";
            this.FirstNameDisplayLabel.Size = new System.Drawing.Size(184, 57);
            this.FirstNameDisplayLabel.TabIndex = 2;
            this.FirstNameDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator7,
            this.helpToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 28);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(774, 27);
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "toolStrip1";
            this.MainToolStrip.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(774, 28);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(170, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(634, 469);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(136, 63);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 469);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(136, 63);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CharacterOpenFileDialog
            // 
            this.CharacterOpenFileDialog.FileName = "openFileDialog1";
            // 
            // CharacterGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MainTabControl);
            this.Name = "CharacterGenerationForm";
            this.Text = "Character Gererator";
            this.MainTabControl.ResumeLayout(false);
            this.IdentityPage.ResumeLayout(false);
            this.IdentityTableLayoutPanel.ResumeLayout(false);
            this.AbilityPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SkillsPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ChracterSheetPage.ResumeLayout(false);
            this.ChracterSheetPage.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.TabPage AbilityPage;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabPage SkillsPage;
        private System.Windows.Forms.TabPage ChracterSheetPage;
        private System.Windows.Forms.TableLayoutPanel IdentityTableLayoutPanel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.Button GenerateNameButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label DexterityDataLabel;
        private System.Windows.Forms.Label StrengthDataLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Button GenerateAbilitiesButton;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.Label EnduranceLabel;
        private System.Windows.Forms.Label IntellectLabel;
        private System.Windows.Forms.Label EducationLabel;
        private System.Windows.Forms.Label SocialStandingLabel;
        private System.Windows.Forms.Label EnduranceDataLabel;
        private System.Windows.Forms.Label IntellectDataLabel;
        private System.Windows.Forms.Label EducationDataLabel;
        private System.Windows.Forms.Label SocialStandingDataLabel;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog CharacterOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog CharacterSaveFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label SkillLabel;
        private System.Windows.Forms.Button GenerateSkillsButton;
        private System.Windows.Forms.Label Skill1Label;
        private System.Windows.Forms.Label Skill2Label;
        private System.Windows.Forms.Label Skill3Label;
        private System.Windows.Forms.Label Skill4Label;
        private System.Windows.Forms.Label Skill1DataLabel;
        private System.Windows.Forms.Label Skill2DataLabel;
        private System.Windows.Forms.Label Skill3DataLabel;
        private System.Windows.Forms.Label Skill4DataLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LastNameDisplayLabel;
        private System.Windows.Forms.Label StrengthDisplayLabel;
        private System.Windows.Forms.Label EnduranceDisplayLabel;
        private System.Windows.Forms.Label EducationDisplayLabel;
        private System.Windows.Forms.Label DexterityDisplayLabel;
        private System.Windows.Forms.Label IntellectDisplayLabel;
        private System.Windows.Forms.Label SocialStandingDisplayLabel;
        private System.Windows.Forms.Label Skill1DisplayLabel;
        private System.Windows.Forms.Label Skill2DisplayLabel;
        private System.Windows.Forms.Label Skill3DisplayLabel;
        private System.Windows.Forms.Label Skill4DisplayLabel;
        private System.Windows.Forms.Label FirstNameDisplayLabel;
    }
}
