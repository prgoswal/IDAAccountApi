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
    public class HSNSACController : ApiController
    {
        HSNSACDataAccess objHSNSACDA = new HSNSACDataAccess();

        [HttpPost]
        public DataTable LoadHSNSACInfo(HSNSACModel objHSNSACModel)
        {
            DataTable dtHSNSACInfo = objHSNSACDA.LoadHSNSACInfo(objHSNSACModel);
            return dtHSNSACInfo;
        }

        [HttpPost]
        public DataTable UpdateHSNSACInfo(HSNSACModel objHSNSACModel)
        { 
            DataTable dtUpdateHSNSACInfo=objHSNSACDA.UpdateHSNSACInfo(objHSNSACModel);
            return dtUpdateHSNSACInfo;
        }
    }
}
