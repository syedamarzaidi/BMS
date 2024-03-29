﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    public class MUser
    {
        private string username;
        private string password;
        private string role;
        public MUser()
        {

        }
        public MUser(string Username,string Password,string Role)
        {
            this.Username = Username;
            this.Password = Password;
            this.Role = Role;
        }
        public MUser(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }
        public bool isAdmin()
        {
            if(this.Role == "Admin")
            {
                return true;
            }
            return false;
        }
        public bool isCustomer()
        {
            if(this.Role == "Customer")
            {
                return true;
            }
            return false;
        }
        public bool isAttendant()
        {
            if(this.Role == "Attendant")
            {
                return true;
            }
            return false;
        }
        public bool isManager()
        {
            if(this.Role == "Manager")
            {
                return true; 
            }
            return false;
        }
    }
}
