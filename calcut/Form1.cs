using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
        }

        private void z_Click(object sender, EventArgs e)
        {
            double y1 = Convert.ToDouble(x1.Text);
            double y2 = Convert.ToDouble(x2.Text);
            double result = y1*y2;
            MessageBox.Show("zarb adad = "+result);
        }

        private void t_Click(object sender, EventArgs e)
        {
            double y1 = Convert.ToDouble(x1.Text);
            double y2 = Convert.ToDouble(x2.Text);
            double result = y1/y2;
            MessageBox.Show("tagsim adad = " + result);
        }

        private void j_Click(object sender, EventArgs e)
        {
            double y1 = Convert.ToDouble(x1.Text);
            double y2 = Convert.ToDouble(x2.Text);
            double result = y1 + y2;
            MessageBox.Show("jam adad = "+result);
        }

        private void m_Click(object sender, EventArgs e)
        {
            double y1 = Convert.ToDouble(x1.Text);
            double y2 = Convert.ToDouble(x2.Text);
            double result = y1-y2;
            MessageBox.Show("tafrigh adad = " + result);
        }
    }
}
