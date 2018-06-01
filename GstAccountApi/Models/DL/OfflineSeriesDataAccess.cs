using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class OfflineSeriesDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtOfflineSeries;
        internal DataTable CheckInvoiceSeries(OfflineSeriesModel ObjOfflineSeriesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPOfflineSeries";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjOfflineSeriesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjOfflineSeriesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjOfflineSeriesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@UserName", ObjOfflineSeriesModel.UserName);
                ClsCon.cmd.Parameters.AddWithValue("@UserPassword", ObjOfflineSeriesModel.UserPassword);
                ClsCon.cmd.Parameters.AddWithValue("@MacAddress", ObjOfflineSeriesModel.MacAddress);
                ClsCon.cmd.Parameters.AddWithValue("@SeriesType", ObjOfflineSeriesModel.SeriesType);
                ClsCon.cmd.Parameters.AddWithValue("@TblSeries", ObjOfflineSeriesModel.Binding_SeriesList);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtOfflineSeries = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtOfflineSeries);
                dtOfflineSeries.TableName = "success";

            }
            catch (Exception)
            {
                dtOfflineSeries = new DataTable();
                dtOfflineSeries.TableName = "error";
                return dtOfflineSeries;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtOfflineSeries;
        }





        internal DataTable UpdateRecord(ClsDownloadSuccess obj)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPOfflineSeries";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", obj.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", obj.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", obj.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@UserName", obj.UserName);
                ClsCon.cmd.Parameters.AddWithValue("@UserPassword", obj.UserPassword);
                ClsCon.cmd.Parameters.AddWithValue("@DowinloadSuccessInd", obj.DowinloadSuccessInd);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtOfflineSeries = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtOfflineSeries);
                dtOfflineSeries.TableName = "success";

            }
            catch (Exception)
            {
                dtOfflineSeries = new DataTable();
                dtOfflineSeries.TableName = "error";
                return dtOfflineSeries;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtOfflineSeries;
        }
    }
}