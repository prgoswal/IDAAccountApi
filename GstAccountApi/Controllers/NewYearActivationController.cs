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
    public class NewYearActivationController : ApiController
    {
        NewYearActivationDataAccess ObjBudgetYearActivationDA = new NewYearActivationDataAccess();

        public DataTable SaveFinancialYear(OpeningBlcTransferModel ObjOpeningBlcTransferModel)
        {
            DataTable dtAmountModel = ObjBudgetYearActivationDA.SaveFinancialYear(ObjOpeningBlcTransferModel);
            return dtAmountModel;
        }
        public DataTable LoadFinancialYear(OpeningBlcTransferModel ObjOpeningBlcTransferModel)
        {
            DataTable dtAmountModel = ObjBudgetYearActivationDA.LoadFinancialYear(ObjOpeningBlcTransferModel);
            return dtAmountModel;
        }

        public DataTable LoadClosingBalance(OpeningBlcTransferModel ObjOpeningBlcTransferModel)
        {
            DataTable dtAmountModel = ObjBudgetYearActivationDA.LoadClosingBalance(ObjOpeningBlcTransferModel);
            return dtAmountModel;
        }

        public DataTable SaveOpeningBalance(OpeningBlcTransferModel ObjOpeningBlcTransfer)
        {
            DataTable dtAmountModel = ObjBudgetYearActivationDA.SaveOpeningBalance(ObjOpeningBlcTransfer);
            return dtAmountModel;
        }

        public DataTable TrasferItemOpeningBlc(OpeningBlcTransferModel ObjOpeningBlcTransfer)
        {
            DataTable dtAmountModel = ObjBudgetYearActivationDA.TrasferItemOpeningBlc(ObjOpeningBlcTransfer);
            return dtAmountModel;
        }

        public DataTable ItemDetails(OpeningBlcTransferModel ObjOpeningBlcTransfer)
        {
            DataTable dtAmountModel = ObjBudgetYearActivationDA.ItemDetails(ObjOpeningBlcTransfer);
            return dtAmountModel;
        }

    }
}
