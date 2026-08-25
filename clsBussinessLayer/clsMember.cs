using clsDataAccessLayer;
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace clsBussinessLogic
{
    public class clsMember
    {
        public enum enMode
        {
            AddNew,
            Update
        }

        public enMode Mode;

        public int MemberID { get; set; }

        public int PersonID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool Status { get; set; }

        public clsPerson person;

        public bool IsMembershipValid
        {
            get
            {
                return Status && EndDate.Date >= DateTime.Now;
            }
        }
        public clsMember()
        {
            MemberID = -1;
            PersonID = -1;

            StartDate = DateTime.Now;
            EndDate = DateTime.Now;

            Status = true;

            Mode = enMode.AddNew;
            person = null;
        }


        private clsMember(int MemberID,
            int PersonID,
            DateTime MembershipStartDate,
            DateTime MembershipEndDate,
            bool MembershipStatus)
        {
            this.MemberID = MemberID;
            this.PersonID = PersonID;

            this.StartDate = MembershipStartDate;
            this.EndDate = MembershipEndDate;

            this.Status = MembershipStatus;

            this.person = clsPerson.Find(PersonID);

            Mode = enMode.Update;
        }


        private bool _AddNewMember()
        {
            this.MemberID = clsMemberData.AddNewMember(
                this.PersonID,
                this.StartDate,
                this.EndDate,
                this.Status);

            return this.MemberID != -1;
        }

        private bool _AddNewMemberWithPayment(decimal PaymentAmount, int UserID, string Notes)
        {
            int NewMemberID = -1;
            int PaymentID = -1;

          bool isAdded =  clsMemberData.AddNewMemberWithPayment(ref NewMemberID, ref PaymentID, this.PersonID, this.StartDate, 
              this.EndDate, this.Status, PaymentAmount, UserID, Notes);

            if (isAdded)
            this.MemberID = NewMemberID;

            return isAdded;
        }
        private bool _UpdateMember()
        {
            return clsMemberData.UpdateMember(
                this.MemberID,
                this.PersonID,
                this.StartDate,
                this.EndDate,
                this.Status);
        }


        public bool Save(decimal PaymentAmount, int UserID, string Notes)
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewMemberWithPayment(PaymentAmount, UserID, Notes)) // Transaction
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;


                case enMode.Update:

                    return _UpdateMember();
            }

            return false;
        }


        public static clsMember Find(int MemberID)
        {
            int PersonID = -1;

            DateTime MembershipStartDate = DateTime.MinValue;
            DateTime MembershipEndDate = DateTime.MinValue;

            bool MembershipStatus = false;


            if (clsMemberData.GetMemberByID(
                MemberID,
                ref PersonID,
                ref MembershipStartDate,
                ref MembershipEndDate,
                ref MembershipStatus))
            {
                return new clsMember(
                    MemberID,
                    PersonID,
                    MembershipStartDate,
                    MembershipEndDate,
                    MembershipStatus);
            }

            return null;
        }


        public static DataTable GetAllMembers()
        {
            return clsMemberData.GetAllMembers();
        }

        public static bool IsPersonMember(int PersonID)
        {
            return clsMemberData.IsPersonMember(PersonID);
        }

        public static bool ChangeMemberStatus(int MemberID, bool MemberStatus)
        {
            return clsMemberData.ChangeMemberStatus(MemberID, MemberStatus);
        }

        public static bool DeactivateExpiredMembers()
        {
            return clsMemberData.DeactivateExpiredMembers();
        }

        public static bool RenewMember(int MemberID, DateTime StartDate, DateTime EndDate, decimal PaymentAmount, int UserID)
        {
            return clsMemberData.RenewMember(MemberID, StartDate, EndDate, PaymentAmount, UserID);
        }

        public static bool IsMemberIDExists(int MemberID)
        {
            return clsMemberData.IsMemberIDExists(MemberID);
        }
    }
}