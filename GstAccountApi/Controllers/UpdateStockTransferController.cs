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
    public class UpdateStockTransferController : ApiController
    {
        UpdateStockTransferDataAccess objUpdSTDA = new UpdateStockTransferDataAccess();

        [HttpPost]
        public DataSet BindStockTransferDDL(UpdateStockTransferModel objUpdSTModel)
        {
            DataSet dsBindSTDDL = objUpdSTDA.BindStockTransferDDL(objUpdSTModel);
            return dsBindSTDDL;
        }

        [HttpPost]
        public DataSet BindItemAndUnitDDL(UpdateStockTransferModel objUpdSTModel)
        {
            DataSet ItemList = objUpdSTDA.BindItemAndUnitDDL(objUpdSTModel);
            return ItemList;
        }

        [HttpPost]
        public DataSet SearchForUpdateStockTransfer(UpdateStockTransferModel objUpdSTModel)
        {
            DataSet dsSearchForUST = objUpdSTDA.SearchForUpdateStockTransfer(objUpdSTModel);
            return dsSearchForUST;
        }

        [HttpPost]
        public DataTable UpdateStockTransfer(UpdateStockTransferModel objUpdSTModel)
        {
            DataTable dtSaveST = objUpdSTDA.UpdateStockTransfer(objUpdSTModel);
            return dtSaveST;
        }

        [HttpPost]
        public DataTable CancelVoucher(UpdateStockTransferModel objUpdSTModel)
        {
            DataTable dtCancel = objUpdSTDA.CancelVoucher(objUpdSTModel);
            return dtCancel;
        }

    }
}
