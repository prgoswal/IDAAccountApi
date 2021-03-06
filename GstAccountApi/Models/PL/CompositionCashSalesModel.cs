﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class CompositionCashSalesModel
    {
        public int Ind { get; set; }
        public string VoucherDate { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public int VchType { get; set; }
        public int YrCD { get; set; }
        public int User { get; set; }
        public string IP { get; set; }
        public int EntryType { get; set; }

        public decimal ItemAmt { get; set; }
        public int ItemID { get; set; }
        public int AccCode { get; set; }
        public int PartyCode { get; set; }
        public string GSTIN { get; set; }

        public string PayMode { get; set; }
        public string PayModeRemark { get; set; }

        public string InvoiceSeries { get; set; }
        public string CancelReason { get; set; }

        public int ByCashSales { get; set; }
        public string PartyName { get; set; }
        public string PartyGSTIN { get; set; }
        public string PartyAddress { get; set; }
        public long PartyMobileNo { get; set; }
        public int WareHouseID { get; set; }
        public string TransName { get; set; }
        public string PONo { get; set; }

        public DataTable DtCashSales { get; set; }
        public DataTable DtSundries { get; set; }
        public DataTable DtItems { get; set; }
        public DataTable DtAdjAdvance { get; set; }
    }
}