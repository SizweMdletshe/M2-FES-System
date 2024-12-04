using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2_Project
{
    public partial class Licence : Form
    {
        public Licence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "COMPLIANCE";
            label1.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = "1/3/2025";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            linkLabel1.Visible = true;
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }
    }
}
