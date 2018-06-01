using GstAccountApi.Models;
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
    public class LoginController : ApiController
    {
        LoginDataAccess dllogin = new LoginDataAccess();

        [HttpGet]
        public DataSet UserValidation(int Ind, string userID)
        {
            DataSet loginDs = dllogin.UserValidation(Ind, userID);
            return loginDs;
        }

        [HttpGet]
        public DataTable LoadYrCode(int Ind)
        {
            DataTable dtfinancialYr = dllogin.LoadYrCode(Ind);
            return dtfinancialYr;
        }
    }
}
