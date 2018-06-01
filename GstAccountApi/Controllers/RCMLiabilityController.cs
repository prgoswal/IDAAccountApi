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
    public class RCMLiabilityController : ApiController
    {
        RCMLiabilityDataAccess objRCMLiaDA = new RCMLiabilityDataAccess();

        
        [HttpPost]
        public DataSet DisplayPVItemRecord(RCMLiabilityModel objRCMLiaModel)
        {
            DataSet dsDisplayPVItemRecord = objRCMLiaDA.DisplayPVItemRecord(objRCMLiaModel);
            return dsDisplayPVItemRecord;
        }

        [HttpPost]
        public DataTable BindGSTIN(RCMLiabilityModel objRCMLiaModel)
        {
            DataTable dtGSTIN = objRCMLiaDA.BindGSTIN(objRCMLiaModel);
            return dtGSTIN;
        }

        [HttpPost]
        public DataTable SaveRCMLiability(RCMLiabilityModel objRCMLiaModel)
        {
            DataTable dtSave = objRCMLiaDA.SaveRCMLiability(objRCMLiaModel);
            return dtSave;
        }
    }
}
