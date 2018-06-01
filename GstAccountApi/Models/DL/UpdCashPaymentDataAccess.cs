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
    public class UpdCashPaymentDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtUpdCashPay; DataTable dtCancelVoucher; DataSet dsUpdCashPay;

        internal DataTable AccountHead(UpdCashPaymentModel objUpdCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCashPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdCashPay = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdCashPay);
                dtUpdCashPay.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdCashPay = new DataTable();
                dtUpdCashPay.TableName = "error";
                return dtUpdCashPay;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdCashPay;
        }

        internal DataTable LastVoucherNo(UpdCashPaymentModel objUpdCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCashPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdCashPay = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdCashPay);
                dtUpdCashPay.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdCashPay = new DataTable();
                dtUpdCashPay.TableName = "error";
                return dtUpdCashPay;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdCashPay;
        }

        internal DataTable LoadNarration(UpdCashPaymentModel objUpdCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCashPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdCashPay = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdCashPay);
                dtUpdCashPay.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdCashPay = new DataTable();
                dtUpdCashPay.TableName = "error";
                return dtUpdCashPay;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdCashPay;
        }

        internal DataSet BindAllUpdCashPaymentDDL(UpdCashPaymentModel objUpdCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCashPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdCashPay = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdCashPay);
                dsUpdCashPay.DataSetName = "success";
            }
            catch (Exception)
            {
                dsUpdCashPay = new DataSet();
                dsUpdCashPay.DataSetName = "error";
                return dsUpdCashPay;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdCashPay;
        }

        internal DataTable LoadCashAccount(UpdCashPaymentModel objUpdCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCashPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdCashPay = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdCashPay);
                dtUpdCashPay.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdCashPay = new DataTable();
                dtUpdCashPay.TableName = "error";
                return dtUpdCashPay;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdCashPay;
        }

        internal DataTable SearchCashPay(UpdCashPaymentModel objUpdCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCashPay.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdCashPay.DocNo);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdCashPay = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdCashPay);
                dtUpdCashPay.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdCashPay = new DataTable();
                dtUpdCashPay.TableName = "error";
                return dtUpdCashPay;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdCashPay;
        }

        internal DataTable UpdateCashPay(UpdCashPaymentModel objUpdCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCashPay.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdCashPay.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objUpdCashPay.CCCode);
                ClsCon.cmd.Parameters.AddWithValue("@DeptID", objUpdCashPay.DeptID);
                ClsCon.cmd.Parameters.AddWithValue("@SubDeptID", objUpdCashPay.SubDeptID);
                ClsCon.cmd.Parameters.AddWithValue("@IsAudit", objUpdCashPay.IsAudit);
                ClsCon.cmd.Parameters.AddWithValue("@IsSendToAudit", objUpdCashPay.IsSendToAudit);

                ClsCon.cmd.Parameters.AddWithValue("@TblCash", JsonConvert.DeserializeObject<DataTable>(objUpdCashPay.Dt));


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdCashPay = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdCashPay);
                dtUpdCashPay.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdCashPay = new DataTable();
                dtUpdCashPay.TableName = "error";
                return dtUpdCashPay;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdCashPay;
        }

        internal DataTable CancelVoucher(UpdCashPaymentModel objUpdCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdCashPay.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objUpdCashPay.CancelReason);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdCashPay.VchType);


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

        internal DataTable CheckBudgetHead(UpdCashPaymentModel objUpdCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUpdCashPay.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdCashPay = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdCashPay);
                dtUpdCashPay.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdCashPay = new DataTable();
                dtUpdCashPay.TableName = "error";
                return dtUpdCashPay;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdCashPay;
        }
    }
}