namespace OOP_BestiaryFinal
{
    partial class MonsterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpMonsterList = new GroupBox();
            cboMonsterSort = new ComboBox();
            btnMonsterSort = new Button();
            grpLootGen = new GroupBox();
            lblItemTitle = new Label();
            lblCoinTitle = new Label();
            lstItems = new ListBox();
            rtbLootDescription = new RichTextBox();
            btnGetLoot = new Button();
            cboType = new ComboBox();
            label4 = new Label();
            lblLootLevel = new Label();
            nudLevel = new NumericUpDown();
            chkUseCurrentMonster = new CheckBox();
            grpLootInfo = new GroupBox();
            cboSortLoot = new ComboBox();
            btnSortLoot = new Button();
            lblGoldCount = new Label();
            lstMonsters = new ListBox();
            tabDisplay = new TabControl();
            tabMonsters = new TabPage();
            grpAbilities = new GroupBox();
            cboSortAbilities = new ComboBox();
            btnSortAbilities = new Button();
            lblAbilityType = new Label();
            lblAbilityCost = new Label();
            lblAbility_TitleType = new Label();
            lstAbilities = new ListBox();
            lblAbility_CostTitle = new Label();
            rtbAbilityDesc = new RichTextBox();
            lblAbilityPower = new Label();
            lblAbility_PowerTitle = new Label();
            grpMonsterDetails = new GroupBox();
            lblDesc = new Label();
            lblType = new Label();
            lblTypeTitle = new Label();
            rtbDescArea = new RichTextBox();
            lblHP = new Label();
            lblHPTitle = new Label();
            lblAC = new Label();
            lblACTitle = new Label();
            lblLevel = new Label();
            lblLevelTitle = new Label();
            lblName = new Label();
            lblNameTitle = new Label();
            tabCreate = new TabPage();
            btnCreate_CreateMonster = new Button();
            grpCreateMonsterAbilities = new GroupBox();
            btnCreateControls_ClearList = new Button();
            btnCreateAbility_Create = new Button();
            btnCreateAbility_ClearBottom = new Button();
            cboCreateAbility_DamageType = new ComboBox();
            nudCreateAbility_Cost = new NumericUpDown();
            lblCreateAbilityTitle_DamageType = new Label();
            lblCreateAbilityTitle_Cost = new Label();
            nudCreateAbility_Power = new NumericUpDown();
            rtbCreateAbility_Desc = new RichTextBox();
            lblCreateAbilityTitle_Power = new Label();
            lblCreateAbilityTitle_Desc = new Label();
            txtCreateAbility_Name = new TextBox();
            lstCreateAbility_List = new ListBox();
            lblCreateAbilityTitle_Name = new Label();
            grpCreateMonsterStats = new GroupBox();
            btnCreate_ClearTop = new Button();
            cboCreate_Resists = new ComboBox();
            nudCreate_MinionMax = new NumericUpDown();
            lblCreateTitle_Max = new Label();
            nudCreate_MinionMin = new NumericUpDown();
            lblCreateTitle_Min = new Label();
            lblCreateTitle_Resists = new Label();
            rtbCreate_Desc = new RichTextBox();
            lblCreateTitle_Description = new Label();
            nudCreate_HP = new NumericUpDown();
            nudCreate_AC = new NumericUpDown();
            lblCreateTitle_HP = new Label();
            lblCreateTitle_AC = new Label();
            cboCreate_Type = new ComboBox();
            cboCreate_Class = new ComboBox();
            lblCreateTitle_Type = new Label();
            lblCreateTitle_Class = new Label();
            chkGenerateACHP = new CheckBox();
            nudCreate_Level = new NumericUpDown();
            txtCreate_Name = new TextBox();
            lblCreateTitle_Level = new Label();
            lblCreateTitle_Name = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblMessenger = new Label();
            grpMonsterList.SuspendLayout();
            grpLootGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLevel).BeginInit();
            grpLootInfo.SuspendLayout();
            tabDisplay.SuspendLayout();
            tabMonsters.SuspendLayout();
            grpAbilities.SuspendLayout();
            grpMonsterDetails.SuspendLayout();
            tabCreate.SuspendLayout();
            grpCreateMonsterAbilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCreateAbility_Cost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCreateAbility_Power).BeginInit();
            grpCreateMonsterStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCreate_MinionMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCreate_MinionMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCreate_HP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCreate_AC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCreate_Level).BeginInit();
            SuspendLayout();
            // 
            // grpMonsterList
            // 
            grpMonsterList.Controls.Add(cboMonsterSort);
            grpMonsterList.Controls.Add(btnMonsterSort);
            grpMonsterList.Controls.Add(grpLootGen);
            grpMonsterList.Controls.Add(lstMonsters);
            grpMonsterList.Location = new Point(3, 0);
            grpMonsterList.Name = "grpMonsterList";
            grpMonsterList.Size = new Size(286, 551);
            grpMonsterList.TabIndex = 0;
            grpMonsterList.TabStop = false;
            grpMonsterList.Text = "Select a Monster";
            // 
            // cboMonsterSort
            // 
            cboMonsterSort.FormattingEnabled = true;
            cboMonsterSort.Items.AddRange(new object[] { "Class", "Type", "Level", "HP", "AC" });
            cboMonsterSort.Location = new Point(10, 215);
            cboMonsterSort.Name = "cboMonsterSort";
            cboMonsterSort.Size = new Size(175, 23);
            cboMonsterSort.TabIndex = 22;
            // 
            // btnMonsterSort
            // 
            btnMonsterSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMonsterSort.Location = new Point(194, 216);
            btnMonsterSort.Name = "btnMonsterSort";
            btnMonsterSort.Size = new Size(82, 23);
            btnMonsterSort.TabIndex = 22;
            btnMonsterSort.Text = "Sort...";
            btnMonsterSort.UseVisualStyleBackColor = true;
            btnMonsterSort.Click += btnMonsterSort_Click;
            // 
            // grpLootGen
            // 
            grpLootGen.Controls.Add(lblItemTitle);
            grpLootGen.Controls.Add(lblCoinTitle);
            grpLootGen.Controls.Add(lstItems);
            grpLootGen.Controls.Add(rtbLootDescription);
            grpLootGen.Controls.Add(btnGetLoot);
            grpLootGen.Controls.Add(cboType);
            grpLootGen.Controls.Add(label4);
            grpLootGen.Controls.Add(lblLootLevel);
            grpLootGen.Controls.Add(nudLevel);
            grpLootGen.Controls.Add(chkUseCurrentMonster);
            grpLootGen.Controls.Add(grpLootInfo);
            grpLootGen.Location = new Point(0, 237);
            grpLootGen.Name = "grpLootGen";
            grpLootGen.Size = new Size(285, 314);
            grpLootGen.TabIndex = 1;
            grpLootGen.TabStop = false;
            grpLootGen.Text = "Loot Generator";
            // 
            // lblItemTitle
            // 
            lblItemTitle.AutoSize = true;
            lblItemTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemTitle.Location = new Point(3, 116);
            lblItemTitle.Name = "lblItemTitle";
            lblItemTitle.Size = new Size(75, 15);
            lblItemTitle.TabIndex = 21;
            lblItemTitle.Text = "ItemDetails:";
            // 
            // lblCoinTitle
            // 
            lblCoinTitle.AutoSize = true;
            lblCoinTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCoinTitle.Location = new Point(149, 116);
            lblCoinTitle.Name = "lblCoinTitle";
            lblCoinTitle.Size = new Size(36, 15);
            lblCoinTitle.TabIndex = 19;
            lblCoinTitle.Text = "Gold:";
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 15;
            lstItems.Location = new Point(6, 142);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(128, 139);
            lstItems.TabIndex = 18;
            lstItems.SelectedIndexChanged += lstItems_SelectedIndexChanged;
            // 
            // rtbLootDescription
            // 
            rtbLootDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbLootDescription.Location = new Point(152, 140);
            rtbLootDescription.Name = "rtbLootDescription";
            rtbLootDescription.ReadOnly = true;
            rtbLootDescription.Size = new Size(124, 141);
            rtbLootDescription.TabIndex = 17;
            rtbLootDescription.Text = "";
            rtbLootDescription.ZoomFactor = 0.9F;
            // 
            // btnGetLoot
            // 
            btnGetLoot.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetLoot.Location = new Point(159, 14);
            btnGetLoot.Name = "btnGetLoot";
            btnGetLoot.Size = new Size(120, 23);
            btnGetLoot.TabIndex = 5;
            btnGetLoot.Text = "Get Loot";
            btnGetLoot.UseVisualStyleBackColor = true;
            btnGetLoot.Click += btnGetLoot_Click;
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(136, 42);
            cboType.Name = "cboType";
            cboType.Size = new Size(143, 23);
            cboType.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 44);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "Type:";
            // 
            // lblLootLevel
            // 
            lblLootLevel.AutoSize = true;
            lblLootLevel.Location = new Point(6, 44);
            lblLootLevel.Name = "lblLootLevel";
            lblLootLevel.Size = new Size(37, 15);
            lblLootLevel.TabIndex = 2;
            lblLootLevel.Text = "Level:";
            // 
            // nudLevel
            // 
            nudLevel.Location = new Point(51, 42);
            nudLevel.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudLevel.Name = "nudLevel";
            nudLevel.Size = new Size(34, 23);
            nudLevel.TabIndex = 1;
            nudLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkUseCurrentMonster
            // 
            chkUseCurrentMonster.AutoSize = true;
            chkUseCurrentMonster.Location = new Point(9, 17);
            chkUseCurrentMonster.Name = "chkUseCurrentMonster";
            chkUseCurrentMonster.Size = new Size(144, 19);
            chkUseCurrentMonster.TabIndex = 0;
            chkUseCurrentMonster.Text = "Use Selected Monster?";
            chkUseCurrentMonster.UseVisualStyleBackColor = true;
            chkUseCurrentMonster.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // grpLootInfo
            // 
            grpLootInfo.Controls.Add(cboSortLoot);
            grpLootInfo.Controls.Add(btnSortLoot);
            grpLootInfo.Controls.Add(lblGoldCount);
            grpLootInfo.Location = new Point(0, 92);
            grpLootInfo.Name = "grpLootInfo";
            grpLootInfo.Size = new Size(286, 218);
            grpLootInfo.TabIndex = 20;
            grpLootInfo.TabStop = false;
            grpLootInfo.Text = "Loot Info";
            // 
            // cboSortLoot
            // 
            cboSortLoot.FormattingEnabled = true;
            cboSortLoot.Items.AddRange(new object[] { "Name", "Magic/Mundane", "Value" });
            cboSortLoot.Location = new Point(6, 192);
            cboSortLoot.Name = "cboSortLoot";
            cboSortLoot.Size = new Size(128, 23);
            cboSortLoot.TabIndex = 23;
            // 
            // btnSortLoot
            // 
            btnSortLoot.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSortLoot.Location = new Point(152, 193);
            btnSortLoot.Name = "btnSortLoot";
            btnSortLoot.Size = new Size(124, 23);
            btnSortLoot.TabIndex = 24;
            btnSortLoot.Text = "Sort...";
            btnSortLoot.UseVisualStyleBackColor = true;
            btnSortLoot.Click += btnSortLoot_Click;
            // 
            // lblGoldCount
            // 
            lblGoldCount.AutoSize = true;
            lblGoldCount.Location = new Point(194, 24);
            lblGoldCount.Name = "lblGoldCount";
            lblGoldCount.Size = new Size(0, 15);
            lblGoldCount.TabIndex = 21;
            // 
            // lstMonsters
            // 
            lstMonsters.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstMonsters.FormattingEnabled = true;
            lstMonsters.ItemHeight = 21;
            lstMonsters.Location = new Point(6, 17);
            lstMonsters.Name = "lstMonsters";
            lstMonsters.Size = new Size(273, 193);
            lstMonsters.TabIndex = 0;
            lstMonsters.SelectedIndexChanged += lstMonsters_SelectedIndexChanged;
            // 
            // tabDisplay
            // 
            tabDisplay.Controls.Add(tabMonsters);
            tabDisplay.Controls.Add(tabCreate);
            tabDisplay.Location = new Point(295, 0);
            tabDisplay.Name = "tabDisplay";
            tabDisplay.SelectedIndex = 0;
            tabDisplay.Size = new Size(525, 551);
            tabDisplay.TabIndex = 0;
            // 
            // tabMonsters
            // 
            tabMonsters.Controls.Add(grpAbilities);
            tabMonsters.Controls.Add(grpMonsterDetails);
            tabMonsters.Location = new Point(4, 24);
            tabMonsters.Name = "tabMonsters";
            tabMonsters.Padding = new Padding(3);
            tabMonsters.Size = new Size(517, 523);
            tabMonsters.TabIndex = 0;
            tabMonsters.Text = "Monster Details";
            tabMonsters.UseVisualStyleBackColor = true;
            // 
            // grpAbilities
            // 
            grpAbilities.Controls.Add(cboSortAbilities);
            grpAbilities.Controls.Add(btnSortAbilities);
            grpAbilities.Controls.Add(lblAbilityType);
            grpAbilities.Controls.Add(lblAbilityCost);
            grpAbilities.Controls.Add(lblAbility_TitleType);
            grpAbilities.Controls.Add(lstAbilities);
            grpAbilities.Controls.Add(lblAbility_CostTitle);
            grpAbilities.Controls.Add(rtbAbilityDesc);
            grpAbilities.Controls.Add(lblAbilityPower);
            grpAbilities.Controls.Add(lblAbility_PowerTitle);
            grpAbilities.Location = new Point(3, 233);
            grpAbilities.Name = "grpAbilities";
            grpAbilities.Size = new Size(508, 294);
            grpAbilities.TabIndex = 2;
            grpAbilities.TabStop = false;
            grpAbilities.Text = "Abilities";
            // 
            // cboSortAbilities
            // 
            cboSortAbilities.FormattingEnabled = true;
            cboSortAbilities.Items.AddRange(new object[] { "Power", "Cost", "Type", "Name" });
            cboSortAbilities.Location = new Point(6, 261);
            cboSortAbilities.Name = "cboSortAbilities";
            cboSortAbilities.Size = new Size(143, 23);
            cboSortAbilities.TabIndex = 23;
            // 
            // btnSortAbilities
            // 
            btnSortAbilities.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSortAbilities.Location = new Point(155, 261);
            btnSortAbilities.Name = "btnSortAbilities";
            btnSortAbilities.Size = new Size(72, 23);
            btnSortAbilities.TabIndex = 24;
            btnSortAbilities.Text = "Sort...";
            btnSortAbilities.UseVisualStyleBackColor = true;
            btnSortAbilities.Click += btnSortAbilities_Click;
            // 
            // lblAbilityType
            // 
            lblAbilityType.AutoSize = true;
            lblAbilityType.BorderStyle = BorderStyle.Fixed3D;
            lblAbilityType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAbilityType.Location = new Point(204, 75);
            lblAbilityType.Name = "lblAbilityType";
            lblAbilityType.Size = new Size(2, 23);
            lblAbilityType.TabIndex = 14;
            // 
            // lblAbilityCost
            // 
            lblAbilityCost.AutoSize = true;
            lblAbilityCost.BorderStyle = BorderStyle.Fixed3D;
            lblAbilityCost.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAbilityCost.Location = new Point(204, 44);
            lblAbilityCost.Name = "lblAbilityCost";
            lblAbilityCost.Size = new Size(2, 23);
            lblAbilityCost.TabIndex = 16;
            // 
            // lblAbility_TitleType
            // 
            lblAbility_TitleType.AutoSize = true;
            lblAbility_TitleType.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAbility_TitleType.Location = new Point(155, 76);
            lblAbility_TitleType.Name = "lblAbility_TitleType";
            lblAbility_TitleType.Size = new Size(41, 17);
            lblAbility_TitleType.TabIndex = 13;
            lblAbility_TitleType.Text = "Type:";
            // 
            // lstAbilities
            // 
            lstAbilities.FormattingEnabled = true;
            lstAbilities.ItemHeight = 15;
            lstAbilities.Location = new Point(6, 14);
            lstAbilities.Name = "lstAbilities";
            lstAbilities.Size = new Size(143, 244);
            lstAbilities.TabIndex = 1;
            lstAbilities.SelectedIndexChanged += lstAbilities_SelectedIndexChanged;
            // 
            // lblAbility_CostTitle
            // 
            lblAbility_CostTitle.AutoSize = true;
            lblAbility_CostTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAbility_CostTitle.Location = new Point(155, 47);
            lblAbility_CostTitle.Name = "lblAbility_CostTitle";
            lblAbility_CostTitle.Size = new Size(39, 17);
            lblAbility_CostTitle.TabIndex = 15;
            lblAbility_CostTitle.Text = "Cost:";
            // 
            // rtbAbilityDesc
            // 
            rtbAbilityDesc.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbAbilityDesc.Location = new Point(300, 14);
            rtbAbilityDesc.Name = "rtbAbilityDesc";
            rtbAbilityDesc.ReadOnly = true;
            rtbAbilityDesc.Size = new Size(202, 244);
            rtbAbilityDesc.TabIndex = 0;
            rtbAbilityDesc.Text = "Hello\nHello\nHelloHello\n\nHello\nHello\nHello\nHello\nHello\nHello\nHello\nHello\nHello";
            rtbAbilityDesc.ZoomFactor = 0.9F;
            // 
            // lblAbilityPower
            // 
            lblAbilityPower.AutoSize = true;
            lblAbilityPower.BorderStyle = BorderStyle.Fixed3D;
            lblAbilityPower.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAbilityPower.Location = new Point(204, 14);
            lblAbilityPower.Name = "lblAbilityPower";
            lblAbilityPower.Size = new Size(2, 23);
            lblAbilityPower.TabIndex = 14;
            // 
            // lblAbility_PowerTitle
            // 
            lblAbility_PowerTitle.AutoSize = true;
            lblAbility_PowerTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAbility_PowerTitle.Location = new Point(155, 15);
            lblAbility_PowerTitle.Name = "lblAbility_PowerTitle";
            lblAbility_PowerTitle.Size = new Size(51, 17);
            lblAbility_PowerTitle.TabIndex = 13;
            lblAbility_PowerTitle.Text = "Power:";
            // 
            // grpMonsterDetails
            // 
            grpMonsterDetails.Controls.Add(lblDesc);
            grpMonsterDetails.Controls.Add(lblType);
            grpMonsterDetails.Controls.Add(lblTypeTitle);
            grpMonsterDetails.Controls.Add(rtbDescArea);
            grpMonsterDetails.Controls.Add(lblHP);
            grpMonsterDetails.Controls.Add(lblHPTitle);
            grpMonsterDetails.Controls.Add(lblAC);
            grpMonsterDetails.Controls.Add(lblACTitle);
            grpMonsterDetails.Controls.Add(lblLevel);
            grpMonsterDetails.Controls.Add(lblLevelTitle);
            grpMonsterDetails.Controls.Add(lblName);
            grpMonsterDetails.Controls.Add(lblNameTitle);
            grpMonsterDetails.Location = new Point(3, 0);
            grpMonsterDetails.Name = "grpMonsterDetails";
            grpMonsterDetails.Size = new Size(508, 227);
            grpMonsterDetails.TabIndex = 1;
            grpMonsterDetails.TabStop = false;
            grpMonsterDetails.Text = "Details";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(196, 6);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(67, 15);
            lblDesc.TabIndex = 11;
            lblDesc.Text = "Description";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.BorderStyle = BorderStyle.Fixed3D;
            lblType.Location = new Point(60, 146);
            lblType.Name = "lblType";
            lblType.Size = new Size(2, 17);
            lblType.TabIndex = 10;
            // 
            // lblTypeTitle
            // 
            lblTypeTitle.AutoSize = true;
            lblTypeTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTypeTitle.Location = new Point(6, 146);
            lblTypeTitle.Name = "lblTypeTitle";
            lblTypeTitle.Size = new Size(41, 17);
            lblTypeTitle.TabIndex = 9;
            lblTypeTitle.Text = "Type:";
            // 
            // rtbDescArea
            // 
            rtbDescArea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbDescArea.Location = new Point(196, 24);
            rtbDescArea.Name = "rtbDescArea";
            rtbDescArea.ReadOnly = true;
            rtbDescArea.Size = new Size(306, 139);
            rtbDescArea.TabIndex = 8;
            rtbDescArea.Text = "";
            rtbDescArea.ZoomFactor = 0.9F;
            // 
            // lblHP
            // 
            lblHP.AutoSize = true;
            lblHP.BorderStyle = BorderStyle.Fixed3D;
            lblHP.Location = new Point(60, 119);
            lblHP.Name = "lblHP";
            lblHP.Size = new Size(2, 17);
            lblHP.TabIndex = 7;
            // 
            // lblHPTitle
            // 
            lblHPTitle.AutoSize = true;
            lblHPTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHPTitle.Location = new Point(6, 119);
            lblHPTitle.Name = "lblHPTitle";
            lblHPTitle.Size = new Size(30, 17);
            lblHPTitle.TabIndex = 6;
            lblHPTitle.Text = "HP:";
            // 
            // lblAC
            // 
            lblAC.AutoSize = true;
            lblAC.BorderStyle = BorderStyle.Fixed3D;
            lblAC.Location = new Point(60, 87);
            lblAC.Name = "lblAC";
            lblAC.Size = new Size(2, 17);
            lblAC.TabIndex = 5;
            // 
            // lblACTitle
            // 
            lblACTitle.AutoSize = true;
            lblACTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblACTitle.Location = new Point(6, 87);
            lblACTitle.Name = "lblACTitle";
            lblACTitle.Size = new Size(29, 17);
            lblACTitle.TabIndex = 4;
            lblACTitle.Text = "AC:";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.BorderStyle = BorderStyle.Fixed3D;
            lblLevel.Location = new Point(60, 56);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(2, 17);
            lblLevel.TabIndex = 3;
            // 
            // lblLevelTitle
            // 
            lblLevelTitle.AutoSize = true;
            lblLevelTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLevelTitle.Location = new Point(6, 56);
            lblLevelTitle.Name = "lblLevelTitle";
            lblLevelTitle.Size = new Size(44, 17);
            lblLevelTitle.TabIndex = 2;
            lblLevelTitle.Text = "Level:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BorderStyle = BorderStyle.Fixed3D;
            lblName.Location = new Point(60, 24);
            lblName.Name = "lblName";
            lblName.Size = new Size(2, 17);
            lblName.TabIndex = 1;
            // 
            // lblNameTitle
            // 
            lblNameTitle.AutoSize = true;
            lblNameTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameTitle.Location = new Point(6, 24);
            lblNameTitle.Name = "lblNameTitle";
            lblNameTitle.Size = new Size(48, 17);
            lblNameTitle.TabIndex = 0;
            lblNameTitle.Text = "Name:";
            // 
            // tabCreate
            // 
            tabCreate.Controls.Add(btnCreate_CreateMonster);
            tabCreate.Controls.Add(grpCreateMonsterAbilities);
            tabCreate.Controls.Add(grpCreateMonsterStats);
            tabCreate.Location = new Point(4, 24);
            tabCreate.Name = "tabCreate";
            tabCreate.Padding = new Padding(3);
            tabCreate.Size = new Size(517, 523);
            tabCreate.TabIndex = 1;
            tabCreate.Text = "Create Monster";
            tabCreate.UseVisualStyleBackColor = true;
            // 
            // btnCreate_CreateMonster
            // 
            btnCreate_CreateMonster.Location = new Point(383, 483);
            btnCreate_CreateMonster.Name = "btnCreate_CreateMonster";
            btnCreate_CreateMonster.Size = new Size(128, 23);
            btnCreate_CreateMonster.TabIndex = 2;
            btnCreate_CreateMonster.Text = "Create New Monster";
            btnCreate_CreateMonster.UseVisualStyleBackColor = true;
            btnCreate_CreateMonster.Click += btnCreate_CreateMonster_Click;
            // 
            // grpCreateMonsterAbilities
            // 
            grpCreateMonsterAbilities.Controls.Add(btnCreateControls_ClearList);
            grpCreateMonsterAbilities.Controls.Add(btnCreateAbility_Create);
            grpCreateMonsterAbilities.Controls.Add(btnCreateAbility_ClearBottom);
            grpCreateMonsterAbilities.Controls.Add(cboCreateAbility_DamageType);
            grpCreateMonsterAbilities.Controls.Add(nudCreateAbility_Cost);
            grpCreateMonsterAbilities.Controls.Add(lblCreateAbilityTitle_DamageType);
            grpCreateMonsterAbilities.Controls.Add(lblCreateAbilityTitle_Cost);
            grpCreateMonsterAbilities.Controls.Add(nudCreateAbility_Power);
            grpCreateMonsterAbilities.Controls.Add(rtbCreateAbility_Desc);
            grpCreateMonsterAbilities.Controls.Add(lblCreateAbilityTitle_Power);
            grpCreateMonsterAbilities.Controls.Add(lblCreateAbilityTitle_Desc);
            grpCreateMonsterAbilities.Controls.Add(txtCreateAbility_Name);
            grpCreateMonsterAbilities.Controls.Add(lstCreateAbility_List);
            grpCreateMonsterAbilities.Controls.Add(lblCreateAbilityTitle_Name);
            grpCreateMonsterAbilities.Location = new Point(6, 255);
            grpCreateMonsterAbilities.Name = "grpCreateMonsterAbilities";
            grpCreateMonsterAbilities.Size = new Size(508, 223);
            grpCreateMonsterAbilities.TabIndex = 1;
            grpCreateMonsterAbilities.TabStop = false;
            grpCreateMonsterAbilities.Text = "Monster Abilities";
            // 
            // btnCreateControls_ClearList
            // 
            btnCreateControls_ClearList.Location = new Point(6, 194);
            btnCreateControls_ClearList.Name = "btnCreateControls_ClearList";
            btnCreateControls_ClearList.Size = new Size(144, 23);
            btnCreateControls_ClearList.TabIndex = 42;
            btnCreateControls_ClearList.Text = "Clear List";
            btnCreateControls_ClearList.UseVisualStyleBackColor = true;
            btnCreateControls_ClearList.Click += btnCreateControls_ClearList_Click;
            // 
            // btnCreateAbility_Create
            // 
            btnCreateAbility_Create.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAbility_Create.Location = new Point(321, 195);
            btnCreateAbility_Create.Name = "btnCreateAbility_Create";
            btnCreateAbility_Create.Size = new Size(90, 23);
            btnCreateAbility_Create.TabIndex = 38;
            btnCreateAbility_Create.Text = "Create Ability";
            btnCreateAbility_Create.UseVisualStyleBackColor = true;
            btnCreateAbility_Create.Click += btnCreateAbility_Create_Click;
            // 
            // btnCreateAbility_ClearBottom
            // 
            btnCreateAbility_ClearBottom.Location = new Point(412, 195);
            btnCreateAbility_ClearBottom.Name = "btnCreateAbility_ClearBottom";
            btnCreateAbility_ClearBottom.Size = new Size(90, 23);
            btnCreateAbility_ClearBottom.TabIndex = 39;
            btnCreateAbility_ClearBottom.Text = "Clear Controls";
            btnCreateAbility_ClearBottom.UseVisualStyleBackColor = true;
            btnCreateAbility_ClearBottom.Click += btnCreateAbility_ClearBottom_Click;
            // 
            // cboCreateAbility_DamageType
            // 
            cboCreateAbility_DamageType.FormattingEnabled = true;
            cboCreateAbility_DamageType.Location = new Point(211, 132);
            cboCreateAbility_DamageType.Name = "cboCreateAbility_DamageType";
            cboCreateAbility_DamageType.Size = new Size(104, 23);
            cboCreateAbility_DamageType.TabIndex = 39;
            // 
            // nudCreateAbility_Cost
            // 
            nudCreateAbility_Cost.Location = new Point(215, 82);
            nudCreateAbility_Cost.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudCreateAbility_Cost.Name = "nudCreateAbility_Cost";
            nudCreateAbility_Cost.Size = new Size(100, 23);
            nudCreateAbility_Cost.TabIndex = 41;
            nudCreateAbility_Cost.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCreateAbilityTitle_DamageType
            // 
            lblCreateAbilityTitle_DamageType.AutoSize = true;
            lblCreateAbilityTitle_DamageType.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateAbilityTitle_DamageType.Location = new Point(159, 116);
            lblCreateAbilityTitle_DamageType.Name = "lblCreateAbilityTitle_DamageType";
            lblCreateAbilityTitle_DamageType.Size = new Size(63, 34);
            lblCreateAbilityTitle_DamageType.TabIndex = 38;
            lblCreateAbilityTitle_DamageType.Text = "Damage \r\nType:";
            // 
            // lblCreateAbilityTitle_Cost
            // 
            lblCreateAbilityTitle_Cost.AutoSize = true;
            lblCreateAbilityTitle_Cost.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateAbilityTitle_Cost.Location = new Point(161, 84);
            lblCreateAbilityTitle_Cost.Name = "lblCreateAbilityTitle_Cost";
            lblCreateAbilityTitle_Cost.Size = new Size(39, 17);
            lblCreateAbilityTitle_Cost.TabIndex = 40;
            lblCreateAbilityTitle_Cost.Text = "Cost:";
            // 
            // nudCreateAbility_Power
            // 
            nudCreateAbility_Power.Location = new Point(215, 48);
            nudCreateAbility_Power.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudCreateAbility_Power.Name = "nudCreateAbility_Power";
            nudCreateAbility_Power.Size = new Size(100, 23);
            nudCreateAbility_Power.TabIndex = 39;
            nudCreateAbility_Power.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // rtbCreateAbility_Desc
            // 
            rtbCreateAbility_Desc.Location = new Point(321, 40);
            rtbCreateAbility_Desc.Name = "rtbCreateAbility_Desc";
            rtbCreateAbility_Desc.Size = new Size(181, 149);
            rtbCreateAbility_Desc.TabIndex = 39;
            rtbCreateAbility_Desc.Text = "";
            // 
            // lblCreateAbilityTitle_Power
            // 
            lblCreateAbilityTitle_Power.AutoSize = true;
            lblCreateAbilityTitle_Power.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateAbilityTitle_Power.Location = new Point(161, 50);
            lblCreateAbilityTitle_Power.Name = "lblCreateAbilityTitle_Power";
            lblCreateAbilityTitle_Power.Size = new Size(51, 17);
            lblCreateAbilityTitle_Power.TabIndex = 38;
            lblCreateAbilityTitle_Power.Text = "Power:";
            // 
            // lblCreateAbilityTitle_Desc
            // 
            lblCreateAbilityTitle_Desc.AutoSize = true;
            lblCreateAbilityTitle_Desc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateAbilityTitle_Desc.Location = new Point(321, 20);
            lblCreateAbilityTitle_Desc.Name = "lblCreateAbilityTitle_Desc";
            lblCreateAbilityTitle_Desc.Size = new Size(83, 17);
            lblCreateAbilityTitle_Desc.TabIndex = 38;
            lblCreateAbilityTitle_Desc.Text = "Description:";
            // 
            // txtCreateAbility_Name
            // 
            txtCreateAbility_Name.Location = new Point(215, 18);
            txtCreateAbility_Name.Name = "txtCreateAbility_Name";
            txtCreateAbility_Name.Size = new Size(100, 23);
            txtCreateAbility_Name.TabIndex = 39;
            // 
            // lstCreateAbility_List
            // 
            lstCreateAbility_List.FormattingEnabled = true;
            lstCreateAbility_List.ItemHeight = 15;
            lstCreateAbility_List.Location = new Point(7, 18);
            lstCreateAbility_List.Name = "lstCreateAbility_List";
            lstCreateAbility_List.Size = new Size(143, 169);
            lstCreateAbility_List.TabIndex = 2;
            // 
            // lblCreateAbilityTitle_Name
            // 
            lblCreateAbilityTitle_Name.AutoSize = true;
            lblCreateAbilityTitle_Name.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateAbilityTitle_Name.Location = new Point(161, 19);
            lblCreateAbilityTitle_Name.Name = "lblCreateAbilityTitle_Name";
            lblCreateAbilityTitle_Name.Size = new Size(48, 17);
            lblCreateAbilityTitle_Name.TabIndex = 38;
            lblCreateAbilityTitle_Name.Text = "Name:";
            // 
            // grpCreateMonsterStats
            // 
            grpCreateMonsterStats.Controls.Add(btnCreate_ClearTop);
            grpCreateMonsterStats.Controls.Add(cboCreate_Resists);
            grpCreateMonsterStats.Controls.Add(nudCreate_MinionMax);
            grpCreateMonsterStats.Controls.Add(lblCreateTitle_Max);
            grpCreateMonsterStats.Controls.Add(nudCreate_MinionMin);
            grpCreateMonsterStats.Controls.Add(lblCreateTitle_Min);
            grpCreateMonsterStats.Controls.Add(lblCreateTitle_Resists);
            grpCreateMonsterStats.Controls.Add(rtbCreate_Desc);
            grpCreateMonsterStats.Controls.Add(lblCreateTitle_Description);
            grpCreateMonsterStats.Controls.Add(nudCreate_HP);
            grpCreateMonsterStats.Controls.Add(nudCreate_AC);
            grpCreateMonsterStats.Controls.Add(lblCreateTitle_HP);
            grpCreateMonsterStats.Controls.Add(lblCreateTitle_AC);
            grpCreateMonsterStats.Controls.Add(cboCreate_Type);
            grpCreateMonsterStats.Controls.Add(cboCreate_Class);
            grpCreateMonsterStats.Controls.Add(lblCreateTitle_Type);
            grpCreateMonsterStats.Controls.Add(lblCreateTitle_Class);
            grpCreateMonsterStats.Controls.Add(chkGenerateACHP);
            grpCreateMonsterStats.Controls.Add(nudCreate_Level);
            grpCreateMonsterStats.Controls.Add(txtCreate_Name);
            grpCreateMonsterStats.Controls.Add(lblCreateTitle_Level);
            grpCreateMonsterStats.Controls.Add(lblCreateTitle_Name);
            grpCreateMonsterStats.Location = new Point(6, 3);
            grpCreateMonsterStats.Name = "grpCreateMonsterStats";
            grpCreateMonsterStats.Size = new Size(508, 247);
            grpCreateMonsterStats.TabIndex = 0;
            grpCreateMonsterStats.TabStop = false;
            grpCreateMonsterStats.Text = "Monster Stats";
            // 
            // btnCreate_ClearTop
            // 
            btnCreate_ClearTop.Location = new Point(403, 194);
            btnCreate_ClearTop.Name = "btnCreate_ClearTop";
            btnCreate_ClearTop.Size = new Size(90, 23);
            btnCreate_ClearTop.TabIndex = 37;
            btnCreate_ClearTop.Text = "Clear Controls";
            btnCreate_ClearTop.UseVisualStyleBackColor = true;
            btnCreate_ClearTop.Click += btnCreate_ClearTop_Click;
            // 
            // cboCreate_Resists
            // 
            cboCreate_Resists.FormattingEnabled = true;
            cboCreate_Resists.Location = new Point(221, 157);
            cboCreate_Resists.Name = "cboCreate_Resists";
            cboCreate_Resists.Size = new Size(161, 23);
            cboCreate_Resists.TabIndex = 22;
            // 
            // nudCreate_MinionMax
            // 
            nudCreate_MinionMax.Location = new Point(341, 193);
            nudCreate_MinionMax.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudCreate_MinionMax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCreate_MinionMax.Name = "nudCreate_MinionMax";
            nudCreate_MinionMax.Size = new Size(41, 23);
            nudCreate_MinionMax.TabIndex = 36;
            nudCreate_MinionMax.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCreateTitle_Max
            // 
            lblCreateTitle_Max.AutoSize = true;
            lblCreateTitle_Max.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateTitle_Max.Location = new Point(281, 196);
            lblCreateTitle_Max.Name = "lblCreateTitle_Max";
            lblCreateTitle_Max.Size = new Size(38, 17);
            lblCreateTitle_Max.TabIndex = 35;
            lblCreateTitle_Max.Text = "Max:";
            // 
            // nudCreate_MinionMin
            // 
            nudCreate_MinionMin.Location = new Point(221, 193);
            nudCreate_MinionMin.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudCreate_MinionMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCreate_MinionMin.Name = "nudCreate_MinionMin";
            nudCreate_MinionMin.Size = new Size(41, 23);
            nudCreate_MinionMin.TabIndex = 34;
            nudCreate_MinionMin.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCreateTitle_Min
            // 
            lblCreateTitle_Min.AutoSize = true;
            lblCreateTitle_Min.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateTitle_Min.Location = new Point(161, 196);
            lblCreateTitle_Min.Name = "lblCreateTitle_Min";
            lblCreateTitle_Min.Size = new Size(36, 17);
            lblCreateTitle_Min.TabIndex = 33;
            lblCreateTitle_Min.Text = "Min:";
            // 
            // lblCreateTitle_Resists
            // 
            lblCreateTitle_Resists.AutoSize = true;
            lblCreateTitle_Resists.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateTitle_Resists.Location = new Point(161, 158);
            lblCreateTitle_Resists.Name = "lblCreateTitle_Resists";
            lblCreateTitle_Resists.Size = new Size(54, 17);
            lblCreateTitle_Resists.TabIndex = 32;
            lblCreateTitle_Resists.Text = "Resists:";
            // 
            // rtbCreate_Desc
            // 
            rtbCreate_Desc.Location = new Point(221, 38);
            rtbCreate_Desc.Name = "rtbCreate_Desc";
            rtbCreate_Desc.Size = new Size(281, 92);
            rtbCreate_Desc.TabIndex = 31;
            rtbCreate_Desc.Text = "";
            // 
            // lblCreateTitle_Description
            // 
            lblCreateTitle_Description.AutoSize = true;
            lblCreateTitle_Description.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateTitle_Description.Location = new Point(221, 18);
            lblCreateTitle_Description.Name = "lblCreateTitle_Description";
            lblCreateTitle_Description.Size = new Size(83, 17);
            lblCreateTitle_Description.TabIndex = 30;
            lblCreateTitle_Description.Text = "Description:";
            // 
            // nudCreate_HP
            // 
            nudCreate_HP.Location = new Point(60, 190);
            nudCreate_HP.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudCreate_HP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCreate_HP.Name = "nudCreate_HP";
            nudCreate_HP.Size = new Size(41, 23);
            nudCreate_HP.TabIndex = 29;
            nudCreate_HP.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudCreate_AC
            // 
            nudCreate_AC.Location = new Point(60, 161);
            nudCreate_AC.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudCreate_AC.Name = "nudCreate_AC";
            nudCreate_AC.Size = new Size(41, 23);
            nudCreate_AC.TabIndex = 28;
            nudCreate_AC.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblCreateTitle_HP
            // 
            lblCreateTitle_HP.AutoSize = true;
            lblCreateTitle_HP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateTitle_HP.Location = new Point(6, 193);
            lblCreateTitle_HP.Name = "lblCreateTitle_HP";
            lblCreateTitle_HP.Size = new Size(30, 17);
            lblCreateTitle_HP.TabIndex = 27;
            lblCreateTitle_HP.Text = "HP:";
            // 
            // lblCreateTitle_AC
            // 
            lblCreateTitle_AC.AutoSize = true;
            lblCreateTitle_AC.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateTitle_AC.Location = new Point(7, 164);
            lblCreateTitle_AC.Name = "lblCreateTitle_AC";
            lblCreateTitle_AC.Size = new Size(29, 17);
            lblCreateTitle_AC.TabIndex = 26;
            lblCreateTitle_AC.Text = "AC:";
            // 
            // cboCreate_Type
            // 
            cboCreate_Type.FormattingEnabled = true;
            cboCreate_Type.Location = new Point(60, 107);
            cboCreate_Type.Name = "cboCreate_Type";
            cboCreate_Type.Size = new Size(104, 23);
            cboCreate_Type.TabIndex = 25;
            // 
            // cboCreate_Class
            // 
            cboCreate_Class.FormattingEnabled = true;
            cboCreate_Class.Location = new Point(60, 79);
            cboCreate_Class.Name = "cboCreate_Class";
            cboCreate_Class.Size = new Size(104, 23);
            cboCreate_Class.TabIndex = 22;
            cboCreate_Class.SelectedIndexChanged += cboCreate_Class_SelectedIndexChanged;
            // 
            // lblCreateTitle_Type
            // 
            lblCreateTitle_Type.AutoSize = true;
            lblCreateTitle_Type.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateTitle_Type.Location = new Point(6, 109);
            lblCreateTitle_Type.Name = "lblCreateTitle_Type";
            lblCreateTitle_Type.Size = new Size(41, 17);
            lblCreateTitle_Type.TabIndex = 24;
            lblCreateTitle_Type.Text = "Type:";
            // 
            // lblCreateTitle_Class
            // 
            lblCreateTitle_Class.AutoSize = true;
            lblCreateTitle_Class.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateTitle_Class.Location = new Point(6, 80);
            lblCreateTitle_Class.Name = "lblCreateTitle_Class";
            lblCreateTitle_Class.Size = new Size(43, 17);
            lblCreateTitle_Class.TabIndex = 23;
            lblCreateTitle_Class.Text = "Class:";
            // 
            // chkGenerateACHP
            // 
            chkGenerateACHP.AutoSize = true;
            chkGenerateACHP.Location = new Point(6, 136);
            chkGenerateACHP.Name = "chkGenerateACHP";
            chkGenerateACHP.Size = new Size(209, 19);
            chkGenerateACHP.TabIndex = 22;
            chkGenerateACHP.Text = "Randomly Calculate w/ Level/Type\r\n";
            chkGenerateACHP.UseVisualStyleBackColor = true;
            chkGenerateACHP.CheckedChanged += chkGenerateACHP_CheckedChanged;
            // 
            // nudCreate_Level
            // 
            nudCreate_Level.Location = new Point(60, 49);
            nudCreate_Level.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudCreate_Level.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCreate_Level.Name = "nudCreate_Level";
            nudCreate_Level.Size = new Size(41, 23);
            nudCreate_Level.TabIndex = 6;
            nudCreate_Level.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtCreate_Name
            // 
            txtCreate_Name.Location = new Point(60, 18);
            txtCreate_Name.Name = "txtCreate_Name";
            txtCreate_Name.Size = new Size(100, 23);
            txtCreate_Name.TabIndex = 5;
            // 
            // lblCreateTitle_Level
            // 
            lblCreateTitle_Level.AutoSize = true;
            lblCreateTitle_Level.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateTitle_Level.Location = new Point(6, 51);
            lblCreateTitle_Level.Name = "lblCreateTitle_Level";
            lblCreateTitle_Level.Size = new Size(44, 17);
            lblCreateTitle_Level.TabIndex = 4;
            lblCreateTitle_Level.Text = "Level:";
            // 
            // lblCreateTitle_Name
            // 
            lblCreateTitle_Name.AutoSize = true;
            lblCreateTitle_Name.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateTitle_Name.Location = new Point(6, 19);
            lblCreateTitle_Name.Name = "lblCreateTitle_Name";
            lblCreateTitle_Name.Size = new Size(48, 17);
            lblCreateTitle_Name.TabIndex = 3;
            lblCreateTitle_Name.Text = "Name:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblMessenger
            // 
            lblMessenger.BorderStyle = BorderStyle.Fixed3D;
            lblMessenger.FlatStyle = FlatStyle.Popup;
            lblMessenger.Location = new Point(6, 554);
            lblMessenger.Name = "lblMessenger";
            lblMessenger.Size = new Size(804, 17);
            lblMessenger.TabIndex = 1;
            lblMessenger.Text = "uh";
            // 
            // MonsterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 576);
            Controls.Add(lblMessenger);
            Controls.Add(tabDisplay);
            Controls.Add(grpMonsterList);
            Name = "MonsterForm";
            Text = "View a Monster";
            FormClosing += MonsterForm_FormClosing;
            Load += Form1_Load;
            grpMonsterList.ResumeLayout(false);
            grpLootGen.ResumeLayout(false);
            grpLootGen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLevel).EndInit();
            grpLootInfo.ResumeLayout(false);
            grpLootInfo.PerformLayout();
            tabDisplay.ResumeLayout(false);
            tabMonsters.ResumeLayout(false);
            grpAbilities.ResumeLayout(false);
            grpAbilities.PerformLayout();
            grpMonsterDetails.ResumeLayout(false);
            grpMonsterDetails.PerformLayout();
            tabCreate.ResumeLayout(false);
            grpCreateMonsterAbilities.ResumeLayout(false);
            grpCreateMonsterAbilities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCreateAbility_Cost).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCreateAbility_Power).EndInit();
            grpCreateMonsterStats.ResumeLayout(false);
            grpCreateMonsterStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCreate_MinionMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCreate_MinionMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCreate_HP).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCreate_AC).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCreate_Level).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMonsterList;
        private TabControl tabDisplay;
        private TabPage tabMonsters;
        private TabPage tabCreate;
        private ListBox lstMonsters;
        private GroupBox grpAbilities;
        private GroupBox grpMonsterDetails;
        private ListBox lstAbilities;
        private RichTextBox rtbAbilityDesc;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblHP;
        private Label lblHPTitle;
        private Label lblAC;
        private Label lblACTitle;
        private Label lblLevel;
        private Label lblLevelTitle;
        private Label lblName;
        private Label lblNameTitle;
        private Label lblType;
        private Label lblTypeTitle;
        private RichTextBox rtbDescArea;
        private Label lblDesc;
        private Label lblAbilityType;
        private Label lblAbilityCost;
        private Label lblAbility_TitleType;
        private Label lblAbility_CostTitle;
        private Label lblAbilityPower;
        private Label lblAbility_PowerTitle;
        private GroupBox grpLootGen;
        private CheckBox chkUseCurrentMonster;
        private ListBox lstItems;
        private RichTextBox rtbLootDescription;
        private Button btnGetLoot;
        private ComboBox cboType;
        private Label label4;
        private Label lblLootLevel;
        private NumericUpDown nudLevel;
        private Label lblCoinTitle;
        private GroupBox grpLootInfo;
        private Label lblItemTitle;
        private Label lblGoldCount;
        private GroupBox grpCreateMonsterAbilities;
        private GroupBox grpCreateMonsterStats;
        private Label lblMessenger;
        private NumericUpDown nudCreate_Level;
        private TextBox txtCreate_Name;
        private Label lblCreateTitle_Level;
        private Label lblCreateTitle_Name;
        private CheckBox chkGenerateACHP;
        private Label lblCreateTitle_HP;
        private Label lblCreateTitle_AC;
        private ComboBox cboCreate_Type;
        private ComboBox cboCreate_Class;
        private Label lblCreateTitle_Type;
        private Label lblCreateTitle_Class;
        private NumericUpDown nudCreate_HP;
        private NumericUpDown nudCreate_AC;
        private Label lblCreateTitle_Description;
        private RichTextBox rtbCreate_Desc;
        private Label lblCreateTitle_Resists;
        private NumericUpDown nudCreate_MinionMin;
        private Label lblCreateTitle_Min;
        private Button btnCreate_ClearTop;
        private ComboBox cboCreate_Resists;
        private NumericUpDown nudCreate_MinionMax;
        private Label lblCreateTitle_Max;
        private Button btnCreate_CreateMonster;
        private ListBox lstCreateAbility_List;
        private RichTextBox rtbCreateAbility_Desc;
        private Label lblCreateAbilityTitle_Desc;
        private TextBox txtCreateAbility_Name;
        private Label lblCreateAbilityTitle_Name;
        private NumericUpDown nudCreateAbility_Power;
        private Label lblCreateAbilityTitle_Power;
        private NumericUpDown nudCreateAbility_Cost;
        private Label lblCreateAbilityTitle_Cost;
        private ComboBox cboCreateAbility_DamageType;
        private Label lblCreateAbilityTitle_DamageType;
        private Button btnCreateAbility_Create;
        private Button btnCreateAbility_ClearBottom;
        private Button btnCreateControls_ClearList;
        private ComboBox cboMonsterSort;
        private Button btnMonsterSort;
        private ComboBox cboSortLoot;
        private Button btnSortLoot;
        private ComboBox cboSortAbilities;
        private Button btnSortAbilities;
    }
}
