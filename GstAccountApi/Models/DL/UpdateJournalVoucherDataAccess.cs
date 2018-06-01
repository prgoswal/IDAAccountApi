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
    public class UpdateJournalVoucherDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtUJV; DataTable dtCancelVoucher; DataSet dsUJV;

        internal DataTable AccountHead(UpdateJournalVoucherModel objUJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUJVModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUJV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUJV);
                dtUJV.TableName = "success";
            }
            catch (Exception)
            {
                dtUJV = new DataTable();
                dtUJV.TableName = "error";
                return dtUJV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUJV;
        }

        internal DataTable LastVoucherNo(UpdateJournalVoucherModel objUJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUJVModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUJV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUJV);
                dtUJV.TableName = "success";
            }
            catch (Exception)
            {
                dtUJV = new DataTable();
                dtUJV.TableName = "error";
                return dtUJV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUJV;
        }

        internal DataTable LoadNarration(UpdateJournalVoucherModel objUJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUJVModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUJV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUJV);
                dtUJV.TableName = "success";
            }
            catch (Exception)
            {
                dtUJV = new DataTable();
                dtUJV.TableName = "error";
                return dtUJV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUJV;
        }

        internal DataSet BindAllUpdJVDDL(UpdateJournalVoucherModel objUJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateJournalVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUJVModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUJV = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUJV);
                dsUJV.DataSetName = "success";
            }
            catch (Exception)
            {
                dsUJV = new DataSet();
                dsUJV.DataSetName = "error";
                return dsUJV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUJV;
        }

        internal DataTable LoadControlAccount(UpdateJournalVoucherModel objUJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUJVModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUJV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUJV);
                dtUJV.TableName = "success";
            }
            catch (Exception)
            {
                dtUJV = new DataTable();
                dtUJV.TableName = "error";
                return dtUJV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUJV;
        }

        internal DataTable SearchJV(UpdateJournalVoucherModel objUJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateJournalVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUJVModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUJVModel.DocNo);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUJV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUJV);
                dtUJV.TableName = "success";
            }
            catch (Exception)
            {
                dtUJV = new DataTable();
                dtUJV.TableName = "error";
                return dtUJV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUJV;
        }

        internal DataTable UpdateJV(UpdateJournalVoucherModel objUJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateJournalVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUJVModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUJVModel.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objUJVModel.CCCode);
                ClsCon.cmd.Parameters.AddWithValue("@IDARefNo", objUJVModel.IDARefNo);
                ClsCon.cmd.Parameters.AddWithValue("@TblJV", JsonConvert.DeserializeObject<DataTable>(objUJVModel.DtJV));
                //ClsCon.cmd.Parameters.AddWithValue("@TblJV", objUJVModel.DtJV);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUJV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUJV);
                dtUJV.TableName = "success";
            }
            catch (Exception)
            {
                dtUJV = new DataTable();
                dtUJV.TableName = "error";
                return dtUJV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUJV;
        }

        internal DataTable CancelVoucher(UpdateJournalVoucherModel objUJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateJournalVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUJVModel.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VChType", objUJVModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objUJVModel.CancelReason);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCancelVoucher = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCancelVoucher);
                dtCancelVoucher.TableName = "success";
            }
            catch (Exception)
            {
                dtCancelVoucher = new DataTable();
                dtCancelVoucher.TableName = "error";
                return dtCancelVoucher;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCancelVoucher;
        }

        internal DataTable CheckBudgetHead(UpdateJournalVoucherModel objUJVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPJournalVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUJVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUJVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUJVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUJVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUJVModel.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUJV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUJV);
                dtUJV.TableName = "success";
            }
            catch (Exception)
            {
                dtUJV = new DataTable();
                dtUJV.TableName = "error";
                return dtUJV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUJV;
        }
    }
}