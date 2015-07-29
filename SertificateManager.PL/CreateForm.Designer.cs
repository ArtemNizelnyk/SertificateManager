namespace SertificateManager.PL
{
    partial class CreateForm
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
            this.DocLabel = new System.Windows.Forms.Label();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.ValidTimeLabel = new System.Windows.Forms.Label();
            this.ValidatorLabel = new System.Windows.Forms.Label();
            this.CreatorLabel = new System.Windows.Forms.Label();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.tagLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.estTimeLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.DocTB = new System.Windows.Forms.TextBox();
            this.ValidTimeTB = new System.Windows.Forms.TextBox();
            this.ValidatorTB = new System.Windows.Forms.TextBox();
            this.OwnerTB = new System.Windows.Forms.TextBox();
            this.CreatorTB = new System.Windows.Forms.TextBox();
            this.ItemsTB = new System.Windows.Forms.TextBox();
            this.TagTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.EstTimeTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DocLabel
            // 
            this.DocLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DocLabel.Location = new System.Drawing.Point(25, 195);
            this.DocLabel.Name = "DocLabel";
            this.DocLabel.Size = new System.Drawing.Size(96, 99);
            this.DocLabel.TabIndex = 29;
            this.DocLabel.Text = "Назва документу, що містить метрологічні вимоги щодо характеристик";
            this.DocLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.Location = new System.Drawing.Point(25, 176);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(50, 13);
            this.OwnerLabel.TabIndex = 23;
            this.OwnerLabel.Text = "Власник";
            // 
            // ValidTimeLabel
            // 
            this.ValidTimeLabel.AutoSize = true;
            this.ValidTimeLabel.Location = new System.Drawing.Point(439, 179);
            this.ValidTimeLabel.Name = "ValidTimeLabel";
            this.ValidTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.ValidTimeLabel.TabIndex = 27;
            this.ValidTimeLabel.Text = "Дата повірки";
            // 
            // ValidatorLabel
            // 
            this.ValidatorLabel.AutoSize = true;
            this.ValidatorLabel.Location = new System.Drawing.Point(439, 153);
            this.ValidatorLabel.Name = "ValidatorLabel";
            this.ValidatorLabel.Size = new System.Drawing.Size(113, 13);
            this.ValidatorLabel.TabIndex = 26;
            this.ValidatorLabel.Text = "Державний повірник";
            // 
            // CreatorLabel
            // 
            this.CreatorLabel.AutoSize = true;
            this.CreatorLabel.Location = new System.Drawing.Point(25, 150);
            this.CreatorLabel.Name = "CreatorLabel";
            this.CreatorLabel.Size = new System.Drawing.Size(56, 13);
            this.CreatorLabel.TabIndex = 25;
            this.CreatorLabel.Text = "Виробник";
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Location = new System.Drawing.Point(439, 20);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(104, 13);
            this.itemsLabel.TabIndex = 22;
            this.itemsLabel.Text = "Склад(через кому):";
            // 
            // tagLabel
            // 
            this.tagLabel.AutoSize = true;
            this.tagLabel.Location = new System.Drawing.Point(25, 98);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(109, 13);
            this.tagLabel.TabIndex = 24;
            this.tagLabel.Text = "Умовне позначення";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(25, 72);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 13);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Назва";
            // 
            // estTimeLabel
            // 
            this.estTimeLabel.AutoSize = true;
            this.estTimeLabel.Location = new System.Drawing.Point(25, 46);
            this.estTimeLabel.Name = "estTimeLabel";
            this.estTimeLabel.Size = new System.Drawing.Size(57, 13);
            this.estTimeLabel.TabIndex = 28;
            this.estTimeLabel.Text = "Чинне до:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(25, 20);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(71, 13);
            this.idLabel.TabIndex = 20;
            this.idLabel.Text = "№ Свідоцтва";
            // 
            // DocTB
            // 
            this.DocTB.Location = new System.Drawing.Point(140, 235);
            this.DocTB.Name = "DocTB";
            this.DocTB.Size = new System.Drawing.Size(283, 20);
            this.DocTB.TabIndex = 19;
            // 
            // ValidTimeTB
            // 
            this.ValidTimeTB.Location = new System.Drawing.Point(558, 176);
            this.ValidTimeTB.Name = "ValidTimeTB";
            this.ValidTimeTB.Size = new System.Drawing.Size(249, 20);
            this.ValidTimeTB.TabIndex = 17;
            // 
            // ValidatorTB
            // 
            this.ValidatorTB.Location = new System.Drawing.Point(558, 150);
            this.ValidatorTB.Name = "ValidatorTB";
            this.ValidatorTB.Size = new System.Drawing.Size(249, 20);
            this.ValidatorTB.TabIndex = 16;
            // 
            // OwnerTB
            // 
            this.OwnerTB.Location = new System.Drawing.Point(140, 176);
            this.OwnerTB.Name = "OwnerTB";
            this.OwnerTB.Size = new System.Drawing.Size(283, 20);
            this.OwnerTB.TabIndex = 18;
            // 
            // CreatorTB
            // 
            this.CreatorTB.Location = new System.Drawing.Point(140, 150);
            this.CreatorTB.Name = "CreatorTB";
            this.CreatorTB.Size = new System.Drawing.Size(283, 20);
            this.CreatorTB.TabIndex = 15;
            // 
            // ItemsTB
            // 
            this.ItemsTB.Location = new System.Drawing.Point(549, 17);
            this.ItemsTB.Multiline = true;
            this.ItemsTB.Name = "ItemsTB";
            this.ItemsTB.Size = new System.Drawing.Size(258, 94);
            this.ItemsTB.TabIndex = 14;
            // 
            // TagTB
            // 
            this.TagTB.Location = new System.Drawing.Point(140, 98);
            this.TagTB.Name = "TagTB";
            this.TagTB.Size = new System.Drawing.Size(283, 20);
            this.TagTB.TabIndex = 13;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(140, 72);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(283, 20);
            this.NameTB.TabIndex = 12;
            // 
            // EstTimeTB
            // 
            this.EstTimeTB.Location = new System.Drawing.Point(140, 46);
            this.EstTimeTB.Name = "EstTimeTB";
            this.EstTimeTB.Size = new System.Drawing.Size(283, 20);
            this.EstTimeTB.TabIndex = 11;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(140, 20);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(283, 20);
            this.idTB.TabIndex = 10;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(231, 315);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 30;
            this.createBtn.Text = "Створити";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(558, 315);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 30;
            this.cancelBtn.Text = "Відмінити";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 350);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.DocLabel);
            this.Controls.Add(this.OwnerLabel);
            this.Controls.Add(this.ValidTimeLabel);
            this.Controls.Add(this.ValidatorLabel);
            this.Controls.Add(this.CreatorLabel);
            this.Controls.Add(this.itemsLabel);
            this.Controls.Add(this.tagLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.estTimeLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.DocTB);
            this.Controls.Add(this.ValidTimeTB);
            this.Controls.Add(this.ValidatorTB);
            this.Controls.Add(this.OwnerTB);
            this.Controls.Add(this.CreatorTB);
            this.Controls.Add(this.ItemsTB);
            this.Controls.Add(this.TagTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.EstTimeTB);
            this.Controls.Add(this.idTB);
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DocLabel;
        private System.Windows.Forms.Label OwnerLabel;
        private System.Windows.Forms.Label ValidTimeLabel;
        private System.Windows.Forms.Label ValidatorLabel;
        private System.Windows.Forms.Label CreatorLabel;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.Label tagLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label estTimeLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox DocTB;
        private System.Windows.Forms.TextBox ValidTimeTB;
        private System.Windows.Forms.TextBox ValidatorTB;
        private System.Windows.Forms.TextBox OwnerTB;
        private System.Windows.Forms.TextBox CreatorTB;
        private System.Windows.Forms.TextBox ItemsTB;
        private System.Windows.Forms.TextBox TagTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox EstTimeTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}