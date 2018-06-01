using GstAccountApi.Models.DL;
using GstAccountApi.Models.PL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GstAccountApi.Controllers
{

    public class SalesData
    {
        public string DetailData { get; set; }
    }
    public class OfflineSalesVoucherController : ApiController
    {
        OfflineSalesVoucherDataAccess ObjOfflineSalesDA = new OfflineSalesVoucherDataAccess();
        OfflineSalesVoucherModel ObjOfflineSalesModel;
        string resp = string.Empty;
        string jsonString = string.Empty;

        [HttpPost]
        public string GetSalesData(SalesData ObjSalesData)
        {
            var DecodedData = Base64Decode(ObjSalesData.DetailData);

            OfflineSalesVoucherModel obj = JsonConvert.DeserializeObject<OfflineSalesVoucherModel>(DecodedData);
            if (obj != null)
            {
                ObjOfflineSalesModel = new OfflineSalesVoucherModel();
                ObjOfflineSalesModel.Ind = 1;
                ObjOfflineSalesModel.OrgID = obj.OrgID;
                ObjOfflineSalesModel.BrID = obj.BrID;
                DataSet dsBindAll = ObjOfflineSalesDA.BindAll(ObjOfflineSalesModel);
                if (dsBindAll.Tables != null && dsBindAll.Tables.Count > 0)
                {
                    dsBindAll.Tables[0].TableName = "OfflineUserInfo";
                    dsBindAll.Tables[1].TableName = "WarehouseInfo";
                    dsBindAll.Tables[2].TableName = "MstAccountInfo";
                    dsBindAll.Tables[3].TableName = "MstAccountPOSInfo";
                    dsBindAll.Tables[4].TableName = "MstAccountGSTINInfo";
                    dsBindAll.Tables[5].TableName = "TblSeriesInfo";
                    dsBindAll.Tables[6].TableName = "MstItemInfo";
                    dsBindAll.Tables[7].TableName = "MstItemUnitInfo";
                    dsBindAll.Tables[8].TableName = "MstTransportModeInfo";

                    jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(dsBindAll);
                    resp = Base64Encode(jsonString);
                    return resp;
                }
                else
                {
                    resp = Base64Encode("Error");
                }
            }
            else
            {
                resp = Base64Encode("Error");
            }
            return resp;
            //string test = Newtonsoft.Json.JsonConvert.SerializeObject(resp);
            //string demo = Base64Decode(test);
        }


        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        //[HttpPost] // 100000
        //public string GetGistnNoWithDetail(SalesData ObjSalesData)
        //{
        //    var DecodedData = Base64Decode(ObjSalesData.DetailData);

        //    OfflineSalesVoucherModel obj = JsonConvert.DeserializeObject<OfflineSalesVoucherModel>(DecodedData);
        //    if (obj != null)
        //    {
        //        ObjOfflineSalesModel = new OfflineSalesVoucherModel();
        //        ObjOfflineSalesModel.Ind = 2;
        //        ObjOfflineSalesModel.OrgID = obj.OrgID;
        //        ObjOfflineSalesModel.BrID = obj.BrID;
        //        ObjOfflineSalesModel.YrCD = obj.YrCD;
        //        ObjOfflineSalesModel.AccCode = obj.AccCode;
        //        ObjOfflineSalesModel.AdvRecPayID = 13;
        //        DataSet dsBindAll = ObjOfflineSalesDA.FillGistnNoWithDetail(ObjOfflineSalesModel);
        //        if (dsBindAll.Tables != null && dsBindAll.Tables.Count > 0)
        //        {
        //            jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(dsBindAll);
        //            resp = Base64Encode(jsonString);
        //            return resp;
        //        }
        //        else
        //        {
        //            resp = Base64Encode("Error");
        //        }
        //    }
        //    else
        //    {
        //        resp = Base64Encode("Error");
        //    }
        //    return resp;
        //}


    }
}
