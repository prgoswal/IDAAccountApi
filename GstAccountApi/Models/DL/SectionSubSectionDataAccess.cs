using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class SectionSubSectionDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtCostCentre;

        internal DataTable LoadMainCost(SectionSubSectionModel ObjSectionSubSectionModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCostCentre";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjSectionSubSectionModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSectionSubSectionModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjSectionSubSectionModel.BrID);

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



        internal DataTable SaveCostCentre(SectionSubSectionModel ObjSectionSubSectionModel)
        {

            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCostCentre";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjSectionSubSectionModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSectionSubSectionModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjSectionSubSectionModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", ObjSectionSubSectionModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", ObjSectionSubSectionModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@CostCentreName", ObjSectionSubSectionModel.CostCentreName);
                ClsCon.cmd.Parameters.AddWithValue("@ParentCostCentreID", ObjSectionSubSectionModel.ParentCostCentreID);
                ClsCon.cmd.Parameters.AddWithValue("@CostCentreID", ObjSectionSubSectionModel.CostCentreID);

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



        internal DataTable DeleteCostCentre(SectionSubSectionModel ObjSectionSubSectionModel)
        {

            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCostCentre";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjSectionSubSectionModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSectionSubSectionModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjSectionSubSectionModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", ObjSectionSubSectionModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", ObjSectionSubSectionModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@CostCentreName", ObjSectionSubSectionModel.CostCentreName);
                ClsCon.cmd.Parameters.AddWithValue("@ParentCostCentreID", ObjSectionSubSectionModel.ParentCostCentreID);

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