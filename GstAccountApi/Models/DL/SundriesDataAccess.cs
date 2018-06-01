using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class SundriesDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataSet dtCheckList;
        DataTable dtmatche;
        DataTable dtSaveChkAllocated;

        internal DataSet LoadChkListAvailable(SundriesModel ObjSundriModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSundries";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjSundriModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSundriModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSundriModel.YrCD);

                con = ClsCon.SqlConn();

                ClsCon.cmd.Connection = con;
                dtCheckList = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCheckList);
                //dtCheckList.TableName = "success";
            }
            catch (Exception)
            {
                dtCheckList = new DataSet();
                // dtCheckList.TableName = "error";
                return dtCheckList;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCheckList;
        }


        internal DataTable MatchSelectedInd(SundriesModel ObjSundriModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSundries";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjSundriModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSundriModel.OrgID);
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSundriModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjSundriModel.SundriCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtmatche = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtmatche);
                dtmatche.TableName = "success";
            }
            catch (Exception)
            {
                dtmatche = new DataTable();
                dtmatche.TableName = "error";
                return dtmatche;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtmatche;
        }

        internal DataTable SaveChkAllocated(SundriesModel ObjSundriModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSundries";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjSundriModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSundriModel.OrgID);
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSundriModel.YrCD);
               // ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjSundriModel.SundriCode);
                ClsCon.cmd.Parameters.AddWithValue("@TblSundries", ObjSundriModel.TblSundries);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtmatche = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtmatche);
                dtmatche.TableName = "success";
            }
            catch (Exception)
            {
                dtmatche = new DataTable();
                dtmatche.TableName = "error";
                return dtmatche;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtmatche;
        }
    }

}