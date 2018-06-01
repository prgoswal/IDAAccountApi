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
    public class BankReceiptController : ApiController
    {
        BankReceiptDataAccess dlBankReceipt = new BankReceiptDataAccess();
       

        [HttpPost]
        public DataTable AccountHead(BankReceiptModel plbankrec)
        {
            DataTable AccHeadList = dlBankReceipt.AccountHead(plbankrec);
            return AccHeadList;
        }

        [HttpPost]
        public DataTable LastVoucherNo(BankReceiptModel plbankrec)
        {
            DataTable LastVoucherNo = dlBankReceipt.LastVoucherNo(plbankrec);
            return LastVoucherNo;
        }

        [HttpPost]
        public DataTable LoadNarration(BankReceiptModel plbankrec)
        {
            DataTable NarrationList = dlBankReceipt.LoadNarration(plbankrec);
            return NarrationList;
        }

        [HttpPost]
        public DataTable LoadBankAccount(BankReceiptModel plbankrec)
        {
            DataTable lstbnkpay = dlBankReceipt.LoadBankAccount(plbankrec);
            return lstbnkpay;
        }

        [HttpPost]
        public DataSet BindAllBankReceiptDDL(BankReceiptModel plbankrec)
        {
            DataSet dsBindAllCRDDL = dlBankReceipt.BindAllBankReceiptDDL(plbankrec);
            return dsBindAllCRDDL;
        }

        [HttpPost]
        public DataSet PartySelect(BankReceiptModel plbankrec)
        {
            DataSet dsPartySelect = new DataSet();

            plbankrec.Ind = 2;
            DataTable SecondaryParty = dlBankReceipt.PartySelect(plbankrec);
            if (SecondaryParty.Rows.Count > 0)
            {
                SecondaryParty.TableName = "SecondaryParty";
                dsPartySelect.Tables.Add(SecondaryParty);
                return dsPartySelect;
            }

            plbankrec.Ind = 3;
            DataTable OutstandingBill = dlBankReceipt.PartySelect(plbankrec);
            if (SecondaryParty.Rows.Count > 0)
            {
                SecondaryParty.TableName = "OutstandingBill";
                dsPartySelect.Tables.Add(OutstandingBill);
                return dsPartySelect;
            }

            return dsPartySelect;
        }
                
        [HttpPost]
        public DataTable SaveBankReceipt(BankReceiptModel plbankrec)
        {
            DataTable lstbnkpay = dlBankReceipt.SaveBankReceipt(plbankrec);
            return lstbnkpay;
        }

        [HttpPost]
        public DataTable CheckBudgetHead(BankReceiptModel plbankrec)
        {
            DataTable lstbnkpay = dlBankReceipt.CheckBudgetHead(plbankrec);
            return lstbnkpay;
        }

        
    }
}
