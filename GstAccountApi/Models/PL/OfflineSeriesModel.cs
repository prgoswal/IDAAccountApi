using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.PL
{
    public class OfflineSeriesModel
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public DataTable Binding_SeriesList { get; set; }
        public int SeriesType { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string MacAddress { get; set; }
    }

    public class SeriesList
    {
        [DisplayName("Sales Type")]
        public int SalesType { get; set; }
        [DisplayName("Series")]
        public string Series { get; set; }
        [DisplayName("Sr. No.")]
        public string SrNo { get; set; }

        [Browsable(false)]
        public int SeriesType { get; set; }
        [Browsable(false)]
        public int OrgID { get; set; }
        [Browsable(false)]
        public int BrID { get; set; }
    }

    public class OfflineUtility
    {
        public int OrgID { get; set; }
        public string CompanyName { get; set; }
        public int BrID { get; set; }
        public string BranchName { get; set; }
    }

    public class FormEntry
    {
        public int SeriesType { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public List<SeriesList> Binding_SeriesList { get; set; }
        public string MacAddress { get; set; }
    }

   

    public class ClsCommonMsg
    {
        public int Code { get; set; }
        public string Msg { get; set; }
        public string DownloadLocation { get; set; }
    }

    public class ClsDownloadSuccess
    {
        public int Ind { get; set; }
        public int OrgID { get; set; }
        public int BrID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int DowinloadSuccessInd { get; set; }
        public string Msg { get; set; }
    }


}