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
namespace BMS.FORMS
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ADMIN.Users extraForm = new ADMIN.Users();
            extraForm.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
          /*  if (CustomerDL.ReadData(FilePaths.CustomerData))
            {
                MessageBox.Show("Customer Data Loaded Successfully");
            }
            */
        }
    }
}
