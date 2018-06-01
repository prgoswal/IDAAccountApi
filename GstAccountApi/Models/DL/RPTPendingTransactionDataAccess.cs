using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class RPTPendingTransactionDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataSet dsPendingTransaction;

        internal DataSet BindPendingTransaction(RPTPendingTransactionModel objRPTPTransModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPRPTPendingTransaction";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objRPTPTransModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objRPTPTransModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objRPTPTransModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@FromDate", objRPTPTransModel.FromDate);
                ClsCon.cmd.Parameters.AddWithValue("@ToDate", objRPTPTransModel.ToDate);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsPendingTransaction = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsPendingTransaction);
                dsPendingTransaction.DataSetName = "success";
            }
            catch (Exception)
            {
                dsPendingTransaction = new DataSet();
                dsPendingTransaction.DataSetName = "error";
                return dsPendingTransaction;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsPendingTransaction;
        }
    }
}