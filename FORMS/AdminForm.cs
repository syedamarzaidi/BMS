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
            ADMIN.TotalCash extraForm = new ADMIN.TotalCash();
            extraForm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ADMIN.Users extraForm = new ADMIN.Users();
            extraForm.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
     
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            ATTENDANT.ShowAttendance extraForm = new ATTENDANT.ShowAttendance();
            extraForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 extraForm = new Form1();
            extraForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
