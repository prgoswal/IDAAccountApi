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
    public class UpdateSalesVoucherController : ApiController
    {
        UpdateSalesVoucherDataAccess ObjSalesDA = new UpdateSalesVoucherDataAccess();

        [HttpPost]
        public DataSet BindAll(UpdateSalesModel ObjSalesModel)
        {
            DataSet dsBindAll = ObjSalesDA.BindAll(ObjSalesModel);
            return dsBindAll;
        }

        [HttpPost]
        public DataSet SearchSaleInvoice(UpdateSalesModel ObjSalesModel)
        {
            DataSet dsSaleInvoice = ObjSalesDA.SearchSaleInvoice(ObjSalesModel);
            return dsSaleInvoice;
        }

        [HttpPost]
        public DataTable FillLocation(UpdateSalesModel ObjSalesModel)
        {
            DataTable dtFillLocation = ObjSalesDA.Filllocation(ObjSalesModel);
            return dtFillLocation;
        }

        [HttpPost]
        public DataTable CheckState(UpdateSalesModel ObjSalesModel)
        {
            DataTable dtCheckState = ObjSalesDA.CheckState(ObjSalesModel);
            return dtCheckState;
        }

        [HttpPost]
        public DataTable FillGistnNo(UpdateSalesModel ObjSalesModel)
        {
            DataTable dtFillGistnNo = ObjSalesDA.FillGistnNo(ObjSalesModel);
            return dtFillGistnNo;
        }

        [HttpPost]
        public DataTable FillShippingAddress(UpdateSalesModel ObjSalesModel)
        {
            DataTable dtFillShippingAddress = ObjSalesDA.FillShippingAddress(ObjSalesModel);
            return dtFillShippingAddress;
        }

        [HttpPost]
        public DataSet FillItemSellRate(UpdateSalesModel ObjSalesModel)
        {
            DataSet dsItemRate = ObjSalesDA.FillItemSellRate(ObjSalesModel);
            return dsItemRate;
        }

        [HttpPost]
        public DataTable UpdateSaleVoucher(UpdateSalesModel ObjSalesModel)
        {
            DataTable dtUpdate = ObjSalesDA.UpdateSaleVoucher(ObjSalesModel);
            return dtUpdate;
        }

        [HttpPost]
        public DataTable SaveSalesVoucher(UpdateSalesModel ObjSalesModel)
        {
            DataTable dtSave = ObjSalesDA.SaveSalesVoucher(ObjSalesModel);
            return dtSave;
        }



        [HttpPost]
        public DataTable CancelVoucher(UpdateSalesModel ObjSalesModel)
        {
            DataTable dtUpdate = ObjSalesDA.CancelVoucher(ObjSalesModel);
            return dtUpdate;
        }


        [HttpPost]
        public DataSet FillBrokerDetail(UpdateSalesModel ObjSalesModel)
        {
            DataSet dsFillBrokerDetail = ObjSalesDA.FillBrokerDetail(ObjSalesModel);
            return dsFillBrokerDetail;
        }
    }
}
