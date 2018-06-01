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
    public class BudgetSubSectionController : ApiController
    {
        BudgetSubSectionDataAccess ObjBudgetSubSectionDA = new BudgetSubSectionDataAccess();

        

        [HttpPost]
        public DataTable SaveBudgetSubSection(BudgetSubSectionModel ObjBudgetSubSectionModel)
        {
            DataTable SectionList = ObjBudgetSubSectionDA.SaveBudgetSubSection(ObjBudgetSubSectionModel);
            return SectionList;
        }


        [HttpPost]
        public DataSet BindAll(BudgetSubSectionModel ObjBudgetSubSectionModel)
        {
            DataSet SectionList = ObjBudgetSubSectionDA.BindAll(ObjBudgetSubSectionModel);
            return SectionList;
        }

        [HttpPost]
        public DataTable UpdateBudgetSubSection(BudgetSubSectionModel ObjBudgetSubSectionModel)
        {
            DataTable SectionList = ObjBudgetSubSectionDA.UpdateBudgetSubSection(ObjBudgetSubSectionModel);
            return SectionList;
        }


        [HttpPost]
        public DataTable DeleteBudgetSubSection(BudgetSubSectionModel ObjBudgetSubSectionModel)
        {
            DataTable SectionList = ObjBudgetSubSectionDA.DeleteBudgetSubSection(ObjBudgetSubSectionModel);
            return SectionList;
        }
      
    }
}
