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
    public class Gstr3BController : ApiController
    {
        Gstr3bDataAccess objGstr3BDA = new Gstr3bDataAccess();
        [HttpPost]
        public DataTable FillGistnNo(Gstr3BModel objGstr3BModel)
        {
            DataTable GstinList = objGstr3BDA.FillGistnNo(objGstr3BModel);
            return GstinList;
        }
        [HttpPost]
        public DataSet GetGSTR3BData(Gstr3BModel objGstr3BModel)
        {
            DataSet dsGetGSTR3BData = objGstr3BDA.GetGSTR3BData(objGstr3BModel); 
            return dsGetGSTR3BData;
        }
        public DataTable SaveGSTR3BData(Gstr3BModel objGstr3BModel)
        {
            DataTable dtSaveGSTR3BData = objGstr3BDA.SaveGSTR3BData(objGstr3BModel);
            return dtSaveGSTR3BData;
        }
    }
}
