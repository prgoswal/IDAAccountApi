using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UserRollDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtCUDA;
        DataSet dsMatchLoginDetails;


        internal DataTable SaveUser(UserRollModel objURModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUserRoll";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objURModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objURModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objURModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@RollDesc", objURModel.RollDesc);
                ClsCon.cmd.Parameters.AddWithValue("@IsActive", objURModel.IsActive);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }


        internal DataTable BindUserRoll(UserRollModel objUserRollModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUserRoll";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUserRollModel.Ind);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }
    }
}