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
    public partial class delivery : Form
    {
        public delivery()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g4Pmb2024DataSet.EmployeeDelivery' table. You can move, or remove it, as needed.
            this.employeeDeliveryTableAdapter.Fill(this.g4Pmb2024DataSet.EmployeeDelivery);
            // TODO: This line of code loads data into the 'g4Pmb2024DataSet.DataTable1' table. You can move, or remove it, as needed.
          

        }
    }
}
