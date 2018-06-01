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
    public class UpdateCashReceiptController : ApiController
    {
        UpdateCashReceiptDataAccess objUpdCashReceiptDA = new UpdateCashReceiptDataAccess();
        [HttpPost]
        public DataTable LoadCashAccount(UpdateCashReceiptModel objUpdCashRec)
        {
            DataTable lstcashrec = objUpdCashReceiptDA.LoadCashAccount(objUpdCashRec);
            return lstcashrec;
        }
        [HttpPost]
        public DataTable AccountHead(UpdateCashReceiptModel objUpdCashRec)
        {
            DataTable AccHeadList = objUpdCashReceiptDA.AccountHead(objUpdCashRec);
            return AccHeadList;
        }

        [HttpPost]
        public DataTable LoadNarration(UpdateCashReceiptModel objUpdCashRec)
        {
            DataTable NarrationList = objUpdCashReceiptDA.LoadNarration(objUpdCashRec);
            return NarrationList;
        }

        [HttpPost]
        public DataSet BindAllUpdCashReceiptDDL(UpdateCashReceiptModel objUpdCashRec)
        {
            DataSet dsBindAllCRDDL = objUpdCashReceiptDA.BindAllUpdCashReceiptDDL(objUpdCashRec);
            return dsBindAllCRDDL;
        }

        [HttpPost]
        public DataTable SearchCashReceipt(UpdateCashReceiptModel objUpdCashRec)
        {
            DataTable SearchCashReceiptList = objUpdCashReceiptDA.SearchCashReceipt(objUpdCashRec);
            return SearchCashReceiptList;
        }

        [HttpPost]
        public DataTable UpdateCashReceipt(UpdateCashReceiptModel objUpdCashRec)
        {
            DataTable UpdateCashReceiptList = objUpdCashReceiptDA.UpdateCashReceipt(objUpdCashRec);
            return UpdateCashReceiptList;
        }

        [HttpPost]
        public DataTable CancelVoucher(UpdateCashReceiptModel objUpdCashRec)
        {
            DataTable dtCancelVoucher = objUpdCashReceiptDA.CancelVoucher(objUpdCashRec);
            return dtCancelVoucher;
        }

        [HttpPost]
        public DataTable CheckBudgetHead(UpdateCashReceiptModel objUpdCashRec)
        {
            DataTable lstcashrec = objUpdCashReceiptDA.CheckBudgetHead(objUpdCashRec);
            return lstcashrec;
        }
    }
}
