using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class AddGSTINDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtAddGSTIN;
        DataSet dsAddGSTIN;

        internal DataSet LoadData(AddGSTINModel objAddGSTINModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPAddGSTIN";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objAddGSTINModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAddGSTINModel.OrgID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsAddGSTIN = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsAddGSTIN);
                dsAddGSTIN.DataSetName = "success";
            }
            catch (Exception)
            {
                dsAddGSTIN = new DataSet();
                dsAddGSTIN.DataSetName = "error";
                return dsAddGSTIN;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsAddGSTIN;
        }
 internal DataSet LoadDatad(AddGSTINModel objAddGSTINModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPAddGSTIN";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objAddGSTINModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAddGSTINModel.OrgID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsAddGSTIN = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsAddGSTIN);
                dsAddGSTIN.DataSetName = "success";
            }
            catch (Exception)
            {
                dsAddGSTIN = new DataSet();
                dsAddGSTIN.DataSetName = "error";
                return dsAddGSTIN;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsAddGSTIN;
        }
        internal DataTable SaveGSTIN(AddGSTINModel objAddGSTINModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPAddGSTIN";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objAddGSTINModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAddGSTINModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objAddGSTINModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@RegAddr", objAddGSTINModel.RegAddr);
                ClsCon.cmd.Parameters.AddWithValue("@RegDate", objAddGSTINModel.RegDate);
                ClsCon.cmd.Parameters.AddWithValue("@City", objAddGSTINModel.City);
                ClsCon.cmd.Parameters.AddWithValue("@StateID", objAddGSTINModel.StateID);
                ClsCon.cmd.Parameters.AddWithValue("@PinCode", objAddGSTINModel.PinCode);
                ClsCon.cmd.Parameters.AddWithValue("@AuthorizedSignatury", objAddGSTINModel.AuthorizedSignatury);
                ClsCon.cmd.Parameters.AddWithValue("@SignaturyDesignation", objAddGSTINModel.SignaturyDesignation);
                ClsCon.cmd.Parameters.AddWithValue("@User", objAddGSTINModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objAddGSTINModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@TblAddGSTINInBranch", objAddGSTINModel.DtAddGSTINInBranch);
                ClsCon.cmd.Parameters.AddWithValue("@TblSeries", objAddGSTINModel.DtSeries);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtAddGSTIN = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtAddGSTIN);
                dtAddGSTIN.TableName = "success";
            }
            catch (Exception)
            {
                dtAddGSTIN = new DataTable();
                dtAddGSTIN.TableName = "error";
                return dtAddGSTIN;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtAddGSTIN;
        }
    }
}
