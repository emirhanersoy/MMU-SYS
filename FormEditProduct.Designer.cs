namespace prototype_BM102
{
    partial class FormEditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditProduct));
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelClear = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.panelDrag1 = new prototype_BM102.panelDrag();
            this.imagecontrolClose = new prototype_BM102.imagecontrol();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.categoriesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDBDataSet = new prototype_BM102.InventoryDBDataSet();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.categoriesTableTableAdapter = new prototype_BM102.InventoryDBDataSetTableAdapters.CategoriesTableTableAdapter();
            this.panelDrag1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.Color.LightGray;
            this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProductName.Location = new System.Drawing.Point(265, 152);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(292, 15);
            this.textBoxProductName.TabIndex = 1;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.LightGray;
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxID.Location = new System.Drawing.Point(265, 111);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(292, 15);
            this.textBoxID.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(264, 329);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(172, 60);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Onayla";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelClear
            // 
            this.labelClear.AutoSize = true;
            this.labelClear.BackColor = System.Drawing.Color.Transparent;
            this.labelClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClear.ForeColor = System.Drawing.Color.Black;
            this.labelClear.Location = new System.Drawing.Point(487, 329);
            this.labelClear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(70, 22);
            this.labelClear.TabIndex = 34;
            this.labelClear.Text = "Temizle";
            this.labelClear.Click += new System.EventHandler(this.labelClear_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrice.Location = new System.Drawing.Point(264, 194);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(296, 15);
            this.textBoxPrice.TabIndex = 2;
            // 
            // panelDrag1
            // 
            this.panelDrag1.BackColor = System.Drawing.Color.Transparent;
            this.panelDrag1.Controls.Add(this.imagecontrolClose);
            this.panelDrag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrag1.Location = new System.Drawing.Point(0, 0);
            this.panelDrag1.Margin = new System.Windows.Forms.Padding(2);
            this.panelDrag1.Name = "panelDrag1";
            this.panelDrag1.Size = new System.Drawing.Size(700, 85);
            this.panelDrag1.TabIndex = 33;
            // 
            // imagecontrolClose
            // 
            this.imagecontrolClose.BackColor = System.Drawing.Color.Transparent;
            this.imagecontrolClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagecontrolClose.Image = global::prototype_BM102.Properties.Resources.cancel;
            this.imagecontrolClose.ImageHover = global::prototype_BM102.Properties.Resources.kapatma_hover;
            this.imagecontrolClose.ImageNormal = global::prototype_BM102.Properties.Resources.cancel;
            this.imagecontrolClose.Location = new System.Drawing.Point(658, 40);
            this.imagecontrolClose.Margin = new System.Windows.Forms.Padding(2);
            this.imagecontrolClose.Name = "imagecontrolClose";
            this.imagecontrolClose.Size = new System.Drawing.Size(40, 40);
            this.imagecontrolClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagecontrolClose.TabIndex = 32;
            this.imagecontrolClose.TabStop = false;
            this.imagecontrolClose.Click += new System.EventHandler(this.imagecontrolClose_Click);
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxProducts.DataSource = this.categoriesTableBindingSource;
            this.comboBoxProducts.DisplayMember = "Kategori";
            this.comboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(265, 277);
            this.comboBoxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(293, 24);
            this.comboBoxProducts.TabIndex = 4;
            this.comboBoxProducts.ValueMember = "Kategori";
            // 
            // categoriesTableBindingSource
            // 
            this.categoriesTableBindingSource.DataMember = "CategoriesTable";
            this.categoriesTableBindingSource.DataSource = this.inventoryDBDataSet;
            // 
            // inventoryDBDataSet
            // 
            this.inventoryDBDataSet.DataSetName = "InventoryDBDataSet";
            this.inventoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBoxQuantity.BackColor = System.Drawing.Color.LightGray;
            this.textBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuantity.Location = new System.Drawing.Point(265, 237);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(292, 15);
            this.textBoxQuantity.TabIndex = 3;
            // 
            // categoriesTableTableAdapter
            // 
            this.categoriesTableTableAdapter.ClearBeforeFill = true;
            // 
            // FormEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::prototype_BM102.Properties.Resources.urunduzenle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelClear);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.panelDrag1);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.textBoxQuantity);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYS";
            this.Load += new System.EventHandler(this.FormEditProduct_Load_1);
            this.panelDrag1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.TextBox textBoxPrice;
        private panelDrag panelDrag1;
        private imagecontrol imagecontrolClose;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private InventoryDBDataSet inventoryDBDataSet;
        private System.Windows.Forms.BindingSource categoriesTableBindingSource;
        private InventoryDBDataSetTableAdapters.CategoriesTableTableAdapter categoriesTableTableAdapter;
    }
}