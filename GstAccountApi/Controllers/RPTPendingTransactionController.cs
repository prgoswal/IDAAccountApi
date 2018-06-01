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
    public class RPTPendingTransactionController : ApiController
    {

        RPTPendingTransactionDataAccess objRPTPTransDA = new RPTPendingTransactionDataAccess();

        [HttpPost]
        public DataSet BindPendingTransaction(RPTPendingTransactionModel objRPTPTransModel)
        {
            DataSet dsPendingTransaction = objRPTPTransDA.BindPendingTransaction(objRPTPTransModel);
            return dsPendingTransaction;
        }
    }
}
