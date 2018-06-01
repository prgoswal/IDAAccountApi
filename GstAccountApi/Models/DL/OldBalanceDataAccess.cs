using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class OldBalanceDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtOldBalance;
        DataSet dsOldBalance;

        internal DataSet BindAll(OldBalanceModel objOldBalance)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SpOldBalanceEntry";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objOldBalance.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objOldBalance.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objOldBalance.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objOldBalance.YrCD);


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsOldBalance = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsOldBalance);
                dsOldBalance.DataSetName = "success";
            }
            catch (Exception)
            {
                dsOldBalance = new DataSet();
                dsOldBalance.DataSetName = "error";
                return dsOldBalance;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsOldBalance;
        }

        internal DataTable SaveOldBalance(OldBalanceModel objOldBalance)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SpOldBalanceEntry";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objOldBalance.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objOldBalance.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objOldBalance.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objOldBalance.YrCD);               
                ClsCon.cmd.Parameters.AddWithValue("@UserID", objOldBalance.UserID);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", objOldBalance.IPAddress);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objOldBalance.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@BookNo", objOldBalance.BookNo);
                ClsCon.cmd.Parameters.AddWithValue("@PageNo", objOldBalance.PageNo);
                ClsCon.cmd.Parameters.AddWithValue("@SerialNo", objOldBalance.SerialNo);
                ClsCon.cmd.Parameters.AddWithValue("@ReferenceNo", objOldBalance.ReferenceNo);
                ClsCon.cmd.Parameters.AddWithValue("@TenderNo", objOldBalance.TenderNo);
                ClsCon.cmd.Parameters.AddWithValue("@TenderDate", objOldBalance.TenderDate);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCD", objOldBalance.PartyCD);
                ClsCon.cmd.Parameters.AddWithValue("@PartyName", objOldBalance.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@CostCentreCD", objOldBalance.CostCentreCD);
                ClsCon.cmd.Parameters.AddWithValue("@OpeningDate", objOldBalance.OpeningDate);
                ClsCon.cmd.Parameters.AddWithValue("@Amount", objOldBalance.Amount);
                ClsCon.cmd.Parameters.AddWithValue("@BSAmount", objOldBalance.BSAmount);


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtOldBalance = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtOldBalance);
                dtOldBalance.TableName = "success";
            }
            catch (Exception)
            {
                dtOldBalance = new DataTable();
                dtOldBalance.TableName = "error";
                return dtOldBalance;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtOldBalance;
        }
    }
}

