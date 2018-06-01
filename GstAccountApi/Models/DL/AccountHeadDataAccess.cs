using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class AccountHeadDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtAccountHead;

        internal DataTable LoadState(AccountHeadModel objAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objAHModel.YrCD);
                
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtAccountHead);
                dtAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtAccountHead = new DataTable();
                dtAccountHead.TableName = "error";
                return dtAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtAccountHead;
        }

        internal DataTable LoadGroupName(AccountHeadModel objAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@IsAdmin", objAHModel.IsAdmin);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtAccountHead);
                dtAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtAccountHead = new DataTable();
                dtAccountHead.TableName = "error";
                return dtAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtAccountHead;
        }

        internal DataTable LoadExportCategory(AccountHeadModel objAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objAHModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtAccountHead);
                dtAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtAccountHead = new DataTable();
                dtAccountHead.TableName = "error";
                return dtAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtAccountHead;
        }

        internal DataTable LoadAccountHead(AccountHeadModel objAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPAccountHead";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objAHModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtAccountHead);
                dtAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtAccountHead = new DataTable();
                dtAccountHead.TableName = "error";
                return dtAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtAccountHead;
        }


        internal DataTable LoadBranchState(AccountHeadModel objAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPAccountHead";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objAHModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtAccountHead);
                dtAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtAccountHead = new DataTable();
                dtAccountHead.TableName = "error";
                return dtAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtAccountHead;
        }

        internal DataTable SaveAccountHead(AccountHeadModel objAHModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPAccountHead";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objAHModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objAHModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objAHModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objAHModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@User", objAHModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objAHModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objAHModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@CompositionOpted", objAHModel.CompositionOpted);
                ClsCon.cmd.Parameters.AddWithValue("@ReffPartyCode", objAHModel.ReffPartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@IsSubDealer", objAHModel.IsSubDealer);
                ClsCon.cmd.Parameters.AddWithValue("@DiscountRate", objAHModel.DiscountRate);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageRate", objAHModel.BrokerageRate);
                ClsCon.cmd.Parameters.AddWithValue("@TblAccount", objAHModel.DtAccount);
                ClsCon.cmd.Parameters.AddWithValue("@TblAccGSTIN", objAHModel.DtAccGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@TblAccPOS", objAHModel.DtAccPOS);
                ClsCon.cmd.Parameters.AddWithValue("@TblAccTerms", objAHModel.TblAccTerms);
                ClsCon.cmd.Parameters.AddWithValue("@TaxCalcForSEZParty", objAHModel.TaxCalcForSEZParty);
                ClsCon.cmd.Parameters.AddWithValue("@AccountHeadHindi", objAHModel.AccountHeadHindi);


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtAccountHead = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtAccountHead);
                dtAccountHead.TableName = "success";
            }
            catch (Exception)
            {
                dtAccountHead = new DataTable();
                dtAccountHead.TableName = "error";
                return dtAccountHead;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtAccountHead;
        }


       
    }
}