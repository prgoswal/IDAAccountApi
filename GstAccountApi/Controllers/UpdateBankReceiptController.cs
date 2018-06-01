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
    public class UpdateBankReceiptController : ApiController
    {
        UpdateBankReceiptDataAccess dlUpdBankRec = new UpdateBankReceiptDataAccess();

        [HttpPost]
        public DataTable AccountHead(UpdateBankReceiptModel objupdBankRec)
        {
            DataTable AccHeadList = dlUpdBankRec.AccountHead(objupdBankRec);
            return AccHeadList;
        }

        [HttpPost]
        public DataTable LastVoucherNo(UpdateBankReceiptModel objupdBankRec)
        {
            DataTable LastVoucherNo = dlUpdBankRec.LastVoucherNo(objupdBankRec);
            return LastVoucherNo;
        }

        [HttpPost]
        public DataTable LoadNarration(UpdateBankReceiptModel objupdBankRec)
        {
            DataTable NarrationList = dlUpdBankRec.LoadNarration(objupdBankRec);
            return NarrationList;
        }

        [HttpPost]
        public DataTable LoadBankAccount(UpdateBankReceiptModel objupdBankRec)
        {
            DataTable lstbnkpay = dlUpdBankRec.LoadBankAccount(objupdBankRec);
            return lstbnkpay;
        }

        [HttpPost]
        public DataSet BindAllUpdBankReceiptDDL(UpdateBankReceiptModel objupdBankRec)
        {
            DataSet dsBindAllCRDDL = dlUpdBankRec.BindAllUpdBankReceiptDDL(objupdBankRec);
            return dsBindAllCRDDL;
        }

        [HttpPost]
        public DataTable SearchBankRec(UpdateBankReceiptModel objupdBankRec)
        {
            DataTable SearchBankPayList = dlUpdBankRec.SearchBankrec(objupdBankRec);
            return SearchBankPayList;
        }

        [HttpPost]
        public DataTable UpdateBankRec(UpdateBankReceiptModel objupdBankRec)
        {
            DataTable updateBankPayList = dlUpdBankRec.UpdateBankrec(objupdBankRec);
            return updateBankPayList;
        }

        [HttpPost]
        public DataTable CancelVoucher(UpdateBankReceiptModel objupdBankRec)
        {
            DataTable dtCancelVoucher = dlUpdBankRec.CancelVoucher(objupdBankRec);
            return dtCancelVoucher;
        }

        [HttpPost]
        public DataTable CheckBudgetHead(UpdateBankReceiptModel objupdBankRec)
        {
            DataTable updateBankPayList = dlUpdBankRec.CheckBudgetHead(objupdBankRec);
            return updateBankPayList;
        }

    }
}
