using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.BL;
using System.IO;
namespace BMS.DL
{
    class CustomerDL
    {
        private static List<Customer> customers = new List<Customer>();
        public static List<Customer> getCustomersList()
        {
            return customers;
        }
        public static void addIntoList(Customer c)
        {
            customers.Add(c);
        }
        public static bool removeFromList(Customer c)
        {
            int userIdx = getCustomerIdx(c.Cnic);
            if (userIdx != -1)
            {
                customers.RemoveAt(userIdx);
                return true;
            }
            return false;
        }
        public static Customer isCustomerExists(string Username)
        {
            foreach(var st in customers)
            {
                if(st.Username == Username)
                {
                    return st;
                }
            }
            return null;
        }
        static int getCustomerIdx(string Cnic)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (Cnic == customers[i].Cnic)
                {
                    return i;
                }
            }
            return -1;
        }
        public static bool ReadData(string path)
        {
            string Record;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while ((Record = file.ReadLine()) != null)
                {
                    string[] splitedRecord = Record.Split(',');
                    string Name = splitedRecord[0];
                    string Address = splitedRecord[1];
                    string Cnic = splitedRecord[2];
                    string PhoneNumber = splitedRecord[3];
                    float CustomerBalance = float.Parse(splitedRecord[4]);
                    string Username = splitedRecord[5];
                    string Password = splitedRecord[6];
                    string Role = splitedRecord[7];
                    string loanTakenStatus = splitedRecord[8];
                    double loanAmount = double.Parse(splitedRecord[9]);
                    double loanInstallment = double.Parse(splitedRecord[10]);
                    int loanDuration = int.Parse(splitedRecord[11]);
                    Customer c = new Customer(Name, Address, Cnic, PhoneNumber,CustomerBalance, Username, Password, Role,loanTakenStatus,loanAmount,loanInstallment,loanDuration);
                    customers.Add(c);
                }
                file.Close();
                return true;
            }
            return false;
        }
        public static void saveData(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (var c in customers)
            {
                file.WriteLine(c.Name + "," + c.Address + "," + c.Cnic + "," + c.PhoneNumber + "," + c.CustomerBalance + "," + c.Username + "," + c.Password + "," + c.Role + "," + c.LoanTakenStatus1 + "," + c.LoanAmount + "," + c.LoanInstallment + "," + c.LoanDuration);
            }
            file.Flush();
            file.Close();
        }
        public static bool EditFromList(Customer previous, Customer updated)
        {
            foreach(var st in customers)
            {
                if(previous.Username == st.Username)
                {
                    st.Name = updated.Name;
                    st.Address = updated.Address;
                    st.Cnic = updated.Cnic;
                    st.PhoneNumber = updated.PhoneNumber;
                    st.Username = updated.Username;
                    st.Password = updated.Password;
                    st.Role = updated.Role;
                    return true;
                }
            }
            return false;
        }
        public static double TotalCash()
        {
            double d = 0;
            foreach(var st in customers)
            {
                d = d + st.CustomerBalance;
            }
            return d;
        }
        public static int getTotalCustomersCount()
        {
            return customers.Count;
        }
    }
}
