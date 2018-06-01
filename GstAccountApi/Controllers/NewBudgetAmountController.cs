
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
    public class NewBudgetAmountController : ApiController
    {
        NewBudgetAmountDataAccess ObjNewBudgetAmountDA = new NewBudgetAmountDataAccess();

        [HttpPost]
        public DataSet BindAll(NewBudgetAmountModel ObjNewBudgetAmountModel)
        {
            DataSet dsAmountModel = ObjNewBudgetAmountDA.BindAll(ObjNewBudgetAmountModel);
            return dsAmountModel;
        }


        public DataTable SaveBudget(NewBudgetAmountModel ObjNewBudgetAmountModel)
        {
            DataTable dtAmountModel = ObjNewBudgetAmountDA.SaveBudgetAmount(ObjNewBudgetAmountModel);
            return dtAmountModel;
        }

        public DataTable CheckBudgetAmount(NewBudgetAmountModel ObjNewBudgetAmountModel)
        {
            DataTable dtAmountModel = ObjNewBudgetAmountDA.CheckBudgetAmount(ObjNewBudgetAmountModel);
            return dtAmountModel;
        }

        public DataTable BindAllocatedScheme(NewBudgetAmountModel ObjNewBudgetAmountModel)
        {
            DataTable dtAmountModel = ObjNewBudgetAmountDA.BindAllocatedScheme(ObjNewBudgetAmountModel);
            return dtAmountModel;
        }



    }
}
