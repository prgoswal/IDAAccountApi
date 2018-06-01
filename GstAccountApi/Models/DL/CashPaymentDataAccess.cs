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
    public class CashPaymentDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtCashPayment; DataTable dtCancelVoucher; DataSet dsCancelPayment;

        internal DataTable AccountHead(CashPaymentModel objCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashPayment);
                dtCashPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtCashPayment = new DataTable();
                dtCashPayment.TableName = "error";
                return dtCashPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashPayment;
        }

        internal DataTable LastVoucherNo(CashPaymentModel objCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashPayment);
                dtCashPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtCashPayment = new DataTable();
                dtCashPayment.TableName = "error";
                return dtCashPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashPayment;
        }

        internal DataTable LoadNarration(CashPaymentModel objCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashPayment);
                dtCashPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtCashPayment = new DataTable();
                dtCashPayment.TableName = "error";
                return dtCashPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashPayment;
        }

        internal DataSet BindAllCashPaymentDDL(CashPaymentModel objCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsCancelPayment = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsCancelPayment);
                dsCancelPayment.DataSetName = "success";
            }
            catch (Exception)
            {
                dsCancelPayment = new DataSet();
                dsCancelPayment.DataSetName = "error";
                return dsCancelPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsCancelPayment;
        }

        internal DataTable LoadCashAccount(CashPaymentModel objCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashPayment);
                dtCashPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtCashPayment = new DataTable();
                dtCashPayment.TableName = "error";
                return dtCashPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashPayment;
        }

        internal DataTable SaveCashPayment(CashPaymentModel objCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashPay.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objCashPay.CCCode);
                ClsCon.cmd.Parameters.AddWithValue("@DeptID", objCashPay.DeptID);
                ClsCon.cmd.Parameters.AddWithValue("@SubDeptID", objCashPay.SubDeptID);
                ClsCon.cmd.Parameters.AddWithValue("@IsFinal", objCashPay.IsFinal);
                ClsCon.cmd.Parameters.AddWithValue("@TblCash", JsonConvert.DeserializeObject<DataTable>(objCashPay.Dt));

                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyName", objCashPay.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyAddress", objCashPay.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyGSTIN", objCashPay.PartyGstIN);
                ClsCon.cmd.Parameters.AddWithValue("@RevenueServiceNo", objCashPay.ServiceNo);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashPayment);
                dtCashPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtCashPayment = new DataTable();
                dtCashPayment.TableName = "error";
                return dtCashPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashPayment;
        }

        internal DataTable PartySelect(CashPaymentModel objCashPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objCashPay.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashPayment);
                dtCashPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtCashPayment = new DataTable();
                dtCashPayment.TableName = "error";
                return dtCashPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashPayment;
        }

        internal DataTable CheckBudgetHead(CashPaymentModel plcashpay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPCashVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", plcashpay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", plcashpay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", plcashpay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", plcashpay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", plcashpay.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashPayment);
                dtCashPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtCashPayment = new DataTable();
                dtCashPayment.TableName = "error";
                return dtCashPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashPayment;
        }
    }
}