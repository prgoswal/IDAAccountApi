using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class CompositionPurchaseDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtPurchase;
        DataSet dsPurchase;

        internal DataTable LoadNarration(CompositionPurchaseModel ObjPurchaseModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjPurchaseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPurchase = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPurchase);
                dtPurchase.TableName = "success";
            }
            catch (Exception)
            {
                dtPurchase = new DataTable();
                dtPurchase.TableName = "error";
                return dtPurchase;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPurchase;
        }

        internal DataTable LoadExpenseHead(CompositionPurchaseModel ObjPurchaseModel) //IncomeHeadFill
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPurchase = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPurchase);
                dtPurchase.TableName = "success";
            }
            catch (Exception)
            {
                dtPurchase = new DataTable();
                dtPurchase.TableName = "error";
                return dtPurchase;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPurchase;
        }

        internal DataTable PurchaseFrom(CompositionPurchaseModel ObjPurchaseModel) // FillDropDownSalesTo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPurchase = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPurchase);
                dtPurchase.TableName = "success";
            }
            catch (Exception)
            {
                dtPurchase = new DataTable();
                dtPurchase.TableName = "error";
                return dtPurchase;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPurchase;
        }

        internal DataTable FillHeadName(CompositionPurchaseModel ObjPurchaseModel) //HeadName in Othertable
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPurchase = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPurchase);
                dtPurchase.TableName = "success";
            }
            catch (Exception)
            {
                dtPurchase = new DataTable();
                dtPurchase.TableName = "error";
                return dtPurchase;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPurchase;
        }

        internal DataTable Filllocation(CompositionPurchaseModel ObjPurchaseModel) //FillLocation in Othertable
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPurchase = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPurchase);
                dtPurchase.TableName = "success";
            }
            catch (Exception)
            {
                dtPurchase = new DataTable();
                dtPurchase.TableName = "error";
                return dtPurchase;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPurchase;
        }

        internal DataTable FillUnitName(CompositionPurchaseModel ObjPurchaseModel) //fill GistnNo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPurchase = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPurchase);
                dtPurchase.TableName = "success";
            }
            catch (Exception)
            {
                dtPurchase = new DataTable();
                dtPurchase.TableName = "error";
                return dtPurchase;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPurchase;
        }

        internal DataTable FillItemName(CompositionPurchaseModel ObjPurchaseModel) //fill GistnNo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPurchase = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPurchase);
                dtPurchase.TableName = "success";
            }
            catch (Exception)
            {
                dtPurchase = new DataTable();
                dtPurchase.TableName = "error";
                return dtPurchase;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPurchase;
        }

        internal DataSet FillItemPurchaseRate(CompositionPurchaseModel ObjPurchaseModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseModel.BrID);
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", ObjPurchaseModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjPurchaseModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", ObjPurchaseModel.ItemID);

                ClsCon.cmd.Parameters.AddWithValue("@ByCash", ObjPurchaseModel.ByCashSale);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsPurchase = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsPurchase);
                dsPurchase.DataSetName = "success";
            }
            catch (Exception)
            {
                dsPurchase = new DataSet();
                dsPurchase.DataSetName = "error";
                return dsPurchase;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsPurchase;

        }

        internal DataTable FillGistnNo(CompositionPurchaseModel ObjPurchaseModel) //fill GistnNo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjPurchaseModel.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPurchase = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPurchase);
                dtPurchase.TableName = "success";
            }
            catch (Exception)
            {
                dtPurchase = new DataTable();
                dtPurchase.TableName = "error";
                return dtPurchase;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPurchase;
        }

        internal DataTable FillShippingAddress(CompositionPurchaseModel ObjPurchaseModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjPurchaseModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", ObjPurchaseModel.GSTIN);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPurchase = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPurchase);
                dtPurchase.TableName = "success";
            }
            catch (Exception)
            {
                dtPurchase = new DataTable();
                dtPurchase.TableName = "error";
                return dtPurchase;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPurchase;
        }

        internal DataTable LastVoucherNo(CompositionPurchaseModel ObjPurchaseModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjPurchaseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjPurchaseModel.VchType);


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPurchase = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPurchase);
                dtPurchase.TableName = "success";
            }
            catch (Exception)
            {
                dtPurchase = new DataTable();
                dtPurchase.TableName = "error";
                return dtPurchase;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPurchase;
        }

        internal DataSet BindAll(CompositionPurchaseModel ObjPurchaseModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPPurchaseVoucherChange";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjPurchaseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsPurchase = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsPurchase);
                dsPurchase.DataSetName = "success";
            }
            catch (Exception)
            {
                dsPurchase = new DataSet();
                dsPurchase.DataSetName = "error";
                return dsPurchase;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsPurchase;
        }

        internal DataTable SavePurchase(CompositionPurchaseModel ObjPurchaseModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPPurchaseVoucherChange";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjPurchaseModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", ObjPurchaseModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", ObjPurchaseModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", ObjPurchaseModel.IP);

                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", ObjPurchaseModel.ByCashSale);
                ClsCon.cmd.Parameters.AddWithValue("@PartyName", ObjPurchaseModel.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@PartyGSTIN", ObjPurchaseModel.PartyGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@PartyAddress", ObjPurchaseModel.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", ObjPurchaseModel.WareHouseID);
                ClsCon.cmd.Parameters.AddWithValue("@PONo", ObjPurchaseModel.PONo);
                ClsCon.cmd.Parameters.AddWithValue("@PurchaseBillNo", ObjPurchaseModel.PurchaseBillNo);
                ClsCon.cmd.Parameters.AddWithValue("@PurchaseBillDate", ObjPurchaseModel.PurchaseBillDate);
                ClsCon.cmd.Parameters.AddWithValue("@GRNNo", ObjPurchaseModel.GRNNo);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", ObjPurchaseModel.VoucherDate);

                ClsCon.cmd.Parameters.AddWithValue("@TblPurchase", ObjPurchaseModel.DtPurchase);
                ClsCon.cmd.Parameters.AddWithValue("@TblPurchaseItems", ObjPurchaseModel.DtItems);
                ClsCon.cmd.Parameters.AddWithValue("@TblPurchaseSundries", ObjPurchaseModel.DtSundries);
                ClsCon.cmd.Parameters.AddWithValue("@TblAdvanceDetail", ObjPurchaseModel.DtAdjAdvance);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtPurchase = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtPurchase);
                dtPurchase.TableName = "success";
            }
            catch (Exception)
            {
                dtPurchase = new DataTable();
                dtPurchase.TableName = "error";
                return dtPurchase;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtPurchase;
        }

        internal DataSet FillGistnNoWithDetail(CompositionPurchaseModel ObjPurchaseModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPurchaseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPurchaseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPurchaseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPurchaseModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", ObjPurchaseModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@AdvRecPayID", ObjPurchaseModel.AdvRecPayID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsPurchase = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsPurchase);
                dsPurchase.DataSetName = "success";
            }
            catch (Exception)
            {
                dsPurchase = new DataSet();
                dsPurchase.DataSetName = "error";
                return dsPurchase;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsPurchase;
        }
       
    }
}