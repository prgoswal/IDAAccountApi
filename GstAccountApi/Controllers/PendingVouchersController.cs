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
    public class PendingVouchersController : ApiController
    {
        PendingVouchersDataAccess objPendingVouchersDA = new PendingVouchersDataAccess();

        [HttpPost]
        public DataSet BindPendingVouchers(PendingVouchersModel objPendingVouchersModel)
        {
            DataSet dsPendingVouchers = objPendingVouchersDA.BindPendingVouchers(objPendingVouchersModel);
            return dsPendingVouchers;
        }

        [HttpPost]
        public DataTable DataApproved(PendingVouchersModel objPendingVouchersModel)
        {
            DataTable dtApproved = objPendingVouchersDA.DataApproved(objPendingVouchersModel);
            return dtApproved;
        }

        [HttpPost]
        public DataTable FinalApproval(PendingVouchersModel objPendingVouchersModel)
        {
            DataTable dtApproved = objPendingVouchersDA.FinalApproval(objPendingVouchersModel);
            return dtApproved;
        }

        [HttpPost]
        public DataTable AuditPendingRecords(PendingVouchersModel objPendingVouchersModel)
        {
            DataTable dtApproved = objPendingVouchersDA.AuditPendingRecords(objPendingVouchersModel);
            return dtApproved;
        }
    }
}
