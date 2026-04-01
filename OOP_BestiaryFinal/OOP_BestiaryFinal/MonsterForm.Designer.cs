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
            grpLootGen = new GroupBox();
            lblItemTitle = new Label();
            lblCoinTitle = new Label();
            lstItems = new ListBox();
            rtbLootDescription = new RichTextBox();
            btnGetLoot = new Button();
            cboType = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            nudLevel = new NumericUpDown();
            chkUseCurrentMonster = new CheckBox();
            grpLootInfo = new GroupBox();
            lblGoldCount = new Label();
            lstMonsters = new ListBox();
            tabDisplay = new TabControl();
            tabMonsters = new TabPage();
            grpAbilities = new GroupBox();
            lblAbilityType = new Label();
            lblAbilityCost = new Label();
            label10 = new Label();
            lstAbilities = new ListBox();
            label2 = new Label();
            rtbAbilityDesc = new RichTextBox();
            lblAbilityPower = new Label();
            label6 = new Label();
            grpMonsterDetails = new GroupBox();
            grpCombat = new GroupBox();
            lblDesc = new Label();
            lblType = new Label();
            label9 = new Label();
            rtbDescArea = new RichTextBox();
            lblHP = new Label();
            label7 = new Label();
            lblAC = new Label();
            label5 = new Label();
            lblLevel = new Label();
            label3 = new Label();
            lblName = new Label();
            lblNameTitle = new Label();
            tabCreate = new TabPage();
            grpCreateMonsterAbilities = new GroupBox();
            grpCreateMonsterStats = new GroupBox();
            rtbCreate_Desc = new RichTextBox();
            Description = new Label();
            nudCreate_HP = new NumericUpDown();
            nudCreate_AC = new NumericUpDown();
            lblCreateTitle_HP = new Label();
            lblCreateTitle_AC = new Label();
            cboCreate_Type = new ComboBox();
            cboCreate_Class = new ComboBox();
            label11 = new Label();
            label8 = new Label();
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
            grpCreateMonsterStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCreate_HP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCreate_AC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCreate_Level).BeginInit();
            SuspendLayout();
            // 
            // grpMonsterList
            // 
            grpMonsterList.Controls.Add(grpLootGen);
            grpMonsterList.Controls.Add(lstMonsters);
            grpMonsterList.Location = new Point(3, 0);
            grpMonsterList.Name = "grpMonsterList";
            grpMonsterList.Size = new Size(286, 539);
            grpMonsterList.TabIndex = 0;
            grpMonsterList.TabStop = false;
            grpMonsterList.Text = "Select a Monster";
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
            grpLootGen.Controls.Add(label1);
            grpLootGen.Controls.Add(nudLevel);
            grpLootGen.Controls.Add(chkUseCurrentMonster);
            grpLootGen.Controls.Add(grpLootInfo);
            grpLootGen.Location = new Point(0, 237);
            grpLootGen.Name = "grpLootGen";
            grpLootGen.Size = new Size(285, 303);
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
            lstItems.Size = new Size(128, 154);
            lstItems.TabIndex = 18;
            lstItems.SelectedIndexChanged += lstItems_SelectedIndexChanged;
            // 
            // rtbLootDescription
            // 
            rtbLootDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbLootDescription.Location = new Point(152, 140);
            rtbLootDescription.Name = "rtbLootDescription";
            rtbLootDescription.ReadOnly = true;
            rtbLootDescription.Size = new Size(124, 155);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Level:";
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
            grpLootInfo.Controls.Add(lblGoldCount);
            grpLootInfo.Location = new Point(0, 92);
            grpLootInfo.Name = "grpLootInfo";
            grpLootInfo.Size = new Size(286, 210);
            grpLootInfo.TabIndex = 20;
            grpLootInfo.TabStop = false;
            grpLootInfo.Text = "Loot Info";
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
            lstMonsters.Size = new Size(273, 214);
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
            tabDisplay.Size = new Size(525, 540);
            tabDisplay.TabIndex = 0;
            // 
            // tabMonsters
            // 
            tabMonsters.Controls.Add(grpAbilities);
            tabMonsters.Controls.Add(grpMonsterDetails);
            tabMonsters.Location = new Point(4, 24);
            tabMonsters.Name = "tabMonsters";
            tabMonsters.Padding = new Padding(3);
            tabMonsters.Size = new Size(517, 512);
            tabMonsters.TabIndex = 0;
            tabMonsters.Text = "Monster Details";
            tabMonsters.UseVisualStyleBackColor = true;
            // 
            // grpAbilities
            // 
            grpAbilities.Controls.Add(lblAbilityType);
            grpAbilities.Controls.Add(lblAbilityCost);
            grpAbilities.Controls.Add(label10);
            grpAbilities.Controls.Add(lstAbilities);
            grpAbilities.Controls.Add(label2);
            grpAbilities.Controls.Add(rtbAbilityDesc);
            grpAbilities.Controls.Add(lblAbilityPower);
            grpAbilities.Controls.Add(label6);
            grpAbilities.Location = new Point(3, 280);
            grpAbilities.Name = "grpAbilities";
            grpAbilities.Size = new Size(508, 226);
            grpAbilities.TabIndex = 2;
            grpAbilities.TabStop = false;
            grpAbilities.Text = "Abilities";
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(155, 76);
            label10.Name = "label10";
            label10.Size = new Size(41, 17);
            label10.TabIndex = 13;
            label10.Text = "Type:";
            // 
            // lstAbilities
            // 
            lstAbilities.FormattingEnabled = true;
            lstAbilities.ItemHeight = 15;
            lstAbilities.Location = new Point(6, 14);
            lstAbilities.Name = "lstAbilities";
            lstAbilities.Size = new Size(143, 199);
            lstAbilities.TabIndex = 1;
            lstAbilities.SelectedIndexChanged += lstAbilities_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(155, 47);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 15;
            label2.Text = "Cost:";
            // 
            // rtbAbilityDesc
            // 
            rtbAbilityDesc.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbAbilityDesc.Location = new Point(300, 14);
            rtbAbilityDesc.Name = "rtbAbilityDesc";
            rtbAbilityDesc.ReadOnly = true;
            rtbAbilityDesc.Size = new Size(202, 199);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(155, 15);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 13;
            label6.Text = "Power:";
            // 
            // grpMonsterDetails
            // 
            grpMonsterDetails.Controls.Add(grpCombat);
            grpMonsterDetails.Controls.Add(lblDesc);
            grpMonsterDetails.Controls.Add(lblType);
            grpMonsterDetails.Controls.Add(label9);
            grpMonsterDetails.Controls.Add(rtbDescArea);
            grpMonsterDetails.Controls.Add(lblHP);
            grpMonsterDetails.Controls.Add(label7);
            grpMonsterDetails.Controls.Add(lblAC);
            grpMonsterDetails.Controls.Add(label5);
            grpMonsterDetails.Controls.Add(lblLevel);
            grpMonsterDetails.Controls.Add(label3);
            grpMonsterDetails.Controls.Add(lblName);
            grpMonsterDetails.Controls.Add(lblNameTitle);
            grpMonsterDetails.Location = new Point(3, 0);
            grpMonsterDetails.Name = "grpMonsterDetails";
            grpMonsterDetails.Size = new Size(508, 274);
            grpMonsterDetails.TabIndex = 1;
            grpMonsterDetails.TabStop = false;
            grpMonsterDetails.Text = "Details";
            // 
            // grpCombat
            // 
            grpCombat.Location = new Point(6, 169);
            grpCombat.Name = "grpCombat";
            grpCombat.Size = new Size(496, 100);
            grpCombat.TabIndex = 12;
            grpCombat.TabStop = false;
            grpCombat.Text = "Combat";
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 146);
            label9.Name = "label9";
            label9.Size = new Size(41, 17);
            label9.TabIndex = 9;
            label9.Text = "Type:";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 119);
            label7.Name = "label7";
            label7.Size = new Size(30, 17);
            label7.TabIndex = 6;
            label7.Text = "HP:";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 87);
            label5.Name = "label5";
            label5.Size = new Size(29, 17);
            label5.TabIndex = 4;
            label5.Text = "AC:";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 56);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 2;
            label3.Text = "Level:";
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
            tabCreate.Controls.Add(grpCreateMonsterAbilities);
            tabCreate.Controls.Add(grpCreateMonsterStats);
            tabCreate.Location = new Point(4, 24);
            tabCreate.Name = "tabCreate";
            tabCreate.Padding = new Padding(3);
            tabCreate.Size = new Size(517, 512);
            tabCreate.TabIndex = 1;
            tabCreate.Text = "Create Monster";
            tabCreate.UseVisualStyleBackColor = true;
            // 
            // grpCreateMonsterAbilities
            // 
            grpCreateMonsterAbilities.Location = new Point(6, 255);
            grpCreateMonsterAbilities.Name = "grpCreateMonsterAbilities";
            grpCreateMonsterAbilities.Size = new Size(508, 251);
            grpCreateMonsterAbilities.TabIndex = 1;
            grpCreateMonsterAbilities.TabStop = false;
            grpCreateMonsterAbilities.Text = "Monster Abilities";
            // 
            // grpCreateMonsterStats
            // 
            grpCreateMonsterStats.Controls.Add(rtbCreate_Desc);
            grpCreateMonsterStats.Controls.Add(Description);
            grpCreateMonsterStats.Controls.Add(nudCreate_HP);
            grpCreateMonsterStats.Controls.Add(nudCreate_AC);
            grpCreateMonsterStats.Controls.Add(lblCreateTitle_HP);
            grpCreateMonsterStats.Controls.Add(lblCreateTitle_AC);
            grpCreateMonsterStats.Controls.Add(cboCreate_Type);
            grpCreateMonsterStats.Controls.Add(cboCreate_Class);
            grpCreateMonsterStats.Controls.Add(label11);
            grpCreateMonsterStats.Controls.Add(label8);
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
            // rtbCreate_Desc
            // 
            rtbCreate_Desc.Location = new Point(204, 38);
            rtbCreate_Desc.Name = "rtbCreate_Desc";
            rtbCreate_Desc.Size = new Size(298, 203);
            rtbCreate_Desc.TabIndex = 31;
            rtbCreate_Desc.Text = "";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Description.Location = new Point(200, 18);
            Description.Name = "Description";
            Description.Size = new Size(83, 17);
            Description.TabIndex = 30;
            Description.Text = "Description:";
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
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(6, 109);
            label11.Name = "label11";
            label11.Size = new Size(41, 17);
            label11.TabIndex = 24;
            label11.Text = "Type:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 80);
            label8.Name = "label8";
            label8.Size = new Size(43, 17);
            label8.TabIndex = 23;
            label8.Text = "Class:";
            // 
            // chkGenerateACHP
            // 
            chkGenerateACHP.AutoSize = true;
            chkGenerateACHP.Location = new Point(6, 136);
            chkGenerateACHP.Name = "chkGenerateACHP";
            chkGenerateACHP.Size = new Size(191, 19);
            chkGenerateACHP.TabIndex = 22;
            chkGenerateACHP.Text = "Calculate AC/HP by Level/Type";
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
            lblMessenger.Location = new Point(12, 543);
            lblMessenger.Name = "lblMessenger";
            lblMessenger.Size = new Size(804, 17);
            lblMessenger.TabIndex = 1;
            lblMessenger.Text = "uh";
            // 
            // MonsterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 569);
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
            grpCreateMonsterStats.ResumeLayout(false);
            grpCreateMonsterStats.PerformLayout();
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
        private Label label7;
        private Label lblAC;
        private Label label5;
        private Label lblLevel;
        private Label label3;
        private Label lblName;
        private Label lblNameTitle;
        private Label lblType;
        private Label label9;
        private RichTextBox rtbDescArea;
        private Label lblDesc;
        private GroupBox grpCombat;
        private Label lblAbilityType;
        private Label lblAbilityCost;
        private Label label10;
        private Label label2;
        private Label lblAbilityPower;
        private Label label6;
        private GroupBox grpLootGen;
        private CheckBox chkUseCurrentMonster;
        private ListBox lstItems;
        private RichTextBox rtbLootDescription;
        private Button btnGetLoot;
        private ComboBox cboType;
        private Label label4;
        private Label label1;
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
        private Label label11;
        private Label label8;
        private NumericUpDown nudCreate_HP;
        private NumericUpDown nudCreate_AC;
        private Label Description;
        private RichTextBox rtbCreate_Desc;
    }
}
