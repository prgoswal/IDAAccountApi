using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class CashSalesDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtCashSales;
        DataSet dsCashSales; DataTable dtStatePanNoList;

        internal DataSet BindAll(CashSalesModel objCashSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSaleVoucher";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashSalesModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", objCashSalesModel.ByCashSales);

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

        internal DataSet FillItemSellRate(CashSalesModel objCashSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", objCashSalesModel.ItemID);
                ClsCon.cmd.Parameters.AddWithValue("@ByCash", objCashSalesModel.ByCashSales);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objCashSalesModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@PartyState", objCashSalesModel.PartyState);

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

        internal DataTable FillGistnNo(CashSalesModel objCashSalesModel) //fill GistnNo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objCashSalesModel.AccCode);

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

        internal DataTable FillShippingAddress(CashSalesModel objCashSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objCashSalesModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objCashSalesModel.GSTIN);

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

        internal DataTable SaveCashSalesVoucher(CashSalesModel objCashSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSaleVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashSalesModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objCashSalesModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objCashSalesModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objCashSalesModel.IP);

                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", objCashSalesModel.ByCashSales);
                ClsCon.cmd.Parameters.AddWithValue("@PartyName", objCashSalesModel.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@PartyGSTIN", objCashSalesModel.PartyGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@PartyAddress", objCashSalesModel.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@PartyMobileNo", objCashSalesModel.PartyMobileNo);
                ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", objCashSalesModel.WareHouseID);
                ClsCon.cmd.Parameters.AddWithValue("@TransName", objCashSalesModel.TransName);
                ClsCon.cmd.Parameters.AddWithValue("@PONo", objCashSalesModel.PONo);

                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objCashSalesModel.CCCode);


                ClsCon.cmd.Parameters.AddWithValue("@PayMode", objCashSalesModel.PayMode);
                ClsCon.cmd.Parameters.AddWithValue("@PayModeRemark", objCashSalesModel.PayModeRemark);

                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", objCashSalesModel.InvoiceSeries);
                ClsCon.cmd.Parameters.AddWithValue("@PartyState", objCashSalesModel.PartyState);

                ClsCon.cmd.Parameters.AddWithValue("@TblSale", objCashSalesModel.DtCashSales);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", objCashSalesModel.DtItems);
                ClsCon.cmd.Parameters.AddWithValue("@TblSundries", objCashSalesModel.DtSundries);
                ClsCon.cmd.Parameters.AddWithValue("@TblAdvanceDetail", objCashSalesModel.DtAdjAdvance);




                ClsCon.cmd.Parameters.AddWithValue("@BrokerageID", objCashSalesModel.BrokerageID);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageRate", objCashSalesModel.BrokerageRate);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageGSTIN", objCashSalesModel.BrokerageGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageAmount", objCashSalesModel.BrokerageAmount);

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

        internal DataTable CancelCashSalesVoucherNo(CashSalesModel objCashSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSaleVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashSalesModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objCashSalesModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objCashSalesModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objCashSalesModel.IP);

                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", objCashSalesModel.ByCashSales);
                ClsCon.cmd.Parameters.AddWithValue("@PartyName", objCashSalesModel.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@PartyGSTIN", objCashSalesModel.PartyGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@PartyAddress", objCashSalesModel.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@PartyMobileNo", objCashSalesModel.PartyMobileNo);
                ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", objCashSalesModel.WareHouseID);
                ClsCon.cmd.Parameters.AddWithValue("@TransName", objCashSalesModel.TransName);
                ClsCon.cmd.Parameters.AddWithValue("@PONo", objCashSalesModel.PONo);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objCashSalesModel.CancelReason);


                ClsCon.cmd.Parameters.AddWithValue("@PayMode", objCashSalesModel.PayMode);
                ClsCon.cmd.Parameters.AddWithValue("@PayModeRemark", objCashSalesModel.PayModeRemark);

                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", objCashSalesModel.InvoiceSeries);

                ClsCon.cmd.Parameters.AddWithValue("@TblSale", objCashSalesModel.DtCashSales);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", objCashSalesModel.DtItems);
                //ClsCon.cmd.Parameters.AddWithValue("@TblSundries", objCashSalesModel.DtSundries);

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

        internal DataTable CheckGSTIN_Number(CashSalesModel objCashSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSaleVoucher";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashSalesModel.OrgID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtStatePanNoList = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtStatePanNoList);
                dtStatePanNoList.TableName = "success";
            }
            catch (Exception)
            {
                dtStatePanNoList = new DataTable();
                dtStatePanNoList.TableName = "error";
                return dtStatePanNoList;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtStatePanNoList;
        }

        internal DataSet FillBrokerDetail(CashSalesModel objCashSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objCashSalesModel.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsCashSales = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsCashSales, "SuccessDataSet");
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
    }
}