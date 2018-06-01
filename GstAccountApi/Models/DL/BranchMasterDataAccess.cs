using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class BranchMasterDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtBranchMaster;
        DataSet dsBranchMaster;

        internal DataSet LoadBMDDL(BranchMasterModel objBMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBranch";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objBMModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBMModel.OrgID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsBranchMaster = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsBranchMaster);
                dsBranchMaster.DataSetName = "success";
            }
            catch (Exception)
            {
                dsBranchMaster = new DataSet();
                dsBranchMaster.DataSetName = "error";
                return dsBranchMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsBranchMaster;
        }

        internal DataTable LoadGSTINDetails(BranchMasterModel objBMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBranch";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objBMModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBMModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@GSTINID", objBMModel.GSTINID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBranchMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBranchMaster);
                dtBranchMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtBranchMaster = new DataTable();
                dtBranchMaster.TableName = "error";
                return dtBranchMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBranchMaster;
        }

        internal DataTable SaveBranch(BranchMasterModel objBMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBranch";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objBMModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBMModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@GSTINID", objBMModel.GSTINID);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objBMModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@BrName", objBMModel.BranchName);
                ClsCon.cmd.Parameters.AddWithValue("@BrAddress", objBMModel.Address);
                ClsCon.cmd.Parameters.AddWithValue("@City", objBMModel.City);
                ClsCon.cmd.Parameters.AddWithValue("@StateID", objBMModel.StateID);
                ClsCon.cmd.Parameters.AddWithValue("@PinCode", objBMModel.PinCode);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceNoSeries", objBMModel.InvoiceNoSeries);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceNo", objBMModel.InvoiceNo);
                ClsCon.cmd.Parameters.AddWithValue("@User", objBMModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objBMModel.IP);
                //ClsCon.cmd.Parameters.AddWithValue("@TblSeries", objBMModel.DtSeries);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBranchMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBranchMaster);
                dtBranchMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtBranchMaster = new DataTable();
                dtBranchMaster.TableName = "error";
                return dtBranchMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBranchMaster;
        }
    }
}