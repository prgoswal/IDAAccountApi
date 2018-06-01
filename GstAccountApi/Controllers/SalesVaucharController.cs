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
    public class SalesVaucharController : ApiController
    {
        SalesDataAccess ObjSalesDA = new SalesDataAccess();

        
        [HttpPost]
        public DataTable LoadNarration(SalesModel ObjSalesModel)
        {
            DataTable NarrationList = ObjSalesDA.LoadNarration(ObjSalesModel);
            return NarrationList;
        }

        [HttpPost]
        public DataTable IncomeHead(SalesModel ObjSalesModel)
        {
            DataTable IncomeHeadList = ObjSalesDA.LoadIncomeHead(ObjSalesModel);
            return IncomeHeadList;
        }

        [HttpPost]
        public DataTable SalesTo(SalesModel ObjSalesModel)
        {
            DataTable dtSalesTo = ObjSalesDA.LoadSalesTo(ObjSalesModel);
            return dtSalesTo;
        }

        [HttpPost]
        public DataTable FillHeadName(SalesModel ObjSalesModel)
        {
            DataTable dtFillHeadName = ObjSalesDA.FillHeadName(ObjSalesModel);
            return dtFillHeadName;
        }

        [HttpPost]
        public DataTable FillLocation(SalesModel ObjSalesModel)
        {
            DataTable dtFillLocation = ObjSalesDA.Filllocation(ObjSalesModel);
            return dtFillLocation;
        }

        [HttpPost]
        public DataTable FillGistnNo(SalesModel ObjSalesModel)
        {
            DataTable IncomeHeadList = ObjSalesDA.FillGistnNo(ObjSalesModel);
            return IncomeHeadList;
        }

        [HttpPost]
        public DataSet FillGistnNoWithDetail(SalesModel ObjSalesModel)
        {
            DataSet dsFillGistnNoWithDetail = ObjSalesDA.FillGistnNoWithDetail(ObjSalesModel);
            return dsFillGistnNoWithDetail;
        }

        [HttpPost]
        public DataTable FillUnitName(SalesModel ObjSalesModel)
        {
            DataTable dtFillUnitName = ObjSalesDA.FillUnitName(ObjSalesModel);
            return dtFillUnitName;
        }

        [HttpPost]
        public DataTable FillItemName(SalesModel ObjSalesModel)
        {
            DataTable dtFillItemName = ObjSalesDA.FillItemName(ObjSalesModel);
            return dtFillItemName;
        }
        [HttpPost]
        public DataTable FillItemSellingRate(SalesModel ObjSalesModel)
        {
            DataTable ItemList = ObjSalesDA.FillItemSellingRate(ObjSalesModel);
            return ItemList;
        }

        [HttpPost]
        public DataTable FillShippingAddress(SalesModel ObjSalesModel)
        {
            DataTable ItemList = ObjSalesDA.FillShippingAddress(ObjSalesModel);
            return ItemList;
        }

        [HttpPost]
        public DataTable SaveSalesVoucher(SalesModel ObjSalesModel)
        {
            DataTable AccHeadList = ObjSalesDA.SaveSalesVoucher(ObjSalesModel);
            return AccHeadList;
        }

        [HttpPost]
        public DataTable LastVoucherNo(SalesModel ObjSalesModel)
        {
            DataTable AccHeadList = ObjSalesDA.LastVoucherNo(ObjSalesModel);
            return AccHeadList;
        }

        [HttpPost]
        public DataTable FillTransportation(SalesModel ObjSalesModel)
        {
            DataTable dtLastVoucherNo = ObjSalesDA.FillTransportation(ObjSalesModel);
            return dtLastVoucherNo;
        }

        [HttpPost]
        public DataTable InvoiceSeries(SalesModel ObjSalesModel)
        {
            DataTable dtLastVoucherNo = ObjSalesDA.InvoiceSeries(ObjSalesModel);
            return dtLastVoucherNo;
        }

        [HttpPost]
        public DataSet BindAll(SalesModel ObjSalesModel)
        {
            DataSet dsBindAll = ObjSalesDA.BindAll(ObjSalesModel);
            return dsBindAll;
        }


        [HttpPost]
        public DataSet FillItemSellRate(SalesModel ObjSalesModel)
        {
            DataSet ItemList = ObjSalesDA.FillItemSellRate(ObjSalesModel);
            return ItemList;
        }


        [HttpPost]
        public DataTable CancelSalesVoucherNo(SalesModel objSalesModel)
        {
            DataTable dtCancelCashSales = ObjSalesDA.CancelSalesVoucherNo(objSalesModel);
            return dtCancelCashSales;
        }


        [HttpPost]
        public DataSet FillBrokerDetail(SalesModel ObjSalesModel)
        {
            DataSet dsFillBrokerDetail = ObjSalesDA.FillBrokerDetail(ObjSalesModel);
            return dsFillBrokerDetail;
        }
    }
}
