using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenChits.Model
{
    public class UserEnity 
    {
        public int? CustomerID { get; set; }
        public string Email { get; set; }
        public string AlterEmail { get; set; }
        public string UserName{get; set;}
        public string Password { get; set; }
        public string ModifiedUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Prefix{ get; set; }
        public string Gender { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? DOB { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? DtCreateDate { get; set; }
        public string ActiveGuid{get;set;}
        public string Qualification{get; set;}
        public string UserType { get; set; }
    }

    public class UserExtend : UserEnity
    {
        public int Status { get; set; }
        public int Lock { get; set; }
        public int Type { get; set; }
        public int LoginStatus { get; set; }
        public int SaltKey { get; set; }
    }




    public class UserAddress : Status
    {
        public Int64 intUid { get; set; }
        public Int64 intModifiedUser { get; set; }
        public int intAccountNo { get; set; }
        public int intPincode { get; set; }
        public int intType { get; set; }
        public int intStatus { get; set; }
        public int intLock { get; set; }
        public string strCity { get; set; }
        public string strState { get; set; }
        public DateTime? dtDOB { get; set; }
        public DateTime? dtLastLogin { get; set; }
        public string strGender { get; set; }
    }

    public class UserAccountDetail : UserEnity
    {
        public string StrAccNoId { get; set; }
        public string StrUid { get; set; }
        public Int64 IntGroupId { get; set; }
        public string StrAccountNo { get; set; }
        public int IntPin { get; set; }
        public int IntStatus { get; set; }
    }

    public class Login
    {
        public Status status { get; set; }
        public UserEnity user { get; set; }
    }

}
