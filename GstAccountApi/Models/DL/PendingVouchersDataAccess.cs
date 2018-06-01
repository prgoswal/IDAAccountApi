using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class PendingVouchersDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtPendingVouchers;
        DataSet dsPendingVouchers;

        internal DataSet BindPendingVouchers(PendingVouchersModel objPendingVouchersModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPPendingVouchers";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objPendingVouchersModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPendingVouchersModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objPendingVouchersModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objPendingVouchersModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@UserLevel", objPendingVouchersModel.UserLevel);
                //ClsCon.cmd.Parameters.AddWithValue("@User", objPendingVouchersModel.User);
                //ClsCon.cmd.Parameters.AddWithValue("@IsAdmin", objPendingVouchersModel.IsAdmin);
                //ClsCon.cmd.Parameters.AddWithValue("@DepartmentID", objPendingVouchersModel.DepartmentID);
                //ClsCon.cmd.Parameters.AddWithValue("@SubDepartmentID", objPendingVouchersModel.SubDepartmentID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsPendingVouchers = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsPendingVouchers);
                dsPendingVouchers.DataSetName = "success";
            }
            catch (Exception)
            {
                dsPendingVouchers = new DataSet();
                dsPendingVouchers.DataSetName = "error";
                return dsPendingVouchers;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsPendingVouchers;
        }

        internal DataTable DataApproved(PendingVouchersModel objPendingVouchersModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPPendingVouchers";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objPendingVouchersModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPendingVouchersModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objPendingVouchersModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objPendingVouchersModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@TransactionNo", objPendingVouchersModel.TransactionNo);
                ClsCon.cmd.Parameters.AddWithValue("@TransactionDate", objPendingVouchersModel.TransactionDate);
                ClsCon.cmd.Parameters.AddWithValue("@BankPayTNo", objPendingVouchersModel.BankPayTNo);
                ClsCon.cmd.Parameters.AddWithValue("@BankPayVType", objPendingVouchersModel.BankPayVType);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objPendingVouchersModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@ApprovalDate", objPendingVouchersModel.ApprovalDate);
                ClsCon.cmd.Parameters.AddWithValue("@ApprovalRemark", objPendingVouchersModel.ApprovalRemark);
                ClsCon.cmd.Parameters.AddWithValue("@User", objPendingVouchersModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", objPendingVouchersModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@IsFinal", objPendingVouchersModel.IsFinal);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPendingVouchers = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPendingVouchers);
                dtPendingVouchers.TableName = "success";
            }
            catch (Exception)
            {
                dtPendingVouchers = new DataTable();
                dtPendingVouchers.TableName = "error";
                return dtPendingVouchers;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPendingVouchers;
        }

        internal DataTable FinalApproval(PendingVouchersModel objPendingVouchersModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPPendingVouchers";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objPendingVouchersModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPendingVouchersModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objPendingVouchersModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objPendingVouchersModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@TransactionNo", objPendingVouchersModel.TransactionNo);
                ClsCon.cmd.Parameters.AddWithValue("@TransactionDate", objPendingVouchersModel.TransactionDate);
                ClsCon.cmd.Parameters.AddWithValue("@BankPayTNo", objPendingVouchersModel.BankPayTNo);
                ClsCon.cmd.Parameters.AddWithValue("@BankPayVType", objPendingVouchersModel.BankPayVType);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objPendingVouchersModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@ApprovalDate", objPendingVouchersModel.ApprovalDate);
                ClsCon.cmd.Parameters.AddWithValue("@ApprovalRemark", objPendingVouchersModel.ApprovalRemark);
                ClsCon.cmd.Parameters.AddWithValue("@User", objPendingVouchersModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", objPendingVouchersModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@IsFinal", objPendingVouchersModel.IsFinal);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPendingVouchers = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPendingVouchers);
                dtPendingVouchers.TableName = "success";
            }
            catch (Exception)
            {
                dtPendingVouchers = new DataTable();
                dtPendingVouchers.TableName = "error";
                return dtPendingVouchers;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPendingVouchers;
        }

        internal DataTable AuditPendingRecords(PendingVouchersModel objPendingVouchersModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPPendingVouchers";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objPendingVouchersModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPendingVouchersModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objPendingVouchersModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objPendingVouchersModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@TransactionNo", objPendingVouchersModel.TransactionNo);
                ClsCon.cmd.Parameters.AddWithValue("@TransactionDate", objPendingVouchersModel.TransactionDate);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objPendingVouchersModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@IsAudit", objPendingVouchersModel.IsAudit);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPendingVouchers = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPendingVouchers);
                dtPendingVouchers.TableName = "success";
            }
            catch (Exception)
            {
                dtPendingVouchers = new DataTable();
                dtPendingVouchers.TableName = "error";
                return dtPendingVouchers;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPendingVouchers;
        }
    }
}