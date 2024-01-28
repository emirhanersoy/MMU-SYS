namespace prototype_BM102
{
    partial class FormAddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrder));
            this.imagecontrolClose = new prototype_BM102.imagecontrol();
            this.panelDrag1 = new prototype_BM102.panelDrag();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDBDataSet1 = new prototype_BM102.InventoryDBDataSet1();
            this.productTableTableAdapter = new prototype_BM102.InventoryDBDataSet1TableAdapters.ProductTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolClose)).BeginInit();
            this.panelDrag1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // imagecontrolClose
            // 
            this.imagecontrolClose.BackColor = System.Drawing.Color.Transparent;
            this.imagecontrolClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagecontrolClose.Image = global::prototype_BM102.Properties.Resources.cancel;
            this.imagecontrolClose.ImageHover = global::prototype_BM102.Properties.Resources.kapatma_hover;
            this.imagecontrolClose.ImageNormal = global::prototype_BM102.Properties.Resources.cancel;
            this.imagecontrolClose.Location = new System.Drawing.Point(658, 38);
            this.imagecontrolClose.Margin = new System.Windows.Forms.Padding(2);
            this.imagecontrolClose.Name = "imagecontrolClose";
            this.imagecontrolClose.Size = new System.Drawing.Size(40, 40);
            this.imagecontrolClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagecontrolClose.TabIndex = 0;
            this.imagecontrolClose.TabStop = false;
            this.imagecontrolClose.Click += new System.EventHandler(this.imagecontrolClose_Click);
            // 
            // panelDrag1
            // 
            this.panelDrag1.BackColor = System.Drawing.Color.Transparent;
            this.panelDrag1.Controls.Add(this.imagecontrolClose);
            this.panelDrag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrag1.Location = new System.Drawing.Point(0, 0);
            this.panelDrag1.Margin = new System.Windows.Forms.Padding(2);
            this.panelDrag1.Name = "panelDrag1";
            this.panelDrag1.Size = new System.Drawing.Size(700, 81);
            this.panelDrag1.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(262, 307);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(175, 58);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Onayla";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxQty
            // 
            this.textBoxQty.BackColor = System.Drawing.Color.LightGray;
            this.textBoxQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQty.Location = new System.Drawing.Point(267, 187);
            this.textBoxQty.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(292, 15);
            this.textBoxQty.TabIndex = 1;
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.BackColor = System.Drawing.Color.LightGray;
            this.textBoxCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCustomer.Location = new System.Drawing.Point(267, 233);
            this.textBoxCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(287, 15);
            this.textBoxCustomer.TabIndex = 2;
            // 
            // comboBoxName
            // 
            this.comboBoxName.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxName.DataSource = this.productTableBindingSource;
            this.comboBoxName.DisplayMember = "İsim";
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(267, 138);
            this.comboBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(292, 24);
            this.comboBoxName.TabIndex = 0;
            // 
            // productTableBindingSource
            // 
            this.productTableBindingSource.DataMember = "ProductTable";
            this.productTableBindingSource.DataSource = this.inventoryDBDataSet1;
            // 
            // inventoryDBDataSet1
            // 
            this.inventoryDBDataSet1.DataSetName = "InventoryDBDataSet1";
            this.inventoryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableTableAdapter
            // 
            this.productTableTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::prototype_BM102.Properties.Resources.sipariştarihsizsiparişler_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.textBoxQty);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panelDrag1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYS";
            this.Load += new System.EventHandler(this.FormAddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolClose)).EndInit();
            this.panelDrag1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private imagecontrol imagecontrolClose;
        private panelDrag panelDrag1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.ComboBox comboBoxName;
        private InventoryDBDataSet1 inventoryDBDataSet1;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private InventoryDBDataSet1TableAdapters.ProductTableTableAdapter productTableTableAdapter;
    }
}