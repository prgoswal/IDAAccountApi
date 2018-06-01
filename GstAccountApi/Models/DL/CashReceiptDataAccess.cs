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
    public class CashReceiptDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtCashReceipt;
        DataSet dsCashReceipt;

        internal DataTable AccountHead(CashReceiptModel objCashRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCashRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashRec.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashReceipt);
                dtCashReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtCashReceipt = new DataTable();
                dtCashReceipt.TableName = "error";
                return dtCashReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashReceipt;
        }

        internal DataTable LastVoucherNo(CashReceiptModel objCashRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCashRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashRec.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashReceipt);
                dtCashReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtCashReceipt = new DataTable();
                dtCashReceipt.TableName = "error";
                return dtCashReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashReceipt;
        }

        internal DataTable LoadNarration(CashReceiptModel objCashRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCashRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashRec.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashReceipt);
                dtCashReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtCashReceipt = new DataTable();
                dtCashReceipt.TableName = "error";
                return dtCashReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashReceipt;
        }

        internal DataSet BindAllCashReceiptDDL(CashReceiptModel objCashRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCashRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashRec.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsCashReceipt = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsCashReceipt);
                dsCashReceipt.DataSetName = "success";
            }
            catch (Exception)
            {
                dsCashReceipt = new DataSet();
                dsCashReceipt.DataSetName = "error";
                return dsCashReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsCashReceipt;
        }

        internal DataTable LoadCashAccount(CashReceiptModel objCashRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCashRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashRec.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashReceipt);
                dtCashReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtCashReceipt = new DataTable();
                dtCashReceipt.TableName = "error";
                return dtCashReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashReceipt;
        }

        internal DataTable SaveCashReceipt(CashReceiptModel objCashRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCashRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashRec.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objCashRec.CCCode);

                //ClsCon.cmd.Parameters.AddWithValue("@TblCash", objCashRec.Dt);
                ClsCon.cmd.Parameters.AddWithValue("@TblCash", JsonConvert.DeserializeObject<DataTable>(objCashRec.Dt));


                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyName", objCashRec.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyAddress", objCashRec.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyGSTIN", objCashRec.PartyGstIN);
                ClsCon.cmd.Parameters.AddWithValue("@RevenueServiceNo", objCashRec.ServiceNo);


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashReceipt);
                dtCashReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtCashReceipt = new DataTable();
                dtCashReceipt.TableName = "error";
                return dtCashReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashReceipt;
        }

        internal DataTable PartySelect(CashReceiptModel objCashRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objCashRec.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashReceipt);
                dtCashReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtCashReceipt = new DataTable();
                dtCashReceipt.TableName = "error";
                return dtCashReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashReceipt;
        }

        internal DataTable CheckBudgetHead(CashReceiptModel plcashrec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", plcashrec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", plcashrec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", plcashrec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", plcashrec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", plcashrec.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashReceipt);
                dtCashReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtCashReceipt = new DataTable();
                dtCashReceipt.TableName = "error";
                return dtCashReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashReceipt;
        }
    }
}