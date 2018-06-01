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
    public class UpdateCompositionSalesVoucherController : ApiController
    {
        UpdateCompositionSalesVoucherDataAccess ObjSalesDA = new UpdateCompositionSalesVoucherDataAccess();

        [HttpPost]
        public DataSet BindAll(UpdateCompositionSalesModel ObjSalesModel)
        {
            DataSet dsBindAll = ObjSalesDA.BindAll(ObjSalesModel);
            return dsBindAll;
        }

        [HttpPost]
        public DataSet SearchSaleInvoice(UpdateCompositionSalesModel ObjSalesModel)
        {
            DataSet dsSaleInvoice = ObjSalesDA.SearchSaleInvoice(ObjSalesModel);
            return dsSaleInvoice;
        }

        [HttpPost]
        public DataTable FillLocation(UpdateCompositionSalesModel ObjSalesModel)
        {
            DataTable dtFillLocation = ObjSalesDA.Filllocation(ObjSalesModel);
            return dtFillLocation;
        }

        [HttpPost]
        public DataTable CheckState(UpdateCompositionSalesModel ObjSalesModel)
        {
            DataTable dtCheckState = ObjSalesDA.CheckState(ObjSalesModel);
            return dtCheckState;
        }

        [HttpPost]
        public DataTable FillGistnNo(UpdateCompositionSalesModel ObjSalesModel)
        {
            DataTable dtFillGistnNo = ObjSalesDA.FillGistnNo(ObjSalesModel);
            return dtFillGistnNo;
        }

        [HttpPost]
        public DataTable FillShippingAddress(UpdateCompositionSalesModel ObjSalesModel)
        {
            DataTable dtFillShippingAddress = ObjSalesDA.FillShippingAddress(ObjSalesModel);
            return dtFillShippingAddress;
        }

        [HttpPost]
        public DataSet FillItemSellRate(UpdateCompositionSalesModel ObjSalesModel)
        {
            DataSet dsItemRate = ObjSalesDA.FillItemSellRate(ObjSalesModel);
            return dsItemRate;
        }

        [HttpPost]
        public DataTable UpdateSaleVoucher(UpdateCompositionSalesModel ObjSalesModel)
        {
            DataTable dtUpdate = ObjSalesDA.UpdateSaleVoucher(ObjSalesModel);
            return dtUpdate;
        }



        [HttpPost]
        public DataTable CancelVoucher(UpdateCompositionSalesModel ObjSalesModel)
        {
            DataTable dtCancel = ObjSalesDA.CancelVoucher(ObjSalesModel);
            return dtCancel;
        }
    }
}
