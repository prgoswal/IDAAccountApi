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
    public class CashSaleReturnController : ApiController
    {

        CashSaleReturnDataAccess objCashSaleReturnDA = new CashSaleReturnDataAccess();

        [HttpPost]
        public DataSet BindAll(CashSaleReturnModel objCashSaleReturnModel)
        {
            DataSet dsBindAll = objCashSaleReturnDA.BindAll(objCashSaleReturnModel);
            return dsBindAll;
        }


        [HttpPost]
        public DataTable FillGistnNo(CashSaleReturnModel objCashSaleReturnModel)
        {
            DataTable IncomeHeadList = objCashSaleReturnDA.FillGistnNo(objCashSaleReturnModel);
            return IncomeHeadList;
        }

        [HttpPost]
        public DataTable FillShippingAddress(CashSaleReturnModel objCashSaleReturnModel)
        {
            DataTable ShippingAddList = objCashSaleReturnDA.FillShippingAddress(objCashSaleReturnModel);
            return ShippingAddList;
        }
          [HttpPost]

        public DataSet SearchSaleInvoice(CashSaleReturnModel objCashSaleReturnModel)
        {
            DataSet SearchInvoiceList = objCashSaleReturnDA.SearchSaleInvoice(objCashSaleReturnModel);
            return SearchInvoiceList;
        }

          [HttpPost]
          public DataSet FillItemSellRate(CashSaleReturnModel objCashSaleReturnModel)
          {
              DataSet dsItemRate = objCashSaleReturnDA.FillItemSellRate(objCashSaleReturnModel);
              return dsItemRate;
          }

          //[HttpPost]
          //public DataTable CancelVoucher(CashSaleReturnModel objCashSaleReturnModel)
          //{
          //    DataTable dtCancel = objCashSaleReturnDA.CancelVoucher(objCashSaleReturnModel);
          //    return dtCancel;
          //} 

          [HttpPost]
          public DataTable SaveCashSalesVoucher(CashSaleReturnModel objCashSaleReturnModel)
          {
              DataTable dtSaveCashSales = objCashSaleReturnDA.SaveCashSalesVoucher(objCashSaleReturnModel);
              return dtSaveCashSales;
          }


          [HttpPost]
          public DataSet FillBrokerDetail(CashSaleReturnModel objCashSaleReturnModel)
          {
              DataSet dsFillBrokerDetail = objCashSaleReturnDA.FillBrokerDetail(objCashSaleReturnModel);
              return dsFillBrokerDetail;
          }

    }
}
