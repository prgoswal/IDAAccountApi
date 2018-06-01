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
    public class GSTR1EntryController : ApiController
    {
        Gstr1DataAccess objGstr1DA = new Gstr1DataAccess();
        [HttpPost]
        public DataTable FillGistnNo(Gstr1EntryModel objGstr1Model)
        {
            DataTable GstinList = objGstr1DA.FillGistnNo(objGstr1Model);
            return GstinList;
        } 
        [HttpPost] 
        public DataTable Gstr1Search(Gstr1EntryModel objGstr1Model)
        {
            DataTable GstrSearch = objGstr1DA.Gstr1Search(objGstr1Model);
            return GstrSearch;
        }


        [HttpPost]
        public DataTable Gstr1Saved(Gstr1EntryModel objGstr1Model)
        {
            DataTable GstrSave = objGstr1DA.Gstr1Saved(objGstr1Model);
            return GstrSave;
        }
    }
}
