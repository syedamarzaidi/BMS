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
using BMS.FILES;
namespace BMS.FORMS
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Address = txtAddress.Text;
            string Cnic = txtCnic.Text;
            string PhoneNumber = txtPhoneNumber.Text;
            string Role = cmbRole.Text;
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            Customer c = new Customer(Name, Address, Cnic, PhoneNumber, Username, Password,Role);
            CustomerDL.addIntoList(c);
            CustomerDL.saveData(FilePaths.CustomerData);
            this.Close();
        }
        private void ClearAddUserForm()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtName.Text = "";
            txtCnic.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
            cmbRole.Text = "Select Role";
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        {

        }
    }
}
