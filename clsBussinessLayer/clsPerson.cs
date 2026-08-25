using System;
using System.Data;
using clsDataAccessLayer;

namespace clsBussinessLogic
{
    public class clsPerson
    {
        public enum enMode { AddNew, Update};
        public enMode Mode = enMode.AddNew;
        public int PersonID { set; get; }
        public string FullName { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public DateTime DateOfBirth { set; get; }
        public DateTime CreatedAt { set; get; }

        public clsPerson()
        {
            PersonID = 0;
            FullName = "";
            Address = "";
            Phone = "";
            Email = "";
            DateOfBirth = DateTime.Now;
            CreatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID, string FullName, string Address, string Phone, string Email, DateTime DateOfBirth, DateTime CreatedAt)
        {
            this.PersonID = PersonID;
            this.FullName = FullName;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.DateOfBirth = DateOfBirth;
            this.CreatedAt = CreatedAt;
            this.Mode = enMode.Update;
        }


        public static clsPerson Find(int PersonID)
        {
            string FullName = "";
            string Address = "";
            string Phone = "";
            string Email = "";
            DateTime DateOfBirth = DateTime.Now;
            DateTime CreatedAt = DateTime.Now;

            if (clsPersonData.GetPersonByID(PersonID, ref FullName, ref Address, ref Phone, ref Email, ref DateOfBirth, ref CreatedAt))
            {
                return new clsPerson(PersonID, FullName, Address, Phone, Email, DateOfBirth, CreatedAt);
            }
            else
                return null;
        }

        private bool _AddNewPerson()
        {
            PersonID = clsPersonData.AddNewPerson(this.FullName, this.Address, this.Phone, this.Email, this.DateOfBirth);
            return PersonID != -1;
        }

        private bool _UdpatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.FullName, this.Address, this.Phone, this.Email, this.DateOfBirth);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                 if (_AddNewPerson())
                 {
                        Mode = enMode.Update;
                        return true;
                 }
                    break;

                case enMode.Update:
                    return _UdpatePerson();

                default:
                    break;
            }
            return false;
        }

        public static DataTable GetAllPerson()
        {
            return clsPersonData.GetAllPerson();
        }

    }
}
