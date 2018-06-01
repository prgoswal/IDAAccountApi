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
    public class BankPaymentDataAccess
    {

        SqlConnection con = new SqlConnection();
        DataTable dtBankPayment;
        DataSet dsBankPayment;

        internal DataTable AccountHead(BankPaymentModel objBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objBankPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBankPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBankPayment);
                dtBankPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtBankPayment = new DataTable();
                dtBankPayment.TableName = "error";
                return dtBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBankPayment;
        }

        internal DataTable LastVoucherNo(BankPaymentModel objBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objBankPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBankPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBankPayment);
                dtBankPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtBankPayment = new DataTable();
                dtBankPayment.TableName = "error";
                return dtBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBankPayment;
        }

        internal DataTable LoadNarration(BankPaymentModel objBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objBankPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBankPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBankPayment);
                dtBankPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtBankPayment = new DataTable();
                dtBankPayment.TableName = "error";
                return dtBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBankPayment;
        }

        internal DataSet BindAllBankPaymentDDL(BankPaymentModel objBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objBankPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsBankPayment = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsBankPayment);
                dsBankPayment.DataSetName = "success";
            }
            catch (Exception)
            {
                dsBankPayment = new DataSet();
                dsBankPayment.DataSetName = "error";
                return dsBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsBankPayment;
        }

        internal DataTable LoadBankAccount(BankPaymentModel objBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objBankPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBankPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBankPayment);
                dtBankPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtBankPayment = new DataTable();
                dtBankPayment.TableName = "error";
                return dtBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBankPayment;
        }

        internal DataTable SaveBankPayment(BankPaymentModel objBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objBankPay.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objBankPay.CCCode);
                ClsCon.cmd.Parameters.AddWithValue("@IDARefNo", objBankPay.IDARefNo);
                ClsCon.cmd.Parameters.AddWithValue("@DeptID", objBankPay.DeptID);
                ClsCon.cmd.Parameters.AddWithValue("@SubDeptID", objBankPay.SubDeptID);
                ClsCon.cmd.Parameters.AddWithValue("@TblBank", JsonConvert.DeserializeObject<DataTable>(objBankPay.Dt));
                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyName", objBankPay.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyAddress", objBankPay.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@RevenuePartyGSTIN", objBankPay.PartyGstIN);
                ClsCon.cmd.Parameters.AddWithValue("@RevenueServiceNo", objBankPay.ServiceNo);
                ClsCon.cmd.Parameters.AddWithValue("@IsFinal", objBankPay.IsFinal);
                ClsCon.cmd.Parameters.AddWithValue("@IsAudit", objBankPay.IsAudit);
                ClsCon.cmd.Parameters.AddWithValue("@IsSendToAudit", objBankPay.IsSendToAudit);
                ClsCon.cmd.Parameters.AddWithValue("@BankPayVoucherInd", objBankPay.BankPayVoucherInd);
                ClsCon.cmd.Parameters.AddWithValue("@ChequeDrawn", objBankPay.ChequeDrawn);
                ClsCon.cmd.Parameters.AddWithValue("@User", objBankPay.User);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBankPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBankPayment);
                dtBankPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtBankPayment = new DataTable();
                dtBankPayment.TableName = "error";
                return dtBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBankPayment;
        }

        internal DataTable PartySelect(BankPaymentModel objBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objBankPay.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBankPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBankPayment);
                dtBankPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtBankPayment = new DataTable();
                dtBankPayment.TableName = "error";
                return dtBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBankPayment;
        }

        internal DataTable CheckBudgetHead(BankPaymentModel objBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objBankPay.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtBankPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtBankPayment);
                dtBankPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtBankPayment = new DataTable();
                dtBankPayment.TableName = "error";
                return dtBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtBankPayment;
        }
    }
}