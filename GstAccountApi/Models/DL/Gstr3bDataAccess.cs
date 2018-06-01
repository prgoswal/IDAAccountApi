using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class Gstr3bDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dt3bGstr;
        DataSet ds3bgstr;
        //DataSet dsDebitNote; 

        internal DataTable FillGistnNo(Gstr3BModel objGstr3BModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPGSTR3B";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objGstr3BModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objGstr3BModel.OrgID);
                //ClsCon.cmd.Parameters.AddWithValue("@BrID", objGstr3BModel.BrID);
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", objGstr3BModel.YrCD);
                
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dt3bGstr = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dt3bGstr);
                dt3bGstr.TableName = "success";
            }
            catch (Exception)
            {
                dt3bGstr = new DataTable();
                dt3bGstr.TableName = "error";
                return dt3bGstr;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dt3bGstr;
        }

        internal DataSet GetGSTR3BData(Gstr3BModel objGstr3BModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPGSTR3B";
                ClsCon.cmd.CommandTimeout = 120;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objGstr3BModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objGstr3BModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objGstr3BModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objGstr3BModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objGstr3BModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@TaxMonth", objGstr3BModel.TaxMonth);
                ClsCon.cmd.Parameters.AddWithValue("@TaxYear", objGstr3BModel.TaxYear);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                ds3bgstr = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(ds3bgstr);
                ds3bgstr.DataSetName = "success";
            }
            catch (Exception)
            {
                ds3bgstr = new DataSet();
                ds3bgstr.DataSetName = "error";
                return ds3bgstr;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return ds3bgstr;
        }
        internal DataTable SaveGSTR3BData(Gstr3BModel objGstr3BModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPGSTR3B";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objGstr3BModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objGstr3BModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objGstr3BModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objGstr3BModel.YrCD); 
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dt3bGstr = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dt3bGstr);
                dt3bGstr.TableName = "success";
            }
            catch (Exception)
            {
                dt3bGstr = new DataTable();
                dt3bGstr.TableName = "error";
                return dt3bGstr;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dt3bGstr;
        }
    }
}