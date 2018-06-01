using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class GSTINDetailsModel
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public DataTable DtGstin
        {
            get { return InitGstin; }
            set { InitGstin = value; }
        }

        private DataTable InitGstin = new DataTable();
    }
}