using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenChits.Model
{
    public class BankAccountEnity
    {
        public string AccountName { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string AccountNo { get; set; }
        public Int64  CustomerBankId { get; set; }
        public Int64  CustomerId { get; set; }
        public int    AccountType { get; set; }
        public string Place { get; set; }
        public string IFSC { get; set; }
        public string MICR { get; set; }
        public int Priority { get; set; }
        public int status { get; set; }
    }
}
