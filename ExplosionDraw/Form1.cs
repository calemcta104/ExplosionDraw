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
            Pen pen1 = new Pen(Color.White);

            g.DrawRectangle(pen1, 0,0, 200, 200);
            g.DrawLine(pen1, 0, 0, 200, 200);
            g.DrawLine(pen1, 0, 200, 200, 0);
        }
    }
}
