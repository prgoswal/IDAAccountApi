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
    public class ClientCstinController : ApiController
    {
        ClientGSTINDataAccess objClientGstinDA = new ClientGSTINDataAccess();
        [HttpPost]
        public DataTable FillGridGstin(ClientGstinModel ObjClientGstinModel)
        {
            DataTable dtFillClientGstin = objClientGstinDA.FillGridCLientGstin(ObjClientGstinModel);
            return dtFillClientGstin;
        } 
    }
}
