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
    public class AdvanceRefundController : ApiController
    {
        AdvanceRefundDataAccess objARDA = new AdvanceRefundDataAccess();

        [HttpPost]
        public DataSet BindAllDDl(AdvanceRefundModel objARModel)
        {
            DataSet dsBindAllDDl = objARDA.BindAllDDl(objARModel);
            return dsBindAllDDl;
        }

        [HttpPost]
        public DataSet LoadAdvanceRefundInfo(AdvanceRefundModel objARModel)
        {
            DataSet dsLoadARInfo = objARDA.LoadAdvanceRefundInfo(objARModel);
            return dsLoadARInfo;
        }

        [HttpPost]
        public DataTable SaveAdvanceRefund(AdvanceRefundModel objARModel)
        {
            DataTable dtSaveAR = objARDA.SaveAdvanceRefund(objARModel);
            return dtSaveAR;
        }
    }
}
