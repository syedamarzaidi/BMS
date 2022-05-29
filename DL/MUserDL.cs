using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.BL;
using System.IO;
namespace BMS.DL
{
    class MUserDL
    {
        private static List<MUser> users = new List<MUser>();
        public static void addIntoList(MUser m)
        {
            users.Add(m);
        }
        public static void removeUsersFromList(MUser m)
        {
            int userIdx = getUserIdx(m.Username);
            users.RemoveAt(userIdx);
        }
        static int getUserIdx(string Username)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Username == Username)
                {
                    return i;
                }
            }
            return -1;
        }
        public static MUser isUserExists(MUser m)
        {
            foreach (var us in users)
            {
                if (us.Username == m.Username && us.Password == m.Password)
                {
                    return us;
                }
            }
            return null;
        }
        public static void saveUserData(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (var us in users)
            {
                file.WriteLine(us.Username + "," + us.Password + "," + us.Role);
            }
            file.Flush();
            file.Close();
        }
        public static bool LoadUserData(string path)
        {
            string Record;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while ((Record = file.ReadLine()) != null)
                {
                    string[] splitedRecord = Record.Split(',');
                    string Username = splitedRecord[0];
                    string Password = splitedRecord[1];
                    string Role = splitedRecord[2];
                    MUser m = new MUser(Username, Password, Role);
                    users.Add(m);
                }
                file.Close();
                return true;
            }
            return false;
        }
    }
}
