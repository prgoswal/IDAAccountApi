using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class PurchaseReturnDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtPurchaseReturn;
        DataSet dsPurchaseReturn;

        #region

        //internal DataTable LoadNarration(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjPurchaseRModel.VchType);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPurchaseReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPurchaseReturn);
        //        dtPurchaseReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPurchaseReturn = new DataTable();
        //        dtPurchaseReturn.TableName = "error";
        //        return dtPurchaseReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPurchaseReturn;
        //}

        //internal DataTable LoadExpenseHead(PurchaseReturnModel ObjPurchaseRModel) //ExpenseHeadFill
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPurchaseReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPurchaseReturn);
        //        dtPurchaseReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPurchaseReturn = new DataTable();
        //        dtPurchaseReturn.TableName = "error";
        //        return dtPurchaseReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPurchaseReturn;
        //}

        //internal DataTable LoadPurchaseFrom(PurchaseReturnModel ObjPurchaseRModel) // FillDropDownPurchaseFrom
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPurchaseReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPurchaseReturn);
        //        dtPurchaseReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPurchaseReturn = new DataTable();
        //        dtPurchaseReturn.TableName = "error";
        //        return dtPurchaseReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPurchaseReturn;
        //}

        //internal DataTable FillHeadName(PurchaseReturnModel ObjPurchaseRModel) //HeadName in Othertable
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPurchaseReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPurchaseReturn);
        //        dtPurchaseReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPurchaseReturn = new DataTable();
        //        dtPurchaseReturn.TableName = "error";
        //        return dtPurchaseReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPurchaseReturn;
        //}

        //internal DataTable Filllocation(PurchaseReturnModel ObjPurchaseRModel) //FillLocation in Othertable
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@GSTINID", ObjPurchaseRModel.AccGst);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPurchaseReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPurchaseReturn);
        //        dtPurchaseReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPurchaseReturn = new DataTable();
        //        dtPurchaseReturn.TableName = "error";
        //        return dtPurchaseReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPurchaseReturn;
        //}

        //internal DataTable FillUnitName(PurchaseReturnModel ObjPurchaseRModel) //fill GistnNo
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPurchaseReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPurchaseReturn);
        //        dtPurchaseReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPurchaseReturn = new DataTable();
        //        dtPurchaseReturn.TableName = "error";
        //        return dtPurchaseReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPurchaseReturn;
        //}

        //internal DataTable FillItemName(PurchaseReturnModel ObjPurchaseRModel) //fill GistnNo
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPurchaseReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPurchaseReturn);
        //        dtPurchaseReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPurchaseReturn = new DataTable();
        //        dtPurchaseReturn.TableName = "error";
        //        return dtPurchaseReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPurchaseReturn;
        //}

        //internal DataTable LastVoucherNo(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjPurchaseRModel.VchType);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPurchaseReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPurchaseReturn);
        //        dtPurchaseReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPurchaseReturn = new DataTable();
        //        dtPurchaseReturn.TableName = "error";
        //        return dtPurchaseReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPurchaseReturn;
        //}

        //internal DataTable FillItemPurchaseRate(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPItems";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
        //        //ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@PartyCode", ObjPurchaseRModel.PartyCode);
        //        ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjPurchaseRModel.AccGst);
        //        ClsCon.cmd.Parameters.AddWithValue("@ItemID", ObjPurchaseRModel.ItemID);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPurchaseReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPurchaseReturn);
        //        dtPurchaseReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPurchaseReturn = new DataTable();
        //        dtPurchaseReturn.TableName = "error";
        //        return dtPurchaseReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPurchaseReturn;

        //}

        //internal DataTable FillGistnNo(PurchaseReturnModel ObjPurchaseRModel) //fill GistnNo
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPSearchByAccount";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjPurchaseRModel.AccCode);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPurchaseReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPurchaseReturn);
        //        dtPurchaseReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPurchaseReturn = new DataTable();
        //        dtPurchaseReturn.TableName = "error";
        //        return dtPurchaseReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPurchaseReturn;
        //}

        //internal DataTable FillShippingAddress(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPSearchByAccount";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjPurchaseRModel.AccCode);
        //        ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjPurchaseRModel.AccGst);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPurchaseReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPurchaseReturn);
        //        dtPurchaseReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPurchaseReturn = new DataTable();
        //        dtPurchaseReturn.TableName = "error";
        //        return dtPurchaseReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPurchaseReturn;
        //}

        //internal DataTable SavePurchaseReturnVoucher(PurchaseReturnModel ObjPurchaseRModel)
        //{


        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPPurchaseReturnVoucher";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjPurchaseRModel.VchType);
        //        ClsCon.cmd.Parameters.AddWithValue("@EntryType", ObjPurchaseRModel.EntryType);
        //        ClsCon.cmd.Parameters.AddWithValue("@User", ObjPurchaseRModel.User);
        //        ClsCon.cmd.Parameters.AddWithValue("@IP", ObjPurchaseRModel.IP);

        //        ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", ObjPurchaseRModel.ByCashSale);
        //        ClsCon.cmd.Parameters.AddWithValue("@PartyName", ObjPurchaseRModel.PartyName);
        //        ClsCon.cmd.Parameters.AddWithValue("@PartyGSTIN", ObjPurchaseRModel.PartyGSTIN);
        //        ClsCon.cmd.Parameters.AddWithValue("@PartyAddress", ObjPurchaseRModel.PartyAddress);
        //        ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", ObjPurchaseRModel.WareHouseID);
        //        ClsCon.cmd.Parameters.AddWithValue("@PONo", ObjPurchaseRModel.PONo);
        //        ClsCon.cmd.Parameters.AddWithValue("@PurchaseBillNo", ObjPurchaseRModel.PurchaseBillNo);
        //        ClsCon.cmd.Parameters.AddWithValue("@PurchaseBillDate", ObjPurchaseRModel.PurchaseBillDate);
        //        ClsCon.cmd.Parameters.AddWithValue("@GRNNo", ObjPurchaseRModel.GRNNo);
        //        ClsCon.cmd.Parameters.AddWithValue("@DocDate", ObjPurchaseRModel.VoucherDate);

        //        ClsCon.cmd.Parameters.AddWithValue("@TblPurchase", ObjPurchaseRModel.DtPurchase);
        //        ClsCon.cmd.Parameters.AddWithValue("@TblPurchaseItems", ObjPurchaseRModel.DtItems);
        //        ClsCon.cmd.Parameters.AddWithValue("@TblPurchaseSundries", ObjPurchaseRModel.DtSundries);


        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPurchaseReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPurchaseReturn);
        //        dtPurchaseReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPurchaseReturn = new DataTable();
        //        dtPurchaseReturn.TableName = "error";
        //        return dtPurchaseReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPurchaseReturn;
        //}

        //internal DataTable SearchItem(PurchaseReturnModel ObjPurchaseRModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPPurchaseReturnVoucher";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjPurchaseRModel.AccCode);
        //        ClsCon.cmd.Parameters.AddWithValue("@AccGst", ObjPurchaseRModel.AccGst);
        //        ClsCon.cmd.Parameters.AddWithValue("@ItemID", ObjPurchaseRModel.ItemID);
        //        ClsCon.cmd.Parameters.AddWithValue("@PurchaseBillNo", ObjPurchaseRModel.PurchaseBillNo);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPurchaseReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPurchaseReturn);
        //        dtPurchaseReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPurchaseReturn = new DataTable();
        //        dtPurchaseReturn.TableName = "error";
        //        return dtPurchaseReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPurchaseReturn;
        //}

        //internal DataTable LastVoucherNo(SalesReturnModel ObjSalesRModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjSalesRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjSalesRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjSalesRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjSalesRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjSalesRModel.VchType);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtPurchaseReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtPurchaseReturn);
        //        dtPurchaseReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtPurchaseReturn = new DataTable();
        //        dtPurchaseReturn.TableName = "error";
        //        return dtPurchaseReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtPurchaseReturn;
        //}

        #endregion

        internal DataSet BindAll(PurchaseReturnModel ObjPurchaseRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPPurchaseVoucherChange";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjPurchaseRModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsPurchaseReturn = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsPurchaseReturn);
                dsPurchaseReturn.DataSetName = "success";
            }
            catch (Exception)
            {
                dsPurchaseReturn = new DataSet();
                dsPurchaseReturn.DataSetName = "error";
                return dsPurchaseReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsPurchaseReturn;
        }

        internal DataTable Filllocation(PurchaseReturnModel ObjPurchaseRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPurchaseReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPurchaseReturn);
                dtPurchaseReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtPurchaseReturn = new DataTable();
                dtPurchaseReturn.TableName = "error";
                return dtPurchaseReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPurchaseReturn;
        }

        internal DataSet FillItemPurchaseRate(PurchaseReturnModel ObjPurchaseRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", ObjPurchaseRModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjPurchaseRModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", ObjPurchaseRModel.ItemID);

                ClsCon.cmd.Parameters.AddWithValue("@ByCash", ObjPurchaseRModel.ByCashSale);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsPurchaseReturn = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsPurchaseReturn);
                dsPurchaseReturn.DataSetName = "success";
            }
            catch (Exception)
            {
                dsPurchaseReturn = new DataSet();
                dsPurchaseReturn.DataSetName = "error";
                return dsPurchaseReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsPurchaseReturn;
        }

        internal DataTable FillGistnNo(PurchaseReturnModel ObjPurchaseRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjPurchaseRModel.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPurchaseReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPurchaseReturn);
                dtPurchaseReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtPurchaseReturn = new DataTable();
                dtPurchaseReturn.TableName = "error";
                return dtPurchaseReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPurchaseReturn;
        }

        internal DataTable FillShippingAddress(PurchaseReturnModel ObjPurchaseRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjPurchaseRModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjPurchaseRModel.GSTIN);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPurchaseReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPurchaseReturn);
                dtPurchaseReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtPurchaseReturn = new DataTable();
                dtPurchaseReturn.TableName = "error";
                return dtPurchaseReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPurchaseReturn;
        }

        internal DataSet LoadPurchaseVoucherDetails(PurchaseReturnModel ObjPurchaseRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPPurchaseReturnVoucher";

                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", ObjPurchaseRModel.VoucherNo);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsPurchaseReturn = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsPurchaseReturn);
                dsPurchaseReturn.DataSetName = "success";
                dsPurchaseReturn.Tables[0].TableName = "Basic";
                dsPurchaseReturn.Tables[1].TableName = "ItemDetails";
                dsPurchaseReturn.Tables[2].TableName = "Sundries";
            }
            catch (Exception)
            {
                dsPurchaseReturn = new DataSet();
                dsPurchaseReturn.DataSetName = "error";
                return dsPurchaseReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsPurchaseReturn;
        }

        internal DataTable SavePurchaseReturn(PurchaseReturnModel ObjPurchaseRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPPurchaseReturnVoucher";

                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjPurchaseRModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", ObjPurchaseRModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", ObjPurchaseRModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", ObjPurchaseRModel.IP);

                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", ObjPurchaseRModel.ByCashSale);
                ClsCon.cmd.Parameters.AddWithValue("@PartyName", ObjPurchaseRModel.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@PartyGSTIN", ObjPurchaseRModel.PartyGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@PartyAddress", ObjPurchaseRModel.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", ObjPurchaseRModel.WareHouseID);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjPurchaseRModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@PONo", ObjPurchaseRModel.PONo);
                ClsCon.cmd.Parameters.AddWithValue("@PODate", ObjPurchaseRModel.PODate);
                ClsCon.cmd.Parameters.AddWithValue("@PurchaseBillNo", ObjPurchaseRModel.PurchaseBillNo);
                ClsCon.cmd.Parameters.AddWithValue("@PurchaseBillDate", ObjPurchaseRModel.PurchaseBillDate);
                ClsCon.cmd.Parameters.AddWithValue("@GRNNo", ObjPurchaseRModel.GRNNo);
                ClsCon.cmd.Parameters.AddWithValue("@GRNDate", ObjPurchaseRModel.GRNDate);
                ClsCon.cmd.Parameters.AddWithValue("@PurchaseSaleRecordID", ObjPurchaseRModel.PurchaseSaleRecordID);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", ObjPurchaseRModel.VoucherNo);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", ObjPurchaseRModel.VoucherDate);
                ClsCon.cmd.Parameters.AddWithValue("@HiddenPucrchaseVoucherDate", ObjPurchaseRModel.HiddenPucrchaseVoucherDate);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", ObjPurchaseRModel.CCCode);
                ClsCon.cmd.Parameters.AddWithValue("@TblPurchase", ObjPurchaseRModel.DtUpdPurchase);
                ClsCon.cmd.Parameters.AddWithValue("@TblPurchaseItems", ObjPurchaseRModel.DtUpdItems);
                ClsCon.cmd.Parameters.AddWithValue("@TblPurchaseSundries", ObjPurchaseRModel.DtUpdSundries);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPurchaseReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPurchaseReturn);
                dtPurchaseReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtPurchaseReturn = new DataTable();
                dtPurchaseReturn.TableName = "error";
                return dtPurchaseReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPurchaseReturn;
        }
    }
}