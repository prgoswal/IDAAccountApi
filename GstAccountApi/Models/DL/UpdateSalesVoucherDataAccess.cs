using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdateSalesVoucherDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtSales;
        DataSet dsSales;

        internal DataSet BindAll(UpdateSalesModel ObjSalesModel)
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

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsSales = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsSales);
                dsSales.DataSetName = "success";
            }
            catch (Exception)
            {
                dsSales = new DataSet();
                dsSales.DataSetName = "error";
                return dsSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsSales;
        }

        internal DataSet SearchSaleInvoice(UpdateSalesModel ObjSalesModel)
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
                dsSales = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsSales);
                dsSales.DataSetName = "success";
            }
            catch (Exception)
            {
                dsSales = new DataSet();
                dsSales.DataSetName = "error";
                return dsSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsSales;
        }

        internal DataTable UpdateSaleVoucher(UpdateSalesModel ObjSalesModel)
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

                ClsCon.cmd.Parameters.AddWithValue("@DocNo", ObjSalesModel.DocNo);

                ClsCon.cmd.Parameters.AddWithValue("@TblSale", ObjSalesModel.DtSales);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", ObjSalesModel.DtItems);
                ClsCon.cmd.Parameters.AddWithValue("@TblSundries", ObjSalesModel.DtSundries);

                ClsCon.cmd.Parameters.AddWithValue("@CCCode", ObjSalesModel.CCCode);

                ClsCon.cmd.Parameters.AddWithValue("@BrokerageID", ObjSalesModel.BrokerageID);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageRate", ObjSalesModel.BrokerageRate);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageGSTIN", ObjSalesModel.BrokerageGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageAmount", ObjSalesModel.BrokerageAmount);


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSales = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSales);
                dtSales.TableName = "success";
            }
            catch (Exception)
            {
                dtSales = new DataTable();
                dtSales.TableName = "error";
                return dtSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSales;
        }

        internal DataTable SaveSalesVoucher(UpdateSalesModel ObjSalesModel)
        {

            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSaleVoucher";

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

                ClsCon.cmd.Parameters.AddWithValue("@TblSale", ObjSalesModel.DtSales);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", ObjSalesModel.DtItems);
                ClsCon.cmd.Parameters.AddWithValue("@TblSundries", ObjSalesModel.DtSundries);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", ObjSalesModel.CCCode);


                ClsCon.cmd.Parameters.AddWithValue("@BrokerageID", ObjSalesModel.BrokerageID);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageRate", ObjSalesModel.BrokerageRate);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageGSTIN", ObjSalesModel.BrokerageGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageAmount", ObjSalesModel.BrokerageAmount);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSales = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSales);
                dtSales.TableName = "success";
            }
            catch (Exception)
            {
                dtSales = new DataTable();
                dtSales.TableName = "error";
                return dtSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSales;
        }

        internal DataTable FillGistnNo(UpdateSalesModel ObjSalesModel)
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
                dtSales = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSales);
                dtSales.TableName = "success";
            }
            catch (Exception)
            {
                dtSales = new DataTable();
                dtSales.TableName = "error";
                return dtSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSales;
        }

        internal DataTable FillShippingAddress(UpdateSalesModel ObjSalesModel)
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
                dtSales = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSales);
                dtSales.TableName = "success";
            }
            catch (Exception)
            {
                dtSales = new DataTable();
                dtSales.TableName = "error";
                return dtSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSales;
        }

        internal DataSet FillItemSellRate(UpdateSalesModel ObjSalesModel)
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

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsSales = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsSales);
                dsSales.DataSetName = "success";
            }
            catch (Exception)
            {
                dsSales = new DataSet();
                dsSales.DataSetName = "error";
                return dsSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsSales;
        }

        internal DataTable Filllocation(UpdateSalesModel ObjSalesModel)
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
                dtSales = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSales);
                dtSales.TableName = "success";
            }
            catch (Exception)
            {
                dtSales = new DataTable();
                dtSales.TableName = "error";
                return dtSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSales;
        }

        internal DataTable CheckState(UpdateSalesModel ObjSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjSalesModel.Ind);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSales = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSales);
                dtSales.TableName = "success";
            }
            catch (Exception)
            {
                dtSales = new DataTable();
                dtSales.TableName = "error";
                return dtSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSales;
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
                dtSales = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSales);
                dtSales.TableName = "success";
            }
            catch (Exception)
            {
                dtSales = new DataTable();
                dtSales.TableName = "error";
                return dtSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSales;
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
                dsSales = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsSales, "SuccessDataSet");
                dsSales.DataSetName = "success";
            }
            catch (Exception)
            {
                dsSales = new DataSet();
                dsSales.DataSetName = "error";
                return dsSales;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsSales;
        }
    }
}