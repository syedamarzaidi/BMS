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
        public FillAttendance()
        {
            InitializeComponent();
        }

        private void FillAttendance_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            int totalPresent = int.Parse(textBox2.Text);
            int totalAbsent = int.Parse(textBox3.Text);
            string Month = comboBox1.Text;
            Attendance a = new Attendance(Name, totalPresent, totalAbsent, Month);
            AttendanceDL.addIntoList(a);
        }
    }
}
