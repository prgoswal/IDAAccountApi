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
    public class UserController : ApiController
    {
        UserDataAccess objUCDA = new UserDataAccess();

        [HttpPost]
        public DataSet BindUCBranch(UserModel objUCModel)
        {
            DataSet dsBranchList = objUCDA.BindUCBranch(objUCModel);
            return dsBranchList;
        }
        [HttpPost]
        public DataTable BindUCGrid(UserModel objUCModel)
        {
            DataTable dtCUGrid = objUCDA.BindUCGrid(objUCModel);
            return dtCUGrid;
        }
        [HttpPost]
        public DataTable SaveUser(UserModel objUCModel)
        {
            DataTable dtSaveUser = objUCDA.SaveUser(objUCModel);
            return dtSaveUser;
        }
        [HttpPost]
        public DataTable MatchLoginDetails(UserModel objUCModel)
        {
            DataTable dtMatchLoginDetails = objUCDA.MatchLoginDetails(objUCModel);
            return dtMatchLoginDetails;
        }

        [HttpPost]
        public DataTable ChangeUserStatus(UserModel objUCModel)
        {
            DataTable dtMatchLoginDetails = objUCDA.ChangeUserStatus(objUCModel);
            return dtMatchLoginDetails;
        }

        [HttpPost]
        public DataTable LoadBranch(UserModel objUCModel)
        {
            DataTable dtMatchLoginDetails = objUCDA.LoadBranch(objUCModel);
            return dtMatchLoginDetails;
        }

        [HttpPost]
        public DataTable ChangePassword(UserModel objUCModel)
        {
            DataTable dtMatchLoginDetails = objUCDA.ChangePassword(objUCModel);
            return dtMatchLoginDetails;
        }

        [HttpPost]
        public DataTable UserLoginDetails(UserModel objUCModel)
        {
            DataTable dtMatchLoginDetails = objUCDA.UserLoginDetails(objUCModel);
            return dtMatchLoginDetails;
        }

        [HttpPost]
        public DataTable Logout(UserModel objUCModel)
        {
            DataTable dtMatchLoginDetails = objUCDA.Logout(objUCModel);
            return dtMatchLoginDetails;
        }

        [HttpPost]
        public DataTable CheckGuidDetails(UserModel objUCModel)
        {
            DataTable dtMatchLoginDetails = objUCDA.CheckGuidDetails(objUCModel);
            return dtMatchLoginDetails;
        }

        [HttpPost]
        public DataTable SaveLogDetails(UserModel objUCModel)
        {
            DataTable dtMatchLoginDetails = objUCDA.SaveLogDetails(objUCModel);
            return dtMatchLoginDetails;
        }


        [HttpPost]
        public DataTable GetUserDetails(UserModel objUCModel)
        {
            DataTable dtMatchLoginDetails = objUCDA.GetUserDetails(objUCModel);
            return dtMatchLoginDetails;
        }

        [HttpPost]
        public DataTable SaveUserRightsDetails(UserModel objUCModel)
        {
            DataTable dtMatchLoginDetails = objUCDA.SaveUserRightsDetails(objUCModel);
            return dtMatchLoginDetails;
        }


        [HttpPost]
        public DataTable DeleteUserRights(UserModel objUCModel)
        {
            DataTable dtMatchLoginDetails = objUCDA.DeleteUserRights(objUCModel);
            return dtMatchLoginDetails;
        }


        [HttpPost]
        public DataTable GetAllottedUserDetails(UserModel objUCModel)
        {
            DataTable dtMatchLoginDetails = objUCDA.GetAllottedUserDetails(objUCModel);
            return dtMatchLoginDetails;
        }


        [HttpPost]
        public DataTable GetAllottedMenuDetails(UserModel objUCModel)
        {
            DataTable dtMatchLoginDetails = objUCDA.GetAllottedMenuDetails(objUCModel);
            return dtMatchLoginDetails;
        }

        [HttpPost]
        public DataSet CheckUserRights(UserModel objUCModel)
        {
            DataSet dsMatchLoginDetails = objUCDA.CheckUserRights(objUCModel);
            return dsMatchLoginDetails;
        }


        [HttpPost]
        public DataTable GetBudgetFinancialYear(UserModel objUCModel)
        {
            DataTable dtFinancialYear = objUCDA.GetBudgetFinancialYear(objUCModel);
            return dtFinancialYear;
        }


        [HttpPost]
        public DataTable LoadNewFinancialYear(UserModel objUCModel)
        {
            DataTable dtNewFinancialYear = objUCDA.LoadNewFinancialYear(objUCModel);
            return dtNewFinancialYear;
        }
    }
}
