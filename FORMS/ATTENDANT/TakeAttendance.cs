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
    public partial class TakeAttendance : Form
    {
        public TakeAttendance()
        {
            InitializeComponent();
        }

        private void TakeAttendance_Load(object sender, EventArgs e)
        {
            if (AttendanceDL.loadAttendance(FILES.FilePaths.AttendanceData))
            {
                MessageBox.Show("Data Loaded Successfully");
            }
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            FillAttendance extraForm = new FillAttendance(cmbSelect.Text);
            extraForm.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowAttendance extraForm = new ShowAttendance();
            extraForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 extraForm = new Form1();
            extraForm.Show();
        }
    }
}
