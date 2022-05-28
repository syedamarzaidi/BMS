using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.BL;
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
    }
}
