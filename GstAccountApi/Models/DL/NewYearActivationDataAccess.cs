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
    public class NewYearActivationDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtFinancialYear;




        internal DataTable SaveFinancialYear(OpeningBlcTransferModel ObjOpeningBlcTransferModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPFinancialYear";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjOpeningBlcTransferModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjOpeningBlcTransferModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjOpeningBlcTransferModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCode", ObjOpeningBlcTransferModel.YrCode);
                ClsCon.cmd.Parameters.AddWithValue("@YearFromTo", ObjOpeningBlcTransferModel.YearFromTo);
                ClsCon.cmd.Parameters.AddWithValue("@ActiveID", ObjOpeningBlcTransferModel.ActiveID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", ObjOpeningBlcTransferModel.UserID);
                ClsCon.cmd.Parameters.AddWithValue("@IPAddress", ObjOpeningBlcTransferModel.IPAddress);
                ClsCon.cmd.Parameters.AddWithValue("@YrStartDate", ObjOpeningBlcTransferModel.YrStartDate);
                ClsCon.cmd.Parameters.AddWithValue("@YrEndDate", ObjOpeningBlcTransferModel.YrEndDate);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtFinancialYear = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtFinancialYear);
                dtFinancialYear.TableName = "success";
            }
            catch (Exception)
            {
                dtFinancialYear = new DataTable();
                dtFinancialYear.TableName = "error";
                return dtFinancialYear;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtFinancialYear;
        }

        internal DataTable LoadFinancialYear(OpeningBlcTransferModel ObjOpeningBlcTransferModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPFinancialYear";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjOpeningBlcTransferModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjOpeningBlcTransferModel.OrgID);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtFinancialYear = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtFinancialYear);
                dtFinancialYear.TableName = "success";
            }
            catch (Exception)
            {
                dtFinancialYear = new DataTable();
                dtFinancialYear.TableName = "error";
                return dtFinancialYear;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtFinancialYear;
        }

        internal DataTable LoadClosingBalance(OpeningBlcTransferModel ObjOpeningBlcTransferModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPRPTtrialBalance";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjOpeningBlcTransferModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjOpeningBlcTransferModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjOpeningBlcTransferModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCode", ObjOpeningBlcTransferModel.YrCode);
                ClsCon.cmd.Parameters.AddWithValue("@VoucharDateFrom", ObjOpeningBlcTransferModel.VoucharDateFrom);
                ClsCon.cmd.Parameters.AddWithValue("@VoucharDateto", ObjOpeningBlcTransferModel.VoucharDateto);
                ClsCon.cmd.Parameters.AddWithValue("@Reportorder", ObjOpeningBlcTransferModel.Reportorder);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtFinancialYear = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtFinancialYear);
                dtFinancialYear.TableName = "success";
            }
            catch (Exception)
            {
                dtFinancialYear = new DataTable();
                dtFinancialYear.TableName = "error";
                return dtFinancialYear;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtFinancialYear;
        }

        internal DataTable SaveOpeningBalance(OpeningBlcTransferModel ObjOpeningBlcTransferModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPFinancialYear";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjOpeningBlcTransferModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjOpeningBlcTransferModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjOpeningBlcTransferModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCode", ObjOpeningBlcTransferModel.YrCode);
                ClsCon.cmd.Parameters.AddWithValue("@VChType", ObjOpeningBlcTransferModel.DocTypeID);
                ClsCon.cmd.Parameters.AddWithValue("@YrStartDate", ObjOpeningBlcTransferModel.YrStartDate);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", ObjOpeningBlcTransferModel.VoucharDate);
                ClsCon.cmd.Parameters.AddWithValue("@VoucherNo", ObjOpeningBlcTransferModel.VoucharNo);
                ClsCon.cmd.Parameters.AddWithValue("@Narration", ObjOpeningBlcTransferModel.Narration);
                ClsCon.cmd.Parameters.AddWithValue("@ClosingStock", ObjOpeningBlcTransferModel.ClosingStock);
                ClsCon.cmd.Parameters.AddWithValue("@IP", ObjOpeningBlcTransferModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@User", ObjOpeningBlcTransferModel.User);


                ClsCon.cmd.Parameters.AddWithValue("@TblOpeningBlc", JsonConvert.DeserializeObject<DataTable>(ObjOpeningBlcTransferModel.dtOpeningBlc));

                //ClsCon.cmd.Parameters.AddWithValue("@TblOpeningBlc", ObjOpeningBlcTransfer.dtOpeningBlc);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtFinancialYear = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtFinancialYear);
                dtFinancialYear.TableName = "success";
            }
            catch (Exception)
            {
                dtFinancialYear = new DataTable();
                dtFinancialYear.TableName = "error";
                return dtFinancialYear;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtFinancialYear;
        }

        internal DataTable TrasferItemOpeningBlc(OpeningBlcTransferModel ObjOpeningBlcTransfer)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPFifoMethod";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjOpeningBlcTransfer.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjOpeningBlcTransfer.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjOpeningBlcTransfer.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjOpeningBlcTransfer.YrCode);
                ClsCon.cmd.Parameters.AddWithValue("@Itemcd", "");

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtFinancialYear = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtFinancialYear);
                dtFinancialYear.TableName = "success";
            }
            catch (Exception)
            {
                dtFinancialYear = new DataTable();
                dtFinancialYear.TableName = "error";
                return dtFinancialYear;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtFinancialYear;
        }

        internal DataTable ItemDetails(OpeningBlcTransferModel ObjOpeningBlcTransfer)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPFinancialYear";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjOpeningBlcTransfer.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjOpeningBlcTransfer.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjOpeningBlcTransfer.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCode", ObjOpeningBlcTransfer.YrCode);
                ClsCon.cmd.Parameters.AddWithValue("@IP", ObjOpeningBlcTransfer.IP);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", ObjOpeningBlcTransfer.User);
                ClsCon.cmd.Parameters.AddWithValue("@EntryDate", ObjOpeningBlcTransfer.EntryDate);
                ClsCon.cmd.Parameters.AddWithValue("@TblItemTransferDetail", JsonConvert.DeserializeObject<DataTable>(ObjOpeningBlcTransfer.dtItemDetail));
                //ClsCon.cmd.Parameters.AddWithValue("@TblItemTransferDetail", ObjOpeningBlcTransfer.dtItemDetail);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtFinancialYear = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtFinancialYear);
                dtFinancialYear.TableName = "success";
            }
            catch (Exception)
            {
                dtFinancialYear = new DataTable();
                dtFinancialYear.TableName = "error";
                return dtFinancialYear;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtFinancialYear;
        }
    }
}