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
    public class SectionSubSectionController : ApiController
    {
        SectionSubSectionDataAccess ObjSectionSubSectionDA = new SectionSubSectionDataAccess();

        
        [HttpPost]
        public DataTable LoadMainCost(SectionSubSectionModel ObjSectionSubSectionModel)
        {
            DataTable CostCentreList = ObjSectionSubSectionDA.LoadMainCost(ObjSectionSubSectionModel);
            return CostCentreList;
        }
        [HttpPost]
        public DataTable SaveCostCentre(SectionSubSectionModel ObjSectionSubSectionModel)
        {
            DataTable CostCentreList = ObjSectionSubSectionDA.SaveCostCentre(ObjSectionSubSectionModel);
            return CostCentreList;
        }

        [HttpPost]
        public DataTable LoadCostCentreGrid(SectionSubSectionModel ObjSectionSubSectionModel)
        {
            DataTable CostCentreList = ObjSectionSubSectionDA.LoadMainCost(ObjSectionSubSectionModel);
            return CostCentreList;
        }


        [HttpPost]
        public DataTable DeleteCostCentre(SectionSubSectionModel ObjSectionSubSectionModel)
        {
            DataTable CostCentreList = ObjSectionSubSectionDA.DeleteCostCentre(ObjSectionSubSectionModel);
            return CostCentreList;
        }
       
    }
}
