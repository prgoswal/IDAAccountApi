using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GstAccountApi.Models.PL;
using GstAccountApi.Models.DL;

namespace GstAccountApi.Controllers
{
    public class MultiInvoiceController : ApiController
    {
        DL_MultiInvoice dlobjMultiInvoice = new DL_MultiInvoice();
        [HttpPost]
        public DataTable Method_MultiInvoice(PL_MultiInvoice plobjMultiInvoice)
        {
            DataTable dtMultiInvoice = dlobjMultiInvoice.BindMultiInvoice(plobjMultiInvoice);
            return dtMultiInvoice;
        }
    }
}
