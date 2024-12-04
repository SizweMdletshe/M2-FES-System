using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;


namespace M2_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public void displayForm(Form showMe)
        {
            if (showMe.Name != "Form1")
                dashboardP.Visible = false;
            else
                dashboardP.Visible = true;

            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
            if (showMe.Name != "Form1")
                showMe.MdiParent = this;
            showMe.Show();
            //default back color[menu highlight handling]
            saleP.BackColor = Color.Gray;
           //stockP.BackColor = Color.Gray;
            inventoryP.BackColor = Color.Gray;
            supplierP.BackColor = Color.Gray;
            dashP.BackColor = Color.Gray;
            //Form1.DefaultBackColor = Color.Gray;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login kk = new Login();
            this.Close();
            kk.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Inventory p = new Inventory();
            displayForm(p);
            inventoryP.BackColor = Color.SlateGray;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Inventory p = new Inventory();
            displayForm(p);
            inventoryP.BackColor = Color.SlateGray;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Supplier p = new Supplier();
            displayForm(p);
            supplierP.BackColor = Color.SlateGray;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Supplier p = new Supplier();
            displayForm(p);
            supplierP.BackColor = Color.SlateGray;

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dashBoard p = new dashBoard();
            displayForm(p);
    
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Licence P = new Licence();
            displayForm(P);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Licence P = new Licence();
            displayForm(P);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Sales_Details p = new Sales_Details();
            displayForm(p);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 p = new Form1();
            displayForm(p);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form1 p = new Form1();
            displayForm(p);
            //Form1.BA
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
