namespace prototype_BM102
{
    partial class FormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.panelDrag1 = new prototype_BM102.panelDrag();
            this.imagecontrolReturn = new prototype_BM102.imagecontrol();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.imagecontrolAdd = new prototype_BM102.imagecontrol();
            this.dgvOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDrag1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDrag1
            // 
            this.panelDrag1.BackColor = System.Drawing.Color.Transparent;
            this.panelDrag1.Controls.Add(this.imagecontrolReturn);
            this.panelDrag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrag1.Location = new System.Drawing.Point(0, 0);
            this.panelDrag1.Margin = new System.Windows.Forms.Padding(2);
            this.panelDrag1.Name = "panelDrag1";
            this.panelDrag1.Size = new System.Drawing.Size(1000, 69);
            this.panelDrag1.TabIndex = 5;
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
            this.imagecontrolReturn.TabIndex = 6;
            this.imagecontrolReturn.TabStop = false;
            this.imagecontrolReturn.Click += new System.EventHandler(this.imagecontrolReturn_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvOrderDate,
            this.dgvCustomer,
            this.dgvProductID,
            this.dgvName,
            this.dgvQty,
            this.dgvPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvOrders.Location = new System.Drawing.Point(0, 68);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrders.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrders.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1000, 431);
            this.dgvOrders.TabIndex = 6;
            // 
            // imagecontrolAdd
            // 
            this.imagecontrolAdd.BackColor = System.Drawing.Color.Transparent;
            this.imagecontrolAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagecontrolAdd.Image = global::prototype_BM102.Properties.Resources.add1;
            this.imagecontrolAdd.ImageHover = global::prototype_BM102.Properties.Resources.add_hover;
            this.imagecontrolAdd.ImageNormal = global::prototype_BM102.Properties.Resources.add1;
            this.imagecontrolAdd.Location = new System.Drawing.Point(944, 502);
            this.imagecontrolAdd.Margin = new System.Windows.Forms.Padding(2);
            this.imagecontrolAdd.Name = "imagecontrolAdd";
            this.imagecontrolAdd.Size = new System.Drawing.Size(50, 50);
            this.imagecontrolAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagecontrolAdd.TabIndex = 7;
            this.imagecontrolAdd.TabStop = false;
            this.imagecontrolAdd.Click += new System.EventHandler(this.imagecontrolAdd_Click);
            // 
            // dgvOrderDate
            // 
            this.dgvOrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvOrderDate.DataPropertyName = "OrderDate";
            this.dgvOrderDate.HeaderText = "Sipariş Zamanı";
            this.dgvOrderDate.MinimumWidth = 6;
            this.dgvOrderDate.Name = "dgvOrderDate";
            this.dgvOrderDate.ReadOnly = true;
            this.dgvOrderDate.Width = 120;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCustomer.DataPropertyName = "CustomerName";
            this.dgvCustomer.HeaderText = "Müşteri Adı";
            this.dgvCustomer.MinimumWidth = 6;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            // 
            // dgvProductID
            // 
            this.dgvProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvProductID.DataPropertyName = "ID";
            this.dgvProductID.HeaderText = "Ürün Kodu";
            this.dgvProductID.MinimumWidth = 6;
            this.dgvProductID.Name = "dgvProductID";
            this.dgvProductID.ReadOnly = true;
            this.dgvProductID.Width = 97;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.DataPropertyName = "ProductName";
            this.dgvName.HeaderText = "Ürün İsmi";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvQty.DataPropertyName = "ProductQuantity";
            this.dgvQty.HeaderText = "Miktar";
            this.dgvQty.MinimumWidth = 6;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 75;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvPrice.DataPropertyName = "TotalValue";
            this.dgvPrice.HeaderText = "Toplam Fiyat";
            this.dgvPrice.MinimumWidth = 6;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 109;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::prototype_BM102.Properties.Resources.formOrders;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.imagecontrolAdd);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.panelDrag1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYS";
            this.panelDrag1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private panelDrag panelDrag1;
        private imagecontrol imagecontrolReturn;
        private System.Windows.Forms.DataGridView dgvOrders;
        private imagecontrol imagecontrolAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
    }
}