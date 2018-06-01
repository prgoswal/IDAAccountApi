using GstAccountApi.Models.PL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class BudgetUserRightsDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataSet dsBudgetRights; DataTable dtBudgetRights;


        internal DataSet BindAllDDL(BudgetUserRightsModel ObjBudgetUserRightsModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetRights";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetUserRightsModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetUserRightsModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetUserRightsModel.BrID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsBudgetRights = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsBudgetRights);
                dsBudgetRights.DataSetName = "success";
            }
            catch (Exception)
            {
                dsBudgetRights = new DataSet();
                dsBudgetRights.DataSetName = "error";
                return dsBudgetRights;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsBudgetRights;
        }

        internal DataSet SaveBudgetRights(BudgetUserRightsModel ObjBudgetUserRightsModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetRights";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetUserRightsModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetUserRightsModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetUserRightsModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@DepartmentID", ObjBudgetUserRightsModel.DepartmentID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjBudgetUserRightsModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@SubDeptID", ObjBudgetUserRightsModel.SubDeptID);
                ClsCon.cmd.Parameters.AddWithValue("@UserRights", JsonConvert.DeserializeObject<DataTable>(ObjBudgetUserRightsModel.TblUserRights));

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsBudgetRights = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsBudgetRights);
                dsBudgetRights.DataSetName = "success";
            }
            catch (Exception)
            {
                dsBudgetRights = new DataSet();
                dsBudgetRights.DataSetName = "error";
                return dsBudgetRights;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsBudgetRights;
        }

        internal DataTable AllotedBudgetRights(BudgetUserRightsModel ObjBudgetUserRightsModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetRights";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetUserRightsModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetUserRightsModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetUserRightsModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@DepartmentID", ObjBudgetUserRightsModel.DepartmentID);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBudgetRights = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBudgetRights);
                dtBudgetRights.TableName = "success";
            }
            catch (Exception)
            {
                dtBudgetRights = new DataTable();
                dtBudgetRights.TableName = "error";
                return dtBudgetRights;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBudgetRights;
        }
    }
}