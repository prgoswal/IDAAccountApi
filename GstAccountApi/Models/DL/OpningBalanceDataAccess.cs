using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class OpningBalanceDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtOpningBalance;

        internal DataTable SaveOpningBalance(OpeningBalanceModel ObjOpeningBalanceModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetOpningBlc";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjOpeningBalanceModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjOpeningBalanceModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjOpeningBalanceModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCode", ObjOpeningBalanceModel.yrcd);
                ClsCon.cmd.Parameters.AddWithValue("@CurrentBudgetAmt", ObjOpeningBalanceModel.CurrentBudgetAmt);
                ClsCon.cmd.Parameters.AddWithValue("@PreviousYearBudgetAmt", ObjOpeningBalanceModel.PreviousYearBudgetAmt);
                 ClsCon.cmd.Parameters.AddWithValue("@PreviousYearActualAmt", ObjOpeningBalanceModel.PreviousYearActualAmt);
                 ClsCon.cmd.Parameters.AddWithValue("@PreviousYear2ActualAmt", ObjOpeningBalanceModel.PreviousYear2ActualAmt);



                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtOpningBalance = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtOpningBalance);
                dtOpningBalance.TableName = "success";
            }
            catch (Exception)
            {
                dtOpningBalance = new DataTable();
                dtOpningBalance.TableName = "error";
                return dtOpningBalance;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtOpningBalance;
        }

        internal DataTable CheckyecodeData (OpeningBalanceModel ObjOpeningBalanceModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetOpningBlc";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjOpeningBalanceModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjOpeningBalanceModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjOpeningBalanceModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCode", ObjOpeningBalanceModel.yrcd);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtOpningBalance = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtOpningBalance);
                dtOpningBalance.TableName = "success";
            }
            catch (Exception)
            {
                dtOpningBalance = new DataTable();
                dtOpningBalance.TableName = "error";
                return dtOpningBalance;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtOpningBalance;
        }
    }
}