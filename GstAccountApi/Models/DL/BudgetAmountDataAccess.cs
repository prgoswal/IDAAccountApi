using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class BudgetAmountDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataSet dsBudgetAmount;
        DataTable dtBudgetAmount;



        internal DataSet BindAll(BudgetAmountModel ObjBudgetAmountModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetAmount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetAmountModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetAmountModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetAmountModel.BrID);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsBudgetAmount = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsBudgetAmount);
                dsBudgetAmount.DataSetName = "success";
            }
            catch (Exception)
            {
                dsBudgetAmount = new DataSet();
                dsBudgetAmount.DataSetName = "error";
                return dsBudgetAmount;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsBudgetAmount;
        }


        internal DataTable SaveBudgetAmount(BudgetAmountModel ObjBudgetAmountModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetAmount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetAmountModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetAmountModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetAmountModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjBudgetAmountModel.YrCode);
                ClsCon.cmd.Parameters.AddWithValue("@SectionCD", ObjBudgetAmountModel.SectionCD);
                ClsCon.cmd.Parameters.AddWithValue("@SubSectionCD", ObjBudgetAmountModel.SubSectionCD);
                ClsCon.cmd.Parameters.AddWithValue("@BudgetHeadCD", ObjBudgetAmountModel.BudgetHeadCD);
                ClsCon.cmd.Parameters.AddWithValue("@Actual3budgetAmtDr", ObjBudgetAmountModel.Actual3budgetAmtDr);
                ClsCon.cmd.Parameters.AddWithValue("@Actual3budgetAmtCr ", ObjBudgetAmountModel.Actual3budgetAmtCr);
                ClsCon.cmd.Parameters.AddWithValue("@Prop2BudgetAmtDr", ObjBudgetAmountModel.Prop2BudgetAmtDr);
                ClsCon.cmd.Parameters.AddWithValue("@Prop2BudgetAmtCr", ObjBudgetAmountModel.Prop2BudgetAmtCr);
                ClsCon.cmd.Parameters.AddWithValue("@Sanc2BudgetAmtDr", ObjBudgetAmountModel.Sanc2BudgetAmtDr);
                ClsCon.cmd.Parameters.AddWithValue("@Sanc2BudgetAmtCr", ObjBudgetAmountModel.Sanc2BudgetAmtCr);
                ClsCon.cmd.Parameters.AddWithValue("@Actual2budgetAmtDr", ObjBudgetAmountModel.Actual2budgetAmtDr);
                ClsCon.cmd.Parameters.AddWithValue("@Actual2budgetAmtcr", ObjBudgetAmountModel.Actual2budgetAmtcr);
                ClsCon.cmd.Parameters.AddWithValue("@PropBudgetAmtDr", ObjBudgetAmountModel.PropBudgetAmtDr);
                ClsCon.cmd.Parameters.AddWithValue("@PropBudgetAmtCr", ObjBudgetAmountModel.PropBudgetAmtCr);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", ObjBudgetAmountModel.UserID);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddr", ObjBudgetAmountModel.IP);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBudgetAmount = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBudgetAmount);
                dtBudgetAmount.TableName = "success";
            }
            catch (Exception)
            {
                dtBudgetAmount = new DataTable();
                dtBudgetAmount.TableName = "error";
                return dtBudgetAmount;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBudgetAmount;
        }

        internal DataTable CheckBudgetAmount(BudgetAmountModel ObjBudgetAmountModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetAmount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetAmountModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetAmountModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetAmountModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjBudgetAmountModel.YrCode);
                ClsCon.cmd.Parameters.AddWithValue("@SectionCD", ObjBudgetAmountModel.SectionCD);
                ClsCon.cmd.Parameters.AddWithValue("@SubSectionCD", ObjBudgetAmountModel.SubSectionCD);
                ClsCon.cmd.Parameters.AddWithValue("@BudgetHeadCD", ObjBudgetAmountModel.BudgetHeadCD);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBudgetAmount = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBudgetAmount);
                dtBudgetAmount.TableName = "success";
            }
            catch (Exception)
            {
                dtBudgetAmount = new DataTable();
                dtBudgetAmount.TableName = "error";
                return dtBudgetAmount;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBudgetAmount;
        }
    }
}