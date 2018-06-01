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
    public class ReportController : ApiController
    {
        ReportDataAccess ObjReportDA = new ReportDataAccess();

        [HttpPost]
        public DataTable LoadBankAccount(BankPaymentModel objBankPay)
        {
            DataTable lstbnkpay = ObjReportDA.LoadBankAccount(objBankPay);
            return lstbnkpay;
        }

        [HttpPost]
        public DataTable LoadCashAccount(CashPaymentModel objCashPay)
        {
            DataTable lstcashpay = ObjReportDA.LoadCashAccount(objCashPay);
            return lstcashpay;
        }

        [HttpPost]
        public DataTable BalanceSheetOnLoad(MasterModel objMaster)
        {
            DataTable dtBalanceSheetOnLoad = ObjReportDA.BalanceSheetOnLoad(objMaster);
            return dtBalanceSheetOnLoad;
        }

        [HttpPost]
        public DataTable AccountHeadLoad(BudgetReportModel ObjRptModel)
        {
            DataTable dtAccountHeadLoad = ObjReportDA.AccountHeadLoad(ObjRptModel);
            return dtAccountHeadLoad;
        } 

        [HttpPost]
        public DataTable FillScheme(BudgetReportModel ObjRptModel)
        {
            DataTable dtLoadScheme = ObjReportDA.LoadScheme(ObjRptModel);
            return dtLoadScheme;
        }

        [HttpPost]
        public DataTable FillSectionName(BudgetReportModel ObjRptModel)
        {
            DataTable dtSectioname = ObjReportDA.FillSectionName(ObjRptModel);
            return dtSectioname;
        } 


    }
}
