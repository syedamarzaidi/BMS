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
    public partial class AccountInfo : Form
    {
        private Customer customer;
        public AccountInfo(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void AccountInfo_Load(object sender, EventArgs e)
        {
            lblName.Text = customer.Name;
            lblAddress.Text = customer.Address;
            lblPhone.Text = customer.PhoneNumber;
            lblCnic.Text = customer.Cnic;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
