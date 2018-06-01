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
    public class CompositionPurchaseVoucherController : ApiController
    {
        CompositionPurchaseDataAccess objPurchaseDA = new CompositionPurchaseDataAccess();

        [HttpPost]
        public DataTable ExpenseHead(CompositionPurchaseModel ObjPurchaseModel)
        {
            DataTable IncomeHeadList = objPurchaseDA.LoadExpenseHead(ObjPurchaseModel);
            return IncomeHeadList;
        }
        [HttpPost]
        public DataTable PurchaseFrom(CompositionPurchaseModel ObjPurchaseModel)
        {
            DataTable dtSalesTo = objPurchaseDA.PurchaseFrom(ObjPurchaseModel);
            return dtSalesTo;
        }
        [HttpPost]
        public DataTable FillLocation(CompositionPurchaseModel ObjPurchaseModel)
        {
            DataTable dtFillLocation = objPurchaseDA.Filllocation(ObjPurchaseModel);
            return dtFillLocation;
        }
        [HttpPost]
        public DataTable FillItemName(CompositionPurchaseModel ObjPurchaseModel)
        {
            DataTable dtFillItemName = objPurchaseDA.FillItemName(ObjPurchaseModel);
            return dtFillItemName;
        }
        [HttpPost]
        public DataTable FillUnitName(CompositionPurchaseModel ObjPurchaseModel)
        {
            DataTable dtFillUnitName = objPurchaseDA.FillUnitName(ObjPurchaseModel);
            return dtFillUnitName;
        }
        [HttpPost]
        public DataTable FillHeadName(CompositionPurchaseModel ObjPurchaseModel)
        {
            DataTable dtFillHeadName = objPurchaseDA.FillHeadName(ObjPurchaseModel);
            return dtFillHeadName;
        }

        [HttpPost]
        public DataTable FillGistnNo(CompositionPurchaseModel ObjPurchaseModel)
        {
            DataTable IncomeHeadList = objPurchaseDA.FillGistnNo(ObjPurchaseModel);
            return IncomeHeadList;
        }

        [HttpPost]
        public DataSet FillGistnNoWithDetail(CompositionPurchaseModel ObjPurchaseModel)
        {
            DataSet dsFillGistnNoWithDetail = objPurchaseDA.FillGistnNoWithDetail(ObjPurchaseModel);
            return dsFillGistnNoWithDetail;
        }

        [HttpPost]
        public DataSet FillItemPurchaseRate(CompositionPurchaseModel ObjPurchaseModel)
        {
            DataSet ItemList = objPurchaseDA.FillItemPurchaseRate(ObjPurchaseModel);
            return ItemList;
        }
        [HttpPost]
        public DataTable LoadNarration(CompositionPurchaseModel ObjPurchaseModel)
        {
            DataTable NarrationList = objPurchaseDA.LoadNarration(ObjPurchaseModel);
            return NarrationList;
        }
        [HttpPost]
        public DataTable FillShippingAddress(CompositionPurchaseModel ObjPurchaseModel)
        {
            DataTable dtShippingAddress = objPurchaseDA.FillShippingAddress(ObjPurchaseModel);
            return dtShippingAddress;
        }
        [HttpPost]
        public DataTable SavePurchase(CompositionPurchaseModel ObjPurchaseModel)
        {
            DataTable dtShippingAddress = objPurchaseDA.SavePurchase(ObjPurchaseModel);
            return dtShippingAddress;
        }
        [HttpPost]
        public DataTable LastVoucherNo(CompositionPurchaseModel ObjPurchaseModel)
        {
            DataTable AccHeadList = objPurchaseDA.LastVoucherNo(ObjPurchaseModel);
            return AccHeadList;
        }
        [HttpPost]
        public DataSet BindAll(CompositionPurchaseModel ObjPurchaseModel)
        {
            DataSet dsBindAll = objPurchaseDA.BindAll(ObjPurchaseModel);
            return dsBindAll;
        }
    }
}
