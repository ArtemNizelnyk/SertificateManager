namespace SertificateManager.PL
{
    partial class HomeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.друкуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sertificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.idTB = new System.Windows.Forms.TextBox();
            this.EstTimeTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.TagTB = new System.Windows.Forms.TextBox();
            this.ItemsTB = new System.Windows.Forms.TextBox();
            this.CreatorTB = new System.Windows.Forms.TextBox();
            this.OwnerTB = new System.Windows.Forms.TextBox();
            this.ValidatorTB = new System.Windows.Forms.TextBox();
            this.ValidTimeTB = new System.Windows.Forms.TextBox();
            this.DocTB = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.estTimeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tagLabel = new System.Windows.Forms.Label();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.CreatorLabel = new System.Windows.Forms.Label();
            this.ValidatorLabel = new System.Windows.Forms.Label();
            this.ValidTimeLabel = new System.Windows.Forms.Label();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.DocLabel = new System.Windows.Forms.Label();
            this.changeBtn = new System.Windows.Forms.Button();
            this.printBTN = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sertificateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.getAllToolStripMenuItem,
            this.findToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.newToolStripMenuItem.Text = "Новий";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // getAllToolStripMenuItem
            // 
            this.getAllToolStripMenuItem.Name = "getAllToolStripMenuItem";
            this.getAllToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.getAllToolStripMenuItem.Text = "Всі сертифікати";
            this.getAllToolStripMenuItem.Click += new System.EventHandler(this.getAllToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редагуватиToolStripMenuItem,
            this.видалитиToolStripMenuItem,
            this.друкуватиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 70);
            // 
            // редагуватиToolStripMenuItem
            // 
            this.редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            this.редагуватиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.редагуватиToolStripMenuItem.Text = "Редагувати";
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            // 
            // друкуватиToolStripMenuItem
            // 
            this.друкуватиToolStripMenuItem.Name = "друкуватиToolStripMenuItem";
            this.друкуватиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.друкуватиToolStripMenuItem.Text = "Оновити";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.findToolStripMenuItem.Text = "Пошук";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleteBtn);
            this.tabPage3.Controls.Add(this.printBTN);
            this.tabPage3.Controls.Add(this.changeBtn);
            this.tabPage3.Controls.Add(this.DocLabel);
            this.tabPage3.Controls.Add(this.OwnerLabel);
            this.tabPage3.Controls.Add(this.ValidTimeLabel);
            this.tabPage3.Controls.Add(this.ValidatorLabel);
            this.tabPage3.Controls.Add(this.CreatorLabel);
            this.tabPage3.Controls.Add(this.itemsLabel);
            this.tabPage3.Controls.Add(this.tagLabel);
            this.tabPage3.Controls.Add(this.nameLabel);
            this.tabPage3.Controls.Add(this.estTimeLabel);
            this.tabPage3.Controls.Add(this.idLabel);
            this.tabPage3.Controls.Add(this.DocTB);
            this.tabPage3.Controls.Add(this.ValidTimeTB);
            this.tabPage3.Controls.Add(this.ValidatorTB);
            this.tabPage3.Controls.Add(this.OwnerTB);
            this.tabPage3.Controls.Add(this.CreatorTB);
            this.tabPage3.Controls.Add(this.ItemsTB);
            this.tabPage3.Controls.Add(this.TagTB);
            this.tabPage3.Controls.Add(this.NameTB);
            this.tabPage3.Controls.Add(this.EstTimeTB);
            this.tabPage3.Controls.Add(this.idTB);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(823, 316);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Результат";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(148, 31);
            this.idTB.Name = "idTB";
            this.idTB.ReadOnly = true;
            this.idTB.Size = new System.Drawing.Size(283, 20);
            this.idTB.TabIndex = 0;
            // 
            // EstTimeTB
            // 
            this.EstTimeTB.Location = new System.Drawing.Point(148, 57);
            this.EstTimeTB.Name = "EstTimeTB";
            this.EstTimeTB.ReadOnly = true;
            this.EstTimeTB.Size = new System.Drawing.Size(283, 20);
            this.EstTimeTB.TabIndex = 1;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(148, 83);
            this.NameTB.Name = "NameTB";
            this.NameTB.ReadOnly = true;
            this.NameTB.Size = new System.Drawing.Size(283, 20);
            this.NameTB.TabIndex = 2;
            // 
            // TagTB
            // 
            this.TagTB.Location = new System.Drawing.Point(148, 109);
            this.TagTB.Name = "TagTB";
            this.TagTB.ReadOnly = true;
            this.TagTB.Size = new System.Drawing.Size(283, 20);
            this.TagTB.TabIndex = 3;
            // 
            // ItemsTB
            // 
            this.ItemsTB.Location = new System.Drawing.Point(557, 28);
            this.ItemsTB.Multiline = true;
            this.ItemsTB.Name = "ItemsTB";
            this.ItemsTB.ReadOnly = true;
            this.ItemsTB.Size = new System.Drawing.Size(258, 94);
            this.ItemsTB.TabIndex = 4;
            // 
            // CreatorTB
            // 
            this.CreatorTB.Location = new System.Drawing.Point(148, 161);
            this.CreatorTB.Name = "CreatorTB";
            this.CreatorTB.ReadOnly = true;
            this.CreatorTB.Size = new System.Drawing.Size(283, 20);
            this.CreatorTB.TabIndex = 5;
            // 
            // OwnerTB
            // 
            this.OwnerTB.Location = new System.Drawing.Point(148, 187);
            this.OwnerTB.Name = "OwnerTB";
            this.OwnerTB.ReadOnly = true;
            this.OwnerTB.Size = new System.Drawing.Size(283, 20);
            this.OwnerTB.TabIndex = 6;
            // 
            // ValidatorTB
            // 
            this.ValidatorTB.Location = new System.Drawing.Point(566, 161);
            this.ValidatorTB.Name = "ValidatorTB";
            this.ValidatorTB.ReadOnly = true;
            this.ValidatorTB.Size = new System.Drawing.Size(249, 20);
            this.ValidatorTB.TabIndex = 5;
            // 
            // ValidTimeTB
            // 
            this.ValidTimeTB.Location = new System.Drawing.Point(566, 187);
            this.ValidTimeTB.Name = "ValidTimeTB";
            this.ValidTimeTB.ReadOnly = true;
            this.ValidTimeTB.Size = new System.Drawing.Size(249, 20);
            this.ValidTimeTB.TabIndex = 5;
            // 
            // DocTB
            // 
            this.DocTB.Location = new System.Drawing.Point(148, 246);
            this.DocTB.Name = "DocTB";
            this.DocTB.ReadOnly = true;
            this.DocTB.Size = new System.Drawing.Size(283, 20);
            this.DocTB.TabIndex = 7;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(33, 31);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(71, 13);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "№ Свідоцтва";
            // 
            // estTimeLabel
            // 
            this.estTimeLabel.AutoSize = true;
            this.estTimeLabel.Location = new System.Drawing.Point(33, 57);
            this.estTimeLabel.Name = "estTimeLabel";
            this.estTimeLabel.Size = new System.Drawing.Size(57, 13);
            this.estTimeLabel.TabIndex = 9;
            this.estTimeLabel.Text = "Чинне до:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(33, 83);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Назва";
            // 
            // tagLabel
            // 
            this.tagLabel.AutoSize = true;
            this.tagLabel.Location = new System.Drawing.Point(33, 109);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(109, 13);
            this.tagLabel.TabIndex = 9;
            this.tagLabel.Text = "Умовне позначення";
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Location = new System.Drawing.Point(447, 31);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(104, 13);
            this.itemsLabel.TabIndex = 8;
            this.itemsLabel.Text = "Склад(через кому):";
            // 
            // CreatorLabel
            // 
            this.CreatorLabel.AutoSize = true;
            this.CreatorLabel.Location = new System.Drawing.Point(33, 161);
            this.CreatorLabel.Name = "CreatorLabel";
            this.CreatorLabel.Size = new System.Drawing.Size(56, 13);
            this.CreatorLabel.TabIndex = 9;
            this.CreatorLabel.Text = "Виробник";
            // 
            // ValidatorLabel
            // 
            this.ValidatorLabel.AutoSize = true;
            this.ValidatorLabel.Location = new System.Drawing.Point(447, 164);
            this.ValidatorLabel.Name = "ValidatorLabel";
            this.ValidatorLabel.Size = new System.Drawing.Size(113, 13);
            this.ValidatorLabel.TabIndex = 9;
            this.ValidatorLabel.Text = "Державний повірник";
            // 
            // ValidTimeLabel
            // 
            this.ValidTimeLabel.AutoSize = true;
            this.ValidTimeLabel.Location = new System.Drawing.Point(447, 190);
            this.ValidTimeLabel.Name = "ValidTimeLabel";
            this.ValidTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.ValidTimeLabel.TabIndex = 9;
            this.ValidTimeLabel.Text = "Дата повірки";
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.Location = new System.Drawing.Point(33, 187);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(50, 13);
            this.OwnerLabel.TabIndex = 8;
            this.OwnerLabel.Text = "Власник";
            // 
            // DocLabel
            // 
            this.DocLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DocLabel.Location = new System.Drawing.Point(33, 206);
            this.DocLabel.Name = "DocLabel";
            this.DocLabel.Size = new System.Drawing.Size(96, 99);
            this.DocLabel.TabIndex = 9;
            this.DocLabel.Text = "Назва документу, що містить метрологічні вимоги щодо характеристик";
            this.DocLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(450, 268);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 23);
            this.changeBtn.TabIndex = 10;
            this.changeBtn.Text = "Змінити";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // printBTN
            // 
            this.printBTN.Location = new System.Drawing.Point(598, 268);
            this.printBTN.Name = "printBTN";
            this.printBTN.Size = new System.Drawing.Size(75, 23);
            this.printBTN.TabIndex = 10;
            this.printBTN.Text = "Друкувати";
            this.printBTN.UseVisualStyleBackColor = true;
            this.printBTN.Click += new System.EventHandler(this.printBTN_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(740, 268);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Видалити";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(823, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "База";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(817, 310);
            this.dataGridView.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(823, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Справка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 342);
            this.tabControl1.TabIndex = 3;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 364);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "SertificateManager";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sertificateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource sertificateBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAllToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem друкуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button printBTN;
        private System.Windows.Forms.Button changeBtn;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;

    }
}

