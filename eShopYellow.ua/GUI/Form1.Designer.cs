﻿namespace eShopYellow.ua
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
            this.components = new System.ComponentModel.Container();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbGrn = new System.Windows.Forms.Label();
            this.txtBoxFind = new System.Windows.Forms.TextBox();
            this.txtBoxDes = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butBrouse = new System.Windows.Forms.Button();
            this.lbDes = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.pBoxImage = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ImageUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.productInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.lbSearch);
            this.tabPage2.Controls.Add(this.lbGrn);
            this.tabPage2.Controls.Add(this.txtBoxFind);
            this.tabPage2.Controls.Add(this.txtBoxDes);
            this.tabPage2.Controls.Add(this.txtBoxPrice);
            this.tabPage2.Controls.Add(this.txtBoxName);
            this.tabPage2.Controls.Add(this.txtBoxId);
            this.tabPage2.Controls.Add(this.butSave);
            this.tabPage2.Controls.Add(this.butDelete);
            this.tabPage2.Controls.Add(this.butCancel);
            this.tabPage2.Controls.Add(this.butEdit);
            this.tabPage2.Controls.Add(this.butAdd);
            this.tabPage2.Controls.Add(this.butBrouse);
            this.tabPage2.Controls.Add(this.lbDes);
            this.tabPage2.Controls.Add(this.lbPrice);
            this.tabPage2.Controls.Add(this.lbName);
            this.tabPage2.Controls.Add(this.lbId);
            this.tabPage2.Controls.Add(this.pBoxImage);
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CRUD";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(167, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Product Card";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(42, 22);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(41, 13);
            this.lbSearch.TabIndex = 19;
            this.lbSearch.Text = "Search";
            // 
            // lbGrn
            // 
            this.lbGrn.AutoSize = true;
            this.lbGrn.Location = new System.Drawing.Point(876, 177);
            this.lbGrn.Name = "lbGrn";
            this.lbGrn.Size = new System.Drawing.Size(22, 13);
            this.lbGrn.TabIndex = 18;
            this.lbGrn.Text = "grn";
            // 
            // txtBoxFind
            // 
            this.txtBoxFind.Location = new System.Drawing.Point(126, 19);
            this.txtBoxFind.Name = "txtBoxFind";
            this.txtBoxFind.Size = new System.Drawing.Size(381, 20);
            this.txtBoxFind.TabIndex = 17;
            this.txtBoxFind.TextChanged += new System.EventHandler(this.txtBoxFind_TextChanged);
            // 
            // txtBoxDes
            // 
            this.txtBoxDes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Description", true));
            this.txtBoxDes.Location = new System.Drawing.Point(663, 262);
            this.txtBoxDes.Multiline = true;
            this.txtBoxDes.Name = "txtBoxDes";
            this.txtBoxDes.Size = new System.Drawing.Size(248, 173);
            this.txtBoxDes.TabIndex = 9;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Price", true));
            this.txtBoxPrice.Location = new System.Drawing.Point(750, 174);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrice.TabIndex = 7;
            // 
            // txtBoxName
            // 
            this.txtBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Name", true));
            this.txtBoxName.Location = new System.Drawing.Point(750, 74);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(161, 76);
            this.txtBoxName.TabIndex = 5;
            // 
            // txtBoxId
            // 
            this.txtBoxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Id", true));
            this.txtBoxId.Location = new System.Drawing.Point(750, 29);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxId.TabIndex = 3;
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(434, 412);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 15;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(332, 413);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 14;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(230, 414);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 13;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(128, 414);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(75, 23);
            this.butEdit.TabIndex = 12;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.OrangeRed;
            this.butAdd.Location = new System.Drawing.Point(26, 413);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 11;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butBrouse
            // 
            this.butBrouse.Location = new System.Drawing.Point(568, 225);
            this.butBrouse.Name = "butBrouse";
            this.butBrouse.Size = new System.Drawing.Size(75, 23);
            this.butBrouse.TabIndex = 10;
            this.butBrouse.Text = "Brouse";
            this.butBrouse.UseVisualStyleBackColor = true;
            this.butBrouse.Click += new System.EventHandler(this.butBrouse_Click);
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
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(690, 174);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "Price";
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
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(687, 29);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(21, 13);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "ID:";
            // 
            // pBoxImage
            // 
            this.pBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxImage.Location = new System.Drawing.Point(540, 57);
            this.pBoxImage.Name = "pBoxImage";
            this.pBoxImage.Size = new System.Drawing.Size(125, 162);
            this.pBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxImage.TabIndex = 1;
            this.pBoxImage.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.ImageUrl});
            this.dataGridView.DataSource = this.productInfoBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(24, 57);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.Size = new System.Drawing.Size(483, 305);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // ImageUrl
            // 
            this.ImageUrl.DataPropertyName = "ImageUrl";
            this.ImageUrl.HeaderText = "ImageUrl";
            this.ImageUrl.Name = "ImageUrl";
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(944, 561);
            this.tabControl.TabIndex = 0;
            // 
            // productInfoBindingSource
            // 
            this.productInfoBindingSource.DataSource = typeof(eShopYellow.ua.ProductInfo);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
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
            this.Text = "eShop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource productInfoBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbGrn;
        private System.Windows.Forms.TextBox txtBoxFind;
        private System.Windows.Forms.TextBox txtBoxDes;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butBrouse;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.PictureBox pBoxImage;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageUrl;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button button1;
    }
}

