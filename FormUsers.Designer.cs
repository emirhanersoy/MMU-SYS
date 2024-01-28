namespace prototype_BM102
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPencil = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.imagecontrolAdd = new prototype_BM102.imagecontrol();
            this.imagecontrolReturn = new prototype_BM102.imagecontrol();
            this.panelDrag1 = new prototype_BM102.panelDrag();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolReturn)).BeginInit();
            this.panelDrag1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvUsername,
            this.dgvFullname,
            this.dgvPassword,
            this.dgvPhone,
            this.dgvPencil,
            this.dgvDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvUsers.Location = new System.Drawing.Point(0, 69);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1000, 424);
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // dgvUsername
            // 
            this.dgvUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvUsername.DataPropertyName = "username";
            this.dgvUsername.HeaderText = "Kullanıcı Adı";
            this.dgvUsername.MinimumWidth = 6;
            this.dgvUsername.Name = "dgvUsername";
            this.dgvUsername.ReadOnly = true;
            // 
            // dgvFullname
            // 
            this.dgvFullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFullname.DataPropertyName = "name";
            this.dgvFullname.HeaderText = "Ad/Soyad";
            this.dgvFullname.MinimumWidth = 6;
            this.dgvFullname.Name = "dgvFullname";
            this.dgvFullname.ReadOnly = true;
            // 
            // dgvPassword
            // 
            this.dgvPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvPassword.DataPropertyName = "password";
            this.dgvPassword.HeaderText = "Şifre";
            this.dgvPassword.MinimumWidth = 6;
            this.dgvPassword.Name = "dgvPassword";
            this.dgvPassword.ReadOnly = true;
            this.dgvPassword.Width = 67;
            // 
            // dgvPhone
            // 
            this.dgvPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPhone.DataPropertyName = "phone";
            this.dgvPhone.HeaderText = "Telefon No.";
            this.dgvPhone.MinimumWidth = 6;
            this.dgvPhone.Name = "dgvPhone";
            this.dgvPhone.ReadOnly = true;
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
            this.dgvPencil.Width = 6;
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
            this.dgvDelete.Width = 6;
            // 
            // imagecontrolAdd
            // 
            this.imagecontrolAdd.BackColor = System.Drawing.Color.Transparent;
            this.imagecontrolAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagecontrolAdd.Image = global::prototype_BM102.Properties.Resources.add1;
            this.imagecontrolAdd.ImageHover = global::prototype_BM102.Properties.Resources.add_hover;
            this.imagecontrolAdd.ImageNormal = global::prototype_BM102.Properties.Resources.add1;
            this.imagecontrolAdd.Location = new System.Drawing.Point(939, 501);
            this.imagecontrolAdd.Margin = new System.Windows.Forms.Padding(2);
            this.imagecontrolAdd.Name = "imagecontrolAdd";
            this.imagecontrolAdd.Size = new System.Drawing.Size(50, 50);
            this.imagecontrolAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagecontrolAdd.TabIndex = 2;
            this.imagecontrolAdd.TabStop = false;
            this.imagecontrolAdd.Click += new System.EventHandler(this.imagecontrolAdd_Click);
            // 
            // imagecontrolReturn
            // 
            this.imagecontrolReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagecontrolReturn.Image = global::prototype_BM102.Properties.Resources.goback;
            this.imagecontrolReturn.ImageHover = global::prototype_BM102.Properties.Resources.goback_hover;
            this.imagecontrolReturn.ImageNormal = global::prototype_BM102.Properties.Resources.goback;
            this.imagecontrolReturn.Location = new System.Drawing.Point(938, 10);
            this.imagecontrolReturn.Margin = new System.Windows.Forms.Padding(2);
            this.imagecontrolReturn.Name = "imagecontrolReturn";
            this.imagecontrolReturn.Size = new System.Drawing.Size(50, 50);
            this.imagecontrolReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagecontrolReturn.TabIndex = 2;
            this.imagecontrolReturn.TabStop = false;
            this.imagecontrolReturn.Click += new System.EventHandler(this.imagecontrolReturn_Click);
            // 
            // panelDrag1
            // 
            this.panelDrag1.BackColor = System.Drawing.Color.Transparent;
            this.panelDrag1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrag1.Controls.Add(this.imagecontrolReturn);
            this.panelDrag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrag1.Location = new System.Drawing.Point(0, 0);
            this.panelDrag1.Name = "panelDrag1";
            this.panelDrag1.Size = new System.Drawing.Size(1000, 69);
            this.panelDrag1.TabIndex = 3;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::prototype_BM102.Properties.Resources.fromUsers_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.panelDrag1);
            this.Controls.Add(this.imagecontrolAdd);
            this.Controls.Add(this.dgvUsers);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagecontrolReturn)).EndInit();
            this.panelDrag1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUsers;
        private imagecontrol imagecontrolAdd;
        private imagecontrol imagecontrolReturn;
        private panelDrag panelDrag1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhone;
        private System.Windows.Forms.DataGridViewImageColumn dgvPencil;
        private System.Windows.Forms.DataGridViewImageColumn dgvDelete;
    }
}