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
    public class AdvancedSuppPaymentController : ApiController
    {
        AdvancedSupppaymentDataAccess objAdvSupPayDA = new AdvancedSupppaymentDataAccess();
        [HttpPost]
        public DataSet AdSuppPay(AdvSuppPaymentModel objAdvSupPayment)
        {
            objAdvSupPayment.Ind = 1;
            DataSet DtAdsup = objAdvSupPayDA.AdSuppPay(objAdvSupPayment);
            DtAdsup.Tables[0].TableName = "CashBankAccount";
            DtAdsup.Tables[1].TableName = "AccountHead";
            DtAdsup.Tables[2].TableName = "ItemList";
            DtAdsup.Tables[3].TableName = "Narration";
            DtAdsup.Tables[4].TableName = "LastVoucherNo"; 

            return DtAdsup;
        } 


        [HttpPost]
        public DataTable FillItemRate(AdvSuppPaymentModel objAdvSupPayment)
        {
            //DataTable ItemRateDetail = objAdvSupPayDA.FillItemTaxRate(objAdvSupPayment); 
            DataTable ItemRateDeatail = objAdvSupPayDA.FillItemTaxRate(objAdvSupPayment);
            return ItemRateDeatail;
        }

        [HttpPost]
        public DataTable SaveingpaymentProcess(AdvSuppPaymentModel objAdvSupPayment)
        {
            //DataTable ItemRateDetail = objAdvSupPayDA.FillItemTaxRate(objAdvSupPayment); 
            DataTable DtSaveProcess = objAdvSupPayDA.SavingAdvPay(objAdvSupPayment);
            return DtSaveProcess;
        }
       
    }
}
