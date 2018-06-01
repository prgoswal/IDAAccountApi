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
    public class UpdateNarrationController : ApiController
    {
        UpdateNarrationMasterDataAccess objUpdNarrMasterDA; 
        [HttpPost]
        public DataTable FillVoucher(UpdateNarrationModel ObjUpdNrraMastModel)
        {
            objUpdNarrMasterDA = new UpdateNarrationMasterDataAccess();

            DataTable fillVoucherType = objUpdNarrMasterDA.LoadVoucherType(ObjUpdNrraMastModel);
            return fillVoucherType;
        }

        [HttpPost]
        public DataTable FillGrid(UpdateNarrationModel ObjUpdNrraMastModel)
        {
            objUpdNarrMasterDA = new UpdateNarrationMasterDataAccess();

            DataTable fillGrid = objUpdNarrMasterDA.FillGridView(ObjUpdNrraMastModel);
            return fillGrid; 
        } 

        [HttpPost]
        public DataTable UpdateProcess(UpdateNarrationModel ObjUpdNrraMastModel)
        {
            objUpdNarrMasterDA = new UpdateNarrationMasterDataAccess();

            DataTable SaveList = objUpdNarrMasterDA.UpdateNarration(ObjUpdNrraMastModel);
            return SaveList;

        }
    }
}
