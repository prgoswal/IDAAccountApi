using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdateCompositionPurchaseVoucherDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtUpdPV;
        DataSet dsUpdPV;

        internal DataSet BindAll(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPPurchaseVoucherChange";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdPVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdPVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdPVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdPVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdPVModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdPV = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdPV);
                dsUpdPV.DataSetName = "success";
            }
            catch (Exception)
            {
                dsUpdPV = new DataSet();
                dsUpdPV.DataSetName = "error";
                return dsUpdPV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdPV;
        }

        internal DataTable Filllocation(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdPVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdPVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdPVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdPVModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdPV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdPV);
                dtUpdPV.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdPV = new DataTable();
                dtUpdPV.TableName = "error";
                return dtUpdPV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdPV;
        }

        internal DataSet FillItemPurchaseRate(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdPVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdPVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdPVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objUpdPVModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objUpdPVModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", objUpdPVModel.ItemID);

                ClsCon.cmd.Parameters.AddWithValue("@ByCash", objUpdPVModel.ByCashSale);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdPV = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdPV);
                dsUpdPV.DataSetName = "success";
            }
            catch (Exception)
            {
                dsUpdPV = new DataSet();
                dsUpdPV.DataSetName = "error";
                return dsUpdPV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdPV;
        }

        internal DataTable FillGistnNo(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdPVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdPVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdPVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdPVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUpdPVModel.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdPV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdPV);
                dtUpdPV.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdPV = new DataTable();
                dtUpdPV.TableName = "error";
                return dtUpdPV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdPV;
        }

        internal DataTable FillShippingAddress(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdPVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdPVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdPVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdPVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUpdPVModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objUpdPVModel.GSTIN);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdPV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdPV);
                dtUpdPV.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdPV = new DataTable();
                dtUpdPV.TableName = "error";
                return dtUpdPV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdPV;
        }

        //internal DataTable LoadPurchaseVoucherDetails(UpdatePurchaseVoucherModel objUpdPVModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPUpdatePurchaseVoucher";

        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdPVModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdPVModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdPVModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdPVModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdPVModel.VchType);
        //        ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdPVModel.VoucherNo);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtUpdPV = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtUpdPV);
        //        dtUpdPV.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtUpdPV = new DataTable();
        //        dtUpdPV.TableName = "error";
        //        return dtUpdPV;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtUpdPV;
        //}

        internal DataSet LoadPurchaseVoucherDetails(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdatePurchaseVoucher";

                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdPVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdPVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdPVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdPVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdPVModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdPVModel.VoucherNo);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdPV = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdPV);
                dsUpdPV.DataSetName = "success";
                dsUpdPV.Tables[0].TableName = "Basic";
                dsUpdPV.Tables[1].TableName = "ItemDetails";
                dsUpdPV.Tables[2].TableName = "FreeItems";
                dsUpdPV.Tables[3].TableName = "Sundries";
            }
            catch (Exception)
            {
                dsUpdPV = new DataSet();
                dsUpdPV.DataSetName = "error";
                return dsUpdPV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdPV;
        }

        internal DataTable UpdatePV(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdatePurchaseVoucher";

                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdPVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdPVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdPVModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdPVModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdPVModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objUpdPVModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objUpdPVModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objUpdPVModel.IP);

                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", objUpdPVModel.ByCashSale);
                ClsCon.cmd.Parameters.AddWithValue("@PartyName", objUpdPVModel.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@PartyGSTIN", objUpdPVModel.PartyGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@PartyAddress", objUpdPVModel.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", objUpdPVModel.WareHouseID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUpdPVModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@PONo", objUpdPVModel.PONo);
                ClsCon.cmd.Parameters.AddWithValue("@PODate", objUpdPVModel.PODate);
                ClsCon.cmd.Parameters.AddWithValue("@PurchaseBillNo", objUpdPVModel.PurchaseBillNo);
                ClsCon.cmd.Parameters.AddWithValue("@PurchaseBillDate", objUpdPVModel.PurchaseBillDate);
                ClsCon.cmd.Parameters.AddWithValue("@GRNNo", objUpdPVModel.GRNNo);
                ClsCon.cmd.Parameters.AddWithValue("@GRNDate", objUpdPVModel.GRNDate);
                ClsCon.cmd.Parameters.AddWithValue("@PurchaseSaleRecordID", objUpdPVModel.PurchaseSaleRecordID);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdPVModel.VoucherNo);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", objUpdPVModel.VoucherDate);

                ClsCon.cmd.Parameters.AddWithValue("@TblPurchase", objUpdPVModel.DtUpdPurchase);
                ClsCon.cmd.Parameters.AddWithValue("@TblPurchaseItems", objUpdPVModel.DtUpdItems);
                ClsCon.cmd.Parameters.AddWithValue("@TblPurchaseSundries", objUpdPVModel.DtUpdSundries);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdPV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdPV);
                dtUpdPV.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdPV = new DataTable();
                dtUpdPV.TableName = "error";
                return dtUpdPV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdPV;
        }

        internal DataTable CancelVoucher(UpdateCompositionPurchaseVoucherModel objUpdPVModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdatePurchaseVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdPVModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdPVModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdPVModel.BrID);

                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdPVModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdPVModel.VoucherNo);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objUpdPVModel.CancelReason);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdPV = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdPV);
                dtUpdPV.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdPV = new DataTable();
                dtUpdPV.TableName = "error";
                return dtUpdPV;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdPV;
        }
    }
}