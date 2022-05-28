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
using BMS.BL;
using BMS.FORMS;
namespace BMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = txtName.Text;
            string Password = txtPassword.Text;
            MUser m = new MUser(Username, Password);
            MUser user = MUserDL.isUserExists(m);
          //  if(user != null)
           // {
                this.Hide();
             //   if (user.Role == "Customer")
               /// {
                    CustomerForm extraForm = new CustomerForm();
                    extraForm.Show();
                //}
            }   
        }
    }
