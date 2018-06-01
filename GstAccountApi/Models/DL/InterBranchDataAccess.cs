using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class InterBranchDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtBankReceipt; DataSet dtBranchList; DataTable dtInterBranch;

        internal DataTable AccountHead(InterBranchModel objInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPInterBranch";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objInterBranch.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objInterBranch.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBankReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBankReceipt);
                dtBankReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtBankReceipt = new DataTable();
                dtBankReceipt.TableName = "error";
                return dtBankReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBankReceipt;
        }

        internal DataTable LastVoucherNo(InterBranchModel objInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPInterBranch";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objInterBranch.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objInterBranch.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objInterBranch.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBankReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBankReceipt);
                dtBankReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtBankReceipt = new DataTable();
                dtBankReceipt.TableName = "error";
                return dtBankReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBankReceipt;
        }

        internal DataTable LoadNarration(InterBranchModel objInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objInterBranch.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objInterBranch.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objInterBranch.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBankReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBankReceipt);
                dtBankReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtBankReceipt = new DataTable();
                dtBankReceipt.TableName = "error";
                return dtBankReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBankReceipt;
        }

        internal DataTable LoadBankAccount(InterBranchModel objInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objInterBranch.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objInterBranch.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objInterBranch.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBankReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBankReceipt);
                dtBankReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtBankReceipt = new DataTable();
                dtBankReceipt.TableName = "error";
                return dtBankReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBankReceipt;
        }

        internal DataTable SaveBankReceipt(InterBranchModel objInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objInterBranch.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objInterBranch.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objInterBranch.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@TblBank", objInterBranch.Dt);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBankReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBankReceipt);
                dtBankReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtBankReceipt = new DataTable();
                dtBankReceipt.TableName = "error";
                return dtBankReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBankReceipt;
        }

        internal DataTable PartySelect(InterBranchModel objInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objInterBranch.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objInterBranch.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBankReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBankReceipt);
                dtBankReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtBankReceipt = new DataTable();
                dtBankReceipt.TableName = "error";
                return dtBankReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBankReceipt;
        }

        internal DataSet LoadBranchList(InterBranchModel objInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPInterBranch";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objInterBranch.BrID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBranchList = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBranchList);
                dtBranchList.DataSetName = "success";
            }
            catch (Exception)
            {
                dtBranchList = new DataSet();
                dtBranchList.DataSetName = "error";
                return dtBranchList;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBranchList;
        }

        internal DataTable SaveInterBranch(InterBranchModel objInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPInterBranch";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objInterBranch.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objInterBranch.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objInterBranch.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@AmountDr", objInterBranch.AmountDr);
                ClsCon.cmd.Parameters.AddWithValue("@AmountCr", objInterBranch.AmountCr);

                ClsCon.cmd.Parameters.AddWithValue("@IP", objInterBranch.IP);
                ClsCon.cmd.Parameters.AddWithValue("@DocDesc", objInterBranch.DocDesc);

                ClsCon.cmd.Parameters.AddWithValue("@BankCode", objInterBranch.BankCode);
                ClsCon.cmd.Parameters.AddWithValue("@InterBrID", objInterBranch.InterBrID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objInterBranch.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode2", objInterBranch.AccCode2);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", objInterBranch.DocDate);

                ClsCon.cmd.Parameters.AddWithValue("@AdvanceInd", objInterBranch.AdvanceInd);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objInterBranch.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objInterBranch.User);

                ClsCon.cmd.Parameters.AddWithValue("@TblBank", objInterBranch.Dt);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtInterBranch = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtInterBranch);
                dtInterBranch.TableName = "success";
            }
            catch (Exception)
            {
                dtInterBranch = new DataTable();
                dtInterBranch.TableName = "error";
                return dtInterBranch;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtInterBranch;
        }
    }
}