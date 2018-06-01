using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class BudgetSectionDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtBudgetSection;

        internal DataTable SaveBudgetSection(BudgetSectionModel ObjBudgetSectionModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetSection";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetSectionModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetSectionModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetSectionModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", ObjBudgetSectionModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", ObjBudgetSectionModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@SectionName", ObjBudgetSectionModel.SectionName);
                ClsCon.cmd.Parameters.AddWithValue("@SectionNameHindi", ObjBudgetSectionModel.SectionNameHindi);
                ClsCon.cmd.Parameters.AddWithValue("@ParentSectionID", ObjBudgetSectionModel.ParentSectionID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBudgetSection = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBudgetSection);
                dtBudgetSection.TableName = "success";
            }
            catch (Exception)
            {
                dtBudgetSection = new DataTable();
                dtBudgetSection.TableName = "error";
                return dtBudgetSection;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBudgetSection;
        }

        internal DataTable BindAll(BudgetSectionModel ObjBudgetSectionModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetSection";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetSectionModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetSectionModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetSectionModel.BrID);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBudgetSection = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBudgetSection);
                dtBudgetSection.TableName = "success";
            }
            catch (Exception)
            {
                dtBudgetSection = new DataTable();
                dtBudgetSection.TableName = "error";
                return dtBudgetSection;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBudgetSection;
        }

        internal DataTable UpdateBudgetSection(BudgetSectionModel ObjBudgetSectionModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetSection";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetSectionModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetSectionModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetSectionModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", ObjBudgetSectionModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", ObjBudgetSectionModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@SectionName", ObjBudgetSectionModel.SectionName);
                ClsCon.cmd.Parameters.AddWithValue("@SectionNameHindi", ObjBudgetSectionModel.SectionNameHindi);
                ClsCon.cmd.Parameters.AddWithValue("@ParentSectionID", ObjBudgetSectionModel.ParentSectionID);
                ClsCon.cmd.Parameters.AddWithValue("@SectionID", ObjBudgetSectionModel.SectionID);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBudgetSection = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBudgetSection);
                dtBudgetSection.TableName = "success";
            }
            catch (Exception)
            {
                dtBudgetSection = new DataTable();
                dtBudgetSection.TableName = "error";
                return dtBudgetSection;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBudgetSection;
        }

        internal DataTable DeleteBudgetSection(BudgetSectionModel ObjBudgetSectionModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetSection";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetSectionModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetSectionModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetSectionModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@SectionID", ObjBudgetSectionModel.SectionID);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBudgetSection = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBudgetSection);
                dtBudgetSection.TableName = "success";
            }
            catch (Exception)
            {
                dtBudgetSection = new DataTable();
                dtBudgetSection.TableName = "error";
                return dtBudgetSection;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBudgetSection;
        }
    }
}