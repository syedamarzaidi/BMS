using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    public class Customer : MUser
    {
        private string name;
        private string address;
        private string cnic;
        private string phoneNumber;
        private double customerBalance;
        private string LoanTakenStatus;
        private double loanAmount;
        private double loanInstallment;
        private int loanDuration; // In months
        private double remainingLoan;
        private bool isHouseRented;
        public Customer()
        {

        }
        public Customer(string Name,string Address,string Cnic,string PhoneNumber,string Username,string Password,string Role):base(Username,Password,Role)
        {
            this.Name = Name;
            this.Address = Address;
            this.Cnic = Cnic;
            this.PhoneNumber = PhoneNumber;
            this.CustomerBalance = 0;
            this.LoanTakenStatus = "NOT TAKEN";
        }
        public Customer(string Name, string Address, string Cnic, string PhoneNumber, string Username, string Password) : base(Username, Password)
        {
            this.Name = Name;
            this.Address = Address;
            this.Cnic = Cnic;
            this.PhoneNumber = PhoneNumber;
        }
        public Customer(string Name, string Address, string Cnic, string PhoneNumber, double customerBalance,string Username, string Password, string Role) : base(Username, Password, Role)
        {
            this.Name = Name;
            this.Address = Address;
            this.Cnic = Cnic;
            this.PhoneNumber = PhoneNumber;
            this.CustomerBalance = customerBalance;
            this.LoanTakenStatus = "NOT TAKEN";
        }
        public Customer(string Name, string Address, string Cnic, string PhoneNumber, double customerBalance, string Username, string Password, string Role,string loanTakenStatus,double loanAmount,double loanInstallment,int loanDuration,bool isHouseRented) : base(Username, Password, Role)
        {
            this.Name = Name;
            this.Address = Address;
            this.Cnic = Cnic;
            this.PhoneNumber = PhoneNumber;
            this.CustomerBalance = customerBalance;
            this.LoanTakenStatus = loanTakenStatus;
            this.loanAmount = loanAmount;
            this.loanInstallment = loanInstallment;
            this.LoanDuration = loanDuration;
            this.IsHouseRented = isHouseRented;
        }
        public Customer(string Name, string Address, string Cnic, string PhoneNumber, double customerBalance, string Username, string Password, string Role, string loanTakenStatus, double loanAmount, double loanInstallment, int loanDuration) : base(Username, Password, Role)
        {
            this.Name = Name;
            this.Address = Address;
            this.Cnic = Cnic;
            this.PhoneNumber = PhoneNumber;
            this.CustomerBalance = customerBalance;
            this.LoanTakenStatus = loanTakenStatus;
            this.loanAmount = loanAmount;
            this.loanInstallment = loanInstallment;
            this.LoanDuration = loanDuration;
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

        public string LoanTakenStatus1
        {
            get
            {
                return LoanTakenStatus;
            }

            set
            {
                LoanTakenStatus = value;
            }
        }

        public double LoanAmount
        {
            get
            {
                return loanAmount;
            }

            set
            {
                loanAmount = value;
            }
        }

        public double LoanInstallment
        {
            get
            {
                return loanInstallment;
            }

            set
            {
                loanInstallment = value;
            }
        }

        public int LoanDuration
        {
            get
            {
                return loanDuration;
            }

            set
            {
                loanDuration = value;
            }
        }

        public bool IsHouseRented
        {
            get
            {
                return isHouseRented;
            }

            set
            {
                isHouseRented = value;
            }
        }

        public double RemainingLoan
        {
            get
            {
                return remainingLoan;
            }

            set
            {
                remainingLoan = value;
            }
        }

        public bool AddBalance(double d)
        {
            if (d >= 0)
            {
                customerBalance = customerBalance + d;
                return true;
            }
            return false;
        }
        public bool RemoveBalance(double d)
        {
            if(d >= 0 && d <= customerBalance)
            {
                customerBalance = customerBalance - d;
                return true;
            }
            return false;
        }
        public bool isLoanPossible(double loanAmmount ,double assetPrice,bool rentedHouse)
        {
            if(rentedHouse == false || assetPrice >= loanAmmount)
            {
                return true;
            }
            return false;
        }
        public static double calculateInstallment(int loanDuration,double loanAmount)
        {
            double amount = loanAmount / loanDuration;
            return amount;
        }
        public bool payloan()
        {
            if (this.loanAmount > 0)
            {
                if (LoanInstallment <= remainingLoan && customerBalance >= LoanInstallment)
                {
                    RemainingLoan = remainingLoan - LoanInstallment;
                    customerBalance = customerBalance - LoanInstallment;
                    return true;
                }
            }
            return false;
        }
    }
}
