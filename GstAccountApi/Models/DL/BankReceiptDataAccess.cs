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
    public class BankReceiptDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtBankReceipt;
        DataSet dsBankReceipt;

        internal DataTable AccountHead(BankReceiptModel objBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBankRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objBankRec.VchType);

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

        internal DataTable LastVoucherNo(BankReceiptModel objBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBankRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objBankRec.VchType);

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

        internal DataTable LoadNarration(BankReceiptModel objBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBankRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objBankRec.VchType);

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

        internal DataSet BindAllBankReceiptDDL(BankReceiptModel objBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBankRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objBankRec.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsBankReceipt = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsBankReceipt);
                dsBankReceipt.DataSetName = "success";
            }
            catch (Exception)
            {
                dsBankReceipt = new DataSet();
                dsBankReceipt.DataSetName = "error";
                return dsBankReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsBankReceipt;
        }

        internal DataTable LoadBankAccount(BankReceiptModel objBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBankRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objBankRec.VchType);

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

        internal DataTable SaveBankReceipt(BankReceiptModel objBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBankRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objBankRec.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objBankRec.CCCode);
                ClsCon.cmd.Parameters.AddWithValue("@IDARefNo", objBankRec.IDARefNo);
                //  ClsCon.cmd.Parameters.AddWithValue("@TblBank", objBankRec.Dt);
                ClsCon.cmd.Parameters.AddWithValue("@TblBank", JsonConvert.DeserializeObject<DataTable>(objBankRec.Dt));
                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyName", objBankRec.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyAddress", objBankRec.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyGSTIN", objBankRec.PartyGstIN);
                ClsCon.cmd.Parameters.AddWithValue("@RevenueServiceNo", objBankRec.ServiceNo);

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

        internal DataTable PartySelect(BankReceiptModel objBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objBankRec.AccCode);

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

        internal DataTable CheckBudgetHead(BankReceiptModel plbankrec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", plbankrec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", plbankrec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", plbankrec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", plbankrec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", plbankrec.AccCode);

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