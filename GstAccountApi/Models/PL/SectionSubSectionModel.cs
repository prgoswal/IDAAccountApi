﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class SectionSubSectionModel
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public int User { get; set; }
        public string IP { get; set; }
        public string CostCentreName { get; set; }
        public int ParentCostCentreID { get; set; }

        public int CostCentreID { get; set; }
    }
}