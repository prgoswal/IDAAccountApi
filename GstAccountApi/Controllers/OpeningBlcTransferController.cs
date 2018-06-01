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
    public class OpeningBlcTransferController : ApiController
    {
        OpeningBlcTransferDataAccess ObjOpeningBlcTransferDA = new OpeningBlcTransferDataAccess();



        [HttpPost]
        public DataTable LoadClosingBalance(OpeningBlcTransferModel ObjOpeningBlcTransfer)
        {
            DataTable ClosingBlcList = ObjOpeningBlcTransferDA.LoadClosingBalance(ObjOpeningBlcTransfer);
            return ClosingBlcList;
        }

        [HttpPost]
        public DataTable SaveOpeningBalance(OpeningBlcTransferModel ObjOpeningBlcTransfer)
        {
            DataTable ClosingBlcList = ObjOpeningBlcTransferDA.SaveOpeningBalance(ObjOpeningBlcTransfer);
            return ClosingBlcList;
        }





      
    }
}
