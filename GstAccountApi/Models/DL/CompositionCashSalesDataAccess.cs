using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class CompositionCashSalesDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtCashSales;
        DataSet dsCashSales;

        internal DataSet BindAll(CompositionCashSalesModel objCompositionCashSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSaleVoucher";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCompositionCashSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCompositionCashSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCompositionCashSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCompositionCashSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCompositionCashSalesModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", objCompositionCashSalesModel.ByCashSales);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsCashSales = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsCashSales);
                dsCashSales.DataSetName = "success";
            }
            catch (Exception)
            {
                dsCashSales = new DataSet();
                dsCashSales.DataSetName = "error";
                return dsCashSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsCashSales;
        }

        internal DataSet FillItemSellRate(CompositionCashSalesModel objCompositionCashSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCompositionCashSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCompositionCashSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCompositionCashSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", objCompositionCashSalesModel.ItemID);
                ClsCon.cmd.Parameters.AddWithValue("@ByCash", objCompositionCashSalesModel.ByCashSales);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsCashSales = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsCashSales);
                dsCashSales.DataSetName = "success";
            }
            catch (Exception)
            {
                dsCashSales = new DataSet();
                dsCashSales.DataSetName = "error";
                return dsCashSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsCashSales;
        }

        internal DataTable FillGistnNo(CompositionCashSalesModel objCompositionCashSalesModel) //fill GistnNo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCompositionCashSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCompositionCashSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCompositionCashSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCompositionCashSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objCompositionCashSalesModel.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashSales = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashSales);
                dtCashSales.TableName = "success";
            }
            catch (Exception)
            {
                dtCashSales = new DataTable();
                dtCashSales.TableName = "error";
                return dtCashSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashSales;
        }

        internal DataTable FillShippingAddress(CompositionCashSalesModel objCompositionCashSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCompositionCashSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCompositionCashSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCompositionCashSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCompositionCashSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objCompositionCashSalesModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objCompositionCashSalesModel.GSTIN);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashSales = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashSales);
                dtCashSales.TableName = "success";
            }
            catch (Exception)
            {
                dtCashSales = new DataTable();
                dtCashSales.TableName = "error";
                return dtCashSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashSales;
        }

        internal DataTable SaveCashSalesVoucher(CompositionCashSalesModel objCompositionCashSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSaleVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCompositionCashSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCompositionCashSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCompositionCashSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCompositionCashSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCompositionCashSalesModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objCompositionCashSalesModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objCompositionCashSalesModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objCompositionCashSalesModel.IP);

                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", objCompositionCashSalesModel.ByCashSales);
                ClsCon.cmd.Parameters.AddWithValue("@PartyName", objCompositionCashSalesModel.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@PartyGSTIN", objCompositionCashSalesModel.PartyGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@PartyAddress", objCompositionCashSalesModel.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@PartyMobileNo", objCompositionCashSalesModel.PartyMobileNo);
                ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", objCompositionCashSalesModel.WareHouseID);
                ClsCon.cmd.Parameters.AddWithValue("@TransName", objCompositionCashSalesModel.TransName);
                ClsCon.cmd.Parameters.AddWithValue("@PONo", objCompositionCashSalesModel.PONo);

                ClsCon.cmd.Parameters.AddWithValue("@PayMode", objCompositionCashSalesModel.PayMode);
                ClsCon.cmd.Parameters.AddWithValue("@PayModeRemark", objCompositionCashSalesModel.PayModeRemark);

                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", objCompositionCashSalesModel.InvoiceSeries);

                ClsCon.cmd.Parameters.AddWithValue("@TblSale", objCompositionCashSalesModel.DtCashSales);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", objCompositionCashSalesModel.DtItems);
                ClsCon.cmd.Parameters.AddWithValue("@TblSundries", objCompositionCashSalesModel.DtSundries);
                ClsCon.cmd.Parameters.AddWithValue("@TblAdvanceDetail", objCompositionCashSalesModel.DtAdjAdvance);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashSales = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashSales);
                dtCashSales.TableName = "success";
            }
            catch (Exception)
            {
                dtCashSales = new DataTable();
                dtCashSales.TableName = "error";
                return dtCashSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashSales;
        }

        internal DataTable CancelCashSalesVoucherNo(CompositionCashSalesModel objCompositionCashSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSaleVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCompositionCashSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCompositionCashSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCompositionCashSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCompositionCashSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCompositionCashSalesModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objCompositionCashSalesModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objCompositionCashSalesModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objCompositionCashSalesModel.IP);

                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", objCompositionCashSalesModel.ByCashSales);
                ClsCon.cmd.Parameters.AddWithValue("@PartyName", objCompositionCashSalesModel.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@PartyGSTIN", objCompositionCashSalesModel.PartyGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@PartyAddress", objCompositionCashSalesModel.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@PartyMobileNo", objCompositionCashSalesModel.PartyMobileNo);
                ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", objCompositionCashSalesModel.WareHouseID);
                ClsCon.cmd.Parameters.AddWithValue("@TransName", objCompositionCashSalesModel.TransName);
                ClsCon.cmd.Parameters.AddWithValue("@PONo", objCompositionCashSalesModel.PONo);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objCompositionCashSalesModel.CancelReason);


                ClsCon.cmd.Parameters.AddWithValue("@PayMode", objCompositionCashSalesModel.PayMode);
                ClsCon.cmd.Parameters.AddWithValue("@PayModeRemark", objCompositionCashSalesModel.PayModeRemark);

                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", objCompositionCashSalesModel.InvoiceSeries);

                ClsCon.cmd.Parameters.AddWithValue("@TblSale", objCompositionCashSalesModel.DtCashSales);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", objCompositionCashSalesModel.DtItems);
                //ClsCon.cmd.Parameters.AddWithValue("@TblSundries", objCompositionCashSalesModel.DtSundries);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashSales = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashSales);
                dtCashSales.TableName = "success";
            }
            catch (Exception)
            {
                dtCashSales = new DataTable();
                dtCashSales.TableName = "error";
                return dtCashSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashSales;
        }
    }
}