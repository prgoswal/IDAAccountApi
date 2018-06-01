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
    public class UpdateItemMasterController : ApiController
    {
        UpdateItemMasterDataAccess objUIMDA = new UpdateItemMasterDataAccess();

        [HttpPost]
        public DataSet ItemMasterDDL(UpdateItemMasterModel objUIMModel)
        {
            DataSet dsItemMaster = new DataSet();

            objUIMModel.Ind = 1;
            DataTable dtItems = objUIMDA.LoadItems(objUIMModel);
            dtItems.TableName = "Items";
            dsItemMaster.Tables.Add(dtItems);

            objUIMModel.Ind = 2;
            DataTable dtItemGroup = objUIMDA.LoadItemGroup(objUIMModel);
            dtItemGroup.TableName = "ItemGroup";
            dsItemMaster.Tables.Add(dtItemGroup);

            objUIMModel.Ind = 14;
            DataTable dtItemUnit = objUIMDA.LoadItemUnit(objUIMModel);
            dtItemUnit.TableName = "ItemUnit";
            dsItemMaster.Tables.Add(dtItemUnit);

            objUIMModel.Ind = 2;
            DataTable dtWarehouse = objUIMDA.LoadWarehouse(objUIMModel);
            dtWarehouse.TableName = "Warehouse";
            dsItemMaster.Tables.Add(dtWarehouse);

            objUIMModel.Ind = 40;
            DataTable dtTaxRate = objUIMDA.LoadTaxRate(objUIMModel); //objUIMDA.LoadTaxRate(objUIMModel);
            dtTaxRate.TableName = "TaxRate";
            dsItemMaster.Tables.Add(dtTaxRate);

            return dsItemMaster;
        }

        [HttpPost]
        public DataTable LoadHSNSCDesc(UpdateItemMasterModel objUIMModel)
        {
            DataTable dtHSNSACDesc = objUIMDA.LoadHSNSCDesc(objUIMModel);
            return dtHSNSACDesc;
        }

        [HttpPost]
        public DataTable LoadItemInfo(UpdateItemMasterModel objUIMModel)
        {
            DataTable dtItemInfo = objUIMDA.LoadItemInfo(objUIMModel);
            return dtItemInfo;
        }

        [HttpPost]
        public DataTable UpdateItem(UpdateItemMasterModel objUIMModel)
        {
            DataTable dtSave = objUIMDA.UpdateItem(objUIMModel);
            return dtSave;
        }
    }
}
