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
    public class TransporterController : ApiController
    {
        TransporterDetailsDataAccess ObjTransporterDetailDA = new TransporterDetailsDataAccess();

        [HttpPost]
        public DataTable SaveTranspoter(TransporterDetailModal ObjTransporterModel)
        {
            DataTable TransporterList = ObjTransporterDetailDA.SaveTransporterDetail(ObjTransporterModel);
            return TransporterList;
        }

        [HttpPost]
        public DataSet BindAll(TransporterDetailModal ObjTransporterModel)
        {
            DataSet SectionList = ObjTransporterDetailDA.BindAll(ObjTransporterModel);
            return SectionList;
        }
    }
}