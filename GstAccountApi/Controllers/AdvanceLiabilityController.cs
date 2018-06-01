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
    public class AdvanceLiabilityController : ApiController
    {
        AdvanceLiabilityDataAccess  ObjAdvLiaDA = new AdvanceLiabilityDataAccess();

        public DataSet DisplayAdvance(AdvanceLiabilityModel ObjALModel)
        {
            DataSet dsDisplayAdvance = ObjAdvLiaDA.DisplayAdvance(ObjALModel);
            return dsDisplayAdvance;
        }

        public DataTable SaveAdvance(AdvanceLiabilityModel ObjALModel)
        {
            DataTable dtSaveAdvance = ObjAdvLiaDA.SaveAdvance(ObjALModel);
            return dtSaveAdvance;
        }
    }
}
