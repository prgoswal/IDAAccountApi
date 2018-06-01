using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdatePurchaseReturnVoucherDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtPRModel; DataTable dtCancel;
        DataSet dsPRModel;

        //internal DataSet LoadAll(UpdatePurchaseReturnVoucherModel objPRModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPUpdatePurchaseReturn";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", objPRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objPRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objPRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", objPRModel.VchType);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dsPRModel = new DataSet();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dsPRModel);
        //        dsPRModel.DataSetName = "success";
        //    }
        //    catch (Exception ex)
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dsPRModel;
        //}

        //internal DataTable FillGistnNo(UpdatePurchaseReturnVoucherModel objPRModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPSearchByAccount";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", objPRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objPRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objPRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@AccCode", objPRModel.AccCode);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPRModel = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPRModel);
        //        dtPRModel.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPRModel = new DataTable();
        //        dtPRModel.TableName = "error";
        //        return dtPRModel;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPRModel;
        //}

        //internal DataTable FillItemPurchaseRate(UpdatePurchaseReturnVoucherModel objPRModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPItems";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", objPRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objPRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objPRModel.PartyCode);
        //        ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objPRModel.AccGst);
        //        ClsCon.cmd.Parameters.AddWithValue("@ItemID", objPRModel.ItemID);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPRModel = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPRModel);
        //        dtPRModel.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPRModel = new DataTable();
        //        dtPRModel.TableName = "error";
        //        return dtPRModel;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPRModel;
        //}

        //internal DataSet SearchDeails(UpdatePurchaseReturnVoucherModel objPRModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPUpdatePurchaseReturn";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", objPRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objPRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objPRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", objPRModel.VchType);
        //        ClsCon.cmd.Parameters.AddWithValue("@DocNo", objPRModel.VoucherNo);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dsPRModel = new DataSet();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dsPRModel);
        //        dsPRModel.DataSetName = "success";
        //    }
        //    catch (Exception ex)
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dsPRModel;
        //}

        internal DataSet BindAll(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPPurchaseVoucherChange";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objPRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objPRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objPRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objPRModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsPRModel = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsPRModel);
                dsPRModel.DataSetName = "success";
            }
            catch (Exception)
            {
                dsPRModel = new DataSet();
                dsPRModel.DataSetName = "error";
                return dsPRModel;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsPRModel;
        }

        internal DataTable Filllocation(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objPRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objPRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objPRModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPRModel = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPRModel);
                dtPRModel.TableName = "success";
            }
            catch (Exception)
            {
                dtPRModel = new DataTable();
                dtPRModel.TableName = "error";
                return dtPRModel;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPRModel;
        }

        internal DataSet FillItemPurchaseRate(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objPRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objPRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objPRModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objPRModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", objPRModel.ItemID);

                ClsCon.cmd.Parameters.AddWithValue("@ByCash", objPRModel.ByCashSale);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsPRModel = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsPRModel);
                dsPRModel.DataSetName = "success";
            }
            catch (Exception)
            {
                dsPRModel = new DataSet();
                dsPRModel.DataSetName = "error";
                return dsPRModel;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsPRModel;
        }

        internal DataTable FillGistnNo(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objPRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objPRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objPRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objPRModel.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPRModel = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPRModel);
                dtPRModel.TableName = "success";
            }
            catch (Exception)
            {
                dtPRModel = new DataTable();
                dtPRModel.TableName = "error";
                return dtPRModel;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPRModel;
        }

        internal DataTable FillShippingAddress(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objPRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objPRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objPRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objPRModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objPRModel.GSTIN);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPRModel = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPRModel);
                dtPRModel.TableName = "success";
            }
            catch (Exception)
            {
                dtPRModel = new DataTable();
                dtPRModel.TableName = "error";
                return dtPRModel;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPRModel;
        }

        internal DataSet LoadPurchaseVoucherDetails(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdatePurchaseReturn";

                ClsCon.cmd.Parameters.AddWithValue("@Ind", objPRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objPRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objPRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objPRModel.DocNo);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsPRModel = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsPRModel);
                dsPRModel.DataSetName = "success";
                dsPRModel.Tables[0].TableName = "Basic";
                dsPRModel.Tables[1].TableName = "ItemDetails";
                dsPRModel.Tables[2].TableName = "Sundries";
                dsPRModel.Tables[3].TableName = "OrgInoiceNoAndDate";
            }
            catch (Exception)
            {
                dsPRModel = new DataSet();
                dsPRModel.DataSetName = "error";
                return dsPRModel;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsPRModel;
        }

        internal DataTable UpdatePurchaseReturn(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdatePurchaseReturn";

                ClsCon.cmd.Parameters.AddWithValue("@Ind", objPRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objPRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objPRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objPRModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objPRModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objPRModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objPRModel.IP);

                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", objPRModel.ByCashSale);
                ClsCon.cmd.Parameters.AddWithValue("@PartyName", objPRModel.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@PartyGSTIN", objPRModel.PartyGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@PartyAddress", objPRModel.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", objPRModel.WareHouseID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objPRModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@PONo", objPRModel.PONo);
                ClsCon.cmd.Parameters.AddWithValue("@PODate", objPRModel.PODate);
                ClsCon.cmd.Parameters.AddWithValue("@PurchaseBillNo", objPRModel.PurchaseBillNo);
                ClsCon.cmd.Parameters.AddWithValue("@PurchaseBillDate", objPRModel.PurchaseBillDate);
                ClsCon.cmd.Parameters.AddWithValue("@GRNNo", objPRModel.GRNNo);
                ClsCon.cmd.Parameters.AddWithValue("@GRNDate", objPRModel.GRNDate);
                ClsCon.cmd.Parameters.AddWithValue("@PurchaseSaleRecordID", objPRModel.PurchaseSaleRecordID);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objPRModel.VoucherNo);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", objPRModel.VoucherDate);

                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objPRModel.CCCode);

                ClsCon.cmd.Parameters.AddWithValue("@OrgVoucherNo", objPRModel.OrgVoucherNo);
                ClsCon.cmd.Parameters.AddWithValue("@OrgVoucherDate", objPRModel.OrgVoucherDate);

                ClsCon.cmd.Parameters.AddWithValue("@TblPurchase", objPRModel.DtUpdPurchase);
                ClsCon.cmd.Parameters.AddWithValue("@TblPurchaseItems", objPRModel.DtUpdItems);
                ClsCon.cmd.Parameters.AddWithValue("@TblPurchaseSundries", objPRModel.DtUpdSundries);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPRModel = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPRModel);
                dtPRModel.TableName = "success";
            }
            catch (Exception)
            {
                dtPRModel = new DataTable();
                dtPRModel.TableName = "error";
                return dtPRModel;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPRModel;
        }

        internal DataTable CancelVoucher(UpdatePurchaseReturnVoucherModel objPRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdatePurchaseReturn";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objPRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objPRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objPRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objPRModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objPRModel.VoucherNo);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objPRModel.CancelReason);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCancel = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCancel);
                dtCancel.TableName = "success";
            }
            catch (Exception)
            {
                dtCancel = new DataTable();
                dtCancel.TableName = "error";
                return dtCancel;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCancel;
        }
    }
}