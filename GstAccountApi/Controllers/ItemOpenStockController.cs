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

    public class ItemOpenStockController : ApiController
    {
        ItemOpenningStockDataAccess objOpenStockDA = new ItemOpenningStockDataAccess();
        [HttpPost]
        public DataTable FillItemName(ItemOpenningStockModel ObjopenStockModel)
        {
            DataTable dtFillItemName = objOpenStockDA.FillItemName(ObjopenStockModel);
            return dtFillItemName;
        } 

        [HttpPost] 
        public DataSet FillUnit(ItemOpenningStockModel ObjopenStockModel)
        {
            ObjopenStockModel.Ind=14;
            DataSet DSFillUnit = objOpenStockDA.FillUnit(ObjopenStockModel);

            //DSFillUnit.Tables[0].TableName = "PrimaryUnit";
            //DSFillUnit.Tables[1].TableName = "SecondryUnit";

            return DSFillUnit;
        }

    
        [HttpPost]
        public DataTable FillWareHouse(ItemOpenningStockModel ObjopenStockModel)
        {
            DataTable dtFillWareHouse = objOpenStockDA.FillIWareHouseName(ObjopenStockModel);
            return dtFillWareHouse;
        }
        [HttpPost]
        public DataTable FillGridItem(ItemOpenningStockModel ObjopenStockModel)
        {
            DataTable dtFillGridItem = objOpenStockDA.FillGridItemName(ObjopenStockModel);
            return dtFillGridItem;
        } 

        [HttpPost]
        public DataTable SaveStockEntry(ItemOpenningStockModel ObjopenStockModel)
        {
            DataTable dtSaveProcess = objOpenStockDA.SaveEntry(ObjopenStockModel);
            return dtSaveProcess;
        } 
    }
}
