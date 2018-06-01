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
    public class BudgetSectionController : ApiController
    {
        BudgetSectionDataAccess ObjBudgetSectionDA = new BudgetSectionDataAccess();

        

        [HttpPost]
        public DataTable SaveBudgetSection(BudgetSectionModel ObjBudgetSectionModel)
        {
            DataTable SectionList = ObjBudgetSectionDA.SaveBudgetSection(ObjBudgetSectionModel);
            return SectionList;
        }


        [HttpPost]
        public DataTable BindAll(BudgetSectionModel ObjBudgetSectionModel)
        {
            DataTable SectionList = ObjBudgetSectionDA.BindAll(ObjBudgetSectionModel);
            return SectionList;
        }

        [HttpPost]
        public DataTable UpdateBudgetSection(BudgetSectionModel ObjBudgetSectionModel)
        {
            DataTable SectionList = ObjBudgetSectionDA.UpdateBudgetSection(ObjBudgetSectionModel);
            return SectionList;
        }

        [HttpPost]
        public DataTable DeleteBudgetSection(BudgetSectionModel ObjBudgetSectionModel)
        {
            DataTable SectionList = ObjBudgetSectionDA.DeleteBudgetSection(ObjBudgetSectionModel);
            return SectionList;
        }

      
    }
}
