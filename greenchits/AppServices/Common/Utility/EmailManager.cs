using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Mail;
using System.Xml;

namespace GreenChits.Common.Utility
{
    public class EmailManager
    {
        private static EmailManager objEmailManager = null;

        private EmailManager()
        {

        }

        public string SmtpHost { private get; set; }

        public int SmtpPort { private get; set; }

        public string SmtpUserName { private get; set; }

        public string SmtpPassword { private get; set; }


        public static EmailManager GetInstance()
        {
            if (objEmailManager == null)
            {
                Mutex mutex = new Mutex();
                mutex.WaitOne();
                objEmailManager = new EmailManager();
                mutex.Close();
            }
            return objEmailManager;
        }

        public bool SendMail(EmailTemplate eMailTemplate, MergeFields mFields)
        {
            SmtpClient smtpMail = new SmtpClient();
            MailMessage mailMessage = new MailMessage();

            if (eMailTemplate.From == null)
            {
                eMailTemplate.From = CommonFunctions.GetConfigurationSettings("eMailFrom");
            }

            if (eMailTemplate.Templatename != null)
            {
                if (eMailTemplate.Templatename == "")  // Template name not set. Handle the exception in UI layer.
                {
                    return false;
                }

                //Load Email Template XML file
                XmlDataDocument xmlDoc = new XmlDataDocument();

                xmlDoc.Load(eMailTemplate.TemplateLocation);
                // Get the template requested to form the body.

                XmlNode oNode = xmlDoc.SelectSingleNode("/EmailTemplates/NotificationTemplate[@Name='" + eMailTemplate.Templatename + "']");

                if (oNode == null)
                {
                    return false;
                }
                if (oNode.ChildNodes[0].InnerText.ToUpper() != "[SUBJECT]")
                    eMailTemplate.Subject = oNode.ChildNodes[0].InnerText;
                eMailTemplate.Body = oNode.ChildNodes[1].OuterXml;
                eMailTemplate.MergeFieldValues = mFields;

                mailMessage.To.Add(eMailTemplate.To);

                // Check if From Address is not Null then add the User to From Address
                /*if (eMailTemplate.From != null && eMailTemplate.From != "")
                {*/
                if (!string.IsNullOrEmpty(eMailTemplate.From))
                    mailMessage.From = new MailAddress(eMailTemplate.From, eMailTemplate.FromName);
                //else
                //mailMessage.From = new MailAddress(eMailTemplate.From, UserContext.GetInstance().ClientName);

                //Add CC list
                if (!string.IsNullOrEmpty(eMailTemplate.CC))
                {
                    string[] cc = eMailTemplate.CC.Split(',');
                    for (int i = 0; i < cc.Length; i++)
                        mailMessage.CC.Add(new MailAddress(cc[i].ToString()));
                }

                //Add BCC list
                if (!string.IsNullOrEmpty(eMailTemplate.Bcc))
                {
                    string[] bcc = eMailTemplate.Bcc.Split(',');
                    for (int i = 0; i < bcc.Length; i++)
                        mailMessage.Bcc.Add(new MailAddress(bcc[i].ToString()));
                }

                mailMessage.Subject = eMailTemplate.Subject;//oNode.FirstChild.InnerXml;

                System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder(eMailTemplate.Body);

                mailMessage.Body = stringBuilder.ToString();

                mailMessage.Body = mailMessage.Body.Replace("[WEBURL]".ToString().ToUpper(), System.Configuration.ConfigurationManager.AppSettings["WEBURL"]);

                if (eMailTemplate.Attachments != null)
                {
                    foreach (Attachment attachment in eMailTemplate.Attachments)
                    {
                        mailMessage.Attachments.Add(attachment);
                    }
                }
            }
            else
            {

                if (eMailTemplate.To.LastIndexOf(",") >= 0)
                {
                    string[] mails = eMailTemplate.To.Split(',');

                    foreach (string mailID in mails)
                    {
                        mailMessage.To.Add(new MailAddress(mailID));
                    }
                }
                else
                {
                    mailMessage.To.Add(new MailAddress(eMailTemplate.To));
                }
                if (!string.IsNullOrEmpty(eMailTemplate.From))
                {
                    mailMessage.From = new MailAddress(eMailTemplate.From);
                }
                mailMessage.Subject = eMailTemplate.Subject;
                mailMessage.Body = eMailTemplate.Body;

                if (eMailTemplate.Attachments != null)
                {
                    foreach (Attachment attachment in eMailTemplate.Attachments)
                    {
                        mailMessage.Attachments.Add(attachment);
                    }
                }
            }
            mailMessage.IsBodyHtml = true;

            /*if (String.IsNullOrEmpty(CommonFunctions.GetConfigurationSettings("SMTPServer")))
            {
                smtpMail.Host = "127.0.0.1";
            }
            else
            {
                smtpMail.Host = CommonFunctions.GetConfigurationSettings("SMTPServer");
                smtpMail.Port = 25;
            }*/

            if (!String.IsNullOrEmpty(CommonFunctions.GetConfigurationSettings("SMTPServerUserName")))
            {
                SmtpPassword = CommonFunctions.GetConfigurationSettings("SMTPServerPassword");
                SmtpUserName = CommonFunctions.GetConfigurationSettings("SMTPServerUserName");
            }


            if (!string.IsNullOrEmpty(SmtpHost))
            {
                smtpMail.Host = SmtpHost;
            }

            if (SmtpPort > 0)
            {
                smtpMail.Port = SmtpPort;
            }

            if (!string.IsNullOrEmpty(SmtpUserName) && !string.IsNullOrEmpty(SmtpPassword))
            {
                smtpMail.UseDefaultCredentials = false;
                smtpMail.Credentials = new System.Net.NetworkCredential(SmtpUserName, SmtpPassword);
            }



            smtpMail.Send(mailMessage);
            smtpMail.Dispose();
            if (eMailTemplate.Attachments != null)
            {
                foreach (Attachment attachment in eMailTemplate.Attachments)
                {
                    attachment.Dispose();
                }
            }
            return true;
        }
    }
}
