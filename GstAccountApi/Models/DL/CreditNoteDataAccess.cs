using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class CreditNoteDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtCreditNote;// ; 
        DataSet DsCreditNote;

        //internal DataTable AccountHead(CreditNoteModel objCNModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCNModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCNModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objCNModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCNModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", objCNModel.VchType);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtCreditNote = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtCreditNote);
        //        dtCreditNote.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtCreditNote = new DataTable();
        //        dtCreditNote.TableName = "error";
        //        return dtCreditNote;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtCreditNote;
        //}

        //internal DataTable LoadNarration(CreditNoteModel objCNModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCNModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCNModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objCNModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCNModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", objCNModel.VchType);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtCreditNote = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtCreditNote);
        //        dtCreditNote.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtCreditNote = new DataTable();
        //        dtCreditNote.TableName = "error";
        //        return dtCreditNote;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtCreditNote;
        //}
        //internal DataTable LastVoucherNo(CreditNoteModel objCNModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCNModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCNModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objCNModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCNModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", objCNModel.VchType);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtCreditNote = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtCreditNote);
        //        dtCreditNote.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtCreditNote = new DataTable();
        //        dtCreditNote.TableName = "error";
        //        return dtCreditNote;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtCreditNote;
        //}

        internal DataSet BindAllCreditNote(DebitNoteModel objDNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCreditNote";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objDNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objDNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objDNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objDNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objDNModel.VchType);

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
                DsCreditNote.Tables[4].TableName = "IssueReason";
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

        internal DataTable ItemsBinding(DebitNoteModel objDNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCreditNote";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objDNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objDNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objDNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objDNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objDNModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objDNModel.InvoiceNo);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", objDNModel.InvoiceDate);


                ClsCon.cmd.Parameters.AddWithValue("@ByPurchaseSale", objDNModel.ByPurchaseSale);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objDNModel.VchType);

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

        internal DataTable FillGistnNo(CreditNoteModel objCNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objCNModel.AccCode);


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

        internal DataTable LoadPartyAccount(CreditNoteModel objCNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCNModel.VchType);

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

        internal DataTable SaveCreditNote(CreditNoteModel objCNModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCreditNote";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCNModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCNModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCNModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCNModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", objCNModel.VoucherDate);
                ClsCon.cmd.Parameters.AddWithValue("@GSTOpted", objCNModel.GSTOpted);
                ClsCon.cmd.Parameters.AddWithValue("@DocDesc", objCNModel.DocDesc);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objCNModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objCNModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objCNModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCNModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@IssueReasonId", objCNModel.issueReasonId);
                ClsCon.cmd.Parameters.AddWithValue("@PreGstId", objCNModel.PreGstId);

                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objCNModel.CCCode);

                ClsCon.cmd.Parameters.AddWithValue("@TblCredit", objCNModel.DtCreditNote);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", objCNModel.DtItems);
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

    }
}