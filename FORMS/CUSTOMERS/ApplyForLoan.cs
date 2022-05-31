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
    public partial class ApplyForLoan : Form
    {
        private Customer customer;
        public ApplyForLoan(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void ApplyForLoan_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            double loanAmount = double.Parse(txtLoanAmount.Text);
            double assetPrice = double.Parse(txtAssetPrice.Text);
            bool status = rbtnYes.Checked;
            if (customer.isLoanPossible(loanAmount, assetPrice, status))
                {
                LoanForm extraForm = new LoanForm(customer, loanAmount);
                extraForm.ShowDialog();
            }
        }
    }
}
