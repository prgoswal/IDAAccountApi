﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class DemoRegistrationModel
    {
        public int Ind { get; set; }
        public string User { get; set; }
        public string OrgType { get; set; }
        public string OrgName { get; set; }
        public Int64 MobNo { get; set; }
        public string Email { get; set; }
    }
}