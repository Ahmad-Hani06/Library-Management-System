using clsDataAccessLayer;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBussinessLogic
{
    public class clsUser
    {
        public enum enMode { AddNew, Update};
        public enMode Mode;
        public int UserID { set; get; }
        public int PersonID { set; get; }
        public string UserName { set; get; }
        public string PasswordHash { set; get; }
        public bool IsActive { get; set; }

        public clsPerson person;

        public clsUser()
        {
            UserID = 0;
            PersonID = 0;
            UserName = "";
            PasswordHash = "";
            IsActive = false;
            person = new clsPerson();
            Mode = enMode.AddNew;
        }
        private clsUser(int UserID, int PersonID, string UserName, string PasswordHash, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.PasswordHash = PasswordHash;
            this.IsActive = IsActive;
            this.person = clsPerson.Find(PersonID);
            Mode = enMode.Update;
        }

        public static clsUser Find(int UserID)
        {
            int PersonID = 0;
            string UserName = "";
            string PasswordHash= "";
            bool IsActive = false;

            if (clsUserData.GetUserByID(UserID, ref PersonID, ref UserName, ref PasswordHash, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, PasswordHash, IsActive);
            }
            else
                return null;
        }

        private bool _AddNewUser()
        {
            UserID = clsUserData.AddNewUser(this.PersonID, this.UserName, clsHashPass.ComputeHash(this.PasswordHash), this.IsActive);// add Hashing
            return UserID != -1;
        }

        private bool _UdpateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.UserName, this.IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;

                case enMode.Update:
                    return _UdpateUser();

                default:
                    break;
            }
            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static bool IsPersonAlreadyUser(int PersonID)
        {
            return clsUserData.IsPersonAlreadyUser(PersonID);
        }

        public static bool isUserNameExists(string UserName)
        {
            return clsUserData.IsUserNameExists(UserName);
        }

        public static clsUser Login(string UserName, string Password)
        {
            int UserID = -1;

            if (clsUserData.Login(UserName, clsHashPass.ComputeHash(Password), ref UserID))
            {
                return Find(UserID); // this is the current User
            }
            return null;
  
        }
    }
}
