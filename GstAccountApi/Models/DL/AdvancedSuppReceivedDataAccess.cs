using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace GstAccountApi.Models.DL
{ 
    
    public class AdvancedSuppReceivedDataAccess
    { 
          SqlConnection con = new SqlConnection();  
         DataSet dtAdvSuppReceived;
         DataTable AdvSupreceiveddt,dtSaving;
         internal DataSet AdvSuupReceived(AdvSuppReceivedModel objAdvSupReceived)
         {
             try 
             {
                 ClsCon.cmd = new SqlCommand();
                 ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                 ClsCon.cmd.CommandText = "SPAdvanceReceived";
                 ClsCon.cmd.Parameters.AddWithValue("@Ind",     objAdvSupReceived.Ind);
                 ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAdvSupReceived.OrgID);
                 ClsCon.cmd.Parameters.AddWithValue("@BrID", objAdvSupReceived.BrID);
                 ClsCon.cmd.Parameters.AddWithValue("@YrCD", objAdvSupReceived.YrCD);
                 ClsCon.cmd.Parameters.AddWithValue("@VchType", objAdvSupReceived.VchType);

                 con = ClsCon.SqlConn();
                 ClsCon.cmd.Connection = con;
                 dtAdvSuppReceived = new DataSet();
                 ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                 ClsCon.da.Fill(dtAdvSuppReceived);
                 //dtAdvSuppReceived.TableName = "success";

             }
             catch (Exception)
             {
                 dtAdvSuppReceived = new DataSet();
                 // dtAdvSuppReceived.TableName = "error";
                 return dtAdvSuppReceived;
             }
             finally
             {
                 con.Close();
                 con.Dispose();
                 ClsCon.da.Dispose();
                 ClsCon.cmd.Dispose();
             }
             return dtAdvSuppReceived;
         }
         internal DataTable FillItemTaxRate(AdvSuppReceivedModel objAdvSupReceived)
         {
             try
             {
                 ClsCon.cmd = new SqlCommand();
                 ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                 ClsCon.cmd.CommandText = "SPItems";

                 ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                 ClsCon.cmd.Parameters.AddWithValue("@Ind", objAdvSupReceived.Ind);
                 ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAdvSupReceived.OrgID);
                 ClsCon.cmd.Parameters.AddWithValue("@BrID", objAdvSupReceived.BrID);
                 ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objAdvSupReceived.AccountCode);
                 ClsCon.cmd.Parameters.AddWithValue("@ItemID", objAdvSupReceived.ItemID); 

                 //ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSalesModel.YrCD); 
                 // ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjSalesModel.GSTIN);
                 //ClsCon.cmd.Parameters.AddWithValue("@ByCash", ObjSalesModel.ByCashSale);

                 con = ClsCon.SqlConn();
                 ClsCon.cmd.Connection = con;
                 AdvSupreceiveddt = new DataTable();
                 ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                 ClsCon.da.Fill(AdvSupreceiveddt);
                 AdvSupreceiveddt.TableName = "success";
             }
             catch (Exception)
             {
                 AdvSupreceiveddt = new DataTable();
                 AdvSupreceiveddt.TableName = "error";
                 return AdvSupreceiveddt;
             }
             finally
             {
                 con.Close();
                 con.Dispose();
                 ClsCon.da.Dispose();
                 ClsCon.cmd.Dispose();
             }
             return AdvSupreceiveddt;

         }


         internal DataTable SavingProcess(AdvSuppReceivedModel objAdvSupReceived)
         {
             try
             {
                 ClsCon.cmd = new SqlCommand();
                 ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                 ClsCon.cmd.CommandText = "SPAdvanceReceived";

                 ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                 ClsCon.cmd.Parameters.AddWithValue("@Ind", objAdvSupReceived.Ind);
                 ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAdvSupReceived.OrgID);
                 ClsCon.cmd.Parameters.AddWithValue("@BrID", objAdvSupReceived.BrID);
                 ClsCon.cmd.Parameters.AddWithValue("@YrCD", objAdvSupReceived.YrCD);
                 ClsCon.cmd.Parameters.AddWithValue("@VchType", objAdvSupReceived.VchType); 
                 ClsCon.cmd.Parameters.AddWithValue("@VchDate", objAdvSupReceived.VchDate);
                 ClsCon.cmd.Parameters.AddWithValue("@CashBankCode", objAdvSupReceived.CashBankCode);
                 ClsCon.cmd.Parameters.AddWithValue("@AcccountCode", objAdvSupReceived.AccountCode);
                 ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objAdvSupReceived.GSTIN);
                 ClsCon.cmd.Parameters.AddWithValue("@NetAmount", objAdvSupReceived.NetAmount);
                 ClsCon.cmd.Parameters.AddWithValue("@TaxAmount", objAdvSupReceived.TaxAmount);
                 ClsCon.cmd.Parameters.AddWithValue("@GrossAmount", objAdvSupReceived.GrossAmount);
                 ClsCon.cmd.Parameters.AddWithValue("@ChequeNo", objAdvSupReceived.ChequeNo);
                 ClsCon.cmd.Parameters.AddWithValue("@ChequeDate", objAdvSupReceived.ChequeDate);
                 ClsCon.cmd.Parameters.AddWithValue("@UTRNo", objAdvSupReceived.UTRNo);
                 ClsCon.cmd.Parameters.AddWithValue("@UTRDate", objAdvSupReceived.UTRDate);
                 ClsCon.cmd.Parameters.AddWithValue("@UserID", objAdvSupReceived.User);
                 ClsCon.cmd.Parameters.AddWithValue("@IP", objAdvSupReceived.IP);
                 ClsCon.cmd.Parameters.AddWithValue("@VchNarratio", objAdvSupReceived.VchNarratio);
                // ClsCon.cmd.Parameters.AddWithValue("@EntryType", objAdvSupReceived.EntryType); 
                 //ClsCon.cmd.Parameters.AddWithValue("@ItemID", objAdvSupReceived.ItemID);

                 ClsCon.cmd.Parameters.AddWithValue("@TblAdvItems", objAdvSupReceived.TblAdvItems); 
               
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
    }
}