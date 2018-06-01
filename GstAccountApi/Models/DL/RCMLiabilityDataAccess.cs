using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class RCMLiabilityDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtRCMLiability;
        DataSet dsRCMLiability;

        internal DataSet DisplayPVItemRecord(RCMLiabilityModel objRCMLiaModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPRCMLiability";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objRCMLiaModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objRCMLiaModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@MonthID", objRCMLiaModel.MonthID);
                ClsCon.cmd.Parameters.AddWithValue("@YearID", objRCMLiaModel.YearID);
                //ClsCon.cmd.Parameters.AddWithValue("@YearCode", objRCMLiaModel.YearCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objRCMLiaModel.GSTIN);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsRCMLiability = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsRCMLiability);
                dsRCMLiability.DataSetName = "success";
            }
            catch (Exception)
            {
                dsRCMLiability = new DataSet();
                dsRCMLiability.DataSetName = "error";
                return dsRCMLiability;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsRCMLiability;
        }

        internal DataTable BindGSTIN(RCMLiabilityModel objRCMLiaModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPRCMLiability";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objRCMLiaModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objRCMLiaModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BRID", objRCMLiaModel.BRID);
                ClsCon.cmd.Parameters.AddWithValue("@YRCD", objRCMLiaModel.YRCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtRCMLiability = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtRCMLiability);
                dtRCMLiability.TableName = "success";
            }
            catch (Exception)
            {
                dtRCMLiability = new DataTable();
                dtRCMLiability.TableName = "error";
                return dtRCMLiability;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtRCMLiability;
        }

        internal DataTable SaveRCMLiability(RCMLiabilityModel objRCMLiaModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPRCMLiability";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objRCMLiaModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objRCMLiaModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BRID", objRCMLiaModel.BRID);
                ClsCon.cmd.Parameters.AddWithValue("@YRCD", objRCMLiaModel.YRCD);
                ClsCon.cmd.Parameters.AddWithValue("@MonthID", objRCMLiaModel.MonthID);
                ClsCon.cmd.Parameters.AddWithValue("@YearID", objRCMLiaModel.YearID);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objRCMLiaModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@TblRCM", objRCMLiaModel.DtRCM);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtRCMLiability = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtRCMLiability);
                dtRCMLiability.TableName = "success";
            }
            catch (Exception)
            {
                dtRCMLiability = new DataTable();
                dtRCMLiability.TableName = "error";
                return dtRCMLiability;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtRCMLiability;
        }
    }
}