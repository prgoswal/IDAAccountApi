using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class Gstr1EntryModel
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public string GSTIN { get; set; }
        public string MonthYear { get; set; }
        public int YrCD { get; set; }
        public int User { get; set; }
        public string IP { get; set; }
        
        public System.Data.DataTable Dtgstr1 { get; set; }
    }
}