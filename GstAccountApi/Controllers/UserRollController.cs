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
    public class UserRollController : ApiController
    {
        UserRollDataAccess objURDA = new UserRollDataAccess();
        
  
        [HttpPost]
        public DataTable BindUserRoll(UserRollModel objUserRollModel)
        {
            DataTable dtCUGrid = objURDA.BindUserRoll(objUserRollModel);
            return dtCUGrid;
        }
        [HttpPost]
        public DataTable SaveUser(UserRollModel objUserRollModel)
        {
            DataTable dtSaveUser = objURDA.SaveUser(objUserRollModel);
            return dtSaveUser;
        }
      
    }
}
