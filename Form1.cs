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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g4Pmb2024DataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.g4Pmb2024DataSet.Admin);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminTableAdapter.Insert(dataGridView1.CurrentRow.Cells[0].Value.ToString(), textBox1.Text, textBox2.Text, textBox3.Text);
            adminTableAdapter.Fill(g4Pmb2024DataSet.Admin);
        }
    }
}
