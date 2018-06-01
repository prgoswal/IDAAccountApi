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
    public class AccountHeadController : ApiController
    {
        AccountHeadDataAccess objAHDA = new AccountHeadDataAccess();

        [HttpPost]
        public DataSet ClientInformation(AccountHeadModel objAHModel)
        {
            DataSet dsAccountHead = new DataSet();

            objAHModel.Ind = 15;
            DataTable dtClientState = objAHDA.LoadState(objAHModel);

            dtClientState.TableName = "State";
            dsAccountHead.Tables.Add(dtClientState);

            objAHModel.Ind = 16;
            DataTable dtGroupName = objAHDA.LoadGroupName(objAHModel);

            dtGroupName.TableName = "GroupName";
            dsAccountHead.Tables.Add(dtGroupName);

            objAHModel.Ind = 19;
            DataTable dtExportCat = objAHDA.LoadExportCategory(objAHModel);

            dtExportCat.TableName = "ExportCategory";
            dsAccountHead.Tables.Add(dtExportCat);

            objAHModel.Ind = 2;
            DataTable dtUpdAccountHead = objAHDA.LoadAccountHead(objAHModel);
            dtUpdAccountHead.TableName = "AccountHead";
            dsAccountHead.Tables.Add(dtUpdAccountHead);
            
            return dsAccountHead;
        }

        [HttpPost]
        public DataTable LoadBranchState(AccountHeadModel objAHModel)
        {
            DataTable dtBranchState = objAHDA.LoadBranchState(objAHModel);
            return dtBranchState;
        }

        [HttpPost]
        public DataTable SaveAccountHead(AccountHeadModel objAHModel)
        {
            DataTable dtAccountHead = objAHDA.SaveAccountHead(objAHModel);
            return dtAccountHead;
        }

      
    }
}
