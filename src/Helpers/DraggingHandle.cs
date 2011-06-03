using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DojoTimer.Helpers
{
    public class DraggingHandle
    {
        private Point ClickedPoint;
        private bool IsDragging = false;
        Form form;
        public DraggingHandle(Form form)
        {
            this.form = form;
        }

        private void Drag_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.IsDragging = true;
            this.ClickedPoint = new Point(e.X, e.Y);

        }

        private void Drag_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.IsDragging = false;
        }

        private void Drag_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (this.IsDragging)
            {
                Point NewPoint;

                NewPoint = form.PointToScreen(new Point(e.X, e.Y));
                NewPoint.Offset(this.ClickedPoint.X * -1, this.ClickedPoint.Y * -1);

                form.Location = NewPoint;
            }
        }

        public void Bind(params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.MouseDown += Drag_MouseDown;
                control.MouseMove += Drag_MouseMove;
                control.MouseUp += Drag_MouseUp;
            }
        }
    }
}
