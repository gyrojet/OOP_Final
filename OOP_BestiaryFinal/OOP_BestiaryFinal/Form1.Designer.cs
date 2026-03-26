namespace OOP_BestiaryFinal
{
    partial class Form1
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
            lblMessenger = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            grpMonsterList.SuspendLayout();
            tabDisplay.SuspendLayout();
            tabMonsters.SuspendLayout();
            grpAbilities.SuspendLayout();
            grpMonsterDetails.SuspendLayout();
            SuspendLayout();
            // 
            // grpMonsterList
            // 
            grpMonsterList.Controls.Add(lstMonsters);
            grpMonsterList.Location = new Point(3, 0);
            grpMonsterList.Name = "grpMonsterList";
            grpMonsterList.Size = new Size(286, 492);
            grpMonsterList.TabIndex = 0;
            grpMonsterList.TabStop = false;
            grpMonsterList.Text = "Select a Monster";
            // 
            // lstMonsters
            // 
            lstMonsters.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstMonsters.FormattingEnabled = true;
            lstMonsters.ItemHeight = 21;
            lstMonsters.Location = new Point(6, 17);
            lstMonsters.Name = "lstMonsters";
            lstMonsters.Size = new Size(273, 466);
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
            tabDisplay.Size = new Size(525, 492);
            tabDisplay.TabIndex = 0;
            // 
            // tabMonsters
            // 
            tabMonsters.Controls.Add(grpAbilities);
            tabMonsters.Controls.Add(grpMonsterDetails);
            tabMonsters.Location = new Point(4, 24);
            tabMonsters.Name = "tabMonsters";
            tabMonsters.Padding = new Padding(3);
            tabMonsters.Size = new Size(517, 464);
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
            grpAbilities.Size = new Size(508, 178);
            grpAbilities.TabIndex = 2;
            grpAbilities.TabStop = false;
            grpAbilities.Text = "Abilities";
            grpAbilities.Enter += grpAbilities_Enter;
            // 
            // lblAbilityType
            // 
            lblAbilityType.AutoSize = true;
            lblAbilityType.BorderStyle = BorderStyle.Fixed3D;
            lblAbilityType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAbilityType.Location = new Point(204, 141);
            lblAbilityType.Name = "lblAbilityType";
            lblAbilityType.Size = new Size(2, 23);
            lblAbilityType.TabIndex = 14;
            // 
            // lblAbilityCost
            // 
            lblAbilityCost.AutoSize = true;
            lblAbilityCost.BorderStyle = BorderStyle.Fixed3D;
            lblAbilityCost.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAbilityCost.Location = new Point(204, 76);
            lblAbilityCost.Name = "lblAbilityCost";
            lblAbilityCost.Size = new Size(2, 23);
            lblAbilityCost.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(155, 142);
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
            lstAbilities.Size = new Size(143, 154);
            lstAbilities.TabIndex = 1;
            lstAbilities.SelectedIndexChanged += lstAbilities_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(155, 79);
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
            rtbAbilityDesc.Size = new Size(202, 154);
            rtbAbilityDesc.TabIndex = 0;
            rtbAbilityDesc.Text = "Hello\nHello\nHelloHello\n\nHello\nHello\nHello\nHello\nHello\nHello\nHello\nHello\nHello";
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
            grpMonsterDetails.Enter += grpMonsterDetails_Enter;
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
            rtbDescArea.Size = new Size(306, 139);
            rtbDescArea.TabIndex = 8;
            rtbDescArea.Text = "";
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
            tabCreate.Location = new Point(4, 24);
            tabCreate.Name = "tabCreate";
            tabCreate.Padding = new Padding(3);
            tabCreate.Size = new Size(517, 464);
            tabCreate.TabIndex = 1;
            tabCreate.Text = "Create Monster";
            tabCreate.UseVisualStyleBackColor = true;
            // 
            // lblMessenger
            // 
            lblMessenger.BorderStyle = BorderStyle.Fixed3D;
            lblMessenger.FlatStyle = FlatStyle.Popup;
            lblMessenger.Location = new Point(12, 495);
            lblMessenger.Name = "lblMessenger";
            lblMessenger.Size = new Size(772, 17);
            lblMessenger.TabIndex = 1;
            lblMessenger.Text = "uh";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 521);
            Controls.Add(lblMessenger);
            Controls.Add(tabDisplay);
            Controls.Add(grpMonsterList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpMonsterList.ResumeLayout(false);
            tabDisplay.ResumeLayout(false);
            tabMonsters.ResumeLayout(false);
            grpAbilities.ResumeLayout(false);
            grpAbilities.PerformLayout();
            grpMonsterDetails.ResumeLayout(false);
            grpMonsterDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMonsterList;
        private TabControl tabDisplay;
        private TabPage tabMonsters;
        private TabPage tabCreate;
        private ListBox lstMonsters;
        private Label lblMessenger;
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
    }
}
