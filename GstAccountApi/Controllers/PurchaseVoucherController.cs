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
    public class PurchaseVoucherController : ApiController
    {
        PurchaseDataAccess objPurchaseDA = new PurchaseDataAccess();

        [HttpPost]
        public DataTable ExpenseHead(PurchaseModel ObjPurchaseModel)
        {
            DataTable IncomeHeadList = objPurchaseDA.LoadExpenseHead(ObjPurchaseModel);
            return IncomeHeadList;
        }
        [HttpPost]
        public DataTable PurchaseFrom(PurchaseModel ObjPurchaseModel)
        {
            DataTable dtSalesTo = objPurchaseDA.PurchaseFrom(ObjPurchaseModel);
            return dtSalesTo;
        }
        [HttpPost]
        public DataTable FillLocation(PurchaseModel ObjPurchaseModel)
        {
            DataTable dtFillLocation = objPurchaseDA.Filllocation(ObjPurchaseModel);
            return dtFillLocation;
        }
        [HttpPost]
        public DataTable FillItemName(PurchaseModel ObjPurchaseModel)
        {
            DataTable dtFillItemName = objPurchaseDA.FillItemName(ObjPurchaseModel);
            return dtFillItemName;
        }
        [HttpPost]
        public DataTable FillUnitName(PurchaseModel ObjPurchaseModel)
        {
            DataTable dtFillUnitName = objPurchaseDA.FillUnitName(ObjPurchaseModel);
            return dtFillUnitName;
        }
        [HttpPost]
        public DataTable FillHeadName(PurchaseModel ObjPurchaseModel)
        {
            DataTable dtFillHeadName = objPurchaseDA.FillHeadName(ObjPurchaseModel);
            return dtFillHeadName;
        }

        [HttpPost]
        public DataTable FillGistnNo(PurchaseModel ObjPurchaseModel)
        {
            DataTable IncomeHeadList = objPurchaseDA.FillGistnNo(ObjPurchaseModel);
            return IncomeHeadList;
        }

        [HttpPost]
        public DataSet FillGistnNoWithDetail(PurchaseModel ObjPurchaseModel)
        {
            DataSet dsFillGistnNoWithDetail = objPurchaseDA.FillGistnNoWithDetail(ObjPurchaseModel);
            return dsFillGistnNoWithDetail;
        }

        [HttpPost]
        public DataSet FillItemPurchaseRate(PurchaseModel ObjPurchaseModel)
        {
            DataSet ItemList = objPurchaseDA.FillItemPurchaseRate(ObjPurchaseModel);
            return ItemList;
        }
        [HttpPost]
        public DataTable LoadNarration(PurchaseModel ObjPurchaseModel)
        {
            DataTable NarrationList = objPurchaseDA.LoadNarration(ObjPurchaseModel);
            return NarrationList;
        }
        [HttpPost]
        public DataTable FillShippingAddress(PurchaseModel ObjPurchaseModel)
        {
            DataTable dtShippingAddress = objPurchaseDA.FillShippingAddress(ObjPurchaseModel);
            return dtShippingAddress;
        }
        [HttpPost]
        public DataTable SavePurchase(PurchaseModel ObjPurchaseModel)
        {
            DataTable dtShippingAddress = objPurchaseDA.SavePurchase(ObjPurchaseModel);
            return dtShippingAddress;
        }
        [HttpPost]
        public DataTable LastVoucherNo(PurchaseModel ObjPurchaseModel)
        {
            DataTable AccHeadList = objPurchaseDA.LastVoucherNo(ObjPurchaseModel);
            return AccHeadList;
        }
        [HttpPost]
        public DataSet BindAll(PurchaseModel ObjPurchaseModel)
        {
            DataSet dsBindAll = objPurchaseDA.BindAll(ObjPurchaseModel);
            return dsBindAll;
        }

        [HttpPost]
        public DataSet CheckGSTIN_Number(PurchaseModel ObjPurchaseModel)
        {
            DataSet GSTINList = objPurchaseDA.CheckGSTIN_Number(ObjPurchaseModel);
            return GSTINList;
        }

        [HttpPost]
        public DataTable CheckBudgetHead(PurchaseModel ObjPurchaseModel)
        {
            DataTable AccHeadList = objPurchaseDA.CheckBudgetHead(ObjPurchaseModel);
            return AccHeadList;
        }
    }
}
