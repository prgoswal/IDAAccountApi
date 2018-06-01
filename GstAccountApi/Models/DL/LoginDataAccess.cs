using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class LoginDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtLogin; DataSet dsLogin;

        internal DataSet UserValidation(int Ind, string userID)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPLoginDetails";

                ClsCon.cmd.Parameters.AddWithValue("@Ind", Ind);
                ClsCon.cmd.Parameters.AddWithValue("@LoginId", userID);
                dsLogin = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsLogin);
                dsLogin.DataSetName = "success";
            }
            catch (Exception)
            {
                dsLogin = new DataSet();
                dsLogin.DataSetName = "error";
                return dsLogin;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsLogin;
        }

        internal DataTable LoadYrCode(int Ind)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", Ind);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtLogin = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtLogin);
                dtLogin.TableName = "success";
            }
            catch (Exception)
            {
                dtLogin = new DataTable();
                dtLogin.TableName = "error";
                return dtLogin;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtLogin;
        }
    }
}