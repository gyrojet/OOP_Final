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
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            richTextBox1 = new RichTextBox();
            grpMonsterDetails = new GroupBox();
            tabCreate = new TabPage();
            lblMessenger = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblNameTitle = new Label();
            lblName = new Label();
            lblLevel = new Label();
            label3 = new Label();
            lblAC = new Label();
            label5 = new Label();
            lbl = new Label();
            label7 = new Label();
            rtbDescArea = new RichTextBox();
            label8 = new Label();
            label9 = new Label();
            lblDesc = new Label();
            grpCombat = new GroupBox();
            grpMonsterList.SuspendLayout();
            tabDisplay.SuspendLayout();
            tabMonsters.SuspendLayout();
            groupBox1.SuspendLayout();
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
            lstMonsters.FormattingEnabled = true;
            lstMonsters.ItemHeight = 15;
            lstMonsters.Location = new Point(6, 17);
            lstMonsters.Name = "lstMonsters";
            lstMonsters.Size = new Size(273, 469);
            lstMonsters.TabIndex = 0;
            // 
            // tabDisplay
            // 
            tabDisplay.Controls.Add(tabMonsters);
            tabDisplay.Controls.Add(tabCreate);
            tabDisplay.Location = new Point(295, 0);
            tabDisplay.Name = "tabDisplay";
            tabDisplay.SelectedIndex = 0;
            tabDisplay.Size = new Size(493, 492);
            tabDisplay.TabIndex = 0;
            // 
            // tabMonsters
            // 
            tabMonsters.Controls.Add(groupBox1);
            tabMonsters.Controls.Add(grpMonsterDetails);
            tabMonsters.Location = new Point(4, 24);
            tabMonsters.Name = "tabMonsters";
            tabMonsters.Padding = new Padding(3);
            tabMonsters.Size = new Size(485, 464);
            tabMonsters.TabIndex = 0;
            tabMonsters.Text = "Monster Details";
            tabMonsters.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(3, 280);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 178);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Abilities";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 14);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 154);
            listBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(212, 14);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(255, 154);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Hello\nHello\nHelloHello\n\nHello\nHello\nHello\nHello\nHello\nHello\nHello\nHello\nHello";
            // 
            // grpMonsterDetails
            // 
            grpMonsterDetails.Controls.Add(grpCombat);
            grpMonsterDetails.Controls.Add(lblDesc);
            grpMonsterDetails.Controls.Add(label8);
            grpMonsterDetails.Controls.Add(label9);
            grpMonsterDetails.Controls.Add(rtbDescArea);
            grpMonsterDetails.Controls.Add(lbl);
            grpMonsterDetails.Controls.Add(label7);
            grpMonsterDetails.Controls.Add(lblAC);
            grpMonsterDetails.Controls.Add(label5);
            grpMonsterDetails.Controls.Add(lblLevel);
            grpMonsterDetails.Controls.Add(label3);
            grpMonsterDetails.Controls.Add(lblName);
            grpMonsterDetails.Controls.Add(lblNameTitle);
            grpMonsterDetails.Location = new Point(3, 0);
            grpMonsterDetails.Name = "grpMonsterDetails";
            grpMonsterDetails.Size = new Size(473, 274);
            grpMonsterDetails.TabIndex = 1;
            grpMonsterDetails.TabStop = false;
            grpMonsterDetails.Text = "Details";
            grpMonsterDetails.Enter += grpMonsterDetails_Enter;
            // 
            // tabCreate
            // 
            tabCreate.Location = new Point(4, 24);
            tabCreate.Name = "tabCreate";
            tabCreate.Padding = new Padding(3);
            tabCreate.Size = new Size(485, 464);
            tabCreate.TabIndex = 1;
            tabCreate.Text = "Create Monster";
            tabCreate.UseVisualStyleBackColor = true;
            // 
            // lblMessenger
            // 
            lblMessenger.AutoSize = true;
            lblMessenger.BorderStyle = BorderStyle.Fixed3D;
            lblMessenger.FlatStyle = FlatStyle.Popup;
            lblMessenger.Location = new Point(12, 495);
            lblMessenger.Name = "lblMessenger";
            lblMessenger.Size = new Size(23, 17);
            lblMessenger.TabIndex = 1;
            lblMessenger.Text = "uh";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
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
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BorderStyle = BorderStyle.Fixed3D;
            lblName.Location = new Point(60, 24);
            lblName.Name = "lblName";
            lblName.Size = new Size(2, 17);
            lblName.TabIndex = 1;
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
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BorderStyle = BorderStyle.Fixed3D;
            lbl.Location = new Point(60, 119);
            lbl.Name = "lbl";
            lbl.Size = new Size(2, 17);
            lbl.TabIndex = 7;
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
            // rtbDescArea
            // 
            rtbDescArea.Location = new Point(196, 24);
            rtbDescArea.Name = "rtbDescArea";
            rtbDescArea.Size = new Size(262, 139);
            rtbDescArea.TabIndex = 8;
            rtbDescArea.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(60, 146);
            label8.Name = "label8";
            label8.Size = new Size(2, 17);
            label8.TabIndex = 10;
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
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(196, 6);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(67, 15);
            lblDesc.TabIndex = 11;
            lblDesc.Text = "Description";
            // 
            // grpCombat
            // 
            grpCombat.Location = new Point(6, 169);
            grpCombat.Name = "grpCombat";
            grpCombat.Size = new Size(452, 100);
            grpCombat.TabIndex = 12;
            grpCombat.TabStop = false;
            grpCombat.Text = "Combat";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(lblMessenger);
            Controls.Add(tabDisplay);
            Controls.Add(grpMonsterList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpMonsterList.ResumeLayout(false);
            tabDisplay.ResumeLayout(false);
            tabMonsters.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            grpMonsterDetails.ResumeLayout(false);
            grpMonsterDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpMonsterList;
        private TabControl tabDisplay;
        private TabPage tabMonsters;
        private TabPage tabCreate;
        private ListBox lstMonsters;
        private Label lblMessenger;
        private GroupBox groupBox1;
        private GroupBox grpMonsterDetails;
        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Label lbl;
        private Label label7;
        private Label lblAC;
        private Label label5;
        private Label lblLevel;
        private Label label3;
        private Label lblName;
        private Label lblNameTitle;
        private Label label8;
        private Label label9;
        private RichTextBox rtbDescArea;
        private Label lblDesc;
        private GroupBox grpCombat;
    }
}
