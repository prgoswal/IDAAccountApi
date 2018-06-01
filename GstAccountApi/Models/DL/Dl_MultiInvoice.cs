using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using GstAccountApi.Models.PL;

namespace GstAccountApi.Models.DL
{
    public class DL_MultiInvoice
    {

        SqlConnection con = new SqlConnection();
        DataTable dtMultiInvoice;

        internal DataTable BindMultiInvoice(PL_MultiInvoice plobjMultiInvoice)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchUtility";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", plobjMultiInvoice.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", plobjMultiInvoice.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", plobjMultiInvoice.BrID);

                ClsCon.cmd.Parameters.AddWithValue("@DocNo", plobjMultiInvoice.InvoiceNo);
                ClsCon.cmd.Parameters.AddWithValue("@DocDateFrom", plobjMultiInvoice.InvoiceDateFrom);
                ClsCon.cmd.Parameters.AddWithValue("@DocDateTo", plobjMultiInvoice.InvoiceDateTo);



                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtMultiInvoice = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtMultiInvoice);
                dtMultiInvoice.TableName = "success";
            }
            catch (Exception)
            {
                dtMultiInvoice = new DataTable();
                dtMultiInvoice.TableName = "error";
                return dtMultiInvoice;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtMultiInvoice;
        }
    }
}