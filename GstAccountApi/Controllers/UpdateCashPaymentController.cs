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
    public class UpdateCashPaymentController : ApiController
    {
        UpdCashPaymentDataAccess UpdCashPaymentDA = new UpdCashPaymentDataAccess();
        [HttpPost]
        public DataTable AccountHead(UpdCashPaymentModel objUpdCashPay)
        {
            DataTable AccHeadList = UpdCashPaymentDA.AccountHead(objUpdCashPay);
            return AccHeadList;
        }

        //[HttpPost]
        //public DataTable LastVoucherNo(UpdCashPaymentModel objUpdCashPay)
        //{
        //    DataTable LastVoucherNo = UpdCashPaymentDA.LastVoucherNo(objUpdCashPay);
        //    return LastVoucherNo;
        //}

        [HttpPost]
        public DataTable LoadNarration(UpdCashPaymentModel objUpdCashPay)
        {

            DataTable NarrationList = UpdCashPaymentDA.LoadNarration(objUpdCashPay);
            return NarrationList;
        }

        [HttpPost]
        public DataTable LoadCashAccount(UpdCashPaymentModel objUpdCashPay)
        {
            DataTable lstcashpay = UpdCashPaymentDA.LoadCashAccount(objUpdCashPay);
            return lstcashpay;
        }

        [HttpPost]
        public DataSet BindAllUpdCashPaymentDDL(UpdCashPaymentModel objUpdCashPay)
        {
            DataSet dsBindAllCPDDL = UpdCashPaymentDA.BindAllUpdCashPaymentDDL(objUpdCashPay);
            return dsBindAllCPDDL;
        }

        [HttpPost]
        public DataTable SearchCashPay(UpdCashPaymentModel objUpdCashPay)
        {
            DataTable SearchCashpayList = UpdCashPaymentDA.SearchCashPay(objUpdCashPay);
            return SearchCashpayList;
        }

        [HttpPost]
        public DataTable UpdateCashPay(UpdCashPaymentModel objUpdCashPay)
        {
            DataTable UpdateCashPayList = UpdCashPaymentDA.UpdateCashPay(objUpdCashPay);
            return UpdateCashPayList;
        }

        [HttpPost]
        public DataTable CancelVoucher(UpdCashPaymentModel objUpdCashPay)
        {
            DataTable dtCancelVoucher = UpdCashPaymentDA.CancelVoucher(objUpdCashPay);
            return dtCancelVoucher;
        }

        [HttpPost]
        public DataTable CheckBudgetHead(UpdCashPaymentModel objUpdCashPay)
        {
            DataTable UpdateCashPayList = UpdCashPaymentDA.CheckBudgetHead(objUpdCashPay);
            return UpdateCashPayList;
        }

    }
}
