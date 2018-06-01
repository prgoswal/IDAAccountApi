using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace GstAccountApi.Models.DL
{
    public class ChequeSeriesDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtChequeSeriesDetail;
        DataSet dsState;

        internal DataTable SaveChkSericesDetail(ChequeSeriesModel ObjChkSeriesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPChequeSeries";
                ClsCon.cmd.CommandTimeout = 0;

                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjChkSeriesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjChkSeriesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjChkSeriesModel.BrID);
               // ClsCon.cmd.Parameters.AddWithValue("@YrCode", ObjChkSeriesModel.yrcd);
                ClsCon.cmd.Parameters.AddWithValue("@BankCode", ObjChkSeriesModel.BankCode);
                ClsCon.cmd.Parameters.AddWithValue("@ChequeFrom", ObjChkSeriesModel.ChequeFrom);
                ClsCon.cmd.Parameters.AddWithValue("@ChequeTo", ObjChkSeriesModel.ChequeTo);
                ClsCon.cmd.Parameters.AddWithValue("@Diffrence", ObjChkSeriesModel.Diffrence);
                ClsCon.cmd.Parameters.AddWithValue("@TblChequeSeries", ObjChkSeriesModel.DtChkSeries);
              

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtChequeSeriesDetail = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtChequeSeriesDetail);

                dtChequeSeriesDetail.TableName = "success";
            }
            catch (Exception)
            {
                dtChequeSeriesDetail = new DataTable();
                dtChequeSeriesDetail.TableName = "error";
                return dtChequeSeriesDetail;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtChequeSeriesDetail;
        }


        internal DataTable ddlBankSeriesDetail(ChequeSeriesModel ObjChkSeriesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPChequeSeries";
                ClsCon.cmd.CommandTimeout = 0;

                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjChkSeriesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjChkSeriesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjChkSeriesModel.BrID);
                // ClsCon.cmd.Parameters.AddWithValue("@YrCode", ObjChkSeriesModel.yrcd);
                ClsCon.cmd.Parameters.AddWithValue("@BankCode", ObjChkSeriesModel.BankCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtChequeSeriesDetail = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtChequeSeriesDetail);

                dtChequeSeriesDetail.TableName = "success";
            }
            catch (Exception)
            {
                dtChequeSeriesDetail = new DataTable();
                dtChequeSeriesDetail.TableName = "error";
                return dtChequeSeriesDetail;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtChequeSeriesDetail;
        }
    }
}