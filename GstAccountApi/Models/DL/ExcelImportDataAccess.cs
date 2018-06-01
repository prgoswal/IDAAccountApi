using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using GstAccountApi.Models.PL;
namespace GstAccountApi.Models.DL
{
    public class ExcelImportDataAccess
    {
        DataTable dt;
        SqlConnection con;

        internal DataTable ExcelImportData(ExcelImportModel  objpl)  
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPImportAccountExcel";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objpl.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@ClientCode", objpl.ClientCode);
                ClsCon.cmd.Parameters.AddWithValue("@table", objpl.dt);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dt);
                dt.TableName = "success";
            }
            catch (Exception)
            {
                dt = new DataTable();
                dt.TableName = "error";
                return dt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dt;
        }

        internal DataTable ExcelItemData(ExcelImportModel objpl)  
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPImportAccountExcel";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objpl.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@ClientCode", objpl.ClientCode);
                ClsCon.cmd.Parameters.AddWithValue("@tableItem", objpl.dt);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dt);
                dt.TableName = "success";
            }
            catch (Exception)
            {
                dt = new DataTable();
                dt.TableName = "error";
                return dt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dt;
        }

        internal DataTable fillCompanyName(ExcelImportModel objExcel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objExcel.Ind);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dt = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dt);
                dt.TableName = "success";
            }
            catch (Exception)
            {
                dt = new DataTable();
                dt.TableName = "error";
                return dt;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dt;
        }

    }
}