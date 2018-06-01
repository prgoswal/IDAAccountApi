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
    public class ItemMasterController : ApiController
    {
        ItemMasterDataAccess objIMDA = new ItemMasterDataAccess();

        [HttpPost]
        public DataSet ItemMasterDDL(ItemMasterModel objIMModel)
        {
            DataSet dsItemMaster = new DataSet();

            objIMModel.Ind = 2;
            DataTable dtItemGroup = objIMDA.LoadItemGroup(objIMModel);
            dtItemGroup.TableName = "ItemGroup";
            dsItemMaster.Tables.Add(dtItemGroup);

            objIMModel.Ind = 14;
            DataTable dtItemUnit = objIMDA.LoadItemUnit(objIMModel);
            dtItemUnit.TableName = "ItemUnit";
            dsItemMaster.Tables.Add(dtItemUnit);

            objIMModel.Ind = 2;
            DataTable dtWarehouse = objIMDA.LoadWarehouse(objIMModel);
            dtWarehouse.TableName = "Warehouse";
            dsItemMaster.Tables.Add(dtWarehouse);

            objIMModel.Ind = 40;
            DataTable dtTaxRate = objIMDA.LoadTaxRate(objIMModel);
            dtTaxRate.TableName = "TaxRate";
            dsItemMaster.Tables.Add(dtTaxRate);

         

            return dsItemMaster;
        }

        [HttpPost]
        public DataTable LoadHSNSCDesc(ItemMasterModel objIMModel)
        {
            DataTable dtHSNSACDesc = objIMDA.LoadHSNSCDesc(objIMModel);
            return dtHSNSACDesc;
        }

        [HttpPost]
        public DataTable SaveItem(ItemMasterModel objIMModel)
        {
            DataTable dtSave = objIMDA.SaveItem(objIMModel);
            return dtSave;
        }
    }
}
