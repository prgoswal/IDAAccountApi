﻿using GstAccountApi.Models.DL;
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
    public class VoucherPrintingController : ApiController
    {
        VoucherPrintingDataAccess objVPDA = new VoucherPrintingDataAccess();

        [HttpPost]
        public DataTable BindDocumentType(VoucherPrintingModel objVPModel)
        {
            DataTable dtBindDocType = objVPDA.BindDocumentType(objVPModel);
            return dtBindDocType;
        }
    }
}
