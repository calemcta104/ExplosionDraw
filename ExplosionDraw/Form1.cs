using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplosionDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen1 = new Pen(Color.Orange, 5);
            Pen pen2 = new Pen(Color.Red, 5);
            Pen pen3 = new Pen(Color.White, 2);
            Pen outlinePen = new Pen(Color.White);

            g.DrawRectangle(outlinePen, 0,0, 200, 200);

            g.DrawLine(pen1, 0, 0, 200, 200);
            g.DrawLine(pen1, 0, 200, 200, 0);
            g.DrawLine(pen2, 100, 0, 100, 200);
            g.DrawLine(pen2, 0, 100, 200, 100);

            g.DrawEllipse(pen3, 60, 20, 10, 10);
            g.DrawEllipse(pen3, 130, 20, 10, 10);

            g.DrawEllipse(pen3, 60, 170, 10, 10);
            g.DrawEllipse(pen3, 130, 170, 10, 10);

            g.DrawEllipse(pen3, 170, 60, 10, 10);
            g.DrawEllipse(pen3, 170, 130, 10, 10);

            g.DrawEllipse(pen3, 20, 60, 10, 10);
            g.DrawEllipse(pen3, 20, 130, 10, 10);
        }
    }
}
