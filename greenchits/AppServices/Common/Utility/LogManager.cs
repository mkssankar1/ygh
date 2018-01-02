using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using GreenChits.Common.Utility;
using GreenChits.Common.Constants;
using System.Configuration;
using System.Net.Configuration;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GreenChits.Common.Security;
using System.Data.SqlClient;


namespace GreenChits.Common.Utility
{
    public static class LogManager
    {
        public static void LogMessage(MessageStructure msgStructure)
        {
            try
            {
                UserContext userContext = (UserContext)HttpContext.Current.Session[AppConstant.UserContext];
                // Creates and fills the log entry with user information
                LogEntry logEntry = new LogEntry();
                logEntry.Severity = (System.Diagnostics.TraceEventType)Convert.ToInt32(msgStructure.Severity);
                logEntry.Message = msgStructure.UserFriendlyMessage;
                logEntry.Categories.Clear();
                // Writes the log entry.
                Logger.Write(logEntry);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void LogMessage(Exception exp, MessageStructure msgStructure)
        {
            try
            {
                StringBuilder sbLogEntry = new StringBuilder();
                sbLogEntry.AppendLine();
                sbLogEntry.AppendLine(msgStructure.UserFriendlyMessage);
                if(!string.IsNullOrEmpty(exp.Message))
                    sbLogEntry.AppendLine(exp.Message);
                sbLogEntry.AppendLine("Stack Trace: ");
                sbLogEntry.AppendLine(exp.StackTrace);


                // Creates and fills the log entry with user information
                               LogEntry logEntry = new LogEntry();
                logEntry.Severity = (System.Diagnostics.TraceEventType)Convert.ToInt32(msgStructure.Severity);
                logEntry.Message = sbLogEntry.ToString();
                logEntry.Categories.Clear();
                // Writes the log entry.
                Logger.Write(logEntry);

                UserContext userContext = (UserContext)HttpContext.Current.Session[AppConstant.UserContext];
                string userName = userContext.UserName;
                //string userName = HttpContext.Current.User.Identity.Name;
                
                EmailManager emailManager = EmailManager.GetInstance();
                EmailTemplate emailTemplate = EmailTemplate.GetInstance();

               emailTemplate.TemplateLocation = HttpContext.Current.Server.MapPath(CommonFunctions.GetConfigurationSettings("EmailTemplateFilePath"));
                
                emailTemplate.Templatename = "NotifyException";
               
                emailTemplate.From = CommonFunctions.GetConfigurationSettings("SenderEmail");
          
                if (!string.IsNullOrEmpty(exp.Message))
                {
                    string getEmailToFromConfig = CommonFunctions.GetConfigurationSettings("EmailTo");
                    string[] strEmailArray = getEmailToFromConfig.Split(',');
                    for (int i = 0; i < strEmailArray.Count(); i++)
                    {
                        emailTemplate.To = strEmailArray[i];
                        MergeFields mergeEmailContents = new MergeFields();
                        mergeEmailContents.AppName = HttpContext.Current.Request.ApplicationPath.Replace('/', ' ');
                        mergeEmailContents.DateTime = DateTime.Now.ToString();
                        mergeEmailContents.WEBURL = HttpContext.Current.Request.Url.AbsolutePath.Substring(1).ToString();
                        mergeEmailContents.UserName = userName;
                        mergeEmailContents.ExceptionMessage = exp.Message;
                        mergeEmailContents.StackTrace = exp.StackTrace;

                        string connName = ConfigurationManager.ConnectionStrings[1].Name;

                        SqlConnectionStringBuilder connString = new SqlConnectionStringBuilder(
                            ConfigurationManager.ConnectionStrings[connName].ConnectionString);

                        string userID = " " + "User ID= "+connString.UserID + ";";
                        string dataSource = "Data Source= " + connString.DataSource + ";";
                        string dbName = " " +"Initial Catalog= "+ connString.InitialCatalog;
                        string persistentInfoSecurity = " "+"Persist Security Info= " + 
                                        connString.PersistSecurityInfo.ToString() + ";";
                        string enlist = " " +"Enlist= "+ connString.Enlist.ToString() + ";";
                        mergeEmailContents.AppDBConnString = dataSource+dbName+
                            persistentInfoSecurity+ enlist+userID;

                        //Sends the Email.
                       emailManager.SendMail(emailTemplate, mergeEmailContents);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
