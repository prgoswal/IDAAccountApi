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
    public class BudgetYearActivationController : ApiController
    {
        BudgetYearActivationDataAccess ObjBudgetYearActivationDA = new BudgetYearActivationDataAccess();

        public DataTable SaveFinancialYear(BudgetYearActivationModel ObjBudgetYearActivationModel)
        {
            DataTable dtAmountModel = ObjBudgetYearActivationDA.SaveFinancialYear(ObjBudgetYearActivationModel);
            return dtAmountModel;
        }
        public DataTable LoadFinancialYear(BudgetYearActivationModel ObjBudgetYearActivationModel)
        {
            DataTable dtAmountModel = ObjBudgetYearActivationDA.LoadFinancialYear(ObjBudgetYearActivationModel);
            return dtAmountModel;
        }



    }
}
