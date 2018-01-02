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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGroupService" in both code and config file together.
    [ServiceContract]
    public interface IGroupService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetUserBankAccount")]
        int GetUserBankAccount();

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GroupInsert")]
        Status GroupInsert(Stream value);
    }
}
