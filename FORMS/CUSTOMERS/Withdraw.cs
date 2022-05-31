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
    public partial class Withdraw : Form
    {
        Customer customer;
        public Withdraw(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            lblBalance.Text = customer.CustomerBalance.ToString();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            double Amount = double.Parse(textBox1.Text);
            if (customer.RemoveBalance(Amount))
            {
                MessageBox.Show("Cash Withdrawn Successfully");
            }
            else
            {
                MessageBox.Show("A Error Occured While Processing ");
            }
            CustomerDL.saveData(FILES.FilePaths.CustomerData);
            this.Close();
        }
    }
}
