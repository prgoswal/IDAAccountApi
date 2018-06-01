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
    public class UpdBankPaymentDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtUpdBankPayment; DataTable dtCancelVoucher; DataSet dsUpdBankPayment;

        internal DataTable AccountHead(UpdBankPaymentModel objUpdBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdBankPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdBankPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdBankPayment);
                dtUpdBankPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdBankPayment = new DataTable();
                dtUpdBankPayment.TableName = "error";
                return dtUpdBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdBankPayment;
        }

        internal DataTable LastVoucherNo(UpdBankPaymentModel objUpdBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdBankPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdBankPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdBankPayment);
                dtUpdBankPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdBankPayment = new DataTable();
                dtUpdBankPayment.TableName = "error";
                return dtUpdBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdBankPayment;
        }

        internal DataTable LoadNarration(UpdBankPaymentModel objUpdBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdBankPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdBankPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdBankPayment);
                dtUpdBankPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdBankPayment = new DataTable();
                dtUpdBankPayment.TableName = "error";
                return dtUpdBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdBankPayment;
        }

        internal DataSet BindAllUpdBankPaymentDDL(UpdBankPaymentModel objUpdBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdBankPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdBankPayment = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdBankPayment);
                dsUpdBankPayment.DataSetName = "success";
            }
            catch (Exception)
            {
                dsUpdBankPayment = new DataSet();
                dsUpdBankPayment.DataSetName = "error";
                return dsUpdBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdBankPayment;
        }

        internal DataTable LoadBankAccount(UpdBankPaymentModel objUpdBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdBankPay.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdBankPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdBankPayment);
                dtUpdBankPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdBankPayment = new DataTable();
                dtUpdBankPayment.TableName = "error";
                return dtUpdBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdBankPayment;
        }

        internal DataTable SearchBankPay(UpdBankPaymentModel objUpdBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdBankPay.VchType);
                // ClsCon.cmd.Parameters.AddWithValue("@TblCash", objUpdCashRec.Dt);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdBankPay.DocNo);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdBankPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdBankPayment);
                dtUpdBankPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdBankPayment = new DataTable();
                dtUpdBankPayment.TableName = "error";
                return dtUpdBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdBankPayment;
        }

        internal DataTable UpdateBankPay(UpdBankPaymentModel objUpdBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdBankPay.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdBankPay.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objUpdBankPay.CCCode);
                ClsCon.cmd.Parameters.AddWithValue("@IDARefNo", objUpdBankPay.IDARefNo);
                ClsCon.cmd.Parameters.AddWithValue("@DeptID", objUpdBankPay.DeptID);
                ClsCon.cmd.Parameters.AddWithValue("@SubDeptID", objUpdBankPay.SubDeptID);
                ClsCon.cmd.Parameters.AddWithValue("@IsFinal", objUpdBankPay.IsFinal);
                ClsCon.cmd.Parameters.AddWithValue("@IsAudit", objUpdBankPay.IsAudit);
                ClsCon.cmd.Parameters.AddWithValue("@IsSendToAudit", objUpdBankPay.IsSendToAudit);
                ClsCon.cmd.Parameters.AddWithValue("@BankPayVoucherInd", objUpdBankPay.BankPayVoucherInd);
                ClsCon.cmd.Parameters.AddWithValue("@ChequeDrawn", objUpdBankPay.ChequeDrawn);
                ClsCon.cmd.Parameters.AddWithValue("@TblBank", JsonConvert.DeserializeObject<DataTable>(objUpdBankPay.Dt));
                ClsCon.cmd.Parameters.AddWithValue("@User", objUpdBankPay.User);

                //ClsCon.cmd.Parameters.AddWithValue("@TblBank", objUpdBankPay.Dt);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdBankPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdBankPayment);
                dtUpdBankPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdBankPayment = new DataTable();
                dtUpdBankPayment.TableName = "error";
                return dtUpdBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdBankPayment;
        }

        internal DataTable CancelVoucher(UpdBankPaymentModel objUpdBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdBankPay.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objUpdBankPay.CancelReason);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdBankPay.VchType);


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

        internal DataTable CheckBudgetHead(UpdBankPaymentModel objUpdBankPay)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBankVoucher";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdBankPay.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdBankPay.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdBankPay.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdBankPay.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUpdBankPay.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdBankPayment = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdBankPayment);
                dtUpdBankPayment.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdBankPayment = new DataTable();
                dtUpdBankPayment.TableName = "error";
                return dtUpdBankPayment;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdBankPayment;
        }
    }
}