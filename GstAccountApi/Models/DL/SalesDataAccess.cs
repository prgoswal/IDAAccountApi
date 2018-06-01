using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class SalesDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtSales;
        DataSet dsSales;

        internal DataTable LoadNarration(SalesModel ObjSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjSalesModel.VchType);

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

        internal DataTable LoadIncomeHead(SalesModel ObjSalesModel) //IncomeHeadFill
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSalesModel.YrCD);

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

        internal DataTable LoadSalesTo(SalesModel ObjSalesModel) // FillDropDownSalesTo
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

        internal DataTable FillHeadName(SalesModel ObjSalesModel) //HeadName in Othertable
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

        internal DataTable Filllocation(SalesModel ObjSalesModel) //FillLocation in Othertable
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

        internal DataTable FillUnitName(SalesModel ObjSalesModel) //fill GistnNo
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

        internal DataTable FillItemName(SalesModel ObjSalesModel) //fill GistnNo
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

        internal DataTable FillItemSellingRate(SalesModel ObjSalesModel)
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
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", ObjSalesModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjSalesModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", ObjSalesModel.ItemID);

                ClsCon.cmd.Parameters.AddWithValue("@ByCash", ObjSalesModel.ByCashSale);

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

        internal DataTable FillGistnNo(SalesModel ObjSalesModel) //fill GistnNo
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

        internal DataSet FillGistnNoWithDetail(SalesModel ObjSalesModel) //fill GistnNo And Party Details
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
                ClsCon.cmd.Parameters.AddWithValue("@AdvRecPayID", ObjSalesModel.AdvRecPayID);

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

        internal DataTable SaveSalesVoucher(SalesModel ObjSalesModel)
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


                ClsCon.cmd.Parameters.AddWithValue("@BrokerageID", ObjSalesModel.BrokerageID);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageRate", ObjSalesModel.BrokerageRate);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageGSTIN", ObjSalesModel.BrokerageGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@BrokerageAmount", ObjSalesModel.BrokerageAmount);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", ObjSalesModel.CCCode);




                ClsCon.cmd.Parameters.AddWithValue("@TblSale", ObjSalesModel.DtSales);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", ObjSalesModel.DtItems);
                ClsCon.cmd.Parameters.AddWithValue("@TblSundries", ObjSalesModel.DtSundries);
                ClsCon.cmd.Parameters.AddWithValue("@TblAdvanceDetail", ObjSalesModel.DtAdjAdvance);


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

        internal DataTable FillShippingAddress(SalesModel ObjSalesModel)
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

        internal DataTable LastVoucherNo(SalesModel ObjSalesModel) // Pending
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
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjSalesModel.VchType);

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

        internal DataTable FillTransportation(SalesModel ObjSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
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

        internal DataTable InvoiceSeries(SalesModel ObjSalesModel)
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
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjSalesModel.VchType);

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

        internal DataSet BindAll(SalesModel ObjSalesModel)
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

        internal DataSet FillItemSellRate(SalesModel ObjSalesModel)
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

        internal DataTable CancelSalesVoucherNo(SalesModel objSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSaleVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objSalesModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objSalesModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objSalesModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objSalesModel.IP);


                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", objSalesModel.ByCashSale);
                ClsCon.cmd.Parameters.AddWithValue("@PartyName", objSalesModel.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@PartyGSTIN", objSalesModel.PartyGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@PartyAddress", objSalesModel.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", objSalesModel.WareHouseID);
                ClsCon.cmd.Parameters.AddWithValue("@TransName", objSalesModel.TransName);


                ClsCon.cmd.Parameters.AddWithValue("@PONo", objSalesModel.PONo);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objSalesModel.CancelReason);

                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", objSalesModel.InvoiceSeries);

                ClsCon.cmd.Parameters.AddWithValue("@TblSale", objSalesModel.DtSales);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", objSalesModel.DtItems);

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

        internal DataSet FillBrokerDetail(SalesModel ObjSalesModel)
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