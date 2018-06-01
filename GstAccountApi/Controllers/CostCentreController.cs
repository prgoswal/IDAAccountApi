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
    public class CostCentreController : ApiController
    {
        CostCentreDataAccess ObjCostCentreDA = new CostCentreDataAccess();

        
        [HttpPost]
        public DataTable LoadMainCost(CostCentreModel ObjCostCentreModel)
        {
            DataTable CostCentreList = ObjCostCentreDA.LoadMainCost(ObjCostCentreModel);
            return CostCentreList;
        }
        [HttpPost]
        public DataTable SaveCostCentre(CostCentreModel ObjCostCentreModel)
        {
            DataTable CostCentreList = ObjCostCentreDA.SaveCostCentre(ObjCostCentreModel);
            return CostCentreList;
        }

        [HttpPost]
        public DataTable LoadCostCentreGrid(CostCentreModel ObjCostCentreModel)
        {
            DataTable CostCentreList = ObjCostCentreDA.LoadMainCost(ObjCostCentreModel);
            return CostCentreList;
        }


        [HttpPost]
        public DataTable DeleteCostCentre(CostCentreModel ObjCostCentreModel)
        {
            DataTable CostCentreList = ObjCostCentreDA.DeleteCostCentre(ObjCostCentreModel);
            return CostCentreList;
        }
       
    }
}
