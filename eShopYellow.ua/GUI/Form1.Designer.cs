namespace eShopYellow.ua
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pBoxImage = new System.Windows.Forms.PictureBox();
            this.lbId = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.lbDes = new System.Windows.Forms.Label();
            this.txtBoxDes = new System.Windows.Forms.TextBox();
            this.butBrouse = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.butFind = new System.Windows.Forms.Button();
            this.txtBoxFind = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(944, 561);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtBoxFind);
            this.tabPage2.Controls.Add(this.butFind);
            this.tabPage2.Controls.Add(this.butSave);
            this.tabPage2.Controls.Add(this.butDelete);
            this.tabPage2.Controls.Add(this.butCancel);
            this.tabPage2.Controls.Add(this.butEdit);
            this.tabPage2.Controls.Add(this.butAdd);
            this.tabPage2.Controls.Add(this.butBrouse);
            this.tabPage2.Controls.Add(this.txtBoxDes);
            this.tabPage2.Controls.Add(this.lbDes);
            this.tabPage2.Controls.Add(this.txtBoxPrice);
            this.tabPage2.Controls.Add(this.lbPrice);
            this.tabPage2.Controls.Add(this.txtBoxName);
            this.tabPage2.Controls.Add(this.lbName);
            this.tabPage2.Controls.Add(this.txtBoxId);
            this.tabPage2.Controls.Add(this.lbId);
            this.tabPage2.Controls.Add(this.pBoxImage);
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(24, 57);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(483, 420);
            this.dataGridView.TabIndex = 0;
            // 
            // pBoxImage
            // 
            this.pBoxImage.Location = new System.Drawing.Point(540, 29);
            this.pBoxImage.Name = "pBoxImage";
            this.pBoxImage.Size = new System.Drawing.Size(125, 190);
            this.pBoxImage.TabIndex = 1;
            this.pBoxImage.TabStop = false;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(687, 29);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(21, 13);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "ID:";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(750, 29);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxId.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(690, 82);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Name:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(750, 74);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(161, 76);
            this.txtBoxName.TabIndex = 5;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(690, 174);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "Price";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(750, 174);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrice.TabIndex = 7;
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Location = new System.Drawing.Point(580, 274);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(63, 13);
            this.lbDes.TabIndex = 8;
            this.lbDes.Text = "Description:";
            // 
            // txtBoxDes
            // 
            this.txtBoxDes.Location = new System.Drawing.Point(663, 262);
            this.txtBoxDes.Multiline = true;
            this.txtBoxDes.Name = "txtBoxDes";
            this.txtBoxDes.Size = new System.Drawing.Size(248, 237);
            this.txtBoxDes.TabIndex = 9;
            // 
            // butBrouse
            // 
            this.butBrouse.Location = new System.Drawing.Point(568, 225);
            this.butBrouse.Name = "butBrouse";
            this.butBrouse.Size = new System.Drawing.Size(75, 23);
            this.butBrouse.TabIndex = 10;
            this.butBrouse.Text = "Brouse";
            this.butBrouse.UseVisualStyleBackColor = true;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(24, 492);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 11;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(126, 493);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(75, 23);
            this.butEdit.TabIndex = 12;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(228, 493);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 13;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(330, 492);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 14;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(432, 491);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 15;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            // 
            // butFind
            // 
            this.butFind.Location = new System.Drawing.Point(24, 19);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(75, 23);
            this.butFind.TabIndex = 16;
            this.butFind.Text = "Find";
            this.butFind.UseVisualStyleBackColor = true;
            // 
            // txtBoxFind
            // 
            this.txtBoxFind.Location = new System.Drawing.Point(126, 19);
            this.txtBoxFind.Name = "txtBoxFind";
            this.txtBoxFind.Size = new System.Drawing.Size(381, 20);
            this.txtBoxFind.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtBoxFind;
        private System.Windows.Forms.Button butFind;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butBrouse;
        private System.Windows.Forms.TextBox txtBoxDes;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.PictureBox pBoxImage;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

