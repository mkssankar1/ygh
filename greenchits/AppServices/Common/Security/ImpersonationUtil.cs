using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using System.Runtime.InteropServices;

namespace GreenChits.Common.Security
{
    public class ImpersonationUtil
    {
        #region Ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="ImpersonationUtil"/> class.
        /// </summary>
        public ImpersonationUtil()
        {
        }

        #endregion

        #region Impersonate User

        public const int LOGON32_LOGON_INTERACTIVE = 2;
        public const int LOGON32_PROVIDER_DEFAULT = 0;

        private WindowsImpersonationContext impersonationContext;

        [DllImport("advapi32.dll")]
        public static extern int LogonUserA(String lpszUserName,
            String lpszDomain,
            String lpszPassword,
            int dwLogonType,
            int dwLogonProvider,
            ref IntPtr phToken);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DuplicateToken(IntPtr hToken,
            int impersonationLevel,
            ref IntPtr hNewToken);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RevertToSelf();

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern bool CloseHandle(IntPtr handle);

        /// <summary>
        /// Impersonates the user.
        /// </summary>
        /// <param name="UserName">Name of the user.</param>
        /// <param name="Password">The password.</param>
        /// <param name="Domain">The domain.</param>
        /// <returns></returns>
        public bool ImpersonateUser(string UserName, string Password, string Domain)
        {
            bool IsValidUser = false;

            try
            {
                if (Environment.UserName.Equals(UserName))
                {
                    IsValidUser = true;
                }
                else
                {
                    WindowsIdentity tempWindowsIdentity;
                    IntPtr token = IntPtr.Zero;
                    IntPtr tokenDuplicate = IntPtr.Zero;

                    if (LogonUserA(UserName, Domain, Password,
                        LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, ref token) != 0)
                    {
                        if (DuplicateToken(token, 2, ref tokenDuplicate) != 0)
                        {
                            tempWindowsIdentity = new WindowsIdentity(tokenDuplicate);
                            impersonationContext = tempWindowsIdentity.Impersonate();

                            if (impersonationContext != null)
                            {
                                CloseHandle(token);
                                CloseHandle(tokenDuplicate);
                                IsValidUser = true;
                                //added to avoid duplicate token handle close on dev machine
                                token = IntPtr.Zero;
                                tokenDuplicate = IntPtr.Zero;
                            }
                        }
                    }

                    if (token != IntPtr.Zero)
                    {
                        CloseHandle(token);
                    }

                    if (tokenDuplicate != IntPtr.Zero)
                    {
                        CloseHandle(tokenDuplicate);
                    }
                }
            }
            catch (System.Exception _e)
            {
                throw _e;
            }
            return IsValidUser;
        }

        /// <summary>
        /// Removes the impersonation.
        /// </summary>
        public void UndoImpersonation()
        {
            if (null != impersonationContext)
            {
                impersonationContext.Undo();
            }
        }

        #endregion
    }
}
