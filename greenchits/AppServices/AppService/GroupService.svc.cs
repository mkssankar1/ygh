using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using GreenChits.Model;
using System.Web.Script.Serialization;
using GreenChits.Common.Constants;
using GreenChits.Common.Utility;
using GreenChits.Common.Security;
using GreenChits.Controllers;


namespace AppService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GroupService" in code, svc and config file together.
    public class GroupService : IGroupService
    {
        public int GetUserBankAccount()
        {
            return 777;
        }

        public Status GroupInsert(Stream jsData)
        {
            string strGetData = CommonFunctions.ReadJSON(jsData);
            GroupDetails objGroup = new GroupDetails();
            try
            {
                objGroup =  new JavaScriptSerializer().Deserialize<GroupDetails>(strGetData);
                objGroup.CreatedUser = UtilCipher.Decrypt(objGroup.CreatedUser.ToString());
            }
            catch(Exception){
                return new Status() {StatusId = AppConstant.HackeAccess,MsgDesc = AppConstant.ErrorHackerMsg };
            }

            try
            {
                return new GroupController().Insert(objGroup);
            }
            catch (Exception ex)
            {
                LogManager.LogMessage(ex, new MessageStructure("Group Creation", MessageSeverity.Exception));
                return new Status() { StatusId = AppConstant.Exception, MsgDesc = AppConstant.ExceptionMsg };
            }
        }
    }
}
