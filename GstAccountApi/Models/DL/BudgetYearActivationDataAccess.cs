using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class BudgetYearActivationDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtFinancialYear;




        internal DataTable SaveFinancialYear(BudgetYearActivationModel ObjBudgetYearActivationModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetFinancialYear";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetYearActivationModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@YrCode", ObjBudgetYearActivationModel.YrCode);
                ClsCon.cmd.Parameters.AddWithValue("@YearFromTo", ObjBudgetYearActivationModel.YearFromTo);
                ClsCon.cmd.Parameters.AddWithValue("@ActiveID", ObjBudgetYearActivationModel.ActiveID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", ObjBudgetYearActivationModel.UserID);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", ObjBudgetYearActivationModel.IPAddress);
                ClsCon.cmd.Parameters.AddWithValue("@AccountInd ", ObjBudgetYearActivationModel.AccountInd);
                ClsCon.cmd.Parameters.AddWithValue("@BudgetInd", ObjBudgetYearActivationModel.BudgetInd);
                ClsCon.cmd.Parameters.AddWithValue("@YrStartDate", ObjBudgetYearActivationModel.YrStartDate);
                ClsCon.cmd.Parameters.AddWithValue("@YrEndDate", ObjBudgetYearActivationModel.YrEndDate);
                ClsCon.cmd.Parameters.AddWithValue("@BudgetOrderNumber", ObjBudgetYearActivationModel.BudgetOrderNumber);
                ClsCon.cmd.Parameters.AddWithValue("@BudgetOrderDate", ObjBudgetYearActivationModel.BudgetOrderDate);
                ClsCon.cmd.Parameters.AddWithValue("@BudgetEntryDate", ObjBudgetYearActivationModel.BudgetEntryDate);
                ClsCon.cmd.Parameters.AddWithValue("@AccountingOrderNumber", ObjBudgetYearActivationModel.AccountingOrderNumber);
                ClsCon.cmd.Parameters.AddWithValue("@AccountingOrderDate", ObjBudgetYearActivationModel.AccountingOrderDate);
                ClsCon.cmd.Parameters.AddWithValue("@AccountingEntryDate", ObjBudgetYearActivationModel.AccountingEntryDate);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtFinancialYear = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtFinancialYear);
                dtFinancialYear.TableName = "success";
            }
            catch (Exception)
            {
                dtFinancialYear = new DataTable();
                dtFinancialYear.TableName = "error";
                return dtFinancialYear;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtFinancialYear;
        }

        internal DataTable LoadFinancialYear(BudgetYearActivationModel ObjBudgetYearActivationModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetFinancialYear";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjBudgetYearActivationModel.Ind);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtFinancialYear = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtFinancialYear);
                dtFinancialYear.TableName = "success";
            }
            catch (Exception)
            {
                dtFinancialYear = new DataTable();
                dtFinancialYear.TableName = "error";
                return dtFinancialYear;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtFinancialYear;
        }
    }
}