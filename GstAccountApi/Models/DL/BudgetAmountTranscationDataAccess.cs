using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class BudgetAmountTranscationDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataSet dsBudgetAmount;
        DataTable dtBudgetAmount;



        internal DataSet BindAll(BudgetAmountTranscationModel ObjBudgetAmountTranscationModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetAmount_New";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetAmountTranscationModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetAmountTranscationModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetAmountTranscationModel.BrID);
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


        internal DataTable SaveBudgetAmount(BudgetAmountTranscationModel ObjBudgetAmountTranscationModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetAmount_New";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetAmountTranscationModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetAmountTranscationModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetAmountTranscationModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjBudgetAmountTranscationModel.YrCode);
                ClsCon.cmd.Parameters.AddWithValue("@SectionCD", ObjBudgetAmountTranscationModel.SectionCD);
                ClsCon.cmd.Parameters.AddWithValue("@SubSectionCD", ObjBudgetAmountTranscationModel.SubSectionCD);
                ClsCon.cmd.Parameters.AddWithValue("@BudgetHeadCD", ObjBudgetAmountTranscationModel.BudgetHeadCD);
                ClsCon.cmd.Parameters.AddWithValue("@Actual3budgetAmtDr", ObjBudgetAmountTranscationModel.Actual3budgetAmtDr);
                ClsCon.cmd.Parameters.AddWithValue("@Actual3budgetAmtCr ", ObjBudgetAmountTranscationModel.Actual3budgetAmtCr);
                ClsCon.cmd.Parameters.AddWithValue("@Prop2BudgetAmtDr", ObjBudgetAmountTranscationModel.Prop2BudgetAmtDr);
                ClsCon.cmd.Parameters.AddWithValue("@Prop2BudgetAmtCr", ObjBudgetAmountTranscationModel.Prop2BudgetAmtCr);
                ClsCon.cmd.Parameters.AddWithValue("@Sanc2BudgetAmtDr", ObjBudgetAmountTranscationModel.Sanc2BudgetAmtDr);
                ClsCon.cmd.Parameters.AddWithValue("@Sanc2BudgetAmtCr", ObjBudgetAmountTranscationModel.Sanc2BudgetAmtCr);
                ClsCon.cmd.Parameters.AddWithValue("@Actual2budgetAmtDr", ObjBudgetAmountTranscationModel.Actual2budgetAmtDr);
                ClsCon.cmd.Parameters.AddWithValue("@Actual2budgetAmtcr", ObjBudgetAmountTranscationModel.Actual2budgetAmtcr);
                ClsCon.cmd.Parameters.AddWithValue("@PropBudgetAmtDr", ObjBudgetAmountTranscationModel.PropBudgetAmtDr);
                ClsCon.cmd.Parameters.AddWithValue("@PropBudgetAmtCr", ObjBudgetAmountTranscationModel.PropBudgetAmtCr);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", ObjBudgetAmountTranscationModel.UserID);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddr", ObjBudgetAmountTranscationModel.IP);

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

        internal DataTable CheckBudgetAmount(BudgetAmountTranscationModel ObjBudgetAmountTranscationModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetAmount_New";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetAmountTranscationModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjBudgetAmountTranscationModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjBudgetAmountTranscationModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjBudgetAmountTranscationModel.YrCode);
                ClsCon.cmd.Parameters.AddWithValue("@SectionCD", ObjBudgetAmountTranscationModel.SectionCD);
                ClsCon.cmd.Parameters.AddWithValue("@SubSectionCD", ObjBudgetAmountTranscationModel.SubSectionCD);
                ClsCon.cmd.Parameters.AddWithValue("@BudgetHeadCD", ObjBudgetAmountTranscationModel.BudgetHeadCD);
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