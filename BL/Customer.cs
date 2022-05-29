using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    class Customer : MUser
    {
        private string name;
        private string address;
        private string cnic;
        private string phoneNumber;
        private double customerBalance;
        public Customer(string Name,string Address,string Cnic,string PhoneNumber,string Username,string Password,string Role):base(Username,Password,Role)
        {
            this.Name = Name;
            this.Address = Address;
            this.Cnic = Cnic;
            this.PhoneNumber = PhoneNumber;
            this.Username = Username;
            this.Password = Password;
            this.Role = Role;
            this.CustomerBalance = 0;
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

        public double CustomerBalance
        {
            get
            {
                return customerBalance;
            }

            set
            {
                customerBalance = value;
            }
        }
    }
}
