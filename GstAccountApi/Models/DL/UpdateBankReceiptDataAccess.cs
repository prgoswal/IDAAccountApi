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
    public class UpdateBankReceiptDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtUpdBankReceipt; DataTable dtCancelVoucher; DataSet dsUpdBankReceipt;

        internal DataTable AccountHead(UpdateBankReceiptModel objUpdBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdBankRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdBankRec.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdBankReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdBankReceipt);
                dtUpdBankReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdBankReceipt = new DataTable();
                dtUpdBankReceipt.TableName = "error";
                return dtUpdBankReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdBankReceipt;
        }

        internal DataTable LastVoucherNo(UpdateBankReceiptModel objUpdBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdBankRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdBankRec.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdBankReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdBankReceipt);
                dtUpdBankReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdBankReceipt = new DataTable();
                dtUpdBankReceipt.TableName = "error";
                return dtUpdBankReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdBankReceipt;
        }

        internal DataTable LoadNarration(UpdateBankReceiptModel objUpdBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdBankRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdBankRec.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdBankReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdBankReceipt);
                dtUpdBankReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdBankReceipt = new DataTable();
                dtUpdBankReceipt.TableName = "error";
                return dtUpdBankReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdBankReceipt;
        }

        internal DataSet BindAllUpdBankReceiptDDL(UpdateBankReceiptModel objupdBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objupdBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objupdBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objupdBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objupdBankRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objupdBankRec.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdBankReceipt = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdBankReceipt);
                dsUpdBankReceipt.DataSetName = "success";
            }
            catch (Exception)
            {
                dsUpdBankReceipt = new DataSet();
                dsUpdBankReceipt.DataSetName = "error";
                return dsUpdBankReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdBankReceipt;
        }

        internal DataTable LoadBankAccount(UpdateBankReceiptModel objUpdBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdBankRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdBankRec.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdBankReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdBankReceipt);
                dtUpdBankReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdBankReceipt = new DataTable();
                dtUpdBankReceipt.TableName = "error";
                return dtUpdBankReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdBankReceipt;
        }

        internal DataTable SearchBankrec(UpdateBankReceiptModel objUpdBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdBankRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdBankRec.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdBankRec.DocNo);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdBankReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdBankReceipt);
                dtUpdBankReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdBankReceipt = new DataTable();
                dtUpdBankReceipt.TableName = "error";
                return dtUpdBankReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdBankReceipt;
        }

        internal DataTable UpdateBankrec(UpdateBankReceiptModel objUpdBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdBankRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdBankRec.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdBankRec.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objUpdBankRec.CCCode);
                ClsCon.cmd.Parameters.AddWithValue("@IDARefNo", objUpdBankRec.IDARefNo);

                ClsCon.cmd.Parameters.AddWithValue("@TblBank", JsonConvert.DeserializeObject<DataTable>(objUpdBankRec.Dt));

                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyName", objUpdBankRec.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyAddress", objUpdBankRec.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyGSTIN", objUpdBankRec.PartyGstIN);
                ClsCon.cmd.Parameters.AddWithValue("@RevenueServiceNo", objUpdBankRec.ServiceNo);

                //ClsCon.cmd.Parameters.AddWithValue("@TblBank", objUpdBankRec.Dt);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdBankReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdBankReceipt);
                dtUpdBankReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdBankReceipt = new DataTable();
                dtUpdBankReceipt.TableName = "error";
                return dtUpdBankReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdBankReceipt;
        }

        internal DataTable CancelVoucher(UpdateBankReceiptModel objupdBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objupdBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objupdBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objupdBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objupdBankRec.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objupdBankRec.CancelReason);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objupdBankRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objupdBankRec.VchType);


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

        internal DataTable CheckBudgetHead(UpdateBankReceiptModel objupdBankRec)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objupdBankRec.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objupdBankRec.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objupdBankRec.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objupdBankRec.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objupdBankRec.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdBankReceipt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdBankReceipt);
                dtUpdBankReceipt.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdBankReceipt = new DataTable();
                dtUpdBankReceipt.TableName = "error";
                return dtUpdBankReceipt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdBankReceipt;
        }
    }
}