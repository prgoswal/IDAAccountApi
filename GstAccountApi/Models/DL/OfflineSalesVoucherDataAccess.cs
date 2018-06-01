using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class OfflineSalesVoucherDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtSales;
        DataSet dsSales;


        internal DataSet BindAll(OfflineSalesVoucherModel ObjOfflineSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPOfflineSaleVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjOfflineSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjOfflineSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjOfflineSalesModel.BrID);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsSales = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsSales);
                dsSales.DataSetName = "success";
            }
            catch (Exception)
            {
                dsSales = new DataSet();
                dsSales.DataSetName = "error";
                return dsSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsSales;
        }





    }
}