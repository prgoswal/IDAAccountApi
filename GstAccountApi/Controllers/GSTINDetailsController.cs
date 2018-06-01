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
    public class GSTINDetailsController : ApiController
    {
        GSTINDetailsDataAccess objGSTINDetailsDA = new GSTINDetailsDataAccess();

        [HttpPost]
        public DataSet BindAll(GSTINDetailsModel objGSTINDetailsModel)
        {
            DataSet dsBindAll = objGSTINDetailsDA.BindAll(objGSTINDetailsModel);
            return dsBindAll;
        }



        [HttpPost]
        public DataTable SaveGSTINDetails(GSTINDetailsModel objGSTINDetailsModel)
        {
            DataTable GSTINDetailList = objGSTINDetailsDA.SaveGSTINDetails(objGSTINDetailsModel);
            return GSTINDetailList;
        }

    }
}
