namespace prototype_BM102
{
    partial class FormProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPencil = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.imagecontrolAdd = new prototype_BM102.imagecontrol();
            this.panelDrag1 = new prototype_BM102.panelDrag();
            this.imagecontrolReturn = new prototype_BM102.imagecontrol();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolAdd)).BeginInit();
            this.panelDrag1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvName,
            this.dgvQty,
            this.dgvPrice,
            this.dgvCategory,
            this.dgvPencil,
            this.dgvDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvProducts.Location = new System.Drawing.Point(0, 69);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1000, 428);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // dgvID
            // 
            this.dgvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvID.DataPropertyName = "Ürün Kodu";
            this.dgvID.HeaderText = "Ürün Kodu";
            this.dgvID.MinimumWidth = 6;
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Width = 105;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.DataPropertyName = "İsim";
            this.dgvName.HeaderText = "İsim";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvQty.DataPropertyName = "Miktar";
            this.dgvQty.HeaderText = "Miktar";
            this.dgvQty.MinimumWidth = 6;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 75;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvPrice.DataPropertyName = "Fiyat";
            this.dgvPrice.HeaderText = "Fiyat";
            this.dgvPrice.MinimumWidth = 6;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 67;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvCategory.DataPropertyName = "Kategori";
            this.dgvCategory.HeaderText = "Kategori";
            this.dgvCategory.MinimumWidth = 6;
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.Width = 90;
            // 
            // dgvPencil
            // 
            this.dgvPencil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvPencil.HeaderText = "";
            this.dgvPencil.Image = global::prototype_BM102.Properties.Resources._00Pen;
            this.dgvPencil.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvPencil.MinimumWidth = 6;
            this.dgvPencil.Name = "dgvPencil";
            this.dgvPencil.ReadOnly = true;
            this.dgvPencil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPencil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvPencil.Width = 23;
            // 
            // dgvDelete
            // 
            this.dgvDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvDelete.HeaderText = "";
            this.dgvDelete.Image = global::prototype_BM102.Properties.Resources._000delete;
            this.dgvDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDelete.MinimumWidth = 6;
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.ReadOnly = true;
            this.dgvDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvDelete.Width = 23;
            // 
            // imagecontrolAdd
            // 
            this.imagecontrolAdd.BackColor = System.Drawing.Color.Transparent;
            this.imagecontrolAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagecontrolAdd.Image = global::prototype_BM102.Properties.Resources.add1;
            this.imagecontrolAdd.ImageHover = global::prototype_BM102.Properties.Resources.add_hover;
            this.imagecontrolAdd.ImageNormal = global::prototype_BM102.Properties.Resources.add1;
            this.imagecontrolAdd.Location = new System.Drawing.Point(940, 501);
            this.imagecontrolAdd.Margin = new System.Windows.Forms.Padding(2);
            this.imagecontrolAdd.Name = "imagecontrolAdd";
            this.imagecontrolAdd.Size = new System.Drawing.Size(50, 50);
            this.imagecontrolAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagecontrolAdd.TabIndex = 3;
            this.imagecontrolAdd.TabStop = false;
            this.imagecontrolAdd.Click += new System.EventHandler(this.imagecontrolAdd_Click);
            // 
            // panelDrag1
            // 
            this.panelDrag1.BackColor = System.Drawing.Color.Transparent;
            this.panelDrag1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrag1.Controls.Add(this.imagecontrolReturn);
            this.panelDrag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrag1.Location = new System.Drawing.Point(0, 0);
            this.panelDrag1.Margin = new System.Windows.Forms.Padding(2);
            this.panelDrag1.Name = "panelDrag1";
            this.panelDrag1.Size = new System.Drawing.Size(1000, 70);
            this.panelDrag1.TabIndex = 0;
            // 
            // imagecontrolReturn
            // 
            this.imagecontrolReturn.BackColor = System.Drawing.Color.Transparent;
            this.imagecontrolReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagecontrolReturn.Image = global::prototype_BM102.Properties.Resources.goback;
            this.imagecontrolReturn.ImageHover = global::prototype_BM102.Properties.Resources.goback_hover;
            this.imagecontrolReturn.ImageNormal = global::prototype_BM102.Properties.Resources.goback;
            this.imagecontrolReturn.Location = new System.Drawing.Point(939, 11);
            this.imagecontrolReturn.Margin = new System.Windows.Forms.Padding(2);
            this.imagecontrolReturn.Name = "imagecontrolReturn";
            this.imagecontrolReturn.Size = new System.Drawing.Size(50, 50);
            this.imagecontrolReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagecontrolReturn.TabIndex = 3;
            this.imagecontrolReturn.TabStop = false;
            this.imagecontrolReturn.Click += new System.EventHandler(this.imagecontrolReturn_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::prototype_BM102.Properties.Resources.formProducts_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.imagecontrolAdd);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panelDrag1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolAdd)).EndInit();
            this.panelDrag1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private panelDrag panelDrag1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private imagecontrol imagecontrolAdd;
        private imagecontrol imagecontrolReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategory;
        private System.Windows.Forms.DataGridViewImageColumn dgvPencil;
        private System.Windows.Forms.DataGridViewImageColumn dgvDelete;
    }
}