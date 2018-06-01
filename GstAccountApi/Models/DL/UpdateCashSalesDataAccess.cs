using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdateCashSalesDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtCashSales;
        DataSet dsCashSales;

        internal DataSet BindAll(UpdateCashSalesModel ObjSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateSaleVoucher";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjSalesModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", ObjSalesModel.ByCashSale);

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

        internal DataSet SearchSaleInvoice(UpdateCashSalesModel ObjSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateSaleVoucher";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjSalesModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceNo", ObjSalesModel.InvoiceNo);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", ObjSalesModel.InvoiceSeries);

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

        internal DataTable UpdateSaleVoucher(UpdateCashSalesModel ObjSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateSaleVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjSalesModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", ObjSalesModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", ObjSalesModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", ObjSalesModel.IP);


                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", ObjSalesModel.ByCashSale);
                ClsCon.cmd.Parameters.AddWithValue("@PartyName", ObjSalesModel.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@PartyGSTIN", ObjSalesModel.PartyGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@PartyAddress", ObjSalesModel.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", ObjSalesModel.WareHouseID);
                ClsCon.cmd.Parameters.AddWithValue("@TransName", ObjSalesModel.TransName);
                ClsCon.cmd.Parameters.AddWithValue("@PONo", ObjSalesModel.PONo);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", ObjSalesModel.InvoiceSeries);

                ClsCon.cmd.Parameters.AddWithValue("@PartyMobileNo", ObjSalesModel.PartyMobileNo);
                ClsCon.cmd.Parameters.AddWithValue("@PayMode", ObjSalesModel.PayMode);
                ClsCon.cmd.Parameters.AddWithValue("@PayModeRemark", ObjSalesModel.PayModeRemark);

                ClsCon.cmd.Parameters.AddWithValue("@DocNo", ObjSalesModel.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@PartyState", ObjSalesModel.PartyState);

                ClsCon.cmd.Parameters.AddWithValue("@CCCode", ObjSalesModel.CCCode);


                ClsCon.cmd.Parameters.AddWithValue("@BrokerageID", ObjSalesModel.BrokerageID);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageRate", ObjSalesModel.BrokerageRate);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageGSTIN", ObjSalesModel.BrokerageGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageAmount", ObjSalesModel.BrokerageAmount);

                ClsCon.cmd.Parameters.AddWithValue("@TblSale", ObjSalesModel.DtCashSales);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", ObjSalesModel.DtItems);
                ClsCon.cmd.Parameters.AddWithValue("@TblSundries", ObjSalesModel.DtSundries);


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

        internal DataTable FillGistnNo(UpdateCashSalesModel ObjSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjSalesModel.AccCode);

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

        internal DataTable FillShippingAddress(UpdateCashSalesModel ObjSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjSalesModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjSalesModel.GSTIN);

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

        internal DataSet FillItemSellRate(UpdateCashSalesModel ObjSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", ObjSalesModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjSalesModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", ObjSalesModel.ItemID);
                ClsCon.cmd.Parameters.AddWithValue("@ByCash", ObjSalesModel.ByCashSale);
                ClsCon.cmd.Parameters.AddWithValue("@PartyState", ObjSalesModel.PartyState);

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

        internal DataTable Filllocation(UpdateCashSalesModel ObjSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@GSTINID", ObjSalesModel.GSTIN);

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

        internal DataTable CheckState(UpdateCashSalesModel ObjSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjSalesModel.Ind);

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

        internal DataTable CancelVoucher(UpdateSalesModel ObjSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateSaleVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", ObjSalesModel.InvoiceSeries);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", ObjSalesModel.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceNo", ObjSalesModel.InvoiceNo);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", ObjSalesModel.CancelReason);
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



        internal DataSet FillBrokerDetail(UpdateSalesModel ObjSalesModel)
        {

            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjSalesModel.AccCode);

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