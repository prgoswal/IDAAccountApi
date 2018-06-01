using GstAccountApi.Models.PL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class JournalVoucherDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtJV;
        DataSet dsJV;

        internal DataTable AccountHead(JournalVoucherModel objJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objJVModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtJV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtJV);
                dtJV.TableName = "success";
            }
            catch (Exception)
            {
                dtJV = new DataTable();
                dtJV.TableName = "error";
                return dtJV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtJV;
        }

        internal DataTable LastVoucherNo(JournalVoucherModel objJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objJVModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtJV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtJV);
                dtJV.TableName = "success";
            }
            catch (Exception)
            {
                dtJV = new DataTable();
                dtJV.TableName = "error";
                return dtJV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtJV;
        }

        internal DataTable LoadNarration(JournalVoucherModel objJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objJVModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtJV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtJV);
                dtJV.TableName = "success";
            }
            catch (Exception)
            {
                dtJV = new DataTable();
                dtJV.TableName = "error";
                return dtJV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtJV;
        }

        internal DataSet BindAllJVDDL(JournalVoucherModel objJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPJournalVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objJVModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsJV = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsJV);
                dsJV.DataSetName = "success";
            }
            catch (Exception)
            {
                dsJV = new DataSet();
                dsJV.DataSetName = "error";
                return dsJV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsJV;
        }

        internal DataTable LoadControlAccount(JournalVoucherModel objJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objJVModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtJV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtJV);
                dtJV.TableName = "success";
            }
            catch (Exception)
            {
                dtJV = new DataTable();
                dtJV.TableName = "error";
                return dtJV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtJV;
        }

        internal DataTable SaveJV(JournalVoucherModel objJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPJournalVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objJVModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objJVModel.CCCode);
                ClsCon.cmd.Parameters.AddWithValue("@IDARefNo", objJVModel.IDARefNo);

                ClsCon.cmd.Parameters.AddWithValue("@TblJV", JsonConvert.DeserializeObject<DataTable>(objJVModel.DtJV));

                //ClsCon.cmd.Parameters.AddWithValue("@TblJV", objJVModel.DtJV); 

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtJV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtJV);
                dtJV.TableName = "success";
            }
            catch (Exception)
            {
                dtJV = new DataTable();
                dtJV.TableName = "error";
                return dtJV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtJV;
        }

        internal DataTable CheckBudgetHead(JournalVoucherModel objJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPJournalVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objJVModel.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtJV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtJV);
                dtJV.TableName = "success";
            }
            catch (Exception)
            {
                dtJV = new DataTable();
                dtJV.TableName = "error";
                return dtJV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtJV;
        }
    }
}