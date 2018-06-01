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
    public class UpdateCompositionPurchaseVoucherController : ApiController
    {
        UpdateCompositionPurchaseVoucherDataAccess objPVDA = new UpdateCompositionPurchaseVoucherDataAccess();

        [HttpPost]
        public DataSet BindAll(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
        {
            DataSet dsBindAll = objPVDA.BindAll(objUpdPVModel);
            return dsBindAll;
        }

        [HttpPost]
        public DataTable FillLocation(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
        {
            DataTable dtFillLocation = objPVDA.Filllocation(objUpdPVModel);
            return dtFillLocation;
        }

        [HttpPost]
        public DataTable FillGistnNo(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
        {
            DataTable IncomeHeadList = objPVDA.FillGistnNo(objUpdPVModel);
            return IncomeHeadList;
        }

        [HttpPost]
        public DataSet FillItemPurchaseRate(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
        {
            DataSet dsItemList = objPVDA.FillItemPurchaseRate(objUpdPVModel);
            return dsItemList;
        }

        [HttpPost]
        public DataTable FillShippingAddress(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
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
        public DataSet LoadPurchaseVoucherDetails(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
        {
            DataSet dsPVDetails = objPVDA.LoadPurchaseVoucherDetails(objUpdPVModel);
            return dsPVDetails;
        }

        [HttpPost]
        public DataTable UpdatePV(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
        {
            DataTable dtUpdPV = objPVDA.UpdatePV(objUpdPVModel);
            return dtUpdPV;
        }



        [HttpPost]
        public DataTable CancelVoucher(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
        {
            DataTable dtUpdate = objPVDA.CancelVoucher(objUpdPVModel);
            return dtUpdate;
        }
    }
}
