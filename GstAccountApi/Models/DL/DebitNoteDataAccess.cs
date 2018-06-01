using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class DebitNoteDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtDebitNote;
        DataSet dsDebitNote;

        //internal DataTable AccountHead(DebitNoteModel objDNModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objDNModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objDNModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objDNModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objDNModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", objDNModel.VchType);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtDebitNote = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtDebitNote);
        //        dtDebitNote.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtDebitNote = new DataTable();
        //        dtDebitNote.TableName = "error";
        //        return dtDebitNote;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtDebitNote;
        //}

        //internal DataTable LoadNarration(DebitNoteModel objDNModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objDNModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objDNModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objDNModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objDNModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", objDNModel.VchType);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtDebitNote = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtDebitNote);
        //        dtDebitNote.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtDebitNote = new DataTable();
        //        dtDebitNote.TableName = "error";
        //        return dtDebitNote;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtDebitNote;
        //}

        //internal DataTable LastVoucherNo(DebitNoteModel objDNModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objDNModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objDNModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objDNModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objDNModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", objDNModel.VchType);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtDebitNote = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtDebitNote);
        //        dtDebitNote.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtDebitNote = new DataTable();
        //        dtDebitNote.TableName = "error";
        //        return dtDebitNote;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtDebitNote;
        //}

        internal DataTable FillGistnNo(DebitNoteModel objDNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objDNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objDNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objDNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objDNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objDNModel.AccCode);


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

        internal DataTable ItemsBinding(DebitNoteModel objDNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPDebitNote";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objDNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objDNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objDNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objDNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objDNModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objDNModel.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", objDNModel.DocDate);


                ClsCon.cmd.Parameters.AddWithValue("@ByPurchaseSale", objDNModel.ByPurchaseSale);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objDNModel.VchType);

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

        internal DataTable LoadPartyAccount(DebitNoteModel objDNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objDNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objDNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objDNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objDNModel.YrCD);

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

        internal DataSet BindAllDebitNote(DebitNoteModel objDNModel)
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
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objDNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objDNModel.VchType);

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

        internal DataTable SaveDebitNote(DebitNoteModel objDNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPDebitNote";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objDNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objDNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objDNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objDNModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", objDNModel.VoucherDate);
                ClsCon.cmd.Parameters.AddWithValue("@GSTOpted", objDNModel.GSTOpted);
                ClsCon.cmd.Parameters.AddWithValue("@DocDesc", objDNModel.DocDesc);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objDNModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objDNModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objDNModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objDNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@IssueReasonId", objDNModel.issueReasonId);
                ClsCon.cmd.Parameters.AddWithValue("@PreGstId", objDNModel.PreGstId);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objDNModel.CCCode);
                ClsCon.cmd.Parameters.AddWithValue("@TblDebit", objDNModel.DtDebitNote);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", objDNModel.DtItems);

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
    }
}