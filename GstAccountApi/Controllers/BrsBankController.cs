using GstAccountApi.Models;
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
    public class BrsBankController : ApiController
    {
        BrsBankDataAccess ObjBrsBankDA = new BrsBankDataAccess();

        [HttpPost]
        public DataSet BindAllBRSDDL(BrsBankModel objBrsBankPay)
        {
            DataSet lstBrsbnkpay = ObjBrsBankDA.BindAllBRSDDL(objBrsBankPay);
            return lstBrsbnkpay;
        }

        [HttpPost]
        public DataSet LoadGridData(BrsBankModel objBrsBankPay)
        {
            DataSet dsGvData = ObjBrsBankDA.LoadGridData(objBrsBankPay);
            return dsGvData;
        }

        [HttpPost]
        public DataSet BindBRSDateAndBalance(BrsBankModel objBrsBankPay)
        {
            DataSet dsDataAndBalance = ObjBrsBankDA.BindBRSDateAndBalance(objBrsBankPay);
            return dsDataAndBalance;
        }

        [HttpPost]
        public DataTable SaveBRS(BrsBankModel objBrsBankPay)
        {
            DataTable lstBrsbnkpay = ObjBrsBankDA.SaveBRS(objBrsBankPay);
            return lstBrsbnkpay;
        }

        [HttpPost]
        public DataSet BRSReconciliationSummary(BrsBankModel objBrsBankPay)
        {
            DataSet dsBRSReconciliationSummary = ObjBrsBankDA.BRSReconciliationSummary(objBrsBankPay);
            return dsBRSReconciliationSummary;
        }

        //[HttpPost]
        //public DataSet BRSReconciliationSummaryDetails(BrsBankModel objBrsBankPay)
        //{
        //    DataSet dsBRSReconSummDetails = ObjBrsBankDA.BRSReconciliationSummaryDetails(objBrsBankPay);
        //    return dsBRSReconSummDetails;
        //}
    }
}
