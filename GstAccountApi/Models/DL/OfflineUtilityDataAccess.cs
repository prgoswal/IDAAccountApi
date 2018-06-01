using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class OfflineUtilityDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtOfflineUtility;


        internal DataTable LoadBranch(OfflineUtilityModel ObjOfflineUtilityModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjOfflineUtilityModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjOfflineUtilityModel.OrgID);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtOfflineUtility = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtOfflineUtility);
                dtOfflineUtility.TableName = "success";
            }
            catch (Exception)
            {
                dtOfflineUtility = new DataTable();
                dtOfflineUtility.TableName = "error";
                return dtOfflineUtility;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtOfflineUtility;
        }

        internal DataTable SaveOfflineRequest(OfflineUtilityModel ObjOfflineUtilityModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPOfflineRequest";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjOfflineUtilityModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjOfflineUtilityModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjOfflineUtilityModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@CompanyName", ObjOfflineUtilityModel.CompanyName);
                ClsCon.cmd.Parameters.AddWithValue("@BranchName", ObjOfflineUtilityModel.BranchName);
                ClsCon.cmd.Parameters.AddWithValue("@User", ObjOfflineUtilityModel.User);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtOfflineUtility = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtOfflineUtility);
                dtOfflineUtility.TableName = "success";
            }
            catch (Exception)
            {
                dtOfflineUtility = new DataTable();
                dtOfflineUtility.TableName = "error";
                return dtOfflineUtility;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtOfflineUtility;
        }
    }
}