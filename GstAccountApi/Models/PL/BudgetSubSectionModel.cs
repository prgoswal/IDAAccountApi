using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class BudgetSubSectionModel
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public int User { get; set; }
        public string IP { get; set; }
        public string SubSectionName { get; set; }
        public string SubSectionNameHindi { get; set; }
        public int ParentSectionID { get; set; }
        public int SectionID { get; set; }


        public string SchemeCode { get; set; }
    }
}