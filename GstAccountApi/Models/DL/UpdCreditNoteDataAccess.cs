using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdCreditNoteDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtCreditNote;
        DataSet DsCreditNote;
        DataTable dtCancel;

        internal DataSet BindAllCreditNote(UpdCreditNoteModel objUpdCNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCreditNote";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdCNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCNModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                DsCreditNote = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(DsCreditNote);
                DsCreditNote.DataSetName = "success";
                DsCreditNote.Tables[0].TableName = "AccountHead";
                DsCreditNote.Tables[1].TableName = "Narration";
                DsCreditNote.Tables[2].TableName = "LastVoucherNo";
                DsCreditNote.Tables[3].TableName = "ItemUnit";
                DsCreditNote.Tables[4].TableName = "Issue Reason";
            }
            catch (Exception)
            {
                DsCreditNote = new DataSet();
                DsCreditNote.DataSetName = "error";
                return DsCreditNote;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return DsCreditNote;
        }

        internal DataSet SearchData(UpdCreditNoteModel objUpdCNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCreditNote";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdCNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdCNModel.VoucherNo);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCNModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                DsCreditNote = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(DsCreditNote);
                DsCreditNote.DataSetName = "success";

            }
            catch (Exception)
            {
                DsCreditNote = new DataSet();
                DsCreditNote.DataSetName = "error";
                return DsCreditNote;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return DsCreditNote;
        }

        internal DataTable ItemsBinding(UpdCreditNoteModel objUpdCNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCreditNote";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdCNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objUpdCNModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdCNModel.InvoiceNo);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", objUpdCNModel.InvoiceDate);


                ClsCon.cmd.Parameters.AddWithValue("@ByPurchaseSale", objUpdCNModel.ByPurchaseSale);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCNModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCreditNote = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCreditNote);
                dtCreditNote.TableName = "success";
            }
            catch (Exception)
            {
                dtCreditNote = new DataTable();
                dtCreditNote.TableName = "error";
                return dtCreditNote;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCreditNote;
        }

        internal DataTable FillGistnNo(UpdCreditNoteModel objUpdCNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdCNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUpdCNModel.AccCode);


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCreditNote = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCreditNote);
                dtCreditNote.TableName = "success";
            }
            catch (Exception)
            {
                dtCreditNote = new DataTable();
                dtCreditNote.TableName = "error";
                return dtCreditNote;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCreditNote;
        }

        internal DataTable LoadPartyAccount(UpdCreditNoteModel objUpdCNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCNModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCreditNote = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCreditNote);
                dtCreditNote.TableName = "success";
            }
            catch (Exception)
            {
                dtCreditNote = new DataTable();
                dtCreditNote.TableName = "error";
                return dtCreditNote;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCreditNote;
        }

        internal DataTable UpdateCreditNote(UpdCreditNoteModel objUpdCNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCreditNote";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdCNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCNModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", objUpdCNModel.VoucherDate);
                ClsCon.cmd.Parameters.AddWithValue("@GSTOpted", objUpdCNModel.GSTOpted);
                ClsCon.cmd.Parameters.AddWithValue("@DocDesc", objUpdCNModel.DocDesc);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objUpdCNModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objUpdCNModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objUpdCNModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdCNModel.VoucherNo);
                ClsCon.cmd.Parameters.AddWithValue("@IssueReasonId", objUpdCNModel.issueReasonId);
                ClsCon.cmd.Parameters.AddWithValue("@PreGstId", objUpdCNModel.PreGstId);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objUpdCNModel.CCCode);

                ClsCon.cmd.Parameters.AddWithValue("@TblCredit", objUpdCNModel.DtCreditNote);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", objUpdCNModel.DtItems);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCreditNote = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCreditNote);
                dtCreditNote.TableName = "success";
            }
            catch (Exception)
            {
                dtCreditNote = new DataTable();
                dtCreditNote.TableName = "error";
                return dtCreditNote;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCreditNote;
        }

        internal DataTable CancelVoucher(UpdCreditNoteModel objUpdCNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCreditNote";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdCNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdCNModel.VoucherNo);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCNModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objUpdCNModel.CancelReason);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCancel = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCancel);
                dtCancel.TableName = "success";
            }
            catch (Exception)
            {
                dtCancel = new DataTable();
                dtCancel.TableName = "error";
                return dtCancel;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCancel;
        }
    }
}