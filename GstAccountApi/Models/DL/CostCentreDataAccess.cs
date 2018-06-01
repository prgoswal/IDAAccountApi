using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class CostCentreDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtCostCentre;

        internal DataTable LoadMainCost(CostCentreModel ObjCostCentreModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCostCentre";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjCostCentreModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjCostCentreModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjCostCentreModel.BrID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCostCentre = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCostCentre);
                dtCostCentre.TableName = "success";
            }
            catch (Exception)
            {
                dtCostCentre = new DataTable();
                dtCostCentre.TableName = "error";
                return dtCostCentre;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCostCentre;
        }



        internal DataTable SaveCostCentre(CostCentreModel ObjCostCentreModel)
        {

            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCostCentre";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjCostCentreModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjCostCentreModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjCostCentreModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", ObjCostCentreModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", ObjCostCentreModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@CostCentreName", ObjCostCentreModel.CostCentreName);

                ClsCon.cmd.Parameters.AddWithValue("@CostCentreID", ObjCostCentreModel.CostCentreID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCostCentre = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCostCentre);
                dtCostCentre.TableName = "success";
            }
            catch (Exception)
            {
                dtCostCentre = new DataTable();
                dtCostCentre.TableName = "error";
                return dtCostCentre;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCostCentre;
        }



        internal DataTable DeleteCostCentre(CostCentreModel ObjCostCentreModel)
        {

            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCostCentre";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjCostCentreModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjCostCentreModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjCostCentreModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", ObjCostCentreModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", ObjCostCentreModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@CostCentreName", ObjCostCentreModel.CostCentreName);


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCostCentre = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCostCentre);
                dtCostCentre.TableName = "success";
            }
            catch (Exception)
            {
                dtCostCentre = new DataTable();
                dtCostCentre.TableName = "error";
                return dtCostCentre;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCostCentre;
        }
    }
}