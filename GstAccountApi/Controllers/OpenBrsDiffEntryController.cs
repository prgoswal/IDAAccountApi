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
    public class OpenBrsDiffEntryController : ApiController
    {
        OpenBrsDiffDataAccess ObjbrsDiff = new OpenBrsDiffDataAccess();

        [HttpPost]
        public DataTable LoadBankAccount(OpenBrsDiffModel objBrsOpenDiffEntery)
        {
            DataTable lstBrsbnkpay = ObjbrsDiff.LoadBankAccount(objBrsOpenDiffEntery);
            return lstBrsbnkpay;
        }

        [HttpPost]
        public DataTable SaveOpenBrs(OpenBrsDiffModel objBrsOpenDiffEntery)
        {
            DataTable SaveopenBrs = ObjbrsDiff.SaveOpenBrs(objBrsOpenDiffEntery);
            return SaveopenBrs;
        }
    }
}
