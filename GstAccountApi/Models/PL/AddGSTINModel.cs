﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class AddGSTINModel
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public int YrCD { get; set; }

        public string GSTIN { get; set; }
        public string RegAddr { get; set; }
        public string RegDate { get; set; }
        public string City { get; set; }
        public int StateID { get; set; }
        public int PinCode { get; set; }
        public string AuthorizedSignatury { get; set; }
        public string SignaturyDesignation { get; set; }

        public int User { get; set; }
        public string IP { get; set; }

        public DataTable DtSeries { get; set; }
        public DataTable DtAddGSTINInBranch { get; set; }
    }
}