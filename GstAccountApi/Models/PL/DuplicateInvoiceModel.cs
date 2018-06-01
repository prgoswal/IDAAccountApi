using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class DuplicateInvoiceModel
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public int VoucherType { get; set; }
        public int YrCD { get; set; }
        public int TaxMonth { get; set; }
        public int TaxYear { get; set; }
        public string IstDate { get; set; }
        public string LastDate { get; set; } 
    }
}