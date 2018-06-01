using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdateInterBranchDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtBankReceipt; DataSet dtBranchList; DataTable dtInterBranch;

        internal DataTable AccountHead(UpdateInterBranchModel objUpdateInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPInterBranch";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdateInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdateInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdateInterBranch.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdateInterBranch.YrCD);

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

        internal DataTable LastVoucherNo(UpdateInterBranchModel objUpdateInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPInterBranch";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdateInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdateInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdateInterBranch.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdateInterBranch.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdateInterBranch.VchType);

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

        internal DataTable LoadNarration(UpdateInterBranchModel objUpdateInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdateInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdateInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdateInterBranch.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdateInterBranch.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdateInterBranch.VchType);

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

        internal DataTable LoadBankAccount(UpdateInterBranchModel objUpdateInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdateInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdateInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdateInterBranch.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdateInterBranch.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdateInterBranch.VchType);

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

        internal DataTable PartySelect(UpdateInterBranchModel objUpdateInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdateInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdateInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdateInterBranch.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUpdateInterBranch.AccCode);

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

        internal DataSet LoadBranchList(UpdateInterBranchModel objUpdateInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPInterBranch";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdateInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdateInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdateInterBranch.BrID);

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

        internal DataTable UpdateInterBranch(UpdateInterBranchModel objUpdateInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPInterBranch";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdateInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdateInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdateInterBranch.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdateInterBranch.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdateInterBranch.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@AmountDr", objUpdateInterBranch.AmountDr);
                ClsCon.cmd.Parameters.AddWithValue("@AmountCr", objUpdateInterBranch.AmountCr);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdateInterBranch.DocNo);


                ClsCon.cmd.Parameters.AddWithValue("@IP", objUpdateInterBranch.IP);
                ClsCon.cmd.Parameters.AddWithValue("@DocDesc", objUpdateInterBranch.DocDesc);

                ClsCon.cmd.Parameters.AddWithValue("@BankCode", objUpdateInterBranch.BankCode);
                ClsCon.cmd.Parameters.AddWithValue("@InterBrID", objUpdateInterBranch.InterBrID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUpdateInterBranch.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode2", objUpdateInterBranch.AccCode2);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", objUpdateInterBranch.DocDate);

                ClsCon.cmd.Parameters.AddWithValue("@AdvanceInd", objUpdateInterBranch.AdvanceInd);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objUpdateInterBranch.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objUpdateInterBranch.User);

                ClsCon.cmd.Parameters.AddWithValue("@TblBank", objUpdateInterBranch.Dt);

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

        internal DataSet SearchInterBranch(UpdateInterBranchModel objUpdateInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPInterBranch";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdateInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdateInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdateInterBranch.DocNo);

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

        internal DataTable CancelVoucher(UpdateInterBranchModel objUpdateInterBranch)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPInterBranch";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdateInterBranch.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdateInterBranch.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdateInterBranch.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objUpdateInterBranch.CancelReason);
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
    }
}