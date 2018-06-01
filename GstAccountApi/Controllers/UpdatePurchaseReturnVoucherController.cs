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
    public class UpdatePurchaseReturnVoucherController : ApiController
    {
        UpdatePurchaseReturnVoucherDataAccess objUpdPRDA = new UpdatePurchaseReturnVoucherDataAccess();

        //[HttpPost]
        //public DataSet LoadAll(UpdatePurchaseReturnVoucherModel objPRModel)
        //{
        //    DataSet dsLoadAll = objUpdPRDA.LoadAll(objPRModel);
        //    return dsLoadAll;
        //}
        //[HttpPost]
        //public DataTable FillGistnNo(UpdatePurchaseReturnVoucherModel objPRModel)
        //{
        //    DataTable dtGSTIN = objUpdPRDA.FillGistnNo(objPRModel);
        //    return dtGSTIN;
        //}
        //[HttpPost]
        //public DataTable FillItemPurchaseRate(UpdatePurchaseReturnVoucherModel objPRModel)
        //{
        //    DataTable ItemList = objUpdPRDA.FillItemPurchaseRate(objPRModel);
        //    return ItemList;
        //}
        //[HttpPost]
        //public DataSet SearchDetails(UpdatePurchaseReturnVoucherModel objPRModel)
        //{
        //    DataSet dsSearchDetails = objUpdPRDA.SearchDeails(objPRModel);
        //    return dsSearchDetails;
        //}

        [HttpPost]
        public DataSet BindAll(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            DataSet dsBindAll = objUpdPRDA.BindAll(objPRModel);
            return dsBindAll;
        }

        [HttpPost]
        public DataTable FillLocation(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            DataTable dtFillLocation = objUpdPRDA.Filllocation(objPRModel);
            return dtFillLocation;
        }

        [HttpPost]
        public DataTable FillGistnNo(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            DataTable IncomeHeadList = objUpdPRDA.FillGistnNo(objPRModel);
            return IncomeHeadList;
        }

        [HttpPost]
        public DataSet FillItemPurchaseRate(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            DataSet dsItemList = objUpdPRDA.FillItemPurchaseRate(objPRModel);
            return dsItemList;
        }

        [HttpPost]
        public DataTable FillShippingAddress(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            DataTable dtShippingAddress = objUpdPRDA.FillShippingAddress(objPRModel);
            return dtShippingAddress;
        }

        [HttpPost]
        public DataSet LoadPurchaseVoucherDetails(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            DataSet dsPVDetails = objUpdPRDA.LoadPurchaseVoucherDetails(objPRModel);
            return dsPVDetails;
        }

        [HttpPost]
        public DataTable UpdatePurchaseReturn(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            DataTable dtUpdPV = objUpdPRDA.UpdatePurchaseReturn(objPRModel);
            return dtUpdPV;
        }


        [HttpPost]
        public DataTable CancelVoucher(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            DataTable dtCancel = objUpdPRDA.CancelVoucher(objPRModel);
            return dtCancel;
        }
    }
}
