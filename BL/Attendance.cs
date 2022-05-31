using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    class Attendance
    {
        private string name;
        private int totalPresent;
        private int totalAbsent;
        private string Month;
        public Attendance(string name,int totalPresent,int totalAbsent,string Month)
        {
            this.name = name;
            this.totalPresent = totalPresent;
            this.TotalAbsent = totalAbsent;
            this.Month = Month;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int TotalPresent
        {
            get
            {
                return totalPresent;
            }

            set
            {
                totalPresent = value;
            }
        }

        public int TotalAbsent
        {
            get
            {
                return totalAbsent;
            }

            set
            {
                totalAbsent = value;
            }
        }

        public string Month1
        {
            get
            {
                return Month;
            }

            set
            {
                Month = value;
            }
        }
    }
}
