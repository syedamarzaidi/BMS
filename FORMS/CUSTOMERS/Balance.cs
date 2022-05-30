using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.BL;
namespace BMS.FORMS.CUSTOMERS
{
    public partial class Balance : Form
    {
        Customer customer;
        public Balance(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            lblBalance.Text =customer.CustomerBalance.ToString();
            lblTotal.Text = customer.CustomerBalance.ToString();
        }
    }
}
