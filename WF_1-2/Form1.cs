using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_1_2
{
    
    public partial class Form1 : Form
    {
        static public int l,m,r;

        public Form1()
        {
            InitializeComponent();
            Text = "Mouse Clicks Count";
            StartPosition = FormStartPosition.Manual;
            Location = new Point(100, 100);
            Width = 500;
            Height = 500;
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;

            if (e.Button == MouseButtons.Left) l++;

            if (e.Button == MouseButtons.Middle) m++;

            if (e.Button == MouseButtons.Right)  r++;

            frm.Text = string.Format("Mouse Clicks Count: Left = {0}, Middle = {1}, Right = {2}",l,m,r);

        }
    }
}
