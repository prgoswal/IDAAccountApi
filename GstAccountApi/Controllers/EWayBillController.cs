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
    public class EWayBillController : ApiController
    {
        EWayBillDataAccess ObjEWayBillDataAccess;
        UserModel objUCModel;

        [HttpPost]
        public DataTable LoadEWayBill(UserModel objUCModel)
        {
            DataTable dtBill = ObjEWayBillDataAccess.LoadEWayBill(objUCModel);
            return dtBill;
        }

      
    }
}
