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
    public class UpdateWarehouseController : ApiController
    {
        UpdateWarehouseDataAccess objUpdWDA = new UpdateWarehouseDataAccess();

        [HttpPost]
        public DataTable fillWarehouse(UpdateWarehouseModel ObjUpdWarehouseModel)
        {


            DataTable fillWareHouseList = objUpdWDA.LoadWareHouse(ObjUpdWarehouseModel);
            return fillWareHouseList;
        }

        [HttpPost]
        public DataTable StateList(UpdateWarehouseModel ObjUpdWarehouseModel)
        {


            DataTable fillStateList = objUpdWDA.LoadState(ObjUpdWarehouseModel);
            return fillStateList;
        }

        [HttpPost]
        public DataTable SearchControl(UpdateWarehouseModel ObjUpdWarehouseModel)
        {


            DataTable Searchitem = objUpdWDA.SearchItem(ObjUpdWarehouseModel);
            return Searchitem;
        }
        [HttpPost]
        public DataTable SaveWarehouseData(UpdateWarehouseModel ObjUpdWarehouseModel)
        {


            DataTable Savinglist = objUpdWDA.SaveUpdWareHouse(ObjUpdWarehouseModel);
            return Savinglist;
        }
    }
}
