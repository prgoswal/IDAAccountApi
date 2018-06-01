using GstAccountApi.Models.DL;
using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace GstAccountApi.Models.DL
{
    public class GSTINDetailsDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataSet dsGstin; DataTable dtGstin;
        internal DataSet BindAll(GSTINDetailsModel objGSTINDetailsModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPGSTINDetails";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objGSTINDetailsModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objGSTINDetailsModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objGSTINDetailsModel.BrID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsGstin = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsGstin);
                dsGstin.DataSetName = "success";
            }
            catch (Exception)
            {
                dsGstin = new DataSet();
                dsGstin.DataSetName = "error";
                return dsGstin;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsGstin;
        }

        internal DataTable SaveGSTINDetails(GSTINDetailsModel objGSTINDetailsModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPGSTINDetails";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objGSTINDetailsModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objGSTINDetailsModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objGSTINDetailsModel.BrID);

                ClsCon.cmd.Parameters.AddWithValue("@GSTINDetails", objGSTINDetailsModel.DtGstin);
        


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtGstin = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtGstin);
                dtGstin.TableName = "success";
            }
            catch (Exception)
            {
                dtGstin = new DataTable();
                dtGstin.TableName = "error";
                return dtGstin;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtGstin;
        }
    }
}