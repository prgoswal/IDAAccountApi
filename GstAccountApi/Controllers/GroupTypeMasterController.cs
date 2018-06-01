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
    public class GroupTypeMasterController : ApiController
    {
        GroupTypeMasterDataAcess objGroupTypeDA;

        [HttpPost]
        public DataTable FillMainType(GroupTypeMasterModel ObjPlGroupTypeModel)
        {
            objGroupTypeDA = new GroupTypeMasterDataAcess();

            DataTable fillVoucherType = objGroupTypeDA.FillMainGrpddl(ObjPlGroupTypeModel);
            return fillVoucherType;
        }

        [HttpPost]
        public DataTable SaveGroupItem(GroupTypeMasterModel ObjPlGroupTypeModel)
        {
            objGroupTypeDA = new GroupTypeMasterDataAcess();

            DataTable SaveItem = objGroupTypeDA.SaveProcessGroupItem(ObjPlGroupTypeModel);
            return SaveItem;
        } 
    }
}
