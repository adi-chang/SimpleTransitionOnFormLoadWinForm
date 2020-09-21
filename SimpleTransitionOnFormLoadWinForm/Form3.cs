using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTransitionOnFormLoadWinForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        int from_left;
        int from_top;

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                from_left = e.X;
                from_top = e.Y;
            }
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X > from_left)
                {
                    this.Left += (e.X - from_left);
                }
                else
                {
                    this.Left -= (from_left - e.X);
                }
                if (e.Y > from_top)
                {
                    this.Top += (e.Y - from_top);
                }
                else
                {
                    this.Top -= (from_top - e.Y);
                }
            }
        }
    }
}
