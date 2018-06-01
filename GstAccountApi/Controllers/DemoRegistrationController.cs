using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GstAccountApi.Models.DL;
using GstAccountApi.Models.PL;

namespace GstAccountApi.Controllers
{
    public class DemoRegistrationController : ApiController
    {
        DemoRegistrationDataAccess dlRegisteration = new DemoRegistrationDataAccess();

        [HttpPost]
        public DataTable Registration(DemoRegistrationModel objRegi)
        {
            DataTable AccHeadList = dlRegisteration.Registration(objRegi);
            return AccHeadList;
        }
    }
}
