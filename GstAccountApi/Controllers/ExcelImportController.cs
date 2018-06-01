using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GstAccountApi.Models.PL;
using GstAccountApi.Models.DL;
namespace GstAccountApi.Controllers
{
    public class ExcelImportController : ApiController
    {
        ExcelImportDataAccess objdl = null;

        [HttpPost]
        public DataTable ExcelImportData(ExcelImportModel obj)
        {
            objdl = new ExcelImportDataAccess();
            DataTable dt = new DataTable();
            if (obj.Ind == 1)
                dt = objdl.ExcelImportData(obj);
            else
                dt = objdl.ExcelItemData(obj);
            return dt;
        }

        [HttpGet]
        public DataTable FillcompanyNames(int Ind=0)
        {
           ExcelImportModel objpl =new ExcelImportModel();
           objdl = new ExcelImportDataAccess();
           objpl.Ind=Ind;
           DataTable dt = objdl.fillCompanyName(objpl);
           return dt;
        }
    }
}
