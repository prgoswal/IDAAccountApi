using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Web;
using GstAccountApi.Models.PL;

namespace GstAccountApi.Models.DL
{
    public class OpenBrsDiffDataAccess
    {
        DataTable dtOpenBrsEntry;
        SqlConnection con; 

        internal DataTable LoadBankAccount(OpenBrsDiffModel objBrsOpenDiffEntery)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPOpenBrsDiffEntry";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objBrsOpenDiffEntery.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBrsOpenDiffEntery.OrgID);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtOpenBrsEntry = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtOpenBrsEntry);
                dtOpenBrsEntry.TableName = "success";
            }
            catch (Exception)
            {
                dtOpenBrsEntry = new DataTable();
                dtOpenBrsEntry.TableName = "error";
                return dtOpenBrsEntry;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtOpenBrsEntry;
        }

        internal DataTable SaveOpenBrs(OpenBrsDiffModel objBrsOpenDiffEntery)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPOpenBrsDiffEntry";
                ClsCon.cmd.Parameters.AddWithValue("@Ind",            objBrsOpenDiffEntery.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID",          objBrsOpenDiffEntery.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID",           objBrsOpenDiffEntery.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD",           objBrsOpenDiffEntery.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate",        objBrsOpenDiffEntery.DocDate); 
                ClsCon.cmd.Parameters.AddWithValue("@Acccode",        objBrsOpenDiffEntery.Acccode);
                ClsCon.cmd.Parameters.AddWithValue("@Narration",      objBrsOpenDiffEntery.Narration);
                ClsCon.cmd.Parameters.AddWithValue("@ChequeNo",       objBrsOpenDiffEntery.ChequeNo);
                ClsCon.cmd.Parameters.AddWithValue("@ChequeDate",     objBrsOpenDiffEntery.ChequeDate);
                ClsCon.cmd.Parameters.AddWithValue("@BSCriteria",     objBrsOpenDiffEntery.BSCriteria);
                ClsCon.cmd.Parameters.AddWithValue("@UTRNo",          objBrsOpenDiffEntery.UTRNo);
                ClsCon.cmd.Parameters.AddWithValue("@DrAmount",       objBrsOpenDiffEntery.DrAmount);
                ClsCon.cmd.Parameters.AddWithValue("@CrAmount",       objBrsOpenDiffEntery.CrAmount);
                ClsCon.cmd.Parameters.AddWithValue("@BSDate",         objBrsOpenDiffEntery.BSDate);
                ClsCon.cmd.Parameters.AddWithValue("@BSAmount",       objBrsOpenDiffEntery.BSAmount);
                ClsCon.cmd.Parameters.AddWithValue("@VoucharDateFrom",objBrsOpenDiffEntery.VoucharDateFrom);
                ClsCon.cmd.Parameters.AddWithValue("@VoucharDateto",  objBrsOpenDiffEntery.VoucharDateto);
                ClsCon.cmd.Parameters.AddWithValue("@OpeningDate",    objBrsOpenDiffEntery.OpeningDate);
                ClsCon.cmd.Parameters.AddWithValue("@OpeningBalance", objBrsOpenDiffEntery.OpeningBalance);
                ClsCon.cmd.Parameters.AddWithValue("@ClosingDate",    objBrsOpenDiffEntery.ClosingDate);
                ClsCon.cmd.Parameters.AddWithValue("@ClosingBalance", objBrsOpenDiffEntery.ClosingBalance);
                ClsCon.cmd.Parameters.AddWithValue("@BSInd",          objBrsOpenDiffEntery.BSInd); 

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtOpenBrsEntry = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtOpenBrsEntry);
                dtOpenBrsEntry.TableName = "success";
            }
            catch (Exception)
            {
                dtOpenBrsEntry = new DataTable();
                dtOpenBrsEntry.TableName = "error";
                return dtOpenBrsEntry;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtOpenBrsEntry;
        }
    }
}