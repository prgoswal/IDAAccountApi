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
    public class ChequeSeriesController : ApiController
    {

        ChequeSeriesDataAccess ObjChequeSeriesDA = new ChequeSeriesDataAccess();

        [HttpPost]
        public DataTable SaveChkSerices(ChequeSeriesModel ObjChkSeriesModel)
        {
            DataTable ChkSeriesList = ObjChequeSeriesDA.SaveChkSericesDetail(ObjChkSeriesModel);
            return ChkSeriesList;
        }

         [HttpPost]
        public DataTable ddlBankSeries(ChequeSeriesModel ObjChkSeriesModel)
        {
            DataTable DDlChkSeriesList = ObjChequeSeriesDA.ddlBankSeriesDetail(ObjChkSeriesModel);
            return DDlChkSeriesList;
        }

    }
}
