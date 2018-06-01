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
    public class OpeningBalanceController : ApiController
    {
        OpningBalanceDataAccess ObjOpningBalanceDA = new OpningBalanceDataAccess();

        [HttpPost]
        public DataTable SaveOpeningBalance(OpeningBalanceModel ObjOpeningBalanceModel)
        {
            DataTable SectionList = ObjOpningBalanceDA.SaveOpningBalance(ObjOpeningBalanceModel);
            return SectionList;
        }

        [HttpPost]
        public DataTable CheckyrCode(OpeningBalanceModel ObjOpeningBalanceModel)
        {
            DataTable SectionList = ObjOpningBalanceDA.CheckyecodeData(ObjOpeningBalanceModel);
            return SectionList;
        }

    }
}