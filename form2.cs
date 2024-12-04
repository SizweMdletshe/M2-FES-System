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
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }
        public void formSetUp(Form form)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            form.ControlBox = false;
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login kk = new Login();
            this.Hide();
            kk.Show();
        }

        private void form2_Load(object sender, EventArgs e)
        {
            Home kk = new Home();
            formSetUp(kk);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Sale kk = new Sale();
            formSetUp(kk);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Home kk = new Home();
            formSetUp(kk);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Add_New_Customer kk = new Add_New_Customer();
            formSetUp(kk);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManageDetails kk = new ManageDetails();
            formSetUp(kk);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Home kk = new Home();
            formSetUp(kk);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            delivery kk = new delivery();
            formSetUp(kk);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            delivery kk = new delivery();
            formSetUp(kk);
        }
    }
}
