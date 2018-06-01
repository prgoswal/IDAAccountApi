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
    public class AdvancedSuppReceivedController : ApiController
    {
        AdvancedSuppReceivedDataAccess objAdvSupRecDA = new AdvancedSuppReceivedDataAccess();
        [HttpPost]
        public DataSet AdSuppReceived(AdvSuppReceivedModel objAdvSupReceived)
        {
            objAdvSupReceived.Ind = 1;
            DataSet DtAdRec = objAdvSupRecDA.AdvSuupReceived(objAdvSupReceived); 

            DtAdRec.Tables[0].TableName = "CashBankAccount";
            DtAdRec.Tables[1].TableName = "AccountHead";
            DtAdRec.Tables[2].TableName = "ItemList";
            DtAdRec.Tables[3].TableName = "Narration";
            DtAdRec.Tables[4].TableName = "LastVoucherNo";

            return DtAdRec;
        }
        [HttpPost]
        public DataTable FillItemRate(AdvSuppReceivedModel objAdvSupReceived)
        {
            //DataTable ItemRateDetail = objAdvSupPayDA.FillItemTaxRate(objAdvSupPayment); 
            DataTable ItemRateDeatail = objAdvSupRecDA.FillItemTaxRate(objAdvSupReceived);
            return ItemRateDeatail;
        }

        [HttpPost]
        public DataTable SaveProcess(AdvSuppReceivedModel objAdvSupReceived)
        {
            //DataTable ItemRateDetail = objAdvSupPayDA.FillItemTaxRate(objAdvSupPayment); 
            DataTable AdvSaving = objAdvSupRecDA.SavingProcess(objAdvSupReceived);
            return AdvSaving;
        } 
    }
}
