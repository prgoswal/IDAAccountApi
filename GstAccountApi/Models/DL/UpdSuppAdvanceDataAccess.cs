using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdSuppAdvanceDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataSet dsAdvUpdSuppPayment;
        DataTable AdvSuppaydt, dtSaving, dtCancel;

        internal DataSet AdUpdSuppPay(UpdSuppAdvancePaymentModel objUpdAdvSupPayment)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPAdvancePayment";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdAdvSupPayment.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdAdvSupPayment.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdAdvSupPayment.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdAdvSupPayment.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdAdvSupPayment.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsAdvUpdSuppPayment = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsAdvUpdSuppPayment);
                //dtAdvSuppPayment.TableName = "success";
            }
            catch (Exception)
            {
                dsAdvUpdSuppPayment = new DataSet();
                // dtAdvSuppPayment.TableName = "error";
                return dsAdvUpdSuppPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsAdvUpdSuppPayment;
        }



        internal DataTable SearchingAdvRec(UpdSuppAdvancePaymentModel objUpdAdvSupPayment)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdAdvancePayment";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdAdvSupPayment.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdAdvSupPayment.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdAdvSupPayment.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdAdvSupPayment.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdAdvSupPayment.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdAdvSupPayment.DocNo);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                AdvSuppaydt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(AdvSuppaydt);
                AdvSuppaydt.TableName = "success";
            }
            catch (Exception)
            {
                AdvSuppaydt = new DataTable();
                AdvSuppaydt.TableName = "error";
                return AdvSuppaydt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return AdvSuppaydt;

        }
        internal DataTable FillItemTaxRate(UpdSuppAdvancePaymentModel objUpdAdvSupPayment)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdAdvSupPayment.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdAdvSupPayment.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdAdvSupPayment.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objUpdAdvSupPayment.AccountCode);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", objUpdAdvSupPayment.ItemID);

                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSalesModel.YrCD); 
                // ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjSalesModel.GSTIN);
                //ClsCon.cmd.Parameters.AddWithValue("@ByCash", ObjSalesModel.ByCashSale);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                AdvSuppaydt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(AdvSuppaydt);
                AdvSuppaydt.TableName = "success";
            }
            catch (Exception)
            {
                AdvSuppaydt = new DataTable();
                AdvSuppaydt.TableName = "error";
                return AdvSuppaydt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return AdvSuppaydt;

        }

        internal DataTable SearchProcess(UpdSuppAdvancePaymentModel objUpdAdvSupPayment)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdAdvanceReceived";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdAdvSupPayment.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdAdvSupPayment.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdAdvSupPayment.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdAdvSupPayment.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdAdvSupPayment.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@VchDate", objUpdAdvSupPayment.VchDate);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdAdvSupPayment.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@CashBankCode", objUpdAdvSupPayment.CashBankCode);
                ClsCon.cmd.Parameters.AddWithValue("@AcccountCode", objUpdAdvSupPayment.AccountCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objUpdAdvSupPayment.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@NetAmount", objUpdAdvSupPayment.NetAmount);
                ClsCon.cmd.Parameters.AddWithValue("@TaxAmount", objUpdAdvSupPayment.TaxAmount);
                ClsCon.cmd.Parameters.AddWithValue("@GrossAmount", objUpdAdvSupPayment.GrossAmount);
                ClsCon.cmd.Parameters.AddWithValue("@ChequeNo", objUpdAdvSupPayment.ChequeNo);
                ClsCon.cmd.Parameters.AddWithValue("@ChequeDate", objUpdAdvSupPayment.ChequeDate);
                ClsCon.cmd.Parameters.AddWithValue("@UTRNo", objUpdAdvSupPayment.UTRNo);
                ClsCon.cmd.Parameters.AddWithValue("@UTRDate", objUpdAdvSupPayment.UTRDate);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", objUpdAdvSupPayment.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objUpdAdvSupPayment.IP);
                ClsCon.cmd.Parameters.AddWithValue("@VchNarration", objUpdAdvSupPayment.VchNarration);

                ClsCon.cmd.Parameters.AddWithValue("@TblAdvItems", objUpdAdvSupPayment.TblAdvItems);

                // ClsCon.cmd.Parameters.AddWithValue("@EntryType", objAdvSupReceived.EntryType); 
                //ClsCon.cmd.Parameters.AddWithValue("@ItemID", objAdvSupReceived.ItemID);
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


        internal DataTable CancelVoucher(UpdSuppAdvancePaymentModel objUpdAdvSupPayment)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdAdvanceReceived";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdAdvSupPayment.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdAdvSupPayment.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdAdvSupPayment.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdAdvSupPayment.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdAdvSupPayment.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objUpdAdvSupPayment.CancelReason);
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