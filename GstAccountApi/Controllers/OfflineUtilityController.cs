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
    public class OfflineUtilityController : ApiController
    {
        OfflineUtilityDataAccess ObjOfflineUtilityDA = new OfflineUtilityDataAccess();

        
        [HttpPost]
        public DataTable LoadBranch(OfflineUtilityModel ObjOfflineUtilityModel)
        {
            DataTable BranchList = ObjOfflineUtilityDA.LoadBranch(ObjOfflineUtilityModel);
            return BranchList;
        }


        [HttpPost]
        public DataTable SaveOfflineRequest(OfflineUtilityModel ObjOfflineUtilityModel)
        {
            DataTable BranchList = ObjOfflineUtilityDA.SaveOfflineRequest(ObjOfflineUtilityModel);
            return BranchList;
        }
      
      
    }
}
