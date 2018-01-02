using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using GreenChits.Model;
using GreenChits.Controllers;
using GreenChits.Common.Constants;
using GreenChits.Common.Utility;
using GreenChits.Common.Security;
using System.IO;
using System.Web.Script.Serialization;
using System.ServiceModel.Activation;
using System.Text.RegularExpressions;
using System.Web;
using System.Net;

namespace AppService
{

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, AddressFilterMode = AddressFilterMode.Any)]
    public class UserService : IUserService
    {
        //private readonly HttpContext context;
        public UserService()
        {
            // context = HttpContext.Current;
        }

        public Status InsertUser(Stream jsData)
        {
            UserExtend objUser = new UserExtend();
            string strGetData = CommonFunctions.ReadJSON(jsData);
            try
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                objUser = jss.Deserialize<UserExtend>(strGetData);
            }
            catch(Exception e){
                return new Status() {StatusId = AppConstant.HackeAccess,MsgDesc = AppConstant.ErrorHackerMsg };
            }

            try
            {
                return new UserController().InsertUser(objUser);
            }
            catch (Exception ex)
            {
                LogManager.LogMessage(ex, new MessageStructure("Insert User", MessageSeverity.Exception));
                return new Status() { StatusId = AppConstant.Exception, MsgDesc = AppConstant.ExceptionMsg };
            }
        }

        public Status Activation(Stream jsData)
        {
            try
            {
                Dictionary<string, object> result = (new JavaScriptSerializer().DeserializeObject(CommonFunctions.ReadJSON(jsData)) as Dictionary<string, object>);
                return new UserController().CheckUserActivation(result["ActiveGuid"].ToString());
            }
            catch (Exception ex)
            {
                LogManager.LogMessage(ex, new MessageStructure("User Activation", MessageSeverity.Exception));
                return new Status() { StatusId = AppConstant.Exception, MsgDesc = AppConstant.ExceptionMsg };
            }
        }

        public Login Login(Stream jsData)
        {
            try {
                return new UserController().Login(new JavaScriptSerializer().Deserialize<UserEnity>(CommonFunctions.ReadJSON(jsData)));
            }
            catch (Exception ex)
            {
                LogManager.LogMessage(ex, new MessageStructure("User Activation", MessageSeverity.Exception));
                return  new Login() { status = new Status() { StatusId = AppConstant.Exception, MsgDesc = AppConstant.ExceptionMsg } };
            }
        }

        
        /*
        public UserEnity InsertContactUser(Stream jsData)
        {
            UserEnity objUser = new UserEnity();
            try
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                objUser = jss.Deserialize<UserEnity>(CommonFunctions.ReadJSON(jsData));

                UserController objuser = new UserController();
                objUser.intLoginStatus = objuser.InsertContact(objUser); 
            }
            catch (Exception ex)
            {
                LogManager.LogMessage(ex, new MessageStructure("Insert Contact User", MessageSeverity.Exception));
                //return (int)MessageSeverity.Exception;
            }
            return objUser;
        }

        public UserEnity InsertUsers(string jsData)
        {
            UserEnity objUser = new UserEnity();
            return objUser;
        }


        public int DeleteUser(Stream jsData)
        {
            try
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                UserEnity objUser = jss.Deserialize<UserEnity>(CommonFunctions.ReadJSON(jsData));

                UserController objuser = new UserController();
                return objuser.Delete(objUser);
            }
            catch (Exception ex)
            {
                LogManager.LogMessage(ex, new MessageStructure("Delete User", MessageSeverity.Exception));
                return (int)MessageSeverity.Exception;
            }
        }

        public UserEnity UpdateUser(Stream jsData)
        {
            UserEnity objUser = new UserEnity();
            string strGetData = CommonFunctions.ReadJSON(jsData);
            try
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                objUser = jss.Deserialize<UserEnity>(strGetData);
                objUser.strModifiedUser = UtilCipher.Decrypt(objUser.strModifiedUser.ToString());
                objUser.strUid = UtilCipher.Decrypt(objUser.strUid.ToString());
            }
            catch (Exception)
            {
                objUser.intstatusId = AppConstant.HackeAccess;
                objUser.strErrorDesc = AppConstant.ErrorHackerMsg;
                return objUser;
            }

            try
            {
                UserController objuser = new UserController();
                objuser.Update(objUser);
                objUser.intstatusId = AppConstant.Success;
                objUser.strErrorDesc = AppConstant.SuccessMsg;
                return objUser;
            }
            catch (Exception ex)
            {
                LogManager.LogMessage(ex, new MessageStructure("Update User", MessageSeverity.Exception));
                objUser.intstatusId = AppConstant.Exception;
                objUser.strErrorDesc = AppConstant.ExceptionMsg;
            }
            return objUser;
        }

        public UserEnity LoginUser(Stream jsData)
        {
            UserEnity objUser = new UserEnity();
            try
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                objUser = jss.Deserialize<UserEnity>(CommonFunctions.ReadJSON(jsData));

                UserController objuser = new UserController();
                return objuser.getUserLogin(objUser);
            }
            catch (Exception ex)
            {
                LogManager.LogMessage(ex, new MessageStructure("Login User", MessageSeverity.Exception));
                return objUser;
            }
        }

        public Status InsertBankAccount(Stream jsData)
        {
            BankAccountEnity objBank = new BankAccountEnity();
            Status objStatus = new Status();
            try
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                objBank = jss.Deserialize<BankAccountEnity>(CommonFunctions.ReadJSON(jsData));
                objBank.strUserId = UtilCipher.Decrypt(objBank.strUserId.ToString(CultureInfo.InvariantCulture),false);
                objBank.strCreatedUser = objBank.strUserId;
                BankController objBankCon = new BankController();
                int intStatus = objBankCon.Insert(objBank);
                if (intStatus == 0)
                {
                    objStatus.intstatusId  = AppConstant.Success;
                    objStatus.strErrorDesc = AppConstant.SuccessMsg;
                }

            }
            catch (Exception e)
            {
                objStatus.intstatusId  = AppConstant.HackeAccess;
                objStatus.strErrorDesc = AppConstant.ErrorHackerMsg;
                return objStatus;
            }

            return objStatus;
        }

        public List<BankAccountEnity> GetUserBankAccount(Stream jsData)
        {
            try
            {
                NameValueCollection nvc = HttpUtility.ParseQueryString(CommonFunctions.ReadJSON(jsData));
                return new BankController().GetUserBankAccount(UtilCipher.Decrypt(nvc["UserId"],false));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<UserAccountDetail> GetUserAccountDetail(Stream jsData)
        {
            try
            {
                NameValueCollection nvc = HttpUtility.ParseQueryString(CommonFunctions.ReadJSON(jsData));
                return new UserController().GetUserAccountDetail(Convert.ToInt64(UtilCipher.Decrypt(nvc["UserId"], false)), Convert.ToInt32(nvc["Type"]), Convert.ToInt32(nvc["Status"]));
            }
            catch (Exception)
            {
                return null;
            }
        }

        */
    }
}
