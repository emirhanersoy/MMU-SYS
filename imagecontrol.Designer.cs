namespace prototype_BM102
{
    partial class imagecontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // imagecontrol
            // 
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MouseEnter += new System.EventHandler(this.imagecontrol_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.imagecontrol_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
