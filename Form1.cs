using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


// send help
// i'm literally the stack overflow copypaste sterotype wtf

namespace QuaverToBG
{
    public partial class QuaverToBG : Form
    {
        public QuaverToBG()
        {
            InitializeComponent();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) // me when the
            // Panel
        {
            
        }
        Point lastPoint;

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void getBgButton_Click(object sender, EventArgs e)
        {
            string me = System.IO.Directory.GetCurrentDirectory();
            Process.Start(me + @"\QuaverToBG (core).exe");
        }
    }
}
