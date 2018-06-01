using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class EWayBillDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtAccountHead;



        internal DataTable LoadEWayBill(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPEWayBill";

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtAccountHead);
                dtAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtAccountHead = new DataTable();
                dtAccountHead.TableName = "error";
                return dtAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtAccountHead;
        }
    }
}