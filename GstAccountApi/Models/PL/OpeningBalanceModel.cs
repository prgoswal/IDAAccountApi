using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class OpeningBalanceModel
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public decimal CurrentBudgetAmt { get; set; }
        public decimal PreviousYearBudgetAmt { get; set; }
        public decimal PreviousYearActualAmt { get; set; }
        public decimal PreviousYear2ActualAmt { get; set; }
        public int yrcd { get; set; }
    }
}