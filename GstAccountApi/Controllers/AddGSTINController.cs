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
    public class AddGSTINController : ApiController
    {
        AddGSTINDataAccess objAddGSTINDA = new AddGSTINDataAccess();

        [HttpPost]
        public DataSet LoadData(AddGSTINModel objAddGSTINModel)
        {
            DataSet dsLoadData = objAddGSTINDA.LoadData(objAddGSTINModel);
            return dsLoadData;
        }

        [HttpPost]
        public DataTable SaveGSTIN(AddGSTINModel objAddGSTINModel)
        {
            DataTable dtSaveGSTIN = objAddGSTINDA.SaveGSTIN(objAddGSTINModel);
            return dtSaveGSTIN;
        }
    }
}
