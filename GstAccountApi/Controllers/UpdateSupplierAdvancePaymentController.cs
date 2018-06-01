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
    public class UpdateSupplierAdvancePaymentController : ApiController
    {
        UpdSuppAdvanceDataAccess objUpdAdvSupPayDA = new UpdSuppAdvanceDataAccess();
        [HttpPost]
        public DataSet AdUpdSuppPay(UpdSuppAdvancePaymentModel objUpdAdvSupPayment)
        {
            objUpdAdvSupPayment.Ind = 1;
            DataSet DtAdsup = objUpdAdvSupPayDA.AdUpdSuppPay(objUpdAdvSupPayment);
            DtAdsup.Tables[0].TableName = "CashBankAccount";
            DtAdsup.Tables[1].TableName = "AccountHead";
            DtAdsup.Tables[2].TableName = "ItemList";
            DtAdsup.Tables[3].TableName = "Narration";
            DtAdsup.Tables[4].TableName = "LastVoucherNo";

            return DtAdsup;
        }

        [HttpPost]
        public DataTable SearchingProcess(UpdSuppAdvancePaymentModel objUpdAdvSupPayment)
        {
            //DataTable ItemRateDetail = objAdvSupPayDA.FillItemTaxRate(objAdvSupPayment); 
            DataTable DtSearchProcess = objUpdAdvSupPayDA.SearchingAdvRec(objUpdAdvSupPayment);
            return DtSearchProcess;
        }
        [HttpPost]
        public DataTable FillItemRate(UpdSuppAdvancePaymentModel objUpdAdvSupPayment)
        {
            //DataTable ItemRateDetail = objAdvSupPayDA.FillItemTaxRate(objAdvSupPayment); 
            DataTable ItemRateDeatail = objUpdAdvSupPayDA.FillItemTaxRate(objUpdAdvSupPayment);
            return ItemRateDeatail;
        }

        [HttpPost]
        public DataTable SaveProcess(UpdSuppAdvancePaymentModel objUpdAdvSupPayment)
        {
            //DataTable ItemRateDetail = objAdvSupPayDA.FillItemTaxRate(objAdvSupPayment); 
            DataTable AdvSaving = objUpdAdvSupPayDA.SearchProcess(objUpdAdvSupPayment);
            return AdvSaving;
        }

        [HttpPost]
        public DataTable CancelVoucher(UpdSuppAdvancePaymentModel objUpdAdvSupPayment)
        {
            DataTable dtCancel = objUpdAdvSupPayDA.CancelVoucher(objUpdAdvSupPayment);
            return dtCancel;
        }

    }
}
