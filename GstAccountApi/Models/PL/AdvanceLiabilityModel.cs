using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class AdvanceLiabilityModel
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public int MonthID { get; set; }
        public int YearID { get; set; }
        public int YrCD { get; set; }
    }
}