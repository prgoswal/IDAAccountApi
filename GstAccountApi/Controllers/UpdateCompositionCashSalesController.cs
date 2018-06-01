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
    public class UpdateCompositionCashSalesController : ApiController
    {
        UpdateCompositionCashSalesDataAccess objCompositionCashSalesDA = new UpdateCompositionCashSalesDataAccess();

        [HttpPost]
        public DataSet BindAll(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            DataSet dsBindAll = objCompositionCashSalesDA.BindAll(ObjCompositionSalesModel);
            return dsBindAll;
        }

        [HttpPost]
        public DataSet SearchSaleInvoice(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            DataSet dsSaleInvoice = objCompositionCashSalesDA.SearchSaleInvoice(ObjCompositionSalesModel);
            return dsSaleInvoice;
        }

        [HttpPost]
        public DataTable FillLocation(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            DataTable dtFillLocation = objCompositionCashSalesDA.Filllocation(ObjCompositionSalesModel);
            return dtFillLocation;
        }

        [HttpPost]
        public DataTable CheckState(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            DataTable dtCheckState = objCompositionCashSalesDA.CheckState(ObjCompositionSalesModel);
            return dtCheckState;
        }

        [HttpPost]
        public DataTable FillGistnNo(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            DataTable dtFillGistnNo = objCompositionCashSalesDA.FillGistnNo(ObjCompositionSalesModel);
            return dtFillGistnNo;
        }

        [HttpPost]
        public DataTable FillShippingAddress(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            DataTable dtFillShippingAddress = objCompositionCashSalesDA.FillShippingAddress(ObjCompositionSalesModel);
            return dtFillShippingAddress;
        }

        [HttpPost]
        public DataSet FillItemSellRate(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            DataSet dsItemRate = objCompositionCashSalesDA.FillItemSellRate(ObjCompositionSalesModel);
            return dsItemRate;
        }

        [HttpPost]
        public DataTable UpdateSaleVoucher(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            DataTable dtUpdate = objCompositionCashSalesDA.UpdateSaleVoucher(ObjCompositionSalesModel);
            return dtUpdate;
        }

        [HttpPost]
        public DataTable CancelVoucher(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            DataTable dtCancel = objCompositionCashSalesDA.CancelVoucher(ObjCompositionSalesModel);
            return dtCancel;
        }
    }
}
