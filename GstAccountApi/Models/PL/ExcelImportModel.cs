using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class ExcelImportModel
    {
        public DataTable dt { get; set; }
        public int Ind { get; set; }
        public int ClientCode { get; set; }
    } 
}