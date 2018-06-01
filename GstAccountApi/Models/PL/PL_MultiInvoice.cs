using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class PL_MultiInvoice
    {

        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public int YrCD { get; set; }
        public string InvoiceNo { set; get; }
        public string InvoiceDateFrom { set; get; }
        public string InvoiceDateTo { set; get; }
        public string InvoiceDate { set; get; }

    }
}