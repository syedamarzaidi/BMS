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
namespace BMS.FORMS.ADMIN
{
    public partial class TotalCash : Form
    {
        public TotalCash()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TotalCash_Load(object sender, EventArgs e)
        {
            lbl1.Text = CustomerDL.getTotalCustomersCount().ToString();
            label3.Text = CustomerDL.TotalCash().ToString();
        }
    }
}
