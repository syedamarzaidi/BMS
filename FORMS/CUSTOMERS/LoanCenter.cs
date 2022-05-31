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
    public partial class LoanCenter : Form
    {
        private Customer customer;
        public LoanCenter(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void LoanCenter_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (customer.payloan())
            {
                MessageBox.Show("Installment is payed from your Bank Account");
            }
        }
    }
}
