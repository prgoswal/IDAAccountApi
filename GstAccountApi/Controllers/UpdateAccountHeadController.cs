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
    public class UpdateAccountHeadController : ApiController
    {
        UpdateAccountHeadDataAccess objUAHDA = new UpdateAccountHeadDataAccess();

        [HttpPost]
        public DataSet BindAccountHeadDDL(UpdateAccounHeadModel objUAHModel)
        {
            DataSet dsAccountHead = new DataSet();

            objUAHModel.Ind = 7;
            DataTable dtUpdAccountHead = objUAHDA.LoadAccountHead(objUAHModel);
            dtUpdAccountHead.TableName = "AccountHead";
            dsAccountHead.Tables.Add(dtUpdAccountHead);

            objUAHModel.Ind = 15;
            DataTable dtClientState = objUAHDA.LoadState(objUAHModel);
            dtClientState.TableName = "State";
            dsAccountHead.Tables.Add(dtClientState);

            objUAHModel.Ind = 16;
            DataTable dtGroupName = objUAHDA.LoadGroupName(objUAHModel);
            dtGroupName.TableName = "GroupName";
            dsAccountHead.Tables.Add(dtGroupName);

            objUAHModel.Ind = 19;
            DataTable dtExportCat = objUAHDA.LoadExportCategory(objUAHModel);
            dtExportCat.TableName = "ExportCategory";
            dsAccountHead.Tables.Add(dtExportCat);

            return dsAccountHead;
        }

        [HttpPost]
        public DataSet LoadBasicInfo(UpdateAccounHeadModel objUAHModel)
        {
            DataSet dtBasicInfo = objUAHDA.LoadBasicInfo(objUAHModel);
            return dtBasicInfo;
        }

        [HttpPost]
        public DataTable LoadGSTINInfo(UpdateAccounHeadModel objUAHModel)
        {
            DataTable dtGSTINInfo = objUAHDA.LoadGSTINInfo(objUAHModel);
            return dtGSTINInfo;
        }

        [HttpPost]
        public DataSet LoadShippingInfo(UpdateAccounHeadModel objUAHModel)
        {
            DataSet dsShippingInfo = objUAHDA.LoadShippingInfo(objUAHModel);
            return dsShippingInfo;
        }

        [HttpPost]
        public DataTable LoadBranchState(UpdateAccounHeadModel objUAHModel)
        {
            DataTable dtBranchState = objUAHDA.LoadBranchState(objUAHModel);
            return dtBranchState;
        }

        [HttpPost]
        public DataTable UpdateClientInfo(UpdateAccounHeadModel objUAHModel)
        {
            DataTable dtUpdClientInfo = objUAHDA.UpdateClientInfo(objUAHModel);
            return dtUpdClientInfo;
        }

        [HttpPost]
        public DataTable UpdateGSTINInfo(UpdateAccounHeadModel objUAHModel)
        {
            DataTable dtUpdGSTINInfo = objUAHDA.UpdateGSTINInfo(objUAHModel);
            return dtUpdGSTINInfo;
        }

        [HttpPost]
        public DataTable UpdateShippingInfo(UpdateAccounHeadModel objUAHModel)
        {
            DataTable dtUpdShippingInfo = objUAHDA.UpdateShippingInfo(objUAHModel);
            return dtUpdShippingInfo;
        }
    }
}
