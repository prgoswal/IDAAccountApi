using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class CompositionSalesDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtSales;
        DataSet dsSales;

        internal DataTable LoadNarration(CompositionSalesModel ObjCompositionSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjCompositionSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjCompositionSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjCompositionSalesModel.VchType);

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

        internal DataTable LoadIncomeHead(CompositionSalesModel ObjCompositionSalesModel) //IncomeHeadFill
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjCompositionSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjCompositionSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjCompositionSalesModel.YrCD);

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

        internal DataTable LoadSalesTo(CompositionSalesModel ObjCompositionSalesModel) // FillDropDownSalesTo
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

        internal DataTable FillHeadName(CompositionSalesModel ObjCompositionSalesModel) //HeadName in Othertable
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

        internal DataTable Filllocation(CompositionSalesModel ObjCompositionSalesModel) //FillLocation in Othertable
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

        internal DataTable FillUnitName(CompositionSalesModel ObjCompositionSalesModel) //fill GistnNo
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

        internal DataTable FillItemName(CompositionSalesModel ObjCompositionSalesModel) //fill GistnNo
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

        internal DataTable FillItemSellingRate(CompositionSalesModel ObjCompositionSalesModel)
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
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", ObjCompositionSalesModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjCompositionSalesModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", ObjCompositionSalesModel.ItemID);

                ClsCon.cmd.Parameters.AddWithValue("@ByCash", ObjCompositionSalesModel.ByCashSale);
               
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

        internal DataTable FillGistnNo(CompositionSalesModel ObjCompositionSalesModel) //fill GistnNo
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

        internal DataTable SaveSalesVoucher(CompositionSalesModel ObjCompositionSalesModel)
        {          

            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSaleVoucher";

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
                
                //for bank
                ClsCon.cmd.Parameters.AddWithValue("@PartyBank", ObjCompositionSalesModel.PartyBank);
                ClsCon.cmd.Parameters.AddWithValue("@PartyIFSC", ObjCompositionSalesModel.PartyIFSC);


                ClsCon.cmd.Parameters.AddWithValue("@TblSale", ObjCompositionSalesModel.DtSales);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", ObjCompositionSalesModel.DtItems);
                ClsCon.cmd.Parameters.AddWithValue("@TblSundries", ObjCompositionSalesModel.DtSundries);
                ClsCon.cmd.Parameters.AddWithValue("@TblAdvanceDetail", ObjCompositionSalesModel.DtAdjAdvance);
                

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

        internal DataTable FillShippingAddress(CompositionSalesModel ObjCompositionSalesModel)
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

        internal DataTable LastVoucherNo(CompositionSalesModel ObjCompositionSalesModel) // Pending
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
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjCompositionSalesModel.VchType);

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

        internal DataTable FillTransportation(CompositionSalesModel ObjCompositionSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjCompositionSalesModel.Ind);

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

        internal DataTable InvoiceSeries(CompositionSalesModel ObjCompositionSalesModel)
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
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjCompositionSalesModel.VchType);

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

        internal DataSet BindAll(CompositionSalesModel ObjCompositionSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSaleVoucher";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjCompositionSalesModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjCompositionSalesModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjCompositionSalesModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjCompositionSalesModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjCompositionSalesModel.VchType);

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

        internal DataSet FillItemSellRate(CompositionSalesModel ObjCompositionSalesModel)
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

        internal DataTable CancelSalesVoucherNo(CompositionSalesModel ObjCompositionSalesModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSaleVoucher";

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
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", ObjCompositionSalesModel.CancelReason);

                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", ObjCompositionSalesModel.InvoiceSeries);

                ClsCon.cmd.Parameters.AddWithValue("@TblSale", ObjCompositionSalesModel.DtSales);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", ObjCompositionSalesModel.DtItems);
                //ClsCon.cmd.Parameters.AddWithValue("@TblSundries", objSalesModel.DtSundries);


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

        internal DataSet FillGistnNoWithDetail(CompositionSalesModel ObjCompositionSalesModel)
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
                ClsCon.cmd.Parameters.AddWithValue("@AdvRecPayID", ObjCompositionSalesModel.AdvRecPayID);

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
    }
}