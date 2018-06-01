using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class PurchaseModel
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

        public int ByCashSale { get; set; }
        public string PartyName { get; set; }
        public string PartyGSTIN { get; set; }
        public string PartyAddress { get; set; }
        public int WareHouseID { get; set; }
        public string PONo { get; set; }

        public string PurchaseBillNo { get; set; }
        public string PurchaseBillDate { get; set; }
        
        public string GRNNo { get; set; }
        public int AdvRecPayID { get; set; }

        public DataTable DtPurchase { get; set; }
        public DataTable DtSundries { get; set; }
        public DataTable DtItems { get; set; }
        public DataTable DtAdjAdvance { get; set; }



        public int BrokerageID { get; set; }

        public decimal BrokerageRate { get; set; }

        public string BrokerageGSTIN { get; set; }

        public decimal BrokerageAmount { get; set; }

        public int CCCode { get; set; }

        public string IDARefNo { get; set; }

        public int DeptID { get; set; }

        public int SubDeptID { get; set; }
        public int IsFinal { get; set; }
    }
}