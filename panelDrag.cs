using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype_BM102
{
    public partial class panelDrag : Panel
    {
        private bool isDragging = false;
        private Point dragOffset;

        public panelDrag()
        {
            InitializeComponent();
            this.MouseDown += panelDrag_MouseDown;
            this.MouseMove += panelDrag_MouseMove;
            this.MouseUp += panelDrag_MouseUp;
        }

        private void panelDrag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragOffset = new Point(e.X, e.Y);
            }
        }

        private void panelDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Form form = this.FindForm();
                Point newLocation = form.PointToScreen(e.Location);
                newLocation.Offset(-dragOffset.X, -dragOffset.Y);
                form.Location = newLocation;
            }
        }

        private void panelDrag_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}
