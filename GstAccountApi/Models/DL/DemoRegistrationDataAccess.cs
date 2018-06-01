using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class DemoRegistrationDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtOutstandingBill;
        
        internal DataTable Registration(PL.DemoRegistrationModel objRegi)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPRequest";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objRegi.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@User", objRegi.User);
                ClsCon.cmd.Parameters.AddWithValue("@OrgType", objRegi.OrgType);
                ClsCon.cmd.Parameters.AddWithValue("@OrgName", objRegi.OrgName);
                ClsCon.cmd.Parameters.AddWithValue("@MobNo", objRegi.MobNo);
                ClsCon.cmd.Parameters.AddWithValue("@Email", objRegi.Email);
                // ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjWarehouseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtOutstandingBill = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtOutstandingBill);
                dtOutstandingBill.TableName = "success";
            }
            catch (Exception)
            {
                dtOutstandingBill = new DataTable();
                dtOutstandingBill.TableName = "error";
                return dtOutstandingBill;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtOutstandingBill;
        }
    }
}