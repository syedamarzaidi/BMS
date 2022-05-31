using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    class Employee
    {
        protected string name;
        protected string address;
        protected string cnic;
        protected string designation;
        protected string phoneNumber;
        public Employee()
        {

        }
        public Employee(string name,string address,string cnic,string designation,string phoneNumber)
        {
            this.Name = name;
            this.Address = address;
            this.cnic = cnic;
            this.designation = designation;
            this.phoneNumber = phoneNumber;
        }
        private char isPresent;

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

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Cnic
        {
            get
            {
                return cnic;
            }

            set
            {
                cnic = value;
            }
        }

        public string Designation
        {
            get
            {
                return designation;
            }

            set
            {
                designation = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public char IsPresent
        {
            get
            {
                return isPresent;
            }

            set
            {
                isPresent = value;
            }
        }
    }
}
