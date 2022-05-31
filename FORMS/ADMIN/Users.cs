using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.DL;
using BMS.FILES;
using BMS.BL;
namespace BMS.FORMS.ADMIN
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            dataBound();
        }
        public void dataBound()
        {
            gvUsers.DataSource = null;
            gvUsers.DataSource = CustomerDL.getCustomersList();
            gvUsers.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserForm extraForm = new AddUserForm();
            extraForm.ShowDialog();
            dataBound();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer user = (Customer)gvUsers.CurrentRow.DataBoundItem;
            MUser m = new MUser(user.Username, user.Password, user.Role);
            MUserDL.removeUsersFromList(m);
            CustomerDL.removeFromList(user);
            CustomerDL.saveData(FilePaths.CustomerData);
            MUserDL.saveUserData(FilePaths.MUserData);
            dataBound();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Customer user = (Customer)gvUsers.CurrentRow.DataBoundItem;
            EditCustomer extraForm = new EditCustomer(user);
            extraForm.ShowDialog();
        }
    }
}
