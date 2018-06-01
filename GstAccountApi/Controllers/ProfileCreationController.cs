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
    public class ProfileCreationController : ApiController
    {
        ProfileCreationDataAccess objPCDA = new ProfileCreationDataAccess();

        //[HttpPost]
        //public DataSet ProfileCreationDDL(ProfileCreationModel objPCModel)
        //{
        //    DataSet dsProfileCreation = new DataSet();

        //    objPCModel.Ind = 24;
        //    DataTable dtOrgType = objPCDA.LoadOrgType(objPCModel);
        //    dtOrgType.TableName = "OrganizationType";
        //    dsProfileCreation.Tables.Add(dtOrgType);

        //    objPCModel.Ind = 25;
        //    DataTable dtBusinessNature = objPCDA.LoadBusinessNature(objPCModel);
        //    dtBusinessNature.TableName = "BusinessNature";
        //    dsProfileCreation.Tables.Add(dtBusinessNature);

        //    objPCModel.Ind = 26;
        //    DataTable dtBusinessType = objPCDA.LoadBusinessType(objPCModel);
        //    dtBusinessType.TableName = "BusinessType";
        //    dsProfileCreation.Tables.Add(dtBusinessType);

        //    objPCModel.Ind = 27;
        //    DataTable dtCopyType = objPCDA.LoadCopyType(objPCModel);
        //    dtCopyType.TableName = "CopyType";
        //    dsProfileCreation.Tables.Add(dtCopyType);

        //    objPCModel.Ind = 15;
        //    DataTable dtClientState = objPCDA.LoadState(objPCModel);
        //    dtClientState.TableName = "State";
        //    dsProfileCreation.Tables.Add(dtClientState);

        //    objPCModel.Ind = 2;
        //    DataTable dtReportFormats = objPCDA.LoadReportFormats(objPCModel);
        //    dtReportFormats.TableName = "ReportFormats";
        //    dsProfileCreation.Tables.Add(dtReportFormats);

        //    return dsProfileCreation;
        //}
        
        [HttpPost]
        public DataSet BindAllProfileCreationDDL(ProfileCreationModel objPCModel)
        {
            DataSet dsProfileCreation = objPCDA.BindAllProfileCreationDDL(objPCModel);
            return dsProfileCreation;
        }

        [HttpPost]
        public DataTable SaveCompanyProfile(ProfileCreationModel objPCModel)
        {
            DataTable dtSavePC = objPCDA.SaveCompanyProfile(objPCModel);
            return dtSavePC;
        }
    }
}
