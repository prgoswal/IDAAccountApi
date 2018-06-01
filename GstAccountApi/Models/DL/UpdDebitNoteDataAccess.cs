using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdDebitNoteDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtDebitNote;
        DataSet dsDebitNote;
        DataTable dtCancel;

        internal DataSet BindAllDebitNote(UpdDebitNoteModel objUpdDNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPDebitNote";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdDNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdDNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdDNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdDNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdDNModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsDebitNote = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsDebitNote);
                dsDebitNote.DataSetName = "success";

            }
            catch (Exception)
            {
                dsDebitNote = new DataSet();
                dsDebitNote.DataSetName = "error";
                return dsDebitNote;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsDebitNote;
        }


        internal DataSet SearchData(UpdDebitNoteModel objUpdDNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPDebitNote";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdDNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdDNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdDNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdDNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdDNModel.VoucherNo);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdDNModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsDebitNote = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsDebitNote);
                dsDebitNote.DataSetName = "success";

            }
            catch (Exception)
            {
                dsDebitNote = new DataSet();
                dsDebitNote.DataSetName = "error";
                return dsDebitNote;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsDebitNote;
        }

        internal DataTable FillGistnNo(UpdDebitNoteModel objUpdDNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdDNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdDNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdDNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdDNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUpdDNModel.AccCode);


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtDebitNote = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtDebitNote);
                dtDebitNote.TableName = "success";
            }
            catch (Exception)
            {
                dtDebitNote = new DataTable();
                dtDebitNote.TableName = "error";
                return dtDebitNote;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtDebitNote;
        }

        internal DataTable ItemsBinding(UpdDebitNoteModel objUpdDNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPDebitNote";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdDNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdDNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdDNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdDNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objUpdDNModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdDNModel.InvoiceNo);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", objUpdDNModel.InvoiceDate);


                ClsCon.cmd.Parameters.AddWithValue("@ByPurchaseSale", objUpdDNModel.ByPurchaseSale);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdDNModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtDebitNote = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtDebitNote);
                dtDebitNote.TableName = "success";
            }
            catch (Exception)
            {
                dtDebitNote = new DataTable();
                dtDebitNote.TableName = "error";
                return dtDebitNote;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtDebitNote;
        }

        internal DataTable LoadPartyAccount(UpdDebitNoteModel objUpdDNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdDNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdDNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdDNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdDNModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtDebitNote = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtDebitNote);
                dtDebitNote.TableName = "success";
            }
            catch (Exception)
            {
                dtDebitNote = new DataTable();
                dtDebitNote.TableName = "error";
                return dtDebitNote;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtDebitNote;
        }

        internal DataTable UpdateDebitNote(UpdDebitNoteModel objUpdDNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPDebitNote";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdDNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdDNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdDNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdDNModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", objUpdDNModel.VoucherDate);
                ClsCon.cmd.Parameters.AddWithValue("@GSTOpted", objUpdDNModel.GSTOpted);
                ClsCon.cmd.Parameters.AddWithValue("@DocDesc", objUpdDNModel.DocDesc);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objUpdDNModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objUpdDNModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objUpdDNModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdDNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdDNModel.VoucherNo);
                ClsCon.cmd.Parameters.AddWithValue("@IssueReasonId", objUpdDNModel.issueReasonId);
                ClsCon.cmd.Parameters.AddWithValue("@PreGstId", objUpdDNModel.PreGstId);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objUpdDNModel.CCCode);
                ClsCon.cmd.Parameters.AddWithValue("@TblDebit", objUpdDNModel.DtDebitNote);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", objUpdDNModel.DtItems);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtDebitNote = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtDebitNote);
                dtDebitNote.TableName = "success";
            }
            catch (Exception)
            {
                dtDebitNote = new DataTable();
                dtDebitNote.TableName = "error";
                return dtDebitNote;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtDebitNote;
        }

        internal DataTable CancelVoucher(DebitNoteModel objDNModel)
        {

            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPDebitNote";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objDNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objDNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objDNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objDNModel.VoucherNo);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objDNModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objDNModel.CancelReason);
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