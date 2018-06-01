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
    public class UpdateSupplierAdvReceivedController : ApiController
    {
        UpdSuppSuppAdvReceivedDataAccess objUpdAdvSupPayDA = new UpdSuppSuppAdvReceivedDataAccess();
        [HttpPost]
        public DataSet AdUpdSuppRec(UpdateAdvSuppReceivedModel objUpdAdvSupReceived)
        {
            objUpdAdvSupReceived.Ind = 1;
            DataSet DtAdsup = objUpdAdvSupPayDA.AdvSuupReceived(objUpdAdvSupReceived);
            DtAdsup.Tables[0].TableName = "CashBankAccount";
            DtAdsup.Tables[1].TableName = "AccountHead";
            DtAdsup.Tables[2].TableName = "ItemList";
            DtAdsup.Tables[3].TableName = "Narration";
            DtAdsup.Tables[4].TableName = "LastVoucherNo";

            return DtAdsup;
        }

        [HttpPost]
        public DataTable SearchingProcess(UpdateAdvSuppReceivedModel objUpdAdvSupReceived)
        {
            //DataTable ItemRateDetail = objAdvSupPayDA.FillItemTaxRate(objAdvSupPayment); 
            DataTable DtSearchProcess = objUpdAdvSupPayDA.SearchingAdvRec(objUpdAdvSupReceived);
            return DtSearchProcess;
        }
         [HttpPost]
        public DataTable FillItemRate(UpdateAdvSuppReceivedModel objUpdAdvSupReceived)
        {
            //DataTable ItemRateDetail = objAdvSupPayDA.FillItemTaxRate(objAdvSupPayment); 
            DataTable ItemRateDeatail = objUpdAdvSupPayDA.FillItemTaxRate(objUpdAdvSupReceived);
            return ItemRateDeatail;
        }

        [HttpPost]
         public DataTable SaveProcess(UpdateAdvSuppReceivedModel objUpdAdvSupReceived)
        {
            //DataTable ItemRateDetail = objAdvSupPayDA.FillItemTaxRate(objAdvSupPayment); 
            DataTable AdvSaving = objUpdAdvSupPayDA.SearchProcess(objUpdAdvSupReceived);
            return AdvSaving;
        }


        [HttpPost]
        public DataTable CancelVoucher(UpdateAdvSuppReceivedModel objUpdAdvSupReceived)
        {
            DataTable dtCancel = objUpdAdvSupPayDA.CancelVoucher(objUpdAdvSupReceived);
            return dtCancel;
        }

    }
}
