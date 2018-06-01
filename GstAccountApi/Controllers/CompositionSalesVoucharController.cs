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
    public class CompositionSalesVoucharController : ApiController
    {
        CompositionSalesDataAccess ObjCompositionSalesDA = new CompositionSalesDataAccess();

        
        [HttpPost]
        public DataTable LoadNarration(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataTable NarrationList = ObjCompositionSalesDA.LoadNarration(ObjCompositionSalesModel);
            return NarrationList;
        }

        [HttpPost]
        public DataTable IncomeHead(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataTable IncomeHeadList = ObjCompositionSalesDA.LoadIncomeHead(ObjCompositionSalesModel);
            return IncomeHeadList;
        }

        [HttpPost]
        public DataTable SalesTo(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataTable dtSalesTo = ObjCompositionSalesDA.LoadSalesTo(ObjCompositionSalesModel);
            return dtSalesTo;
        }

        [HttpPost]
        public DataTable FillHeadName(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataTable dtFillHeadName = ObjCompositionSalesDA.FillHeadName(ObjCompositionSalesModel);
            return dtFillHeadName;
        }

        [HttpPost]
        public DataTable FillLocation(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataTable dtFillLocation = ObjCompositionSalesDA.Filllocation(ObjCompositionSalesModel);
            return dtFillLocation;
        }

        [HttpPost]
        public DataTable FillGistnNo(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataTable IncomeHeadList = ObjCompositionSalesDA.FillGistnNo(ObjCompositionSalesModel);
            return IncomeHeadList;
        }

        [HttpPost]
        public DataSet FillGistnNoWithDetail(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataSet dsFillGistnNoWithDetail = ObjCompositionSalesDA.FillGistnNoWithDetail(ObjCompositionSalesModel);
            return dsFillGistnNoWithDetail;
        }

        [HttpPost]
        public DataTable FillUnitName(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataTable dtFillUnitName = ObjCompositionSalesDA.FillUnitName(ObjCompositionSalesModel);
            return dtFillUnitName;
        }

        [HttpPost]
        public DataTable FillItemName(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataTable dtFillItemName = ObjCompositionSalesDA.FillItemName(ObjCompositionSalesModel);
            return dtFillItemName;
        }
        [HttpPost]
        public DataTable FillItemSellingRate(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataTable ItemList = ObjCompositionSalesDA.FillItemSellingRate(ObjCompositionSalesModel);
            return ItemList;
        }

        [HttpPost]
        public DataTable FillShippingAddress(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataTable ItemList = ObjCompositionSalesDA.FillShippingAddress(ObjCompositionSalesModel);
            return ItemList;
        }

        [HttpPost]
        public DataTable SaveSalesVoucher(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataTable AccHeadList = ObjCompositionSalesDA.SaveSalesVoucher(ObjCompositionSalesModel);
            return AccHeadList;
        }

        [HttpPost]
        public DataTable LastVoucherNo(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataTable AccHeadList = ObjCompositionSalesDA.LastVoucherNo(ObjCompositionSalesModel);
            return AccHeadList;
        }

        [HttpPost]
        public DataTable FillTransportation(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataTable dtLastVoucherNo = ObjCompositionSalesDA.FillTransportation(ObjCompositionSalesModel);
            return dtLastVoucherNo;
        }

        [HttpPost]
        public DataTable InvoiceSeries(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataTable dtLastVoucherNo = ObjCompositionSalesDA.InvoiceSeries(ObjCompositionSalesModel);
            return dtLastVoucherNo;
        }

        [HttpPost]
        public DataSet BindAll(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataSet dsBindAll = ObjCompositionSalesDA.BindAll(ObjCompositionSalesModel);
            return dsBindAll;
        }


        [HttpPost]
        public DataSet FillItemSellRate(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataSet ItemList = ObjCompositionSalesDA.FillItemSellRate(ObjCompositionSalesModel);
            return ItemList;
        }

        [HttpPost]
        public DataTable CancelSalesVoucherNo(CompositionSalesModel ObjCompositionSalesModel)
        {
            DataTable dtCancelCashSales = ObjCompositionSalesDA.CancelSalesVoucherNo(ObjCompositionSalesModel);
            return dtCancelCashSales;
        }

    }
}
