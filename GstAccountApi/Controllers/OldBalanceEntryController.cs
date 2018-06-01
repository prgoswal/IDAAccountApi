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
    public class OldBalanceEntryController : ApiController
    {
        OldBalanceDataAccess objOldBalDA = new OldBalanceDataAccess(); 
        [HttpPost]
        public DataSet BindAllddl(OldBalanceModel objOldBalance)
        {
            DataSet dsOldBalList = objOldBalDA.BindAll(objOldBalance);
            return dsOldBalList;
        }


        [HttpPost]
        public DataTable SaveOldBalance(OldBalanceModel objOldBalance)
        {
            DataTable dtOldBal = objOldBalDA.SaveOldBalance(objOldBalance);
            return dtOldBal;
        }

    }
}
