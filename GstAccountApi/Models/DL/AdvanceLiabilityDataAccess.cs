using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class AdvanceLiabilityDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtAdvanceLia;
        DataSet dsAdvanceLia;

        internal DataSet DisplayAdvance(AdvanceLiabilityModel ObjALModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SpAdvanceLiability";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjALModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjALModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjALModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YearID", ObjALModel.YearID);
                ClsCon.cmd.Parameters.AddWithValue("@MonthID", ObjALModel.MonthID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsAdvanceLia = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsAdvanceLia);
                dsAdvanceLia.DataSetName = "success";
            }
            catch (Exception)
            {
                dsAdvanceLia = new DataSet();
                dsAdvanceLia.DataSetName = "error";
                return dsAdvanceLia;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsAdvanceLia;
        }

        internal DataTable SaveAdvance(AdvanceLiabilityModel ObjALModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SpAdvanceLiability";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjALModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjALModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjALModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YRCD", ObjALModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@YearID", ObjALModel.YearID);
                ClsCon.cmd.Parameters.AddWithValue("@MonthID", ObjALModel.MonthID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtAdvanceLia = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtAdvanceLia);
                dtAdvanceLia.TableName = "success";
            }
            catch (Exception)
            {
                dtAdvanceLia = new DataTable();
                dtAdvanceLia.TableName = "error";
                return dtAdvanceLia;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtAdvanceLia;
        }
    }
}