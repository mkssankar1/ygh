using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GreenChits.Common.Constants;

namespace GreenChits.Common.Utility
{
    public struct MessageStructure
    {
        public MessageStructure(string friendlyMessage, MessageSeverity messageSeverity)
        {
            userFriendlyMessage = friendlyMessage;
            severity = messageSeverity;
        }

        private string userFriendlyMessage;

        public string UserFriendlyMessage
        {
            get { return userFriendlyMessage; }
            set { userFriendlyMessage = value; }
        }

        private MessageSeverity severity;

        public MessageSeverity Severity
        {
            get { return severity; }
            set { severity = value; }
        }
    }
}
