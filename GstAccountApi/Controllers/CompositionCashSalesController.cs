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
    public class CompositionCashSalesController : ApiController
    {
        CompositionCashSalesDataAccess objCompositionCashSalesDA = new CompositionCashSalesDataAccess();

        [HttpPost]
        public DataSet BindAll(CompositionCashSalesModel objCompositionCashSalesModel)
        {
            DataSet dsBindAll = objCompositionCashSalesDA.BindAll(objCompositionCashSalesModel);
            return dsBindAll;
        }

        [HttpPost]
        public DataSet FillItemSellRate(CompositionCashSalesModel objCompositionCashSalesModel)
        {
            DataSet dsSeleRate = objCompositionCashSalesDA.FillItemSellRate(objCompositionCashSalesModel);
            return dsSeleRate;
        }

        [HttpPost]
        public DataTable FillGistnNo(CompositionCashSalesModel objCompositionCashSalesModel)
        {
            DataTable IncomeHeadList = objCompositionCashSalesDA.FillGistnNo(objCompositionCashSalesModel);
            return IncomeHeadList;
        }

        [HttpPost]
        public DataTable FillShippingAddress(CompositionCashSalesModel objCompositionCashSalesModel)
        {
            DataTable ItemList = objCompositionCashSalesDA.FillShippingAddress(objCompositionCashSalesModel);
            return ItemList;
        }

        [HttpPost]
        public DataTable SaveCashSalesVoucher(CompositionCashSalesModel objCompositionCashSalesModel)
        {
            DataTable dtSaveCashSales = objCompositionCashSalesDA.SaveCashSalesVoucher(objCompositionCashSalesModel);
            return dtSaveCashSales;
        }

        [HttpPost]
        public DataTable CancelCashSalesVoucherNo(CompositionCashSalesModel objCompositionCashSalesModel)
        {
            DataTable dtSaveCashSales = objCompositionCashSalesDA.CancelCashSalesVoucherNo(objCompositionCashSalesModel);
            return dtSaveCashSales;
        }

    }
}
