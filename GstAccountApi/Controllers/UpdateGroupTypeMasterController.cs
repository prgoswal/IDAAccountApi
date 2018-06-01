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
    public class UpdateGroupTypeMasterController : ApiController
    {
        UpdateGroupTypeDataAccess objUpdGrTypeDA;
        [HttpPost]
        public DataTable FillGrid(UpdateGroupMasterModel ObjPlGroupTypeModel)
        {
            objUpdGrTypeDA = new UpdateGroupTypeDataAccess();

            DataTable fillGridGrType = objUpdGrTypeDA.FillGridView(ObjPlGroupTypeModel);
            return fillGridGrType;
        }

        [HttpPost]
        public DataTable UpdateProcess(UpdateGroupMasterModel ObjPlGroupTypeModel)
        {
            objUpdGrTypeDA = new UpdateGroupTypeDataAccess();

            DataTable UpdateGrType = objUpdGrTypeDA.SaveProcessGroupItem(ObjPlGroupTypeModel);
            return UpdateGrType;
        }

    }
}
