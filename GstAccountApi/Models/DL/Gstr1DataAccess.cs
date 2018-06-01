using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class Gstr1DataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtbGstr1;
       
        //DataSet dsDebitNote; 

        internal DataTable FillGistnNo(Gstr1EntryModel objGstr1Model)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPGstr1Entry";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objGstr1Model.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objGstr1Model.OrgID);
                
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtbGstr1 = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtbGstr1);
                dtbGstr1.TableName = "success";
            }
            catch (Exception)
            {
                dtbGstr1 = new DataTable();
                dtbGstr1.TableName = "error";
                return dtbGstr1;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtbGstr1;
        }
        internal DataTable Gstr1Search(Gstr1EntryModel objGstr1Model)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPGstr1Entry";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objGstr1Model.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objGstr1Model.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objGstr1Model.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objGstr1Model.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@MonthYear", objGstr1Model.MonthYear);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtbGstr1 = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtbGstr1);
                dtbGstr1.TableName = "success";
            }
            catch (Exception)
            {
                dtbGstr1 = new DataTable();
                dtbGstr1.TableName = "error";
                return dtbGstr1;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtbGstr1;
        }



        internal DataTable Gstr1Saved(Gstr1EntryModel objGstr1Model)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPGstr1Entry";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objGstr1Model.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objGstr1Model.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objGstr1Model.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objGstr1Model.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@User", objGstr1Model.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objGstr1Model.IP);
                ClsCon.cmd.Parameters.AddWithValue("@TblGstr1", objGstr1Model.Dtgstr1);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtbGstr1 = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtbGstr1);
                dtbGstr1.TableName = "success";
            }
            catch (Exception)
            {
                dtbGstr1 = new DataTable();
                dtbGstr1.TableName = "error";
                return dtbGstr1;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtbGstr1;
        }
    }
}