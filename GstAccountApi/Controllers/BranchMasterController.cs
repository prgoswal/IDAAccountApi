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
    public class BranchMasterController : ApiController
    {
        BranchMasterDataAccess objBMDA = new BranchMasterDataAccess();

        [HttpPost]
        public DataSet LoadBMDDL(BranchMasterModel objBMModel)
        {
            DataSet dsLoadBMDDL = objBMDA.LoadBMDDL(objBMModel);
            return dsLoadBMDDL;
        }

        [HttpPost]
        public DataTable LoadGSTINDetails(BranchMasterModel objBMModel)
        {
            DataTable dtLoadGSTINDetails = objBMDA.LoadGSTINDetails(objBMModel);
            return dtLoadGSTINDetails;
        }

        [HttpPost]
        public DataTable SaveBranch(BranchMasterModel objBMModel)
        {
            DataTable dtSaveBranch = objBMDA.SaveBranch(objBMModel);
            return dtSaveBranch;
        }
    }
}
