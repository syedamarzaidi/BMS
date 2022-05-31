using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BMS.BL;
namespace BMS.DL
{
    class EmployeeDL
    {
        private static List<Employee> employees = new List<Employee>();
        public static void addIntoList(Employee e)
        {
            employees.Add(e);
        }
        public static List<Employee> getEmployees()
        {
            return employees;
        }
        public static void removeEmployee(Employee e)
        {
            int employeeIdx = getEmpIdx(e.Cnic);
            employees.RemoveAt(employeeIdx);
        }
        static int getEmpIdx(string Cnic)
        {
            for(int i = 0;i < employees.Count; i++)
            {
                if(employees[i].Cnic == Cnic)
                {
                    return i;
                }
            }
            return -1;
        }
        public void saveAttendance(string path)
        {
            string record = "";
            StreamWriter file = new StreamWriter(path,true);
            for(int i = 0;i < employees.Count-1;i++)
            {
                record = record + employees[i].Cnic+employees[i].IsPresent + ',';
            }
            record = record + employees[employees.Count].Cnic+employees[employees.Count].IsPresent;
            file.WriteLine(record);
            file.Flush();
            file.Close();
        }
        public void saveEmployeeData(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach(var st in employees)
            {
                Console.WriteLine(st.Name + "," + st.Cnic + "," + st.Address + "," + st.PhoneNumber + "," + st.Designation);
            }
            file.Flush();
            file.Close();
        }
        public bool loadEmployeeData(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while((record = file.ReadLine()) != null)
                {
                    string[] splitedRecord = record.Split(',');
                    string Name = splitedRecord[0];
                    string Cnic = splitedRecord[1];
                    string Address = splitedRecord[2];
                    string PhoneNumber = splitedRecord[3];
                    string Designation = splitedRecord[4];
                    Employee e = new Employee(Name, Address, Cnic, Designation, PhoneNumber);
                    employees.Add(e);
                }
                file.Close();
                return true;
            }
            return false;
        }
       /* public bool (string path)
        {
            string record;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while ((record = file.ReadLine()) != null)
                {
                    string[] splitedRecord = record.Split(',');

                }
            }
        }*/
    }
}
