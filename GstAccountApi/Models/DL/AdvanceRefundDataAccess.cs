using GstAccountApi.Models.DL;
using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class AdvanceRefundDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtAR;
        DataSet dsAR;

        internal DataSet BindAllDDl(AdvanceRefundModel objARModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPAdvanceRefund";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objARModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objARModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objARModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objARModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objARModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsAR = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsAR);
                dsAR.DataSetName = "Success";
            }
            catch (Exception)
            {
                dtAR = new DataTable();
                dtAR.TableName = "error";
                dsAR.Tables.Add(dtAR);
                return dsAR;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsAR;
        }

        internal DataSet LoadAdvanceRefundInfo(AdvanceRefundModel objARModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPAdvanceRefund";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objARModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objARModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objARModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objARModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objARModel.DocNo);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsAR = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsAR);
                dsAR.DataSetName = "Success";
            }
            catch (Exception)
            {
                dtAR = new DataTable();
                dtAR.TableName = "error";
                dsAR.Tables.Add(dtAR);
                return dsAR;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsAR;
        }

        internal DataTable SaveAdvanceRefund(AdvanceRefundModel objARModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPAdvanceRefund";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objARModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objARModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objARModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objARModel.YrCD);
                //ClsCon.cmd.Parameters.AddWithValue("@DocNo", objARModel.DocNo);

                ClsCon.cmd.Parameters.AddWithValue("@VchType", objARModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@VchDate", objARModel.VchDate);
                ClsCon.cmd.Parameters.AddWithValue("@CashBankCode", objARModel.CashBankCode);
                ClsCon.cmd.Parameters.AddWithValue("@AcccountCode", objARModel.AccountCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objARModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@NetAmount", objARModel.NetAmount);

                ClsCon.cmd.Parameters.AddWithValue("@ChequeNo", objARModel.ChequeNo);
                ClsCon.cmd.Parameters.AddWithValue("@ChequeDate", objARModel.ChequeDate);
                ClsCon.cmd.Parameters.AddWithValue("@UTRNo", objARModel.UTRNo);
                ClsCon.cmd.Parameters.AddWithValue("@UTRDate", objARModel.UTRDate);
                ClsCon.cmd.Parameters.AddWithValue("@VchNarratio", objARModel.VchNarration);
                ClsCon.cmd.Parameters.AddWithValue("@TblAdvItems", objARModel.DtAR);

                ClsCon.cmd.Parameters.AddWithValue("@UserID", objARModel.UserID);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objARModel.IP);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtAR = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtAR);
                dtAR.TableName = "Success";
            }
            catch (Exception ex)
            {
                dtAR = new DataTable();
                dtAR.TableName = "error";
                return dtAR;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtAR;
        }
    }
}