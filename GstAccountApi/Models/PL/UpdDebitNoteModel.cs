﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class UpdDebitNoteModel
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public int YrCD { get; set; }
        public int VchType { get; set; }
        public int PartyCode { get; set; }
        public string GSTIN { get; set; }
        public int InvoiceNo { get; set; }
        public string InvoiceDate { get; set; }
        public int AccCode { get; set; }
        public int GSTOpted { get; set; }
        public int VoucherNo { get; set; }
        public string VoucherDate { get; set; }
        public int AccCode2 { get; set; }
        public decimal AmountDr { get; set; }
        public decimal AmountCr { get; set; }
        public int EntryType { get; set; }
        public string DocDesc { get; set; }
        public int User { get; set; }
        public string IP { get; set; }
        public int ByPurchaseSale { get; set; }
        public int issueReasonId { get; set; }
        public int PreGstId { get; set; }

        public int CCCode { get; set; }


        public DataTable DtDebitNote { get; set; }
        public DataTable DtItems { get; set; }

    }
}