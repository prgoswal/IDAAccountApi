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
    public class StockTransferController : ApiController
    {
        StockTransferDataAccess objSTDA = new StockTransferDataAccess();

        [HttpPost]
        public DataSet BindStockTransferDDL(StockTransferModel objSTModel)
        {
            DataSet dsBindSTDDL = objSTDA.BindStockTransferDDL(objSTModel);
            return dsBindSTDDL;
        }

        [HttpPost]
        public DataSet BindItemAndUnitDDL(StockTransferModel objSTModel)
        {
            DataSet ItemList = objSTDA.BindItemAndUnitDDL(objSTModel);
            return ItemList;
        }

        [HttpPost]
        public DataTable SaveStockTransfer(StockTransferModel objSTModel)
        {
            DataTable dtSaveST = objSTDA.SaveStockTransfer(objSTModel);
            return dtSaveST;
        }
    }
}
