﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class UpdateNarrationModel
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public int VchType { get; set; }
        public string NarrDesc { get; set; }
        public int YrCD { get; set; }
        public int NarrationID { get; set; }
        public int User { get; set; }
        public string IP { get; set; }
        public int DocTypeID { get; set; }
    }
}