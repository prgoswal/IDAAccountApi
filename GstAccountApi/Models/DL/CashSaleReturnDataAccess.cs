using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class CashSaleReturnDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtCashSalesReturn;
        DataSet dsCashSalesReturn; DataTable dtStatePanNoList;

        internal DataSet BindAll(CashSaleReturnModel objCashSalesReturnModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SpCashSaleReturnVoucher";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashSalesReturnModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashSalesReturnModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashSalesReturnModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashSalesReturnModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashSalesReturnModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", objCashSalesReturnModel.ByCashSale);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsCashSalesReturn = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsCashSalesReturn);
                dsCashSalesReturn.DataSetName = "success";
            }
            catch (Exception)
            {
                dsCashSalesReturn = new DataSet();
                dsCashSalesReturn.DataSetName = "error";
                return dsCashSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsCashSalesReturn;
        }


        internal DataTable FillGistnNo(CashSaleReturnModel objCashSalesReturnModel) //fill GistnNo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashSalesReturnModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashSalesReturnModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashSalesReturnModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashSalesReturnModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objCashSalesReturnModel.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashSalesReturn);
                dtCashSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtCashSalesReturn = new DataTable();
                dtCashSalesReturn.TableName = "error";
                return dtCashSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashSalesReturn;
        }


        internal DataTable FillShippingAddress(CashSaleReturnModel objCashSalesReturnModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashSalesReturnModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashSalesReturnModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashSalesReturnModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashSalesReturnModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objCashSalesReturnModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objCashSalesReturnModel.GSTIN);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashSalesReturn);
                dtCashSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtCashSalesReturn = new DataTable();
                dtCashSalesReturn.TableName = "error";
                return dtCashSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashSalesReturn;
        }


        internal DataSet SearchSaleInvoice(CashSaleReturnModel objCashSalesReturnModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SpCashSaleReturnVoucher";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashSalesReturnModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashSalesReturnModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashSalesReturnModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashSalesReturnModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashSalesReturnModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceNo", objCashSalesReturnModel.InvoiceNo);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", objCashSalesReturnModel.InvoiceSeries);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsCashSalesReturn = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsCashSalesReturn);
                dsCashSalesReturn.DataSetName = "success";
            }
            catch (Exception)
            {
                dsCashSalesReturn = new DataSet();
                dsCashSalesReturn.DataSetName = "error";
                return dsCashSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsCashSalesReturn;
        }

        internal DataSet FillItemSellRate(CashSaleReturnModel objCashSalesReturnModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashSalesReturnModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashSalesReturnModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashSalesReturnModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objCashSalesReturnModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objCashSalesReturnModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", objCashSalesReturnModel.ItemID);
                ClsCon.cmd.Parameters.AddWithValue("@ByCash", objCashSalesReturnModel.ByCashSale);
                ClsCon.cmd.Parameters.AddWithValue("@PartyState", objCashSalesReturnModel.PartyState);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsCashSalesReturn = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsCashSalesReturn);
                dsCashSalesReturn.DataSetName = "success";
            }
            catch (Exception)
            {
                dsCashSalesReturn = new DataSet();
                dsCashSalesReturn.DataSetName = "error";
                return dsCashSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsCashSalesReturn;
        }


        internal DataSet FillBrokerDetail(CashSaleReturnModel objCashSalesReturnModel)
        {

            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashSalesReturnModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashSalesReturnModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashSalesReturnModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objCashSalesReturnModel.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsCashSalesReturn = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsCashSalesReturn, "SuccessDataSet");
                dsCashSalesReturn.DataSetName = "success";
            }
            catch (Exception)
            {
                dsCashSalesReturn = new DataSet();
                dsCashSalesReturn.DataSetName = "error";
                return dsCashSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsCashSalesReturn;
        }




        internal DataTable SaveCashSalesVoucher(CashSaleReturnModel objCashSalesReturnModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SpCashSaleReturnVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objCashSalesReturnModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objCashSalesReturnModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objCashSalesReturnModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objCashSalesReturnModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objCashSalesReturnModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objCashSalesReturnModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objCashSalesReturnModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objCashSalesReturnModel.IP);

                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", objCashSalesReturnModel.ByCashSale);
                ClsCon.cmd.Parameters.AddWithValue("@PartyName", objCashSalesReturnModel.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@PartyGSTIN", objCashSalesReturnModel.PartyGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@PartyAddress", objCashSalesReturnModel.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@PartyMobileNo", objCashSalesReturnModel.PartyMobileNo);
                ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", objCashSalesReturnModel.WareHouseID);
                ClsCon.cmd.Parameters.AddWithValue("@TransName", objCashSalesReturnModel.TransName);
                ClsCon.cmd.Parameters.AddWithValue("@PONo", objCashSalesReturnModel.PONo);
                ClsCon.cmd.Parameters.AddWithValue("@PayMode", objCashSalesReturnModel.PayMode);
                ClsCon.cmd.Parameters.AddWithValue("@PayModeRemark", objCashSalesReturnModel.PayModeRemark);

                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objCashSalesReturnModel.CCCode);

                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", objCashSalesReturnModel.InvoiceSeries);
                ClsCon.cmd.Parameters.AddWithValue("@PartyState", objCashSalesReturnModel.PartyState);


                //if (objCashSalesReturnModel.ds.Tables["DtCashSales"].Rows.Count > 0)
                //{
                //    ClsCon.cmd.Parameters.AddWithValue("@TblSale", objCashSalesReturnModel.ds.Tables["DtCashSales"]);
                //}

                //if (objCashSalesReturnModel.ds.Tables["DtItems"].Rows.Count > 0)
                //{
                //    ClsCon.cmd.Parameters.AddWithValue("@TblItems", objCashSalesReturnModel.ds.Tables["DtItems"]);
                //}


                //if (objCashSalesReturnModel.ds.Tables["DtSundries"].Rows.Count > 0)
                //{
                //    ClsCon.cmd.Parameters.AddWithValue("@TblSundries", objCashSalesReturnModel.ds.Tables["DtSundries"]);
                //}

                //if (objCashSalesReturnModel.ds.Tables["DtAdjAdvance"].Rows.Count > 0)
                //{
                //    ClsCon.cmd.Parameters.AddWithValue("@TblAdvanceDetail", objCashSalesReturnModel.ds.Tables["DtAdjAdvance"]);
                //}


                ClsCon.cmd.Parameters.AddWithValue("@TblSale", objCashSalesReturnModel.DtCashSales);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", objCashSalesReturnModel.DtItems);
                ClsCon.cmd.Parameters.AddWithValue("@TblSundries", objCashSalesReturnModel.DtSundries);
                // ClsCon.cmd.Parameters.AddWithValue("@TblAdvanceDetail", objCashSalesReturnModel.DtAdjAdvance);


                ClsCon.cmd.Parameters.AddWithValue("@BrokerageID", objCashSalesReturnModel.BrokerageID);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageRate", objCashSalesReturnModel.BrokerageRate);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageGSTIN", objCashSalesReturnModel.BrokerageGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageAmount", objCashSalesReturnModel.BrokerageAmount);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCashSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCashSalesReturn);
                dtCashSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtCashSalesReturn = new DataTable();
                dtCashSalesReturn.TableName = "error";
                return dtCashSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCashSalesReturn;
        }







    }
}