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
namespace BMS.FORMS.CUSTOMERS
{
    public partial class Deposit : Form
    {
        Customer customer;
        public Deposit(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            lblBalance.Text = customer.CustomerBalance.ToString();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        { 
            double Amount = double.Parse(textBox1.Text);
            if (customer.AddBalance(Amount))
            {
                MessageBox.Show("Cash Deposited Successfully");
            }
            else
            {
                MessageBox.Show("A Error Occured While Processing ");
            }
            CustomerDL.saveData(FILES.FilePaths.CustomerData);
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
