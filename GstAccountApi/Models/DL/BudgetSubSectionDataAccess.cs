using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class BudgetSubSectionDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtBudgetSection;
        DataSet dsBudgetSection;


        internal DataTable SaveBudgetSubSection(BudgetSubSectionModel ObjBudgetSubSectionModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetSubSection";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetSubSectionModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetSubSectionModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetSubSectionModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", ObjBudgetSubSectionModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", ObjBudgetSubSectionModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@SectionName", ObjBudgetSubSectionModel.SubSectionName);
                ClsCon.cmd.Parameters.AddWithValue("@SectionNameHindi", ObjBudgetSubSectionModel.SubSectionNameHindi);
                ClsCon.cmd.Parameters.AddWithValue("@ParentSectionID", ObjBudgetSubSectionModel.ParentSectionID);
                ClsCon.cmd.Parameters.AddWithValue("@SchemeCode", ObjBudgetSubSectionModel.SchemeCode);


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

        internal DataSet BindAll(BudgetSubSectionModel ObjBudgetSubSectionModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetSubSection";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetSubSectionModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetSubSectionModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetSubSectionModel.BrID);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsBudgetSection = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsBudgetSection);
                dsBudgetSection.DataSetName = "success";
            }
            catch (Exception)
            {
                dsBudgetSection = new DataSet();
                dsBudgetSection.DataSetName = "error";
                return dsBudgetSection;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsBudgetSection;
        }

        internal DataTable UpdateBudgetSubSection(BudgetSubSectionModel ObjBudgetSubSectionModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetSubSection";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetSubSectionModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetSubSectionModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetSubSectionModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", ObjBudgetSubSectionModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", ObjBudgetSubSectionModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@SectionName", ObjBudgetSubSectionModel.SubSectionName);
                ClsCon.cmd.Parameters.AddWithValue("@SectionNameHindi", ObjBudgetSubSectionModel.SubSectionNameHindi);
                ClsCon.cmd.Parameters.AddWithValue("@ParentSectionID", ObjBudgetSubSectionModel.ParentSectionID);
                ClsCon.cmd.Parameters.AddWithValue("@SectionID", ObjBudgetSubSectionModel.SectionID);
                ClsCon.cmd.Parameters.AddWithValue("@SchemeCode", ObjBudgetSubSectionModel.SchemeCode);
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

        internal DataTable DeleteBudgetSubSection(BudgetSubSectionModel ObjBudgetSubSectionModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetSubSection";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetSubSectionModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetSubSectionModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetSubSectionModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetSubSectionModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@SectionID", ObjBudgetSubSectionModel.SectionID);
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