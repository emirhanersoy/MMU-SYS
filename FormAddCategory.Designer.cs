namespace prototype_BM102
{
    partial class FormAddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCategory));
            this.panelDrag1 = new prototype_BM102.panelDrag();
            this.imagecontrolClose = new prototype_BM102.imagecontrol();
            this.textBoxAddCategory = new System.Windows.Forms.TextBox();
            this.labelClear = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelDrag1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDrag1
            // 
            this.panelDrag1.BackColor = System.Drawing.Color.Transparent;
            this.panelDrag1.Controls.Add(this.imagecontrolClose);
            this.panelDrag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrag1.Location = new System.Drawing.Point(0, 0);
            this.panelDrag1.Margin = new System.Windows.Forms.Padding(2);
            this.panelDrag1.Name = "panelDrag1";
            this.panelDrag1.Size = new System.Drawing.Size(500, 62);
            this.panelDrag1.TabIndex = 0;
            // 
            // imagecontrolClose
            // 
            this.imagecontrolClose.BackColor = System.Drawing.Color.Transparent;
            this.imagecontrolClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagecontrolClose.Image = global::prototype_BM102.Properties.Resources.cancel;
            this.imagecontrolClose.ImageHover = global::prototype_BM102.Properties.Resources.kapatma_hover;
            this.imagecontrolClose.ImageNormal = global::prototype_BM102.Properties.Resources.cancel;
            this.imagecontrolClose.Location = new System.Drawing.Point(458, 29);
            this.imagecontrolClose.Name = "imagecontrolClose";
            this.imagecontrolClose.Size = new System.Drawing.Size(30, 30);
            this.imagecontrolClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagecontrolClose.TabIndex = 16;
            this.imagecontrolClose.TabStop = false;
            this.imagecontrolClose.Click += new System.EventHandler(this.imagecontrolClose_Click);
            // 
            // textBoxAddCategory
            // 
            this.textBoxAddCategory.BackColor = System.Drawing.Color.LightGray;
            this.textBoxAddCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddCategory.Location = new System.Drawing.Point(226, 115);
            this.textBoxAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddCategory.Name = "textBoxAddCategory";
            this.textBoxAddCategory.Size = new System.Drawing.Size(200, 15);
            this.textBoxAddCategory.TabIndex = 1;
            // 
            // labelClear
            // 
            this.labelClear.AutoSize = true;
            this.labelClear.BackColor = System.Drawing.Color.Transparent;
            this.labelClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClear.ForeColor = System.Drawing.Color.Black;
            this.labelClear.Location = new System.Drawing.Point(226, 165);
            this.labelClear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(70, 22);
            this.labelClear.TabIndex = 9;
            this.labelClear.Text = "Temizle";
            this.labelClear.Click += new System.EventHandler(this.labelClear_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(194, 202);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(124, 40);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Onayla";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::prototype_BM102.Properties.Resources.yenikategori_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(500, 281);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelClear);
            this.Controls.Add(this.textBoxAddCategory);
            this.Controls.Add(this.panelDrag1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYS";
            this.panelDrag1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private panelDrag panelDrag1;
        private System.Windows.Forms.TextBox textBoxAddCategory;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.Button buttonLogin;
        private imagecontrol imagecontrolClose;
    }
}