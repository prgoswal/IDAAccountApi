using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class NewBudgetAmountDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataSet dsBudgetAmount;
        DataTable dtBudgetAmount;



        internal DataSet BindAll(NewBudgetAmountModel ObjNewBudgetAmountModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetAmount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjNewBudgetAmountModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjNewBudgetAmountModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjNewBudgetAmountModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@DeptID", ObjNewBudgetAmountModel.DeptID);

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


        internal DataTable SaveBudgetAmount(NewBudgetAmountModel ObjNewBudgetAmountModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetAmount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjNewBudgetAmountModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjNewBudgetAmountModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjNewBudgetAmountModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjNewBudgetAmountModel.YrCode);
                ClsCon.cmd.Parameters.AddWithValue("@SectionCD", ObjNewBudgetAmountModel.SectionCD);
                ClsCon.cmd.Parameters.AddWithValue("@SubSectionCD", ObjNewBudgetAmountModel.SubSectionCD);
                ClsCon.cmd.Parameters.AddWithValue("@BudgetHeadCD", ObjNewBudgetAmountModel.BudgetHeadCD);
                ClsCon.cmd.Parameters.AddWithValue("@SecCode", ObjNewBudgetAmountModel.SecCode);

                ClsCon.cmd.Parameters.AddWithValue("@ActualUptoBudgetAmtDr", ObjNewBudgetAmountModel.ActualUptoBudgetAmtDr);
                ClsCon.cmd.Parameters.AddWithValue("@ActualUptoBudgetAmtCr ", ObjNewBudgetAmountModel.ActualUptoBudgetAmtCr);

                ClsCon.cmd.Parameters.AddWithValue("@Prop2BudgetAmtDr", ObjNewBudgetAmountModel.Prop2BudgetAmtDr);
                ClsCon.cmd.Parameters.AddWithValue("@Prop2BudgetAmtCr", ObjNewBudgetAmountModel.Prop2BudgetAmtCr);

                ClsCon.cmd.Parameters.AddWithValue("@Sanc2BudgetAmtDr", ObjNewBudgetAmountModel.Sanc2BudgetAmtDr);
                ClsCon.cmd.Parameters.AddWithValue("@Sanc2BudgetAmtCr", ObjNewBudgetAmountModel.Sanc2BudgetAmtCr);

                ClsCon.cmd.Parameters.AddWithValue("@PropLastQtrBudgetAmtDr", ObjNewBudgetAmountModel.PropLastQtrBudgetAmtDr);
                ClsCon.cmd.Parameters.AddWithValue("@PropLastQtrBudgetAmtCr", ObjNewBudgetAmountModel.PropLastQtrBudgetAmtCr);

                ClsCon.cmd.Parameters.AddWithValue("@PropBudgetAmtDr", ObjNewBudgetAmountModel.PropBudgetAmtDr);
                ClsCon.cmd.Parameters.AddWithValue("@PropBudgetAmtCr", ObjNewBudgetAmountModel.PropBudgetAmtCr);

                ClsCon.cmd.Parameters.AddWithValue("@PropBudgetCapitalAmtCr", ObjNewBudgetAmountModel.PropBudgetCapitalAmtCr);
                ClsCon.cmd.Parameters.AddWithValue("@PropBudgetCapitalAmtDr", ObjNewBudgetAmountModel.PropBudgetCapitalAmtDr);

                ClsCon.cmd.Parameters.AddWithValue("@PropBudgetRevenueAmtCr", ObjNewBudgetAmountModel.PropBudgetRevenueAmtCr);
                ClsCon.cmd.Parameters.AddWithValue("@PropBudgetRevenueAmtDr", ObjNewBudgetAmountModel.PropBudgetRevenueAmtDr);

                ClsCon.cmd.Parameters.AddWithValue("@UserID", ObjNewBudgetAmountModel.UserID);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddr", ObjNewBudgetAmountModel.IP);

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

        internal DataTable CheckBudgetAmount(NewBudgetAmountModel ObjNewBudgetAmountModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetAmount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjNewBudgetAmountModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjNewBudgetAmountModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjNewBudgetAmountModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjNewBudgetAmountModel.YrCode);
                ClsCon.cmd.Parameters.AddWithValue("@SectionCD", ObjNewBudgetAmountModel.SectionCD);
                ClsCon.cmd.Parameters.AddWithValue("@SubSectionCD", ObjNewBudgetAmountModel.SubSectionCD);
                ClsCon.cmd.Parameters.AddWithValue("@BudgetHeadCD", ObjNewBudgetAmountModel.BudgetHeadCD);
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

        internal DataTable BindAllocatedScheme(NewBudgetAmountModel ObjNewBudgetAmountModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetReport";
                ClsCon.cmd.Parameters.AddWithValue("@RptInd", ObjNewBudgetAmountModel.Ind);
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