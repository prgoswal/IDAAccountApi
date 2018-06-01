using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class FinancialYearModel
    {
        public int YrCode { get; set; }
        public string YearFromTo { get; set; }
        public DateTime YrStartDate { get; set; }
        public DateTime YrEndDate { get; set; }
        public int ActiveID { get; set; }
        public int UserID { get; set; }
        public string IPAddress { get; set; }
        public DateTime EntryDate { get; set; }
    }
}