﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class SundriesModel
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public int VchType { get; set; }
        public string NarrDesc { get; set; }
        public int YrCD { get; set; }
        public int SundriCode { get; set; }
        public int User { get; set; }
        public string IP { get; set; }
        public int DocTypeID { get; set; }
        public DataTable TblSundries { get; set; }
    }
}