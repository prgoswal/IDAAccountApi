using GstAccountApi.Models.DL;
using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GstAccountApi.Controllers
{
    public class SundriController : ApiController
    {
        SundriesDataAccess objSundriDA = new SundriesDataAccess();

        [HttpPost]
        public DataSet ChkList(SundriesModel ObjSundriModel)
        {
            //DataSet dsAvailablelist = new DataSet();

            ObjSundriModel.Ind = 1;
            DataSet dtAvailable = objSundriDA.LoadChkListAvailable(ObjSundriModel);

            dtAvailable.Tables[0].TableName = "AvailableList";
       
            dtAvailable.Tables[1].TableName = "AllocatedList";
    
            return dtAvailable;
        } 

        [HttpPost] 
        public DataTable MatchInd(SundriesModel ObjSundriModel)
        {
           // objGroupTypeDA = new GroupTypeMasterDataAcess();

            DataTable MatchItem = objSundriDA.MatchSelectedInd(ObjSundriModel);
            return MatchItem;
        }

        [HttpPost]
        public DataTable SaveChkAllocated(SundriesModel ObjSundriModel)
        {
            // objGroupTypeDA = new GroupTypeMasterDataAcess();

            DataTable SaveItem = objSundriDA.SaveChkAllocated(ObjSundriModel);
            return SaveItem;
        }
    }
}
