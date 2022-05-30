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
    }
}
