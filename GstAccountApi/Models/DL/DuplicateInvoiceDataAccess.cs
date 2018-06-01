using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class DuplicateInvoiceDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtDupInvoice;

        internal DataTable GetDate(DuplicateInvoiceModel objDupInvoicePl)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SpDupInvoice";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objDupInvoicePl.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objDupInvoicePl.OrgID);
              

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtDupInvoice = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtDupInvoice);
                dtDupInvoice.TableName = "success";
            } 
            catch(Exception ex)
            {
                dtDupInvoice = new DataTable();
                dtDupInvoice.TableName = "Error";
                return dtDupInvoice;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtDupInvoice;

        }

        internal DataTable GetShowData(DuplicateInvoiceModel objDupInvoicePl)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SpDupInvoice";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objDupInvoicePl.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objDupInvoicePl.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@DocTypeId", objDupInvoicePl.VoucherType);
                ClsCon.cmd.Parameters.AddWithValue("@IstDate", objDupInvoicePl.IstDate);
                ClsCon.cmd.Parameters.AddWithValue("@LastDate", objDupInvoicePl.LastDate);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtDupInvoice = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtDupInvoice);
                dtDupInvoice.TableName = "success";
            }
            catch (Exception ex)
            {
                dtDupInvoice = new DataTable();
                dtDupInvoice.TableName = "Error";
                return dtDupInvoice;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtDupInvoice;

        }

    }
}