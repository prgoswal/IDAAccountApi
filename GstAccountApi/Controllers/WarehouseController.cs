using GstAccountApi.Models.PL;
using GstAccountApi.Models.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GstAccountApi.Controllers
{
    public class WarehouseController : ApiController
    {
        WarehouseDataAccess objWarehouseDA;

        [HttpPost]
        public DataTable StateList(WarehouseModel ObjWarehouseModel)
        {
            objWarehouseDA = new WarehouseDataAccess();

            DataTable fillStateList = objWarehouseDA.LoadState(ObjWarehouseModel);
            return fillStateList;
        }

        [HttpPost]
        public DataTable CityList(WarehouseModel ObjWarehouseModel)
        {
            objWarehouseDA = new WarehouseDataAccess();

            DataTable fillStateList = objWarehouseDA.LoadCity(ObjWarehouseModel);
            return fillStateList;
        } 

        [HttpPost] 
        public DataTable CompnyGSTIN(WarehouseModel ObjWarehouseModel)
        {
            objWarehouseDA = new WarehouseDataAccess();

            DataTable fillGSTINList = objWarehouseDA.LoadGSTINNo(ObjWarehouseModel);
            return fillGSTINList;
        }  

        [HttpPost] 
        public DataTable SaveWarehouseData(WarehouseModel ObjWarehouseModel)
        {
            objWarehouseDA = new WarehouseDataAccess();

            DataTable Savinglist = objWarehouseDA.SaveWareHouse(ObjWarehouseModel);
            return Savinglist;
        }
    }
}
