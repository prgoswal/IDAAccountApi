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
    public class ItemGroupController : ApiController
    {
        DataTable dt;
        ItemGroupDataAccess dl = new ItemGroupDataAccess();

        [HttpGet]
        public IHttpActionResult Default(int id)
        {
            List<ItemGroupModel> obj = dl.Get();
            return Ok(obj);
        }

        [HttpPost]
        public IHttpActionResult Default(ItemGroupModel pl)
        {
            return Ok("Success");
        }
        [HttpGet]
        public IHttpActionResult CheckActivation(string UserID)
        {
            bool status = dl.CheckActivation(UserID);
            return Ok(status);
        }
    }
}
