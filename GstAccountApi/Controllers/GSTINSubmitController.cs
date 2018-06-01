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
    public class GSTINSubmitController : ApiController
    {
        GstinSubmitDataAccess objGstinSubmitDA = new GstinSubmitDataAccess();

        [HttpPost]
        public DataSet FillGridGstin(GstinSubmitModel ObjGstinSubmitModel)
        {
            DataSet dtFillGstinSubmit = objGstinSubmitDA.FillGridGstinSubmit(ObjGstinSubmitModel);
            return dtFillGstinSubmit;
        }

        [HttpPost]
        public DataSet FillGridGSTR2(GstinSubmitModel ObjGstinSubmitModel)
        {
            DataSet dtFillGridGSTR2 = objGstinSubmitDA.FillGridGSTR2(ObjGstinSubmitModel);
            return dtFillGridGSTR2;
        }

        

        [HttpPost]
        public DataTable GstinSubmitProcess(GstinSubmitModel ObjGstinSubmitModel)
        {
            DataTable dtGstinSubmitProcess = objGstinSubmitDA.GstinSubmitProcess(ObjGstinSubmitModel);
            return dtGstinSubmitProcess;
        }

        [HttpPost]
        public DataSet FillGSTR1(GstinSubmitModel ObjGstinSubmitModel)
        {
            DataSet dsFillGSTR1 = objGstinSubmitDA.FillGSTR1(ObjGstinSubmitModel);
            return dsFillGSTR1;
        }

        [HttpPost]
        public DataSet FillGSTR2(GstinSubmitModel ObjGstinSubmitModel)
        {
            DataSet dsFillGSTR2 = objGstinSubmitDA.FillGSTR2(ObjGstinSubmitModel);
            return dsFillGSTR2;
        }

        [HttpPost]
        public DataSet GetExcelData(GstinSubmitModel ObjGstinSubmitModel)
        {
            DataSet dsFillGSTR1 = objGstinSubmitDA.GetExcelData(ObjGstinSubmitModel);
            return dsFillGSTR1;
        }
        
    }
}
