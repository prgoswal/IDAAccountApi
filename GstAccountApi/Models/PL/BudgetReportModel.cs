using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class BudgetReportModel
    {  
         public int RptInd { get; set; }
        public int CompanyID { get; set; }
        public int BranchID { get; set; }
        public int YrCD { get; set; }
        public int GroupID { get; set; } 
        public int UserID { get; set; } 
         public int BudgetHead { get; set; }
         public int Ind { get; set; }

    }
}