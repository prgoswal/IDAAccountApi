﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class BrsBankModel
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public int VchType { get; set; }
        public int LastNo { get; set; }
        public int VchRangeFrom { get; set; }
        public int VchRangeTo { get; set; }
        public int YrCD { get; set; }
        public string DocDate { get; set; }
        public int DocNo { get; set; }
        public int AccCode { get; set; }
        public string AccGst { get; set; }
        public int AccCode2 { get; set; }
        public int RefNo { get; set; }
        public string RefDate { get; set; }
        public decimal AmountDr { get; set; }
        public decimal AmountCr { get; set; }
        public int AdvanceInd { get; set; }
        public string DocDesc { get; set; }
        public int EntryType { get; set; }
        public int User { get; set; }
        public string IP { get; set; }
        public string VoucharDateFrom { get; set; }
        public string VoucharDateto { get; set; }
        public string OpeningDate { get; set; }
        public decimal OpeningBalance { get; set; }
        public string ClosingDate { get; set; }
        public decimal ClosingBalance { get; set; } 

        public DataTable DtBrs { get; set; } 
    }
}