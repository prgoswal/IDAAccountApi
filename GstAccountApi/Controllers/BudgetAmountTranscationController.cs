
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
    public class BudgetAmountTranscationController : ApiController
    {
        BudgetAmountTranscationDataAccess ObjBudgetAmountTranscationDA = new BudgetAmountTranscationDataAccess();

        [HttpPost]
        public DataSet BindAll(BudgetAmountTranscationModel ObjBudgetAmountTranscationModel)
        {
            DataSet dsAmountModel = ObjBudgetAmountTranscationDA.BindAll(ObjBudgetAmountTranscationModel);
            return dsAmountModel;
        }


        public DataTable SaveBudget(BudgetAmountTranscationModel ObjBudgetAmountTranscationModel)
        {
            DataTable dtAmountModel = ObjBudgetAmountTranscationDA.SaveBudgetAmount(ObjBudgetAmountTranscationModel);
            return dtAmountModel;
        }

        public DataTable CheckBudgetAmount(BudgetAmountTranscationModel ObjBudgetAmountTranscationModel)
        {
            DataTable dtAmountModel = ObjBudgetAmountTranscationDA.CheckBudgetAmount(ObjBudgetAmountTranscationModel);
            return dtAmountModel;
        }



    }
}
