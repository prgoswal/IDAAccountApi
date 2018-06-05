using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class AdvancedSupppaymentDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataSet dtAdvSuppPayment;
        DataTable AdvSuppaydt;

        internal DataSet AdSuppPay(AdvSuppPaymentModel objAdvSupPayment)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPAdvancePayment";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objAdvSupPayment.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAdvSupPayment.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objAdvSupPayment.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objAdvSupPayment.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objAdvSupPayment.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtAdvSuppPayment = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtAdvSuppPayment);
                //dtAdvSuppPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtAdvSuppPayment = new DataSet();
                // dtAdvSuppPayment.TableName = "error";
                return dtAdvSuppPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtAdvSuppPayment;
        }
        internal DataTable FillItemTaxRate(AdvSuppPaymentModel objAdvSupPayment)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objAdvSupPayment.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAdvSupPayment.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objAdvSupPayment.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objAdvSupPayment.AccountCode);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", objAdvSupPayment.ItemID);

                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", objAdvSupPayment.YrCD);
                //ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objAdvSupPayment.GSTIN);

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
         internal DataTable FillItemTaxRates(AdvSuppPaymentModel objAdvSupPayment)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objAdvSupPayment.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAdvSupPayment.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objAdvSupPayment.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objAdvSupPayment.AccountCode);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", objAdvSupPayment.ItemID);

                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", objAdvSupPayment.YrCD);
                //ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objAdvSupPayment.GSTIN);

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

        internal DataTable SavingAdvPay(AdvSuppPaymentModel objAdvSupPayment)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandText = "SPAdvancePayment";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objAdvSupPayment.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAdvSupPayment.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objAdvSupPayment.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objAdvSupPayment.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objAdvSupPayment.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@VchDate", objAdvSupPayment.VchDate);
                ClsCon.cmd.Parameters.AddWithValue("@CashBankCode", objAdvSupPayment.CashBankCode);
                ClsCon.cmd.Parameters.AddWithValue("@AcccountCode", objAdvSupPayment.AccountCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objAdvSupPayment.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@NetAmount", objAdvSupPayment.NetAmount);
                ClsCon.cmd.Parameters.AddWithValue("@TaxAmount", objAdvSupPayment.TaxAmount);
                ClsCon.cmd.Parameters.AddWithValue("@GrossAmount", objAdvSupPayment.GrossAmount);
                ClsCon.cmd.Parameters.AddWithValue("@ChequeNo", objAdvSupPayment.ChequeNo);
                ClsCon.cmd.Parameters.AddWithValue("@ChequeDate", objAdvSupPayment.ChequeDate);
                ClsCon.cmd.Parameters.AddWithValue("@UTRNo", objAdvSupPayment.UTRNo);
                ClsCon.cmd.Parameters.AddWithValue("@UTRDate", objAdvSupPayment.UTRDate);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", objAdvSupPayment.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objAdvSupPayment.IP);
                ClsCon.cmd.Parameters.AddWithValue("@VchNarratio", objAdvSupPayment.VchNarratio);
                // ClsCon.cmd.Parameters.AddWithValue("@EntryType", objAdvSupReceived.EntryType); 
                //ClsCon.cmd.Parameters.AddWithValue("@ItemID", objAdvSupReceived.ItemID);

                ClsCon.cmd.Parameters.AddWithValue("@TblAdvItems", objAdvSupPayment.TblAdvItems);

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
    }
}
