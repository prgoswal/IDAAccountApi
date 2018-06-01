using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdateCompositionCashSalesDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtCashSales;
        DataSet dsCashSales;

        internal DataSet BindAll(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateSaleVoucher";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjCompositionSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjCompositionSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjCompositionSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjCompositionSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjCompositionSalesModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", ObjCompositionSalesModel.ByCashSale);

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

        internal DataSet SearchSaleInvoice(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateSaleVoucher";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjCompositionSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjCompositionSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjCompositionSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjCompositionSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjCompositionSalesModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceNo", ObjCompositionSalesModel.InvoiceNo);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", ObjCompositionSalesModel.InvoiceSeries);

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

        internal DataTable UpdateSaleVoucher(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateSaleVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjCompositionSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjCompositionSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjCompositionSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjCompositionSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjCompositionSalesModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", ObjCompositionSalesModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", ObjCompositionSalesModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", ObjCompositionSalesModel.IP);


                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", ObjCompositionSalesModel.ByCashSale);
                ClsCon.cmd.Parameters.AddWithValue("@PartyName", ObjCompositionSalesModel.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@PartyGSTIN", ObjCompositionSalesModel.PartyGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@PartyAddress", ObjCompositionSalesModel.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", ObjCompositionSalesModel.WareHouseID);
                ClsCon.cmd.Parameters.AddWithValue("@TransName", ObjCompositionSalesModel.TransName);
                ClsCon.cmd.Parameters.AddWithValue("@PONo", ObjCompositionSalesModel.PONo);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", ObjCompositionSalesModel.InvoiceSeries);

                ClsCon.cmd.Parameters.AddWithValue("@PartyMobileNo", ObjCompositionSalesModel.PartyMobileNo);
                ClsCon.cmd.Parameters.AddWithValue("@PayMode", ObjCompositionSalesModel.PayMode);
                ClsCon.cmd.Parameters.AddWithValue("@PayModeRemark", ObjCompositionSalesModel.PayModeRemark);

                ClsCon.cmd.Parameters.AddWithValue("@DocNo", ObjCompositionSalesModel.DocNo);

                ClsCon.cmd.Parameters.AddWithValue("@TblSale", ObjCompositionSalesModel.DtCashSales);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", ObjCompositionSalesModel.DtItems);
                ClsCon.cmd.Parameters.AddWithValue("@TblSundries", ObjCompositionSalesModel.DtSundries);


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

        internal DataTable FillGistnNo(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjCompositionSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjCompositionSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjCompositionSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjCompositionSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjCompositionSalesModel.AccCode);

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

        internal DataTable FillShippingAddress(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjCompositionSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjCompositionSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjCompositionSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjCompositionSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjCompositionSalesModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjCompositionSalesModel.GSTIN);

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

        internal DataSet FillItemSellRate(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjCompositionSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjCompositionSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjCompositionSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", ObjCompositionSalesModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjCompositionSalesModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", ObjCompositionSalesModel.ItemID);
                ClsCon.cmd.Parameters.AddWithValue("@ByCash", ObjCompositionSalesModel.ByCashSale);

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

        internal DataTable Filllocation(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjCompositionSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjCompositionSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjCompositionSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjCompositionSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@GSTINID", ObjCompositionSalesModel.GSTIN);

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

        internal DataTable CheckState(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjCompositionSalesModel.Ind);

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

        internal DataTable CancelVoucher(UpdateCompositionCashSalesModel ObjCompositionSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateSaleVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjCompositionSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjCompositionSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjCompositionSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", ObjCompositionSalesModel.InvoiceSeries);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", ObjCompositionSalesModel.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceNo", ObjCompositionSalesModel.InvoiceNo);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", ObjCompositionSalesModel.CancelReason);
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