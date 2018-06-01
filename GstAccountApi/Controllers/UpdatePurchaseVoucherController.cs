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
    public class UpdatePurchaseVoucherController : ApiController
    {
        UpdatePurchaseVoucherDataAccess objPVDA = new UpdatePurchaseVoucherDataAccess();

        [HttpPost]
        public DataSet BindAll(UpdatePurchaseVoucherModel objUpdPVModel)
        {
            DataSet dsBindAll = objPVDA.BindAll(objUpdPVModel);
            return dsBindAll;
        }

        [HttpPost]
        public DataTable FillLocation(UpdatePurchaseVoucherModel objUpdPVModel)
        {
            DataTable dtFillLocation = objPVDA.Filllocation(objUpdPVModel);
            return dtFillLocation;
        }

        [HttpPost]
        public DataTable FillGistnNo(UpdatePurchaseVoucherModel objUpdPVModel)
        {
            DataTable IncomeHeadList = objPVDA.FillGistnNo(objUpdPVModel);
            return IncomeHeadList;
        }

        [HttpPost]
        public DataSet FillItemPurchaseRate(UpdatePurchaseVoucherModel objUpdPVModel)
        {
            DataSet dsItemList = objPVDA.FillItemPurchaseRate(objUpdPVModel);
            return dsItemList;
        }

        [HttpPost]
        public DataTable FillShippingAddress(UpdatePurchaseVoucherModel objUpdPVModel)
        {
            DataTable dtShippingAddress = objPVDA.FillShippingAddress(objUpdPVModel);
            return dtShippingAddress;
        }

        //[HttpPost]
        //public DataTable LoadPurchaseVoucherDetails(UpdatePurchaseVoucherModel objUpdPVModel)
        //{
        //    DataTable dtPVDetails = objPVDA.LoadPurchaseVoucherDetails(objUpdPVModel);
        //    return dtPVDetails;
        //}

        [HttpPost]
        public DataSet LoadPurchaseVoucherDetails(UpdatePurchaseVoucherModel objUpdPVModel)
        {
            DataSet dsPVDetails = objPVDA.LoadPurchaseVoucherDetails(objUpdPVModel);
            return dsPVDetails;
        }

        [HttpPost]
        public DataTable UpdatePV(UpdatePurchaseVoucherModel objUpdPVModel)
        {
            DataTable dtUpdPV = objPVDA.UpdatePV(objUpdPVModel);
            return dtUpdPV;
        }


       [HttpPost]
       public DataTable CancelVoucher(UpdatePurchaseVoucherModel objUpdPVModel)
       {
           DataTable dtUpdate = objPVDA.CancelVoucher(objUpdPVModel);
           return dtUpdate;
       }
       [HttpPost]
       public DataTable CheckBudgetHead(UpdatePurchaseVoucherModel objUpdPVModel)
       {
           DataTable AccHeadList = objPVDA.CheckBudgetHead(objUpdPVModel);
           return AccHeadList;
       }
    }
}
