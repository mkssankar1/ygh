using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace GreenChits.ServiceConstants
{
    public class EnumCollection
    {
        public enum Gender
        {
            Male,
            Female,
            None
        }

        public enum Salutation
        {
            Mr,
            Mrs,
            Miss,
            Ms
        }

        public enum RelationShipType
        {
            Spouse,
            Child,
            Parent,
            Sibling,
            Other,
            None
        }

        public enum AddressType
        {
            Home,
            Division,
            Mailing,
            Billing,
            MainOffice,
            None
        }

        public enum EmploymentStatus
        {
            Employed,
            Terminated,
            LeaveofAbsence,
            Enrollment,
            EnrollmentFailed,
            COBRA
        }

        public enum BankAccountType
        {
            Checking,
            Savings,
            None
        }

        public enum CardStatus
        { 
            Active,
			Inactive
        }

        public enum MessageCategory
        {
            //TODO: Add Values here
        }
		public enum MaritalStatus
		{
			Single,
			Married,
			Widowed,
			Divorced,
			None
		}
        //Added to include Division department for EEPortal
        public enum EEDepartments
        {
            [DescriptionAttribute("OSG STERLING DIE")] OSG_STERLING_DIE,
            Main_Office
        }
    }
}