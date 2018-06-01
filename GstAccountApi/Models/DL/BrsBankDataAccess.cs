using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models
{
    public class BrsBankDataAccess
    {
        DataTable dtBRS;
        DataSet dsBRS;
        SqlConnection con;

        internal DataSet BindAllBRSDDL(BrsBankModel objBrsBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBRS";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objBrsBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBrsBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBrsBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBrsBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objBrsBankPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsBRS = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsBRS);
                dsBRS.DataSetName = "success";
            }
            catch (Exception)
            {
                dsBRS = new DataSet();
                dsBRS.DataSetName = "error";
                return dsBRS;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsBRS;
        }

        internal DataSet LoadGridData(BrsBankModel objBrsBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBRS";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objBrsBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBrsBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBrsBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBrsBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@Acccode", objBrsBankPay.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@VoucharDateFrom", objBrsBankPay.VoucharDateFrom);
                ClsCon.cmd.Parameters.AddWithValue("@VoucharDateto", objBrsBankPay.VoucharDateto);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsBRS = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsBRS);
                dsBRS.DataSetName = "success";
            }
            catch (Exception)
            {
                dsBRS = new DataSet();
                dsBRS.DataSetName = "error";
                return dsBRS;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsBRS;
        }

        internal DataSet BindBRSDateAndBalance(BrsBankModel objBrsBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBRS";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objBrsBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBrsBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBrsBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBrsBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@Acccode", objBrsBankPay.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsBRS = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsBRS);
                dsBRS.DataSetName = "success";
            }
            catch (Exception)
            {
                dsBRS = new DataSet();
                dsBRS.DataSetName = "error";
                return dsBRS;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsBRS;
        }

        internal DataTable SaveBRS(BrsBankModel objBrsBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBRS";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objBrsBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBrsBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBrsBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBrsBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@Acccode", objBrsBankPay.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@VoucharDateFrom", objBrsBankPay.VoucharDateFrom);
                ClsCon.cmd.Parameters.AddWithValue("@VoucharDateto", objBrsBankPay.VoucharDateto);
                ClsCon.cmd.Parameters.AddWithValue("@OpeningDate", objBrsBankPay.OpeningDate);
                ClsCon.cmd.Parameters.AddWithValue("@OpeningBalance", objBrsBankPay.OpeningBalance);
                ClsCon.cmd.Parameters.AddWithValue("@ClosingDate", objBrsBankPay.ClosingDate);
                ClsCon.cmd.Parameters.AddWithValue("@ClosingBalance", objBrsBankPay.ClosingBalance); 
                ClsCon.cmd.Parameters.AddWithValue("@TblBRS", objBrsBankPay.DtBrs);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBRS = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBRS);
                dtBRS.TableName = "success";
            }
            catch (Exception)
            {
                dtBRS = new DataTable();
                dtBRS.TableName = "error";
                return dtBRS;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBRS;
        }

        internal DataSet BRSReconciliationSummary(BrsBankModel objBrsBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBRS";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objBrsBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBrsBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBrsBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBrsBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objBrsBankPay.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@Acccode", objBrsBankPay.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@VoucharDateFrom", objBrsBankPay.VoucharDateFrom);
                ClsCon.cmd.Parameters.AddWithValue("@VoucharDateto", objBrsBankPay.VoucharDateto);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsBRS = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsBRS);
                dsBRS.DataSetName = "success";
            }
            catch (Exception)
            {
                dsBRS = new DataSet();
                dsBRS.DataSetName = "error";
                return dsBRS;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsBRS;
        }
        //internal DataSet BRSReconciliationSummaryDetails(BrsBankModel objBrsBankPay)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPBRS";
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", objBrsBankPay.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBrsBankPay.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objBrsBankPay.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBrsBankPay.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@DocNo", objBrsBankPay.DocNo);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", objBrsBankPay.VchType);
        //        ClsCon.cmd.Parameters.AddWithValue("@Acccode", objBrsBankPay.AccCode);
        //        ClsCon.cmd.Parameters.AddWithValue("@VoucharDateFrom", objBrsBankPay.VoucharDateFrom);
        //        ClsCon.cmd.Parameters.AddWithValue("@VoucharDateto", objBrsBankPay.VoucharDateto);
        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dsBRS = new DataSet();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dsBRS);
        //        dsBRS.DataSetName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dsBRS = new DataSet();
        //        dsBRS.DataSetName = "error";
        //        return dsBRS;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dsBRS;
        //}
    }
}