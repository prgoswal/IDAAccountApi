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
    public class UpdateSalesReturnController : ApiController
    {
        UpdateSalesReturnDataAccess objUpdSRDA = new UpdateSalesReturnDataAccess();

        [HttpPost]
        public DataTable LoadNarration(UpdateSalesReturnModel objUpdSRModel)
        {
            DataTable NarrationList = objUpdSRDA.LoadNarration(objUpdSRModel);
            return NarrationList;
        }

        [HttpPost]
        public DataTable IncomeHead(UpdateSalesReturnModel objUpdSRModel)
        {
            DataTable IncomeHeadList = objUpdSRDA.LoadIncomeHead(objUpdSRModel);
            return IncomeHeadList;
        }

        [HttpPost]
        public DataTable SalesTo(UpdateSalesReturnModel objUpdSRModel)
        {
            DataTable dtSalesTo = objUpdSRDA.LoadSalesTo(objUpdSRModel);
            return dtSalesTo;
        }

        [HttpPost]
        public DataTable FillHeadName(UpdateSalesReturnModel objUpdSRModel)
        {
            DataTable dtFillHeadName = objUpdSRDA.FillHeadName(objUpdSRModel);
            return dtFillHeadName;
        }

        [HttpPost]
        public DataTable FillLocation(UpdateSalesReturnModel objUpdSRModel)
        {
            DataTable dtFillLocation = objUpdSRDA.Filllocation(objUpdSRModel);
            return dtFillLocation;
        }

        [HttpPost]
        public DataTable FillGistnNo(UpdateSalesReturnModel objUpdSRModel)
        {
            DataTable IncomeHeadList = objUpdSRDA.FillGistnNo(objUpdSRModel);
            return IncomeHeadList;
        }


        [HttpPost]
        public DataTable FillUnitName(UpdateSalesReturnModel objUpdSRModel)
        {
            DataTable dtFillUnitName = objUpdSRDA.FillUnitName(objUpdSRModel);
            return dtFillUnitName;
        }

        [HttpPost]
        public DataTable FillItemName(UpdateSalesReturnModel objUpdSRModel)
        {
            DataTable dtFillItemName = objUpdSRDA.FillItemName(objUpdSRModel);
            return dtFillItemName;
        }
        [HttpPost]
        public DataTable FillItemSellingRate(UpdateSalesReturnModel objUpdSRModel)
        {
            DataTable ItemList = objUpdSRDA.FillItemSellingRate(objUpdSRModel);
            return ItemList;
        }

        [HttpPost]
        public DataTable FillShippingAddress(UpdateSalesReturnModel objUpdSRModel)
        {
            DataTable ItemList = objUpdSRDA.FillShippingAddress(objUpdSRModel);
            return ItemList;
        }

        [HttpPost]
        public DataTable LastVoucherNo(UpdateSalesReturnModel objUpdSRModel)
        {
            DataTable AccHeadList = objUpdSRDA.LastVoucherNo(objUpdSRModel);
            return AccHeadList;
        }

        [HttpPost]
        public DataTable FillTransportation(UpdateSalesReturnModel objUpdSRModel)
        {
            DataTable dtLastVoucherNo = objUpdSRDA.FillTransportation(objUpdSRModel);
            return dtLastVoucherNo;
        }

        [HttpPost]
        public DataTable InvoiceSeries(UpdateSalesReturnModel objUpdSRModel)
        {
            DataTable dtLastVoucherNo = objUpdSRDA.InvoiceSeries(objUpdSRModel);
            return dtLastVoucherNo;
        }

        [HttpPost]
        public DataSet BindAll(UpdateSalesReturnModel objUpdSRModel)
        {
            DataSet dsBindAll = objUpdSRDA.BindAll(objUpdSRModel);
            return dsBindAll;
        }


        [HttpPost]
        public DataSet FillItemSellRate(UpdateSalesReturnModel objUpdSRModel)
        {
            DataSet ItemList = objUpdSRDA.FillItemSellRate(objUpdSRModel);
            return ItemList;
        }

        [HttpPost]
        public DataSet LoadSRBasicDetails(UpdateSalesReturnModel objUpdSRModel)
        {
            DataSet dsSRBasicDetails = objUpdSRDA.LoadSRBasicDetails(objUpdSRModel);
            return dsSRBasicDetails;
        }

        [HttpPost]
        public DataTable UpdateSalesReturnVoucher(UpdateSalesReturnModel objUpdSRModel)
        {
            DataTable AccHeadList = objUpdSRDA.UpdateSalesReturnVoucher(objUpdSRModel);
            return AccHeadList;
        }
    }
}
