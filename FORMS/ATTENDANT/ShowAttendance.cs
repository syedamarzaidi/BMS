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
namespace BMS.FORMS.ATTENDANT
{
    public partial class ShowAttendance : Form
    {
        public ShowAttendance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowAttendance_Load(object sender, EventArgs e)
        {
            dataBound();
        }
        private void dataBound()
        {
            gv.DataSource = null;
            gv.DataSource = AttendanceDL.getAttendance();
            gv.Refresh();
        }
    }
}
