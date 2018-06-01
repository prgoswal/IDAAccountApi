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
    public class CashSalesController : ApiController
    {
        CashSalesDataAccess objCashSalesDA = new CashSalesDataAccess();

        [HttpPost]
        public DataSet BindAll(CashSalesModel objCashSalesModel)
        {
            DataSet dsBindAll = objCashSalesDA.BindAll(objCashSalesModel);
            return dsBindAll;
        }

        [HttpPost]
        public DataSet FillItemSellRate(CashSalesModel objCashSalesModel)
        {
            DataSet dsSeleRate = objCashSalesDA.FillItemSellRate(objCashSalesModel);
            return dsSeleRate;
        }

        [HttpPost]
        public DataTable FillGistnNo(CashSalesModel objCashSalesModel)
        {
            DataTable IncomeHeadList = objCashSalesDA.FillGistnNo(objCashSalesModel);
            return IncomeHeadList;
        }

        [HttpPost]
        public DataTable FillShippingAddress(CashSalesModel objCashSalesModel)
        {
            DataTable ItemList = objCashSalesDA.FillShippingAddress(objCashSalesModel);
            return ItemList;
        }

        [HttpPost]
        public DataTable SaveCashSalesVoucher(CashSalesModel objCashSalesModel)
        {
            DataTable dtSaveCashSales = objCashSalesDA.SaveCashSalesVoucher(objCashSalesModel);
            return dtSaveCashSales;
        }


        [HttpPost]
        public DataTable CancelCashSalesVoucherNo(CashSalesModel objCashSalesModel)
        {
            DataTable dtSaveCashSales = objCashSalesDA.CancelCashSalesVoucherNo(objCashSalesModel);
            return dtSaveCashSales;
        }



        //[HttpPost]
        //public DataTable CheckGSTIN_Number(CashSalesModel objCashSalesModel)
        //{
        //    DataTable GSTINList = objCashSalesDA.CheckGSTIN_Number(objCashSalesModel);
        //    return GSTINList;
        //}


        [HttpPost]
        public DataSet FillBrokerDetail(CashSalesModel objCashSalesModel)
        {
            DataSet dsFillBrokerDetail = objCashSalesDA.FillBrokerDetail(objCashSalesModel);
            return dsFillBrokerDetail;
        }
    }
}
