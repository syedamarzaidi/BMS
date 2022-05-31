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
    public partial class LoanForm : Form
    {
        private Customer customer;
        private double loanAmount;
        public LoanForm(Customer customer,double loanAmount)
        {
            InitializeComponent();
            this.customer = customer;
            this.loanAmount = loanAmount;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            int months = int.Parse(cmbPlan.Text);
            double installment = Customer.calculateInstallment(months, customer.LoanAmount);
            if (installment >= 0)
            {
                customer.LoanAmount = loanAmount;
                customer.LoanDuration = months;
                customer.LoanTakenStatus1 = "TAKEN";
                customer.LoanInstallment = installment;
                this.Close();
            }
        }
    }
}
