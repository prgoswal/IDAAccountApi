using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class Pl_FrmSearchByAmtDate
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public int YrCD { get; set; }
        public string DocNo { set; get; }
        public string InvoiceDateFrom { set; get; }
        public string InvoiceDateTo { set; get; }
        public decimal MinAmount { set; get; }
        public decimal MaxAmount { set; get; }


    }
}