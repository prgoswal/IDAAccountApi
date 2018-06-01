using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class OfflineUtilityModel
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public string CompanyName { get; set; }
        public string BranchName { get; set; }
        public int User { get; set; }
    }
}