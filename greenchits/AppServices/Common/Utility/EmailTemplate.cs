using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Specialized;
using System.Net.Mail;

namespace GreenChits.Common.Utility
{

    /// <summary>
    /// Summary description for EmailTemplate
    /// </summary>
    public class EmailTemplate
    {
        #region Private members

        private MergeFields mergeFieldValues;
        #endregion Private members


        private static EmailTemplate objEmailTemplate = null;

        #region Constuctor

        private EmailTemplate()
        {
        }

        #endregion Constuctor

        public static EmailTemplate GetInstance()
        {
            if (objEmailTemplate == null)
            {
                Mutex mutex = new Mutex();
                mutex.WaitOne();
                if (null == objEmailTemplate)
                {
                    objEmailTemplate = new EmailTemplate();
                }
                mutex.Close();
            }
            objEmailTemplate.Attachments = null;
            objEmailTemplate.TemplateLocation = null;
            objEmailTemplate.Templatename = null;
            return objEmailTemplate;
        }

        #region Public Properties

        public string Templatename { get; set; }

        public string TemplateLocation { get; set; }
        /// <summary>
        /// SMTP user name
        /// </summary>
        public string SmtpUser { get; set; }

        public string Body { get; set; }


        public string Subject { get; set; }

        /// <summary>
        /// User password
        /// </summary>
        public string SmtpPassword { get; set; }

        /// <summary>
        /// To Email address 
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// From EMail Address
        /// </summary>
        public string From { get; set; }

        public string FromName { get; set; }

        /// <summary>
        /// CC Address for the EMail
        /// </summary>
        public string CC { get; set; }

        /// <summary>
        /// BCC list for email
        /// </summary>
        public string Bcc { get; set; }

        /// <summary>
        /// Priority of email
        /// </summary>
        public int Priority { get; set; }


        /// List of merge fields.
        /// </summary>
        public MergeFields MergeFieldValues
        {
            get { return mergeFieldValues; }
            set
            {
                mergeFieldValues = value;
                if (mergeFieldValues != null)
                {
                    this.Body = this.Body.Replace("[TO]", mergeFieldValues.To);
                    this.Body = this.Body.Replace("[PASSWORD]", mergeFieldValues.Password);
                    this.Body = this.Body.Replace("[USERNAME]", mergeFieldValues.UserName);
                    this.Body = this.Body.Replace("[DateTime]", mergeFieldValues.DateTime);
                    this.Body = this.Body.Replace("[WEBURL]", mergeFieldValues.WEBURL);
                    this.Body = this.Body.Replace("[AppName]", mergeFieldValues.AppName);
                    this.Body = this.Body.Replace("[ExceptionMessage]", mergeFieldValues.ExceptionMessage);
                    this.Body = this.Body.Replace("[StackTrace]", mergeFieldValues.StackTrace);
                    this.Body = this.Body.Replace("[AppDBConnString]", mergeFieldValues.AppDBConnString);
                }
            }
        }

        public IList<Attachment> Attachments { get; set; }

        #endregion

    }

    public class MergeFields
    {
        public string To { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string DateTime { get; set; }
        public string WEBURL { get; set; }
        public string ExceptionMessage { get; set; }
        public string StackTrace { get; set; }
        public string AppName { get; set; }
        public string AppDBConnString { get; set; }
        public MergeFields()
        {

        }
    }
}
