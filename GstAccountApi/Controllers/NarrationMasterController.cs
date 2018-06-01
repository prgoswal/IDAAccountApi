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
    public class NarrationMasterController : ApiController
    {
        NarrationMasterDataAccess objNarrMasterDA;

        [HttpPost]
        public DataTable FillVoucher(NarrationMasterModel ObjNrrationMastModel)
        {
            objNarrMasterDA = new NarrationMasterDataAccess();

            DataTable fillVoucherType = objNarrMasterDA.LoadVoucherType(ObjNrrationMastModel);
            return fillVoucherType;
        }

        [HttpPost]
        public DataTable FillGrid(NarrationMasterModel ObjNrrationMastModel) 

        {
            objNarrMasterDA = new NarrationMasterDataAccess();

            DataTable fillGrid = objNarrMasterDA.FillGridView(ObjNrrationMastModel);
            return fillGrid;
            
        }
        [HttpPost]
        public DataTable SaveProcess(NarrationMasterModel ObjNrrationMastModel)
        {
            objNarrMasterDA = new NarrationMasterDataAccess();

            DataTable SaveList = objNarrMasterDA.SaveNarration(ObjNrrationMastModel);
            return SaveList;

        }
    }
}
