namespace prototype_BM102
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelClear = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxHidePw = new System.Windows.Forms.PictureBox();
            this.imagecontrol1 = new prototype_BM102.imagecontrol();
            this.panelDrag1 = new prototype_BM102.panelDrag();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidePw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrol1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(659, 291);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(203, 20);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(659, 352);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(203, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelClear
            // 
            this.labelClear.AutoSize = true;
            this.labelClear.BackColor = System.Drawing.Color.Transparent;
            this.labelClear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClear.ForeColor = System.Drawing.Color.Black;
            this.labelClear.Location = new System.Drawing.Point(711, 398);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(70, 22);
            this.labelClear.TabIndex = 7;
            this.labelClear.Text = "Temizle";
            this.labelClear.Click += new System.EventHandler(this.label_Clear_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(662, 425);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(168, 55);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Giriş";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxHidePw
            // 
            this.pictureBoxHidePw.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHidePw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHidePw.Image = global::prototype_BM102.Properties.Resources.hide;
            this.pictureBoxHidePw.Location = new System.Drawing.Point(876, 349);
            this.pictureBoxHidePw.Name = "pictureBoxHidePw";
            this.pictureBoxHidePw.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxHidePw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHidePw.TabIndex = 9;
            this.pictureBoxHidePw.TabStop = false;
            this.pictureBoxHidePw.Click += new System.EventHandler(this.pictureBoxHidePw_Click);
            // 
            // imagecontrol1
            // 
            this.imagecontrol1.BackColor = System.Drawing.Color.Transparent;
            this.imagecontrol1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagecontrol1.Image = global::prototype_BM102.Properties.Resources.cancel;
            this.imagecontrol1.ImageHover = global::prototype_BM102.Properties.Resources.kapatma_hover;
            this.imagecontrol1.ImageNormal = global::prototype_BM102.Properties.Resources.cancel;
            this.imagecontrol1.Location = new System.Drawing.Point(940, 10);
            this.imagecontrol1.Name = "imagecontrol1";
            this.imagecontrol1.Size = new System.Drawing.Size(50, 50);
            this.imagecontrol1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagecontrol1.TabIndex = 11;
            this.imagecontrol1.TabStop = false;
            this.imagecontrol1.Click += new System.EventHandler(this.imagecontrol1_Click);
            // 
            // panelDrag1
            // 
            this.panelDrag1.BackColor = System.Drawing.Color.Transparent;
            this.panelDrag1.Location = new System.Drawing.Point(0, 0);
            this.panelDrag1.Name = "panelDrag1";
            this.panelDrag1.Size = new System.Drawing.Size(932, 212);
            this.panelDrag1.TabIndex = 10;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::prototype_BM102.Properties.Resources.formLogin_bg_tekarkaplanli;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.imagecontrol1);
            this.Controls.Add(this.panelDrag1);
            this.Controls.Add(this.pictureBoxHidePw);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelClear);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidePw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrol1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.PictureBox pictureBoxHidePw;
        private panelDrag panelDrag1;
        private imagecontrol imagecontrol1;
    }
}

