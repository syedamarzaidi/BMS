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
namespace BMS.FORMS.ADMIN
{
    public partial class EditCustomer : Form
    {
        private Customer previous;
        public EditCustomer(Customer previous)
        {
            InitializeComponent();
            this.previous = previous;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string cnic = txtCnic.Text;
            string address = txtAddress.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string phoneNumber = txtPhoneNumber.Text;
            Customer c = new Customer(Name, address, cnic, phoneNumber, username, password);
            MUser updated = new MUser(username, password);
            MUser pre = new MUser(previous.Username, previous.Password);
            CustomerDL.EditFromList(previous, c);
            MUserDL.EditFromList(pre, updated);
            MUserDL.saveUserData(FILES.FilePaths.MUserData);
            CustomerDL.saveData(FILES.FilePaths.CustomerData);
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            txtName.Text = previous.Name;
            txtPassword.Text = previous.Password;
            txtPhoneNumber.Text = previous.PhoneNumber;
            txtUsername.Text = previous.Username;
            txtAddress.Text = previous.Address;
            txtCnic.Text = previous.Cnic;
        }
    }
}
