using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenChits.Model
{
    public class GroupDetails
    {
        public string GroupName { get; set; }
        public Int64  GroupID { get; set; }
        public int Status { get; set; }
        public string Desc { get; set; }
        public string StatusMsg { get; set; }
        public string ApprovalByUser { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}

