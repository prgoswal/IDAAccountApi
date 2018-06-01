using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using GstAccountApi.Models.PL;

namespace GstAccountApi.Models.DL
{
    public class Dl_FrmSearchByAmtDate
    {

        SqlConnection con = new SqlConnection();
        DataTable dtFrmSearchByAmtDate;

        internal DataTable BindFrmSearchByAmtDate(Pl_FrmSearchByAmtDate plobjFrmSearchByAmtDate)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchUtility";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", plobjFrmSearchByAmtDate.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", plobjFrmSearchByAmtDate.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", plobjFrmSearchByAmtDate.BrID);

                ClsCon.cmd.Parameters.AddWithValue("@DocNo", plobjFrmSearchByAmtDate.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@DocDateFrom", plobjFrmSearchByAmtDate.InvoiceDateFrom);
                ClsCon.cmd.Parameters.AddWithValue("@DocDateTo", plobjFrmSearchByAmtDate.InvoiceDateTo);

                ClsCon.cmd.Parameters.AddWithValue("@DocAmtFrom", plobjFrmSearchByAmtDate.MinAmount);
                ClsCon.cmd.Parameters.AddWithValue("@DocAmtTo", plobjFrmSearchByAmtDate.MaxAmount);



                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtFrmSearchByAmtDate = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtFrmSearchByAmtDate);
                dtFrmSearchByAmtDate.TableName = "success";
            }
            catch (Exception)
            {
                dtFrmSearchByAmtDate = new DataTable();
                dtFrmSearchByAmtDate.TableName = "error";
                return dtFrmSearchByAmtDate;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtFrmSearchByAmtDate;
        }
    }
}