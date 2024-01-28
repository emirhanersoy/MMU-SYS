namespace prototype_BM102
{
    partial class FormAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUser));
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelClear = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxFullname = new System.Windows.Forms.TextBox();
            this.pictureBoxHidePw = new System.Windows.Forms.PictureBox();
            this.panelDrag1 = new prototype_BM102.panelDrag();
            this.imagecontrolClose = new prototype_BM102.imagecontrol();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidePw)).BeginInit();
            this.panelDrag1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolClose)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Location = new System.Drawing.Point(281, 217);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(288, 15);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Location = new System.Drawing.Point(281, 262);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(288, 15);
            this.textBoxPhone.TabIndex = 3;
            // 
            // labelClear
            // 
            this.labelClear.AutoSize = true;
            this.labelClear.BackColor = System.Drawing.Color.Transparent;
            this.labelClear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClear.ForeColor = System.Drawing.Color.Black;
            this.labelClear.Location = new System.Drawing.Point(499, 329);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(70, 22);
            this.labelClear.TabIndex = 8;
            this.labelClear.Text = "Temizle";
            this.labelClear.Click += new System.EventHandler(this.labelClear_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(263, 317);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(175, 58);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Kayıt";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.LightGray;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Location = new System.Drawing.Point(281, 125);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(288, 15);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.BackColor = System.Drawing.Color.LightGray;
            this.textBoxFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFullname.Location = new System.Drawing.Point(281, 171);
            this.textBoxFullname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.Size = new System.Drawing.Size(288, 15);
            this.textBoxFullname.TabIndex = 1;
            // 
            // pictureBoxHidePw
            // 
            this.pictureBoxHidePw.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHidePw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHidePw.Image = global::prototype_BM102.Properties.Resources.hide;
            this.pictureBoxHidePw.Location = new System.Drawing.Point(590, 211);
            this.pictureBoxHidePw.Name = "pictureBoxHidePw";
            this.pictureBoxHidePw.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxHidePw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHidePw.TabIndex = 14;
            this.pictureBoxHidePw.TabStop = false;
            this.pictureBoxHidePw.Click += new System.EventHandler(this.pictureBoxHidePw_Click);
            // 
            // panelDrag1
            // 
            this.panelDrag1.BackColor = System.Drawing.Color.Transparent;
            this.panelDrag1.Controls.Add(this.imagecontrolClose);
            this.panelDrag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrag1.Location = new System.Drawing.Point(0, 0);
            this.panelDrag1.Name = "panelDrag1";
            this.panelDrag1.Size = new System.Drawing.Size(700, 86);
            this.panelDrag1.TabIndex = 13;
            // 
            // imagecontrolClose
            // 
            this.imagecontrolClose.BackColor = System.Drawing.Color.Transparent;
            this.imagecontrolClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagecontrolClose.Image = global::prototype_BM102.Properties.Resources.cancel;
            this.imagecontrolClose.ImageHover = global::prototype_BM102.Properties.Resources.kapatma_hover;
            this.imagecontrolClose.ImageNormal = global::prototype_BM102.Properties.Resources.cancel;
            this.imagecontrolClose.Location = new System.Drawing.Point(657, 43);
            this.imagecontrolClose.Name = "imagecontrolClose";
            this.imagecontrolClose.Size = new System.Drawing.Size(40, 40);
            this.imagecontrolClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagecontrolClose.TabIndex = 17;
            this.imagecontrolClose.TabStop = false;
            this.imagecontrolClose.Click += new System.EventHandler(this.imagecontrolClose_Click);
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::prototype_BM102.Properties.Resources.yenikullanıcı_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(700, 394);
            this.Controls.Add(this.pictureBoxHidePw);
            this.Controls.Add(this.panelDrag1);
            this.Controls.Add(this.textBoxFullname);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelClear);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxPassword);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidePw)).EndInit();
            this.panelDrag1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxFullname;
        private panelDrag panelDrag1;
        private System.Windows.Forms.PictureBox pictureBoxHidePw;
        private imagecontrol imagecontrolClose;
    }
}