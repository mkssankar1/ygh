using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenChits.Model
{
    public class GroupDetails
    {
        public string GroupName { get; set; }
        public string GroupID { get; set; }
        public int Status { get; set; }
        public string Desc { get; set; }
        public string StatusMsg { get; set; }
        public string ApprovalByUser { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsAdmin { get; set; }
    }

    public class GroupList
    {
        public Status status { get; set; }
        public List<GroupDetails> groups { get; set; }
    }
}

