using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdateAccountHeadDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtUpdAccountHead;
        DataSet dsUpdAccountHead;

        internal DataTable LoadAccountHead(UpdateAccounHeadModel objUAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateAccountHead";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUAHModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdAccountHead);
                dtUpdAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdAccountHead = new DataTable();
                dtUpdAccountHead.TableName = "error";
                return dtUpdAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdAccountHead;
        }

        internal DataTable LoadState(UpdateAccounHeadModel objUAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUAHModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdAccountHead);
                dtUpdAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdAccountHead = new DataTable();
                dtUpdAccountHead.TableName = "error";
                return dtUpdAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdAccountHead;
        }

        internal DataTable LoadGroupName(UpdateAccounHeadModel objUAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@IsAdmin", objUAHModel.IsAdmin);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdAccountHead);
                dtUpdAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdAccountHead = new DataTable();
                dtUpdAccountHead.TableName = "error";
                return dtUpdAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdAccountHead;
        }

        internal DataTable LoadExportCategory(UpdateAccounHeadModel objUAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUAHModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdAccountHead);
                dtUpdAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdAccountHead = new DataTable();
                dtUpdAccountHead.TableName = "error";
                return dtUpdAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdAccountHead;
        }

        internal DataSet LoadBasicInfo(UpdateAccounHeadModel objUAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateAccountHead";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUAHModel.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdAccountHead = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdAccountHead);
                //DSUpdAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dsUpdAccountHead = new DataSet();
                //dtUpdAccountHead.TableName = "error";
                return dsUpdAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdAccountHead;
        }

        internal DataTable LoadGSTINInfo(UpdateAccounHeadModel objUAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateAccountHead";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUAHModel.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdAccountHead);
                dtUpdAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdAccountHead = new DataTable();
                dtUpdAccountHead.TableName = "error";
                return dtUpdAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdAccountHead;
        }

        internal DataSet LoadShippingInfo(UpdateAccounHeadModel objUAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateAccountHead";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUAHModel.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdAccountHead = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdAccountHead);
                dsUpdAccountHead.DataSetName = "success";
            }
            catch (Exception)
            {
                dsUpdAccountHead = new DataSet();
                dsUpdAccountHead.DataSetName = "error";
                return dsUpdAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdAccountHead;
        }

        internal DataTable LoadBranchState(UpdateAccounHeadModel objUAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateAccountHead";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUAHModel.BrID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdAccountHead);
                dtUpdAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdAccountHead = new DataTable();
                dtUpdAccountHead.TableName = "error";
                return dtUpdAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdAccountHead;
        }

        internal DataTable UpdateClientInfo(UpdateAccounHeadModel objUAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateAccountHead";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUAHModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUAHModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@AccName", objUAHModel.AccName);
                ClsCon.cmd.Parameters.AddWithValue("@AccNameHindi", objUAHModel.AccNameHindi);
                ClsCon.cmd.Parameters.AddWithValue("@MainGroupID", objUAHModel.MainGroupID);
                ClsCon.cmd.Parameters.AddWithValue("@SubGroupID", objUAHModel.SubGroupID);
                ClsCon.cmd.Parameters.AddWithValue("@AccGroupID", objUAHModel.AccGroupID);
                ClsCon.cmd.Parameters.AddWithValue("@AccSubGroupID", objUAHModel.AccSubGroupID);
                ClsCon.cmd.Parameters.AddWithValue("@Address", objUAHModel.Address);
                ClsCon.cmd.Parameters.AddWithValue("@City", objUAHModel.City);
                ClsCon.cmd.Parameters.AddWithValue("@StateID", objUAHModel.StateID);
                ClsCon.cmd.Parameters.AddWithValue("@PinCode", objUAHModel.PinCode);
                ClsCon.cmd.Parameters.AddWithValue("@PanNo", objUAHModel.PanNo);
                ClsCon.cmd.Parameters.AddWithValue("@MobileNo", objUAHModel.MobileNo);
                ClsCon.cmd.Parameters.AddWithValue("@LandlineNo", objUAHModel.LandlineNo);
                ClsCon.cmd.Parameters.AddWithValue("@Email", objUAHModel.Email);
                ClsCon.cmd.Parameters.AddWithValue("@ContactPerson", objUAHModel.ContactPerson);
                ClsCon.cmd.Parameters.AddWithValue("@DrOpBalance", objUAHModel.DrOpBalance);
                ClsCon.cmd.Parameters.AddWithValue("@CrOpBalance", objUAHModel.CrOpBalance);
                ClsCon.cmd.Parameters.AddWithValue("@CategoryID", objUAHModel.CategoryID);
                ClsCon.cmd.Parameters.AddWithValue("@ISDApplicable", objUAHModel.ISDApplicable);
                ClsCon.cmd.Parameters.AddWithValue("@TDSApplicable", objUAHModel.TDSApplicable);
                ClsCon.cmd.Parameters.AddWithValue("@RCMApplicable", objUAHModel.RCMApplicable);
                ClsCon.cmd.Parameters.AddWithValue("@TCSApplicable", objUAHModel.TCSApplicable);
                ClsCon.cmd.Parameters.AddWithValue("@MerchantID", objUAHModel.MerchantID);
                ClsCon.cmd.Parameters.AddWithValue("@BankName", objUAHModel.BankName);
                ClsCon.cmd.Parameters.AddWithValue("@BranchName", objUAHModel.BranchName);
                ClsCon.cmd.Parameters.AddWithValue("@IFSCCode", objUAHModel.IFSCCode);
                ClsCon.cmd.Parameters.AddWithValue("@BankAccountNo", objUAHModel.BankAccountNo);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", objUAHModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", objUAHModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@CompositionOpted", objUAHModel.CompositionOpted);
                ClsCon.cmd.Parameters.AddWithValue("@ReffPartyCode", objUAHModel.ReffPartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@IsSubDealer", objUAHModel.IsSubDealer);
                ClsCon.cmd.Parameters.AddWithValue("@DiscountRate", objUAHModel.DiscountRate);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageRate", objUAHModel.BrokerageRate);
                ClsCon.cmd.Parameters.AddWithValue("@TblAccTerms", objUAHModel.TblAccTerms);
                ClsCon.cmd.Parameters.AddWithValue("@TaxCalcForSEZParty", objUAHModel.TaxCalcForSEZParty);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageLimit", objUAHModel.BrokerageLimit);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageType", objUAHModel.BrokerageType);
                ClsCon.cmd.Parameters.AddWithValue("@Remark", objUAHModel.Remark);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdAccountHead);
                dtUpdAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdAccountHead = new DataTable();
                dtUpdAccountHead.TableName = "error";
                return dtUpdAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdAccountHead;
        }

        internal DataTable UpdateGSTINInfo(UpdateAccounHeadModel objUAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateAccountHead";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", objUAHModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", objUAHModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@TblAccGSTIN", objUAHModel.DtAccGSTIN);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdAccountHead);
                dtUpdAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdAccountHead = new DataTable();
                dtUpdAccountHead.TableName = "error";
                return dtUpdAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdAccountHead;
        }

        internal DataTable UpdateShippingInfo(UpdateAccounHeadModel objUAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateAccountHead";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", objUAHModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", objUAHModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@TblAccPOS", objUAHModel.DtAccPOS);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdAccountHead);
                dtUpdAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdAccountHead = new DataTable();
                dtUpdAccountHead.TableName = "error";
                return dtUpdAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdAccountHead;
        }
    }
}