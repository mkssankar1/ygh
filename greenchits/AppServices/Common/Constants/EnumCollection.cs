using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenChits.Common.Constants
{
    public enum MessageSeverity
    {
        Success = 0,
        InvaildData=1,
        ValidationFailed = 2,
        Exception = 3,
        Information = 4,
        Verbose = 5,
        Warning = 6,
        HackeAccess=8
    }

    public enum Employerstatus
    {
        Active = 184,
        Inactive = 185,
        Enrollment = 186,
        EnrollmentCompleted = 187,
        Failed = 188,
        MigrationPending = 189
    }

    public enum userRoles
    {
        user = 0,
        vendor = 1,
        admin =2,
    }
  
    public enum ContactStatus
    {
        Active = 1291,
        InActive = 1292
    }
  

    public enum RoleType
    {
        Financial = 387,
        Billing = 388,
        Admin = 389
    }


    public enum ContributionFrequency
    {
        Daily = 80,
        Custom = 81,
        Annual = 82,
        Monthly = 83,
        SemiMonthly = 84,
        BiWeekly = 85,
        Weekly = 86
    }

    public enum PayrollFrequency
    {
        Daily = 1791,
        Custom = 1792,
        Annual = 1793,
        Monthly = 1794,
        SemiMonthly = 1795,
        BiWeekly = 1796,
        Weekly = 1797
    }

    public enum ScheduleTemplateFrequency
    {
        Annual = 570,
        Monthly = 571,
        SemiMonthly = 572,
        BiWeekly = 573,
        Weekly = 574
    }

    public enum PayScheduleFrequency
    {
        Daily = 99,
        Annual = 94,
        Monthly = 95,
        SemiMonthly = 96,
        BiWeekly = 97,
        Weekly = 98
    }
    public enum Gender
    {
        Male = 352,
        Female = 353
    }

    public enum EmployeeStatus
    {
        Employed = 191,
        Terminated = 192,
        Leave = 193,
        Enrollment = 194,
        Enrollment_Failed = 196,
        COBRA = 197
    }

    public enum BenefitAction
    {
        Add = 1140,
        //Renewal,
        Terminate = 1142,
        On_Leave,
        Benefit_Change,
        Cobra
    }


    public enum ClaimStatus
    {
        Approved = 1441,
        Paid = 1442,
        Denied = 1443,
        Hold_Payment = 1444
    }
    public enum EmployeeCommunicationMethod
    { 
        Email =1400,
        Fax =1401,
        None=1
    }

    public enum CRUD
    {
        Save=1,
        Update=2,
        Delete=3
    }

 }
