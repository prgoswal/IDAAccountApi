using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class VoucherPrintingDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtVP;
        DataSet dsVP;

        internal DataTable BindDocumentType(VoucherPrintingModel objVPModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPVoucherPrinting";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objVPModel.Ind);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtVP = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtVP);
                dtVP.TableName = "success";
            }
            catch (Exception)
            {
                dtVP = new DataTable();
                dtVP.TableName = "error";
                return dtVP;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtVP;
        }
    }
}