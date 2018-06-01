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
    public class UpdateCashReceiptDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtUpdCashReceipt; DataTable dtCancelVoucher; DataSet dsUpdCashReceipt;

        internal DataTable LoadCashAccount(UpdateCashReceiptModel objUpdCashRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCashRec.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdCashReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdCashReceipt);
                dtUpdCashReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdCashReceipt = new DataTable();
                dtUpdCashReceipt.TableName = "error";
                return dtUpdCashReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdCashReceipt;
        }

        internal DataTable AccountHead(UpdateCashReceiptModel objUpdCashRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCashRec.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdCashReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdCashReceipt);
                dtUpdCashReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdCashReceipt = new DataTable();
                dtUpdCashReceipt.TableName = "error";
                return dtUpdCashReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdCashReceipt;
        }

        internal DataTable LoadNarration(UpdateCashReceiptModel objUpdCashRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCashRec.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdCashReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdCashReceipt);
                dtUpdCashReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdCashReceipt = new DataTable();
                dtUpdCashReceipt.TableName = "error";
                return dtUpdCashReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdCashReceipt;
        }

        internal DataSet BindAllUpdCashReceiptDDL(UpdateCashReceiptModel objUpdCashRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCashRec.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdCashReceipt = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdCashReceipt);
                dsUpdCashReceipt.DataSetName = "success";
            }
            catch (Exception)
            {
                dsUpdCashReceipt = new DataSet();
                dsUpdCashReceipt.DataSetName = "error";
                return dsUpdCashReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdCashReceipt;
        }

        internal DataTable SearchCashReceipt(UpdateCashReceiptModel objUpdCashRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCashRec.VchType);
                // ClsCon.cmd.Parameters.AddWithValue("@TblCash", objUpdCashRec.Dt);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdCashRec.DocNo);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdCashReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdCashReceipt);
                dtUpdCashReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdCashReceipt = new DataTable();
                dtUpdCashReceipt.TableName = "error";
                return dtUpdCashReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdCashReceipt;
        }

        internal DataTable UpdateCashReceipt(UpdateCashReceiptModel objUpdCashRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCashRec.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdCashRec.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objUpdCashRec.CCCode);

                ClsCon.cmd.Parameters.AddWithValue("@TblCash", JsonConvert.DeserializeObject<DataTable>(objUpdCashRec.Dt));
                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyName", objUpdCashRec.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyAddress", objUpdCashRec.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyGSTIN", objUpdCashRec.PartyGstIN);
                ClsCon.cmd.Parameters.AddWithValue("@RevenueServiceNo", objUpdCashRec.ServiceNo);

                //ClsCon.cmd.Parameters.AddWithValue("@TblCash", objUpdCashRec.Dt);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdCashReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdCashReceipt);
                dtUpdCashReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdCashReceipt = new DataTable();
                dtUpdCashReceipt.TableName = "error";
                return dtUpdCashReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdCashReceipt;
        }

        internal DataTable CancelVoucher(UpdateCashReceiptModel objUpdCashRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdCashRec.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCashRec.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objUpdCashRec.CancelReason);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCancelVoucher = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCancelVoucher);
                dtCancelVoucher.TableName = "success";
            }
            catch (Exception)
            {
                dtCancelVoucher = new DataTable();
                dtCancelVoucher.TableName = "error";
                return dtCancelVoucher;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCancelVoucher;
        }

        internal DataTable CheckBudgetHead(UpdateCashReceiptModel objUpdCashRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUpdCashRec.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdCashReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdCashReceipt);
                dtUpdCashReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdCashReceipt = new DataTable();
                dtUpdCashReceipt.TableName = "error";
                return dtUpdCashReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdCashReceipt;
        }
    }
}