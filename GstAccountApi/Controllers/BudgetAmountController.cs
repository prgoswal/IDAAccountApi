
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
    public class BudgetAmountController : ApiController
    {
        BudgetAmountDataAccess ObjBudgetAmountDA = new BudgetAmountDataAccess();

        [HttpPost]
        public DataSet BindAll(BudgetAmountModel ObjBudgetAmountModel)
        {
            DataSet dsAmountModel = ObjBudgetAmountDA.BindAll(ObjBudgetAmountModel);
            return dsAmountModel;
        }


        public DataTable SaveBudget(BudgetAmountModel ObjBudgetAmountModel)
        {
            DataTable dtAmountModel = ObjBudgetAmountDA.SaveBudgetAmount(ObjBudgetAmountModel);
            return dtAmountModel;
        }

        public DataTable CheckBudgetAmount(BudgetAmountModel ObjBudgetAmountModel)
        {
            DataTable dtAmountModel = ObjBudgetAmountDA.CheckBudgetAmount(ObjBudgetAmountModel);
            return dtAmountModel;
        }



    }
}
