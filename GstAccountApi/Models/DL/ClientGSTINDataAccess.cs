using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class ClientGSTINDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtClientGstin;
        internal DataTable FillGridCLientGstin(ClientGstinModel ObjClientGSTINModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPGSTR1";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjClientGSTINModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjClientGSTINModel.OrgID);
               // ClsCon.cmd.Parameters.AddWithValue("@ItemID", ObjClientGSTINModel.ItemID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjClientGSTINModel.BrID);
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjopenStockModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtClientGstin = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtClientGstin);
                dtClientGstin.TableName = "success";
            }
            catch (Exception)
            {
                dtClientGstin = new DataTable();
                dtClientGstin.TableName = "error";
                return dtClientGstin;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtClientGstin;
        }
    }
}