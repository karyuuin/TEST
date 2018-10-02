using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            string s = textBox1.Text;
            double d = Convert.ToDouble(s);
            string r = textBox2.Text;
            double rr = Convert.ToDouble(r);

            x = (d - rr)/2;
            richTextBox1.Text = x.ToString();
        }
    }
}
