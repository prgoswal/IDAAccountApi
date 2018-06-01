using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class AccountHeadModel
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public int YrCD { get; set; }
        public int VchType { get; set; }
        public int User { get; set; }
        public string IP { get; set; }
        public int EntryType { get; set; }
        public int IsAdmin { get; set; }
        public int CompositionOpted { get; set; }
        public string ReffPartyCode { get; set; }
        public int IsSubDealer { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal BrokerageRate { get; set; }
        public int TaxCalcForSEZParty { get; set; }

        public DataTable DtAccount { get; set; }
        public DataTable DtAccGSTIN { get; set; }
        public DataTable DtAccPOS { get; set; }
        public DataTable TblAccTerms { get; set; }



        public string AccountHeadHindi { get; set; }
    }
}