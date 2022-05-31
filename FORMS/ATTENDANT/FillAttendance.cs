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
namespace BMS.FORMS.ATTENDANT
{
    public partial class FillAttendance : Form
    {
        private string Name;
        public FillAttendance(string Name)
        {
            InitializeComponent();
            this.Name = Name;
        }

        private void FillAttendance_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFillAttendance_Click_1(object sender, EventArgs e)
        {
            int totalDays = int.Parse(textBox1.Text);
            int totalPresent = int.Parse(textBox2.Text);
            int totalAbsent = int.Parse(textBox3.Text);
            string Month = comboBox1.Text;
            Attendance a = new Attendance(Name, totalDays, totalPresent, totalAbsent, Month);
            AttendanceDL.addIntoList(a);
            AttendanceDL.saveAttendance(FILES.FilePaths.AttendanceData);
        }
    }
}
