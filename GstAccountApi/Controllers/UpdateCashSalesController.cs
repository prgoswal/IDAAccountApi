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
    public class UpdateCashSalesController : ApiController
    {
        UpdateCashSalesDataAccess objCashSalesDA = new UpdateCashSalesDataAccess();

        [HttpPost]
        public DataSet BindAll(UpdateCashSalesModel ObjSalesModel)
        {
            DataSet dsBindAll = objCashSalesDA.BindAll(ObjSalesModel);
            return dsBindAll;
        }

        [HttpPost]
        public DataSet SearchSaleInvoice(UpdateCashSalesModel ObjSalesModel)
        {
            DataSet dsSaleInvoice = objCashSalesDA.SearchSaleInvoice(ObjSalesModel);
            return dsSaleInvoice;
        }

        [HttpPost]
        public DataTable FillLocation(UpdateCashSalesModel ObjSalesModel)
        {
            DataTable dtFillLocation = objCashSalesDA.Filllocation(ObjSalesModel);
            return dtFillLocation;
        }

        [HttpPost]
        public DataTable CheckState(UpdateCashSalesModel ObjSalesModel)
        {
            DataTable dtCheckState = objCashSalesDA.CheckState(ObjSalesModel);
            return dtCheckState;
        }

        [HttpPost]
        public DataTable FillGistnNo(UpdateCashSalesModel ObjSalesModel)
        {
            DataTable dtFillGistnNo = objCashSalesDA.FillGistnNo(ObjSalesModel);
            return dtFillGistnNo;
        }

        [HttpPost]
        public DataTable FillShippingAddress(UpdateCashSalesModel ObjSalesModel)
        {
            DataTable dtFillShippingAddress = objCashSalesDA.FillShippingAddress(ObjSalesModel);
            return dtFillShippingAddress;
        }

        [HttpPost]
        public DataSet FillItemSellRate(UpdateCashSalesModel ObjSalesModel)
        {
            DataSet dsItemRate = objCashSalesDA.FillItemSellRate(ObjSalesModel);
            return dsItemRate;
        }

        [HttpPost]
        public DataTable UpdateSaleVoucher(UpdateCashSalesModel ObjSalesModel)
        {
            DataTable dtUpdate = objCashSalesDA.UpdateSaleVoucher(ObjSalesModel);
            return dtUpdate;
        }

        [HttpPost]
        public DataTable CancelVoucher(UpdateSalesModel ObjSalesModel)
        {
            DataTable dtCancel = objCashSalesDA.CancelVoucher(ObjSalesModel);
            return dtCancel;
        }


        [HttpPost]
        public DataSet FillBrokerDetail(UpdateSalesModel ObjSalesModel)
        {
            DataSet dsFillBrokerDetail = objCashSalesDA.FillBrokerDetail(ObjSalesModel);
            return dsFillBrokerDetail;
        }
    }
}
