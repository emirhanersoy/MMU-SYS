namespace prototype_BM102
{
    partial class FormCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategories));
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.imagecontrolAdd = new prototype_BM102.imagecontrol();
            this.panelDrag1 = new prototype_BM102.panelDrag();
            this.imagecontrolReturn = new prototype_BM102.imagecontrol();
            this.dgvCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategoryDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolAdd)).BeginInit();
            this.panelDrag1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCategory,
            this.dgvCategoryDelete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategories.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvCategories.Location = new System.Drawing.Point(0, 55);
            this.dgvCategories.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCategories.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCategories.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCategories.RowTemplate.Height = 24;
            this.dgvCategories.Size = new System.Drawing.Size(800, 333);
            this.dgvCategories.TabIndex = 6;
            this.dgvCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellContentClick);
            // 
            // imagecontrolAdd
            // 
            this.imagecontrolAdd.BackColor = System.Drawing.Color.Transparent;
            this.imagecontrolAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagecontrolAdd.Image = global::prototype_BM102.Properties.Resources.add1;
            this.imagecontrolAdd.ImageHover = global::prototype_BM102.Properties.Resources.add_hover;
            this.imagecontrolAdd.ImageNormal = global::prototype_BM102.Properties.Resources.add1;
            this.imagecontrolAdd.Location = new System.Drawing.Point(750, 400);
            this.imagecontrolAdd.Margin = new System.Windows.Forms.Padding(2);
            this.imagecontrolAdd.Name = "imagecontrolAdd";
            this.imagecontrolAdd.Size = new System.Drawing.Size(40, 40);
            this.imagecontrolAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagecontrolAdd.TabIndex = 4;
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
            this.panelDrag1.Size = new System.Drawing.Size(800, 56);
            this.panelDrag1.TabIndex = 0;
            // 
            // imagecontrolReturn
            // 
            this.imagecontrolReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagecontrolReturn.Image = global::prototype_BM102.Properties.Resources.goback;
            this.imagecontrolReturn.ImageHover = global::prototype_BM102.Properties.Resources.goback_hover;
            this.imagecontrolReturn.ImageNormal = global::prototype_BM102.Properties.Resources.goback;
            this.imagecontrolReturn.Location = new System.Drawing.Point(734, 10);
            this.imagecontrolReturn.Margin = new System.Windows.Forms.Padding(2);
            this.imagecontrolReturn.Name = "imagecontrolReturn";
            this.imagecontrolReturn.Size = new System.Drawing.Size(40, 40);
            this.imagecontrolReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagecontrolReturn.TabIndex = 19;
            this.imagecontrolReturn.TabStop = false;
            this.imagecontrolReturn.Click += new System.EventHandler(this.imagecontrolReturn_Click);
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCategory.DataPropertyName = "Kategori";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategory.HeaderText = "Kategori";
            this.dgvCategory.MinimumWidth = 6;
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            // 
            // dgvCategoryDelete
            // 
            this.dgvCategoryDelete.HeaderText = "";
            this.dgvCategoryDelete.Image = global::prototype_BM102.Properties.Resources._000delete;
            this.dgvCategoryDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvCategoryDelete.MinimumWidth = 6;
            this.dgvCategoryDelete.Name = "dgvCategoryDelete";
            this.dgvCategoryDelete.ReadOnly = true;
            this.dgvCategoryDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategoryDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvCategoryDelete.Width = 19;
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::prototype_BM102.Properties.Resources.formCategories_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imagecontrolAdd);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.panelDrag1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolAdd)).EndInit();
            this.panelDrag1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private panelDrag panelDrag1;
        private imagecontrol imagecontrolReturn;
        private imagecontrol imagecontrolAdd;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategory;
        private System.Windows.Forms.DataGridViewImageColumn dgvCategoryDelete;
    }
}