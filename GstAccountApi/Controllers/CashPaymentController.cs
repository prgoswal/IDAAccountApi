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
   
    public class CashPaymentController : ApiController
    {
        CashPaymentDataAccess dlCashPayment = new CashPaymentDataAccess();
        DataTable dtCancelVoucher;

        [HttpPost]
        public DataTable AccountHead(CashPaymentModel plcashpay)
        {
            DataTable AccHeadList = dlCashPayment.AccountHead(plcashpay);
            return AccHeadList;
        }

        [HttpPost]
        public DataTable LastVoucherNo(CashPaymentModel plcashpay)
        {
            DataTable LastVoucherNo = dlCashPayment.LastVoucherNo(plcashpay);
            return LastVoucherNo;
        }

        [HttpPost]
        public DataTable LoadNarration(CashPaymentModel plcashpay)
        {

            DataTable NarrationList = dlCashPayment.LoadNarration(plcashpay);
            return NarrationList;
        }

        [HttpPost]
        public DataTable LoadCashAccount(CashPaymentModel plcashpay)
        {
            DataTable lstcashpay = dlCashPayment.LoadCashAccount(plcashpay);
            return lstcashpay;
        }

        [HttpPost]
        public DataSet BindAllCashPaymentDDL(CashPaymentModel plcashpay)
        {
            DataSet dsBindAllCPDDL = dlCashPayment.BindAllCashPaymentDDL(plcashpay);
            return dsBindAllCPDDL;
        }

        [HttpPost]
        public DataSet PartySelect(CashPaymentModel plcashpay)
        {
            DataSet dsPartySelect = new DataSet();

            plcashpay.Ind = 2;
            DataTable SecondaryParty = dlCashPayment.PartySelect(plcashpay);
            if (SecondaryParty.Rows.Count > 0)
            {
                SecondaryParty.TableName = "SecondaryParty";
                dsPartySelect.Tables.Add(SecondaryParty);
                return dsPartySelect;
            }

            plcashpay.Ind = 3;
            DataTable OutstandingBill = dlCashPayment.PartySelect(plcashpay);
            if (SecondaryParty.Rows.Count > 0)
            {
                SecondaryParty.TableName = "OutstandingBill";
                dsPartySelect.Tables.Add(OutstandingBill);
                return dsPartySelect;
            }

            return dsPartySelect;
        }

        [HttpPost]
        public DataTable SaveCashPayment(CashPaymentModel plcashpay)
        {
            DataTable lstcashpay = dlCashPayment.SaveCashPayment(plcashpay);
            return lstcashpay;
        }


        [HttpPost]
        public DataTable CheckBudgetHead(CashPaymentModel plcashpay)
        {
            DataTable lstcashpay = dlCashPayment.CheckBudgetHead(plcashpay);
            return lstcashpay;
        }

    }
}
