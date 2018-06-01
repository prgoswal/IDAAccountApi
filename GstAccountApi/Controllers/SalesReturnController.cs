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
    public class SalesReturnController : ApiController
    {
        SalesReturnDataAccess objSalesRDA = new SalesReturnDataAccess();

        //[HttpPost]
        //public DataTable LoadNarration(SalesReturnModel objSalesRModel)
        //{
        //    DataTable NarrationList = objSalesRDA.LoadNarration(objSalesRModel);
        //    return NarrationList;
        //}

        //[HttpPost]
        //public DataTable IncomeHead(SalesReturnModel objSalesRModel)
        //{
        //    DataTable IncomeHeadList = objSalesRDA.LoadIncomeHead(objSalesRModel);
        //    return IncomeHeadList;
        //}

        //[HttpPost]
        //public DataTable SalesTo(SalesReturnModel objSalesRModel)
        //{
        //    DataTable dtSalesTo = objSalesRDA.LoadSalesTo(objSalesRModel);
        //    return dtSalesTo;
        //}

        //[HttpPost]
        //public DataTable FillHeadName(SalesReturnModel objSalesRModel)
        //{
        //    DataTable dtFillHeadName = objSalesRDA.FillHeadName(objSalesRModel);
        //    return dtFillHeadName;
        //}

        //[HttpPost]
        //public DataTable FillLocation(SalesReturnModel objSalesRModel)
        //{
        //    DataTable dtFillLocation = objSalesRDA.Filllocation(objSalesRModel);
        //    return dtFillLocation;
        //}

        //[HttpPost]
        //public DataTable FillGistnNo(SalesReturnModel objSalesRModel)
        //{
        //    DataTable IncomeHeadList = objSalesRDA.FillGistnNo(objSalesRModel);
        //    return IncomeHeadList;
        //}


        //[HttpPost]
        //public DataTable FillUnitName(SalesReturnModel objSalesRModel)
        //{
        //    DataTable dtFillUnitName = objSalesRDA.FillUnitName(objSalesRModel);
        //    return dtFillUnitName;
        //}

        //[HttpPost]
        //public DataTable FillItemName(SalesReturnModel objSalesRModel)
        //{
        //    DataTable dtFillItemName = objSalesRDA.FillItemName(objSalesRModel);
        //    return dtFillItemName;
        //}
        //[HttpPost]
        //public DataTable FillItemSellingRate(SalesReturnModel objSalesRModel)
        //{
        //    DataTable ItemList = objSalesRDA.FillItemSellingRate(objSalesRModel);
        //    return ItemList;
        //}

        //[HttpPost]
        //public DataTable FillShippingAddress(SalesReturnModel objSalesRModel)
        //{
        //    DataTable ItemList = objSalesRDA.FillShippingAddress(objSalesRModel);
        //    return ItemList;
        //}

        //[HttpPost]
        //public DataTable SearchItem(SalesReturnModel objSalesRModel)
        //{
        //    DataTable dtItem = objSalesRDA.SearchItem(objSalesRModel);
        //    return dtItem;
        //}

        //[HttpPost]
        //public DataTable SaveSalesReturnVoucher(SalesReturnModel objSalesRModel)
        //{
        //    DataTable dtSaveReturn = objSalesRDA.SaveSalesReturnVoucher(objSalesRModel);
        //    return dtSaveReturn;
        //}

        //[HttpPost]
        //public DataTable LastVoucherNo(SalesReturnModel objSalesRModel)
        //{
        //    DataTable dtLastVoucherNo = objSalesRDA.LastVoucherNo(objSalesRModel);
        //    return dtLastVoucherNo;
        //}       

        [HttpPost]
        public DataTable LoadNarration(SalesReturnModel objSalesRModel)
        {
            DataTable NarrationList = objSalesRDA.LoadNarration(objSalesRModel);
            return NarrationList;
        }

        [HttpPost]
        public DataTable IncomeHead(SalesReturnModel objSalesRModel)
        {
            DataTable IncomeHeadList = objSalesRDA.LoadIncomeHead(objSalesRModel);
            return IncomeHeadList;
        }

        [HttpPost]
        public DataTable SalesTo(SalesReturnModel objSalesRModel)
        {
            DataTable dtSalesTo = objSalesRDA.LoadSalesTo(objSalesRModel);
            return dtSalesTo;
        }

        [HttpPost]
        public DataTable FillHeadName(SalesReturnModel objSalesRModel)
        {
            DataTable dtFillHeadName = objSalesRDA.FillHeadName(objSalesRModel);
            return dtFillHeadName;
        }

        [HttpPost]
        public DataTable FillLocation(SalesReturnModel objSalesRModel)
        {
            DataTable dtFillLocation = objSalesRDA.Filllocation(objSalesRModel);
            return dtFillLocation;
        }

        [HttpPost]
        public DataTable FillGistnNo(SalesReturnModel objSalesRModel)
        {
            DataTable IncomeHeadList = objSalesRDA.FillGistnNo(objSalesRModel);
            return IncomeHeadList;
        }


        [HttpPost]
        public DataTable FillUnitName(SalesReturnModel objSalesRModel)
        {
            DataTable dtFillUnitName = objSalesRDA.FillUnitName(objSalesRModel);
            return dtFillUnitName;
        }

        [HttpPost]
        public DataTable FillItemName(SalesReturnModel objSalesRModel)
        {
            DataTable dtFillItemName = objSalesRDA.FillItemName(objSalesRModel);
            return dtFillItemName;
        }
        [HttpPost]
        public DataTable FillItemSellingRate(SalesReturnModel objSalesRModel)
        {
            DataTable ItemList = objSalesRDA.FillItemSellingRate(objSalesRModel);
            return ItemList;
        }

        [HttpPost]
        public DataTable FillShippingAddress(SalesReturnModel objSalesRModel)
        {
            DataTable ItemList = objSalesRDA.FillShippingAddress(objSalesRModel);
            return ItemList;
        }

        [HttpPost]
        public DataTable LastVoucherNo(SalesReturnModel objSalesRModel)
        {
            DataTable AccHeadList = objSalesRDA.LastVoucherNo(objSalesRModel);
            return AccHeadList;
        }

        [HttpPost]
        public DataTable FillTransportation(SalesReturnModel objSalesRModel)
        {
            DataTable dtLastVoucherNo = objSalesRDA.FillTransportation(objSalesRModel);
            return dtLastVoucherNo;
        }

        [HttpPost]
        public DataTable InvoiceSeries(SalesReturnModel objSalesRModel)
        {
            DataTable dtLastVoucherNo = objSalesRDA.InvoiceSeries(objSalesRModel);
            return dtLastVoucherNo;
        }

        [HttpPost]
        public DataSet BindAll(SalesReturnModel objSalesRModel)
        {
            DataSet dsBindAll = objSalesRDA.BindAll(objSalesRModel);
            return dsBindAll;
        }


        [HttpPost]
        public DataSet FillItemSellRate(SalesReturnModel objSalesRModel)
        {
            DataSet ItemList = objSalesRDA.FillItemSellRate(objSalesRModel);
            return ItemList;
        }

        [HttpPost]
        public DataSet LoadSRBasicDetails(SalesReturnModel objSalesRModel)
        {
            DataSet dsSRBasicDetails = objSalesRDA.LoadSRBasicDetails(objSalesRModel);
            return dsSRBasicDetails;
        }

        [HttpPost]
        public DataTable SaveSalesReturnVoucher(SalesReturnModel objSalesRModel)
        {
            DataTable AccHeadList = objSalesRDA.SaveSalesReturnVoucher(objSalesRModel);
            return AccHeadList;
        }
    }
}
