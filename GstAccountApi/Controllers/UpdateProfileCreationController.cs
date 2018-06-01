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
    public class UpdateProfileCreationController : ApiController
    {
        UpdateProfileCreationDataAccess objUPCDA = new UpdateProfileCreationDataAccess();

        //[HttpPost]
        //public DataSet UpdateProfileCreationDDL(UpdateProfileCreationModel objPCModel)
        //{
        //    DataSet dsUPC = new DataSet();

        //    objPCModel.Ind = 24;
        //    DataTable dtOrgType = objUPCDA.LoadOrgType(objPCModel);
        //    dtOrgType.TableName = "OrganizationType";
        //    dsUPC.Tables.Add(dtOrgType);

        //    objPCModel.Ind = 25;
        //    DataTable dtBusinessNature = objUPCDA.LoadBusinessNature(objPCModel);
        //    dtBusinessNature.TableName = "BusinessNature";
        //    dsUPC.Tables.Add(dtBusinessNature);

        //    objPCModel.Ind = 26;
        //    DataTable dtBusinessType = objUPCDA.LoadBusinessType(objPCModel);
        //    dtBusinessType.TableName = "BusinessType";
        //    dsUPC.Tables.Add(dtBusinessType);

        //    objPCModel.Ind = 27;
        //    DataTable dtCopyType = objUPCDA.LoadCopyType(objPCModel);
        //    dtCopyType.TableName = "CopyType";
        //    dsUPC.Tables.Add(dtCopyType);

        //    objPCModel.Ind = 15;
        //    DataTable dtClientState = objUPCDA.LoadState(objPCModel);
        //    dtClientState.TableName = "State";
        //    dsUPC.Tables.Add(dtClientState);

        //    objPCModel.Ind = 2;
        //    DataTable dtReportFormats = objUPCDA.LoadReportFormats(objPCModel);
        //    dtReportFormats.TableName = "ReportFormats";
        //    dsUPC.Tables.Add(dtReportFormats);

        //    return dsUPC;
        //}

        [HttpPost]
        public DataSet BindAllUpdProfileCreationDDL(UpdateProfileCreationModel objUPCModel)
        {
            DataSet dsProfileCreation = objUPCDA.BindAllUpdProfileCreationDDL(objUPCModel);
            return dsProfileCreation;
        }

        [HttpPost]
        public DataSet LoadProfileCreationInfo(UpdateProfileCreationModel objUPCModel)
        {
            DataSet dsLoadPCInfo = objUPCDA.LoadProfileCreationInfo(objUPCModel);
            return dsLoadPCInfo;
        }

        [HttpPost]
        public DataTable UpdateCompanyProfile(UpdateProfileCreationModel objUPCModel)
        {
            DataTable dtUpdatePC = objUPCDA.UpdateCompanyProfile(objUPCModel);
            return dtUpdatePC;
        }
    }
}
