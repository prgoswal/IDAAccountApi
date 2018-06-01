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
    public class PurchaseReturnController : ApiController
    {
        PurchaseReturnDataAccess objPurchaseRDA = new PurchaseReturnDataAccess();

        //[HttpPost]
        //public DataTable LoadNarration(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    DataTable NarrationList = objPurchaseRDA.LoadNarration(ObjPurchaseRModel);
        //    return NarrationList;
        //}

        //[HttpPost]
        //public DataTable ExpenseHead(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    DataTable ExpenseHeadList = objPurchaseRDA.LoadExpenseHead(ObjPurchaseRModel);
        //    return ExpenseHeadList;
        //}

        //[HttpPost]
        //public DataTable PurchaseFrom(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    DataTable dtPurchaseFrom = objPurchaseRDA.LoadPurchaseFrom(ObjPurchaseRModel);
        //    return dtPurchaseFrom;
        //}

        //[HttpPost]
        //public DataTable FillHeadName(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    DataTable dtFillHeadName = objPurchaseRDA.FillHeadName(ObjPurchaseRModel);
        //    return dtFillHeadName;
        //}

        //[HttpPost]
        //public DataTable FillLocation(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    DataTable dtFillLocation = objPurchaseRDA.Filllocation(ObjPurchaseRModel);
        //    return dtFillLocation;
        //}

        //[HttpPost]
        //public DataTable FillGistnNo(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    DataTable IncomeHeadList = objPurchaseRDA.FillGistnNo(ObjPurchaseRModel);
        //    return IncomeHeadList;
        //}


        //[HttpPost]
        //public DataTable FillUnitName(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    DataTable dtFillUnitName = objPurchaseRDA.FillUnitName(ObjPurchaseRModel);
        //    return dtFillUnitName;
        //}

        //[HttpPost]
        //public DataTable FillItemName(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    DataTable dtFillItemName = objPurchaseRDA.FillItemName(ObjPurchaseRModel);
        //    return dtFillItemName;
        //}
        //[HttpPost]
        //public DataTable FillItemPurchaseRate(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    DataTable ItemList = objPurchaseRDA.FillItemPurchaseRate(ObjPurchaseRModel);
        //    return ItemList;
        //}

        //[HttpPost]
        //public DataTable FillShippingAddress(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    DataTable ItemList = objPurchaseRDA.FillShippingAddress(ObjPurchaseRModel);
        //    return ItemList;
        //}

        //[HttpPost]
        //public DataTable SearchItem(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    DataTable dtItem = objPurchaseRDA.SearchItem(ObjPurchaseRModel);
        //    return dtItem;
        //}

        //[HttpPost]
        //public DataTable SavePurchaseReturnVoucher(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    DataTable dtSaveReturn = objPurchaseRDA.SavePurchaseReturnVoucher(ObjPurchaseRModel);
        //    return dtSaveReturn;
        //}

        //[HttpPost]
        //public DataTable LastVoucherNo(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    DataTable dtLastVoucherNo = objPurchaseRDA.LastVoucherNo(ObjPurchaseRModel);
        //    return dtLastVoucherNo;
        //}

        [HttpPost]
        public DataSet BindAll(PurchaseReturnModel ObjPurchaseRModel)
        {
            DataSet dsBindAll = objPurchaseRDA.BindAll(ObjPurchaseRModel);
            return dsBindAll;
        }

        [HttpPost]
        public DataTable FillLocation(PurchaseReturnModel ObjPurchaseRModel)
        {
            DataTable dtFillLocation = objPurchaseRDA.Filllocation(ObjPurchaseRModel);
            return dtFillLocation;
        }

        [HttpPost]
        public DataTable FillGistnNo(PurchaseReturnModel ObjPurchaseRModel)
        {
            DataTable IncomeHeadList = objPurchaseRDA.FillGistnNo(ObjPurchaseRModel);
            return IncomeHeadList;
        }

        [HttpPost]
        public DataSet FillItemPurchaseRate(PurchaseReturnModel ObjPurchaseRModel)
        {
            DataSet dsItemList = objPurchaseRDA.FillItemPurchaseRate(ObjPurchaseRModel);
            return dsItemList;
        }

        [HttpPost]
        public DataTable FillShippingAddress(PurchaseReturnModel ObjPurchaseRModel)
        {
            DataTable dtShippingAddress = objPurchaseRDA.FillShippingAddress(ObjPurchaseRModel);
            return dtShippingAddress;
        }

        [HttpPost]
        public DataSet LoadPurchaseVoucherDetails(PurchaseReturnModel ObjPurchaseRModel)
        {
            DataSet dsPVDetails = objPurchaseRDA.LoadPurchaseVoucherDetails(ObjPurchaseRModel);
            return dsPVDetails;
        }

        [HttpPost]
        public DataTable SavePurchaseReturn(PurchaseReturnModel ObjPurchaseRModel)
        {
            DataTable dtUpdPV = objPurchaseRDA.SavePurchaseReturn(ObjPurchaseRModel);
            return dtUpdPV;
        }
    }
}
