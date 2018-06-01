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
    public class BudgetUserRightsController : ApiController
    {
        BudgetUserRightsDataAccess ObjBudgetUserRightsDA = new BudgetUserRightsDataAccess();



        [HttpPost]
        public DataSet BindAllDDL(BudgetUserRightsModel ObjBudgetUserRightsModel)
        {
            DataSet UserRightsList = ObjBudgetUserRightsDA.BindAllDDL(ObjBudgetUserRightsModel);
            return UserRightsList;
        }


        [HttpPost]
        public DataSet SaveBudgetRights(BudgetUserRightsModel ObjBudgetUserRightsModel)
        {
            DataSet UserRightsList = ObjBudgetUserRightsDA.SaveBudgetRights(ObjBudgetUserRightsModel);
            return UserRightsList;
        }


        [HttpPost]
        public DataTable AllotedBudgetRights(BudgetUserRightsModel ObjBudgetUserRightsModel)
        {
            DataTable UserRightsList = ObjBudgetUserRightsDA.AllotedBudgetRights(ObjBudgetUserRightsModel);
            return UserRightsList;
        }




    }
}
