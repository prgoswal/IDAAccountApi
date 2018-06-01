using GstAccountApi.Models;
using GstAccountApi.Models.DL;
using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GstAccountApi.Controllers
{
    public class CashReceiptController : ApiController
    {
        CashReceiptDataAccess dlCashReceipt = new CashReceiptDataAccess();


        [HttpPost]
        public DataTable AccountHead(CashReceiptModel plcashrec)
        {
            DataTable AccHeadList = dlCashReceipt.AccountHead(plcashrec);
            return AccHeadList;
        }

        [HttpPost]
        public DataTable LastVoucherNo(CashReceiptModel plcashrec)
        {
            DataTable LastVoucherNo = dlCashReceipt.LastVoucherNo(plcashrec);
            return LastVoucherNo;
        }

        [HttpPost]
        public DataTable LoadNarration(CashReceiptModel plcashrec)
        {

            DataTable NarrationList = dlCashReceipt.LoadNarration(plcashrec);
            return NarrationList;
        }

        public DataTable LoadCashAccount(CashReceiptModel plcashrec)
        {
            DataTable lstcashrec = dlCashReceipt.LoadCashAccount(plcashrec);
            return lstcashrec;
        }

        [HttpPost]
        public DataSet BindAllCashReceiptDDL(CashReceiptModel plcashrec)
        {
            DataSet dsBindAllCRDDL = dlCashReceipt.BindAllCashReceiptDDL(plcashrec);
            return dsBindAllCRDDL;
        }

        [HttpPost]
        public DataSet PartySelect(CashReceiptModel plcashrec)
        {
            DataSet dsPartySelect = new DataSet();

            plcashrec.Ind = 2;
            DataTable SecondaryParty = dlCashReceipt.PartySelect(plcashrec);
            if (SecondaryParty.Rows.Count > 0)
            {
                SecondaryParty.TableName = "SecondaryParty";
                dsPartySelect.Tables.Add(SecondaryParty);
                return dsPartySelect;
            }

            plcashrec.Ind = 3;
            DataTable OutstandingBill = dlCashReceipt.PartySelect(plcashrec);
            if (SecondaryParty.Rows.Count > 0)
            {
                SecondaryParty.TableName = "OutstandingBill";
                dsPartySelect.Tables.Add(OutstandingBill);
                return dsPartySelect;
            }

            return dsPartySelect;
        }

        [HttpPost]
        public DataTable SaveCashReceipt(CashReceiptModel plcashrec)
        {
            DataTable lstcashrec = dlCashReceipt.SaveCashReceipt(plcashrec);
            return lstcashrec;
        }


        [HttpPost]
        public DataTable CheckBudgetHead(CashReceiptModel plcashrec)
        {
            DataTable lstcashrec = dlCashReceipt.CheckBudgetHead(plcashrec);
            return lstcashrec;
        }

    }
}
