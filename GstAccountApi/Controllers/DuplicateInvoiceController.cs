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
    public class DuplicateInvoiceController : ApiController
    {
        DuplicateInvoiceDataAccess ObjDupInvoiceDA = new DuplicateInvoiceDataAccess();  

        [HttpPost] 
        public DataTable LoadGetDate(DuplicateInvoiceModel objDupInvoicePl)
        {
            DataTable DupInvoiceList = ObjDupInvoiceDA.GetDate(objDupInvoicePl);
            return DupInvoiceList;
        }

        [HttpPost]
        public DataTable ShowData(DuplicateInvoiceModel objDupInvoicePl)
        {
            DataTable DupInvoiceList = ObjDupInvoiceDA.GetShowData(objDupInvoicePl);
            return DupInvoiceList;
        }
    }
}
