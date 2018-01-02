using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using GreenChits.Common.Constants;

namespace GreenChits.Common.Security
{
    public class UserContext
    {
        public UserContext(){}

        private string userGUID;
        private long userID;
        private string userName;
        private string password;
        private string status;
        private int failedAttempts;
        private DateTime? lastLoginOn;
        private DateTime? passwordChangesOn;
        private int locked;

        public string UserGUID
        {
            get
            {
                return userGUID;
            }
            set
            {
                userGUID = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
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

        public Int64 UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public int FailedAttempts
        {
            get
            {
                return failedAttempts;
            }
            set
            {
                failedAttempts = value;
            }
        }

        public DateTime ? LastLoginOn
        {
            get
            {
                return lastLoginOn;
            }
            set
            {
                lastLoginOn = value;
            }
        }

        public DateTime ? PasswordChangedOn
        {
            get
            {
                return passwordChangesOn;
            }
            set
            {
                passwordChangesOn = value;
            }
        }

        public int Locked
        {
            get
            {
                return locked;
            }
            set
            {
                locked = value;
            }
        }

        public string Email { get; set; }

        #region Public methods

        public static UserContext GetInstance()
        {
            
            if (null == HttpContext.Current.Session[AppConstant.UserContext])
            {
                HttpContext.Current.Session[AppConstant.UserContext] = new UserContext();
            }
            return (UserContext)HttpContext.Current.Session[AppConstant.UserContext];
        }

        #endregion Public methods
    }
}
