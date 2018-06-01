using GstAccountApi.Models.DL;
using GstAccountApi.Models.PL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace GstAccountApi.Controllers
{
    public class Data
    {
        public string DetailData { get; set; }
    }

    public class OfflineSeriesController : ApiController
    {
        OfflineSeriesDataAccess ObjOfflineSeriesDA;
        OfflineSeriesModel objModel;
        ClsDownloadSuccess objUpdateModel;

        string resp = string.Empty;
        string jsonString = string.Empty;
        ClsCommonMsg objMsg;
        int respInd = 0;
        [HttpPost]
        public string GetData(Data Obj)
        {
            var DecodedData = Base64Decode(Obj.DetailData);

            FormEntry obj = JsonConvert.DeserializeObject<FormEntry>(DecodedData);
            if (obj != null)
            {
                objModel = new OfflineSeriesModel();
                objModel.Ind = 1;
                objModel.OrgID = obj.OrgID;
                objModel.BrID = obj.BrID;
                objModel.SeriesType = obj.SeriesType;
                objModel.UserName = obj.UserName;
                objModel.UserPassword = obj.UserPassword;
                objModel.MacAddress = obj.MacAddress;
                objModel.Binding_SeriesList = ToDataTable(obj.Binding_SeriesList);

                ObjOfflineSeriesDA = new OfflineSeriesDataAccess();
                DataTable dt = ObjOfflineSeriesDA.CheckInvoiceSeries(objModel);
                if (dt != null && dt.Rows.Count > 0)
                {

                    respInd = Convert.ToInt32(dt.Rows[0][0].ToString());
                    if (respInd == 1)
                    {
                        objMsg = new ClsCommonMsg();
                        objMsg.Code = 1;
                        objMsg.Msg = "Successfully Save";
                        objMsg.DownloadLocation = "";

                    }
                    else if (respInd == 2)
                    {
                        objMsg = new ClsCommonMsg();
                        objMsg.Code = 2;
                        objMsg.Msg = "";
                        objMsg.DownloadLocation = string.Empty;
                    }
                    else if (respInd == 9)
                    {
                        objMsg = new ClsCommonMsg();
                        objMsg.Code = 9;
                        objMsg.Msg = "";
                        objMsg.DownloadLocation = string.Empty;
                    }

                    jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(objMsg);
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
                //error
                resp = Base64Encode("Error");
            }
            return resp;
        }

        [HttpPost]
        public string UpdateRecord(Data Obj)
        {
            var DecodedData = Base64Decode(Obj.DetailData);

            ClsDownloadSuccess obj = JsonConvert.DeserializeObject<ClsDownloadSuccess>(DecodedData);
            if (obj != null)
            {
                objUpdateModel = new ClsDownloadSuccess();
                objUpdateModel.Ind = 2;
                objUpdateModel.OrgID = obj.OrgID;
                objUpdateModel.BrID = obj.BrID;
                objUpdateModel.UserName = obj.UserName;
                objUpdateModel.UserPassword = obj.UserPassword;
                objUpdateModel.DowinloadSuccessInd = obj.DowinloadSuccessInd;
                ObjOfflineSeriesDA = new OfflineSeriesDataAccess();
                DataTable dt = ObjOfflineSeriesDA.UpdateRecord(obj);
                if (dt != null && dt.Rows.Count > 0)
                {

                    respInd = Convert.ToInt32(dt.Rows[0][0].ToString());
                    if (respInd == 8)
                    {
                        objMsg = new ClsCommonMsg();
                        objMsg.Code = 8;
                        objMsg.Msg = "Successfully Update";
                        objMsg.DownloadLocation = "";

                    }

                    jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(objMsg);
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
                //error
                resp = Base64Encode("Error");
            }
            return resp;
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

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }



    }
}
