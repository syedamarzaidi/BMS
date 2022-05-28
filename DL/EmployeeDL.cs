using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
