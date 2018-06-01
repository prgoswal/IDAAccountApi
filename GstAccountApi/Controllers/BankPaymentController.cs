using GstAccountApi.Models;
using GstAccountApi.Models.DL;
using GstAccountApi.Models.PL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GstAccountApi.Controllers
{
    public class BankPaymentController : ApiController
    {
        BankPaymentDataAccess dlBankAccount = new BankPaymentDataAccess();

        [HttpPost]
        public DataTable AccountHead(BankPaymentModel objBankPay)
        {
            DataTable AccHeadList = dlBankAccount.AccountHead(objBankPay);
            return AccHeadList;
        }
        
        [HttpPost]
        public DataTable LastVoucherNo(BankPaymentModel objBankPay)
        {
            DataTable LastVoucherNo = dlBankAccount.LastVoucherNo(objBankPay);
            return LastVoucherNo;
        }

        [HttpPost]
        public DataTable LoadNarration(BankPaymentModel objBankPay)
        {
            DataTable NarrationList = dlBankAccount.LoadNarration(objBankPay);
            return NarrationList;
        }

        [HttpPost]
        public DataTable LoadBankAccount(BankPaymentModel objBankPay)
        {
            DataTable lstbnkpay = dlBankAccount.LoadBankAccount(objBankPay);
            return lstbnkpay;
        }

        [HttpPost]
        public DataSet BindAllBankPaymentDDL(BankPaymentModel objBankPay)
        {
            DataSet dsBindAllCRDDL = dlBankAccount.BindAllBankPaymentDDL(objBankPay);
            return dsBindAllCRDDL;
        }

        [HttpPost]
        public DataSet PartySelect(BankPaymentModel objBankPay)
        {
            DataSet dsPartySelect = new DataSet();

            objBankPay.Ind = 2;
            DataTable SecondaryParty = dlBankAccount.PartySelect(objBankPay);
            if (SecondaryParty.Rows.Count > 0)
            {
                SecondaryParty.TableName = "SecondaryParty";
                dsPartySelect.Tables.Add(SecondaryParty);
                return dsPartySelect;
            }

            objBankPay.Ind = 3;
            DataTable OutstandingBill = dlBankAccount.PartySelect(objBankPay);
            if (SecondaryParty.Rows.Count > 0)
            {
                SecondaryParty.TableName = "OutstandingBill";
                dsPartySelect.Tables.Add(OutstandingBill);
                return dsPartySelect;
            }

            return dsPartySelect;
        }

        [HttpPost]
        public DataTable SaveBankPayment(BankPaymentModel objBankPay)
        {
            DataTable lstbnkpay = dlBankAccount.SaveBankPayment(objBankPay);
            return lstbnkpay;
        }
        [HttpPost]
        public DataTable CheckBudgetHead(BankPaymentModel objBankPay)
        {
            DataTable lstbnkpay = dlBankAccount.CheckBudgetHead(objBankPay);
            return lstbnkpay;
        }

        
    }
}
