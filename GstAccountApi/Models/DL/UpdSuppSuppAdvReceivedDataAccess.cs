using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdSuppSuppAdvReceivedDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataSet dsAdvSuppReceived;
        DataTable AdvUpdSupreceiveddt, dtSaving, dtCancel;
        internal DataSet AdvSuupReceived(UpdateAdvSuppReceivedModel objUpdAdvSupReceived)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdAdvanceReceived";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdAdvSupReceived.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdAdvSupReceived.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdAdvSupReceived.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdAdvSupReceived.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdAdvSupReceived.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsAdvSuppReceived = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsAdvSuppReceived);
                //dtAdvSuppReceived.TableName = "success";

            }
            catch (Exception)
            {
                dsAdvSuppReceived = new DataSet();
                // dtAdvSuppReceived.TableName = "error";
                return dsAdvSuppReceived;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsAdvSuppReceived;
        }


        internal DataTable SearchingAdvRec(UpdateAdvSuppReceivedModel objUpdAdvSupReceived)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdAdvanceReceived";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdAdvSupReceived.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdAdvSupReceived.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdAdvSupReceived.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdAdvSupReceived.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdAdvSupReceived.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdAdvSupReceived.DocNo); 

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                AdvUpdSupreceiveddt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(AdvUpdSupreceiveddt);
                AdvUpdSupreceiveddt.TableName = "success";
            }
            catch (Exception)
            {
                AdvUpdSupreceiveddt = new DataTable();
                AdvUpdSupreceiveddt.TableName = "error";
                return AdvUpdSupreceiveddt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return AdvUpdSupreceiveddt;

        }
        internal DataTable FillItemTaxRate(UpdateAdvSuppReceivedModel objUpdAdvSupReceived)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdAdvSupReceived.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdAdvSupReceived.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdAdvSupReceived.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objUpdAdvSupReceived.AccountCode);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", objUpdAdvSupReceived.ItemID);

                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSalesModel.YrCD); 
                // ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjSalesModel.GSTIN);
                //ClsCon.cmd.Parameters.AddWithValue("@ByCash", ObjSalesModel.ByCashSale);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                AdvUpdSupreceiveddt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(AdvUpdSupreceiveddt);
                AdvUpdSupreceiveddt.TableName = "success";
            }
            catch (Exception)
            {
                AdvUpdSupreceiveddt = new DataTable();
                AdvUpdSupreceiveddt.TableName = "error";
                return AdvUpdSupreceiveddt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return AdvUpdSupreceiveddt;

        }

        internal DataTable SearchProcess(UpdateAdvSuppReceivedModel objUpdAdvSupReceived)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdAdvanceReceived";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdAdvSupReceived.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdAdvSupReceived.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdAdvSupReceived.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdAdvSupReceived.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdAdvSupReceived.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@VchDate", objUpdAdvSupReceived.VchDate);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdAdvSupReceived.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@CashBankCode", objUpdAdvSupReceived.CashBankCode);
                ClsCon.cmd.Parameters.AddWithValue("@AcccountCode", objUpdAdvSupReceived.AccountCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objUpdAdvSupReceived.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@NetAmount", objUpdAdvSupReceived.NetAmount);
                ClsCon.cmd.Parameters.AddWithValue("@TaxAmount", objUpdAdvSupReceived.TaxAmount);
                ClsCon.cmd.Parameters.AddWithValue("@GrossAmount", objUpdAdvSupReceived.GrossAmount);
                ClsCon.cmd.Parameters.AddWithValue("@ChequeNo", objUpdAdvSupReceived.ChequeNo);
                ClsCon.cmd.Parameters.AddWithValue("@ChequeDate", objUpdAdvSupReceived.ChequeDate);
                ClsCon.cmd.Parameters.AddWithValue("@UTRNo", objUpdAdvSupReceived.UTRNo);
                ClsCon.cmd.Parameters.AddWithValue("@UTRDate", objUpdAdvSupReceived.UTRDate);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", objUpdAdvSupReceived.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objUpdAdvSupReceived.IP);
                ClsCon.cmd.Parameters.AddWithValue("@VchNarration", objUpdAdvSupReceived.VchNarration);
                // ClsCon.cmd.Parameters.AddWithValue("@EntryType", objAdvSupReceived.EntryType); 
                //ClsCon.cmd.Parameters.AddWithValue("@ItemID", objAdvSupReceived.ItemID);

                ClsCon.cmd.Parameters.AddWithValue("@TblAdvItems", objUpdAdvSupReceived.TblAdvItems);

                // ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjSalesModel.GSTIN);
                //ClsCon.cmd.Parameters.AddWithValue("@ByCash", ObjSalesModel.ByCashSale);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSaving = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSaving);
                dtSaving.TableName = "success";
            }
            catch (Exception)
            {
                dtSaving = new DataTable();
                dtSaving.TableName = "error";
                return dtSaving;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSaving;

        }


        internal DataTable CancelVoucher(UpdateAdvSuppReceivedModel objUpdAdvSupReceived)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdAdvanceReceived";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdAdvSupReceived.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdAdvSupReceived.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdAdvSupReceived.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdAdvSupReceived.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdAdvSupReceived.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objUpdAdvSupReceived.CancelReason);
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