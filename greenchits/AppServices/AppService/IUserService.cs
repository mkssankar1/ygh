using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using GreenChits.Common.Utility;
using GreenChits.Model;

namespace AppService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(SessionMode = SessionMode.Allowed)]
    public interface IUserService
    {
        
      /*  [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "InsertUsers/{value}")]
        UserEnity InsertUsers(string value);*/

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "InsertUser")]
        Status InsertUser(Stream value);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Activation")]
        Status Activation(Stream value);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Login")]
        Login Login(Stream value);

       /*   [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "DeleteUser")]
        int DeleteUser(Stream value);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "UpdateUser")]
        UserEnity UpdateUser(Stream value);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "LoginUser")]
        UserEnity LoginUser(Stream value);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "ContactUser")]
        UserEnity InsertContactUser(Stream value);


        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "InsertBankAccount")]
        Status InsertBankAccount(Stream value);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetUserAccountDetail")]
        List<UserAccountDetail> GetUserAccountDetail(Stream value);
        
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetUserBankAccount")]
        List<BankAccountEnity> GetUserBankAccount(Stream value);*/
    }

}
