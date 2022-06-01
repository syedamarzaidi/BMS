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
using BMS.DL;
namespace BMS.FORMS
{
    public partial class CustomerForm : Form
    {
        private Customer customer;
        public CustomerForm(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
                }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            CustomerPanelTop.BackColor = Color.IndianRed;
            if(customer.LoanTakenStatus1 == "TAKEN")
            {
                btnCenter.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CUSTOMERS.AccountInfo extraForm = new CUSTOMERS.AccountInfo(customer);
            extraForm.ShowDialog();
        }

        private void CustomerPanelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CUSTOMERS.Balance extraForm = new CUSTOMERS.Balance(customer);
            extraForm.ShowDialog();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            CUSTOMERS.Deposit extraForm = new CUSTOMERS.Deposit(customer);
            extraForm.ShowDialog();
        }

        private void btnWIthdraw_Click(object sender, EventArgs e)
        {
            CUSTOMERS.Withdraw extraForm = new CUSTOMERS.Withdraw(customer);
            extraForm.ShowDialog();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 extraForm = new Form1();
            extraForm.Show();
        }

        private void btnLoanApply_Click(object sender, EventArgs e)
        {
            CUSTOMERS.ApplyForLoan extraForm = new CUSTOMERS.ApplyForLoan(customer);
            extraForm.ShowDialog();
            if(customer.LoanTakenStatus1 == "TAKEN")
            {
                btnCenter.Visible = true;
            }
            CustomerDL.saveData(FILES.FilePaths.CustomerData);
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            CUSTOMERS.LoanCenter extraForm = new CUSTOMERS.LoanCenter(customer);
            extraForm.ShowDialog();
            CustomerDL.saveData(FILES.FilePaths.CustomerData);
        }
    }
}
