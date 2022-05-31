using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BMS.BL;
namespace BMS.DL
{
    class AttendanceDL
    {
        private static List<Attendance> attendance = new List<Attendance>();
        public static void addIntoList(Attendance a)
        {
            attendance.Add(a);
        }
        public static List<Attendance> getAttendance()
        {
            return attendance;
        }
        public static void saveAttendance(string path)
        {
            StreamWriter file = new StreamWriter(path);
                string Record;
                for(int x = 0; x <attendance.Count;x++)
                {
                    Record = attendance[x].Name + "," +  attendance[x].TotalDays+"," + attendance[x].TotalPresent + "," + attendance[x].TotalAbsent + "," + attendance[x].Month1;
                    Console.WriteLine(Record);
                }
            file.Flush();
            file.Close();
        }
        public static bool loadAttendance(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string Record;
                while((Record = file.ReadLine()) != null)
                {
                    string[] splitedRecord = Record.Split(',');
                    string Name = splitedRecord[0];
                    int totalDays = int.Parse(splitedRecord[1]);
                    int totalPresent = int.Parse(splitedRecord[2]);
                    int totalAbsent = int.Parse(splitedRecord[3]);
                    string month = splitedRecord[4];
                    Attendance a = new Attendance(Name, totalDays,totalPresent, totalAbsent, month);
                    attendance.Add(a);
                }
                file.Close();
                return true; 
            }
            return false;
        }
    }
}
