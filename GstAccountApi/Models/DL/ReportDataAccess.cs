using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class ReportDataAccess
    {
        DataTable dtBankPayment, dtCashPayment, dtReport;
        SqlConnection con;

        internal DataTable LoadBankAccount(BankPaymentModel objBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objBankPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBankPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBankPayment);
                dtBankPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtBankPayment = new DataTable();
                dtBankPayment.TableName = "error";
                return dtBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBankPayment;
        }

        internal DataTable LoadCashAccount(CashPaymentModel objCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashPayment);
                dtCashPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtCashPayment = new DataTable();
                dtCashPayment.TableName = "error";
                return dtCashPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashPayment;
        }

        internal DataTable BalanceSheetOnLoad(MasterModel objMaster)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objMaster.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objMaster.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objMaster.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objMaster.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AsOnDate", objMaster.StartDate);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtReport = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtReport);
                dtReport.TableName = "success";
            }
            catch (Exception)
            {
                dtReport = new DataTable();
                dtReport.TableName = "error";
                return dtReport;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtReport;
        }


        internal DataTable AccountHeadLoad(BudgetReportModel objRptModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetReport";
                ClsCon.cmd.Parameters.AddWithValue("@RptInd", objRptModel.RptInd);
                ClsCon.cmd.Parameters.AddWithValue("@CompanyID", objRptModel.CompanyID);
                ClsCon.cmd.Parameters.AddWithValue("@BranchID", objRptModel.BranchID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objRptModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtReport = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtReport);
                dtReport.TableName = "success";
            }
            catch (Exception)
            {
                dtReport = new DataTable();
                dtReport.TableName = "error";
                return dtReport;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtReport;
        }

        internal DataTable LoadScheme(BudgetReportModel ObjRptModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSchemeWiseTransactions";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjRptModel.Ind);
                //ClsCon.cmd.Parameters.AddWithValue("@CompanyID", ObjRptModel.CompanyID);
                //ClsCon.cmd.Parameters.AddWithValue("@BranchID", ObjRptModel.BranchID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCode", ObjRptModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtReport = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtReport);
                dtReport.TableName = "success";
            }
            catch (Exception ex)
            {
                dtReport = new DataTable();
                dtReport.TableName = "error";
                return dtReport;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtReport;
        }

        internal DataTable FillSectionName(BudgetReportModel ObjRptModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetReport";
                ClsCon.cmd.Parameters.AddWithValue("@RptInd", ObjRptModel.RptInd);
                ClsCon.cmd.Parameters.AddWithValue("@CompanyID", ObjRptModel.CompanyID);
                ClsCon.cmd.Parameters.AddWithValue("@BranchID", ObjRptModel.BranchID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjRptModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtReport = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtReport);
                dtReport.TableName = "success";
            }
            catch (Exception ex)
            {
                dtReport = new DataTable();
                dtReport.TableName = "error";
                return dtReport;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtReport;
        }
    }
}