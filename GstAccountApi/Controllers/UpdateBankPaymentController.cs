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
    public class UpdateBankPaymentController : ApiController
    {
        UpdBankPaymentDataAccess dlUpdBankPay = new UpdBankPaymentDataAccess();

        [HttpPost]
        public DataTable AccountHead(UpdBankPaymentModel objUpdBankPay)
        {
            DataTable AccHeadList = dlUpdBankPay.AccountHead(objUpdBankPay);
            return AccHeadList;
        }

        [HttpPost]
        public DataTable LastVoucherNo(UpdBankPaymentModel objUpdBankPay)
        {
            DataTable LastVoucherNo = dlUpdBankPay.LastVoucherNo(objUpdBankPay);
            return LastVoucherNo;
        }

        [HttpPost]
        public DataTable LoadNarration(UpdBankPaymentModel objUpdBankPay)
        {
            DataTable NarrationList = dlUpdBankPay.LoadNarration(objUpdBankPay);
            return NarrationList;
        }

        [HttpPost]
        public DataTable LoadBankAccount(UpdBankPaymentModel objUpdBankPay)
        {
            DataTable lstbnkpay = dlUpdBankPay.LoadBankAccount(objUpdBankPay);
            return lstbnkpay;
        }

        [HttpPost]
        public DataSet BindAllUpdBankPaymentDDL(UpdBankPaymentModel objUpdBankPay)
        {
            DataSet dsBindAllCRDDL = dlUpdBankPay.BindAllUpdBankPaymentDDL(objUpdBankPay);
            return dsBindAllCRDDL;
        }

        [HttpPost]
        public DataTable SearchBankPay(UpdBankPaymentModel objUpdBankPay)
        {
            DataTable SearchBankPayList = dlUpdBankPay.SearchBankPay(objUpdBankPay);
            return SearchBankPayList;
        }

        [HttpPost]
        public DataTable UpdateBankPay(UpdBankPaymentModel objUpdBankPay)
        {
            DataTable updateBankPayList = dlUpdBankPay.UpdateBankPay(objUpdBankPay);
            return updateBankPayList;
        }

        [HttpPost]
        public DataTable CancelVoucher(UpdBankPaymentModel objUpdBankPay)
        {
            DataTable dtCancelVoucher = dlUpdBankPay.CancelVoucher(objUpdBankPay);
            return dtCancelVoucher;
        }


        [HttpPost]
        public DataTable CheckBudgetHead(UpdBankPaymentModel objUpdBankPay)
        {
            DataTable updateBankPayList = dlUpdBankPay.CheckBudgetHead(objUpdBankPay);
            return updateBankPayList;
        }

    }
}
