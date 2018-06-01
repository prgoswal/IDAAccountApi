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
    public class FixedDepositController : ApiController
    {
        FixedDepositDataAccess objFDDA = new FixedDepositDataAccess();

        [HttpPost]
        public DataTable SaveFixedDeposit(FixedDepositModel objFDModel)
        {
            DataTable dtFD = objFDDA.SaveFixedDeposit(objFDModel);
            return dtFD;
        }

        [HttpPost]
        public DataSet BindAll(FixedDepositModel objFDModel)
        {
            DataSet dsFD = objFDDA.BindAll(objFDModel);
            return dsFD;
        }


    }
}
