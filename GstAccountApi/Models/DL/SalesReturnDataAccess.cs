using GstAccountApi.Models.PL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class SalesReturnDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtSalesReturn;
        DataSet dsSalesReturn;

        //internal DataTable LoadNarration(SalesReturnModel objSalesRModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", objSalesRModel.VchType);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtSalesReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtSalesReturn);
        //        dtSalesReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtSalesReturn = new DataTable();
        //        dtSalesReturn.TableName = "error";
        //        return dtSalesReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtSalesReturn;
        //}

        //internal DataTable LoadIncomeHead(SalesReturnModel objSalesRModel) //IncomeHeadFill
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtSalesReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtSalesReturn);
        //        dtSalesReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtSalesReturn = new DataTable();
        //        dtSalesReturn.TableName = "error";
        //        return dtSalesReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtSalesReturn;
        //}

        //internal DataTable LoadSalesTo(SalesReturnModel objSalesRModel) // FillDropDownSalesTo
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtSalesReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtSalesReturn);
        //        dtSalesReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtSalesReturn = new DataTable();
        //        dtSalesReturn.TableName = "error";
        //        return dtSalesReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtSalesReturn;
        //}

        //internal DataTable FillHeadName(SalesReturnModel objSalesRModel) //HeadName in Othertable
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtSalesReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtSalesReturn);
        //        dtSalesReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtSalesReturn = new DataTable();
        //        dtSalesReturn.TableName = "error";
        //        return dtSalesReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtSalesReturn;
        //}

        //internal DataTable Filllocation(SalesReturnModel objSalesRModel) //FillLocation in Othertable
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@GSTINID", objSalesRModel.AccGst);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtSalesReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtSalesReturn);
        //        dtSalesReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtSalesReturn = new DataTable();
        //        dtSalesReturn.TableName = "error";
        //        return dtSalesReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtSalesReturn;
        //}

        //internal DataTable FillUnitName(SalesReturnModel objSalesRModel) //fill GistnNo
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtSalesReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtSalesReturn);
        //        dtSalesReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtSalesReturn = new DataTable();
        //        dtSalesReturn.TableName = "error";
        //        return dtSalesReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtSalesReturn;
        //}

        //internal DataTable FillItemName(SalesReturnModel objSalesRModel) //fill GistnNo
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtSalesReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtSalesReturn);
        //        dtSalesReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtSalesReturn = new DataTable();
        //        dtSalesReturn.TableName = "error";
        //        return dtSalesReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtSalesReturn;
        //}

        //internal DataTable FillItemSellingRate(SalesReturnModel objSalesRModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPItems";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", objSalesRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
        //        //ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objSalesRModel.PartyCode);
        //        ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objSalesRModel.AccGst);
        //        ClsCon.cmd.Parameters.AddWithValue("@ItemID", objSalesRModel.ItemID);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtSalesReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtSalesReturn);
        //        dtSalesReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtSalesReturn = new DataTable();
        //        dtSalesReturn.TableName = "error";
        //        return dtSalesReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtSalesReturn;

        //}

        //internal DataTable FillGistnNo(SalesReturnModel objSalesRModel) //fill GistnNo
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPSearchByAccount";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", objSalesRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@AccCode", objSalesRModel.AccCode);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtSalesReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtSalesReturn);
        //        dtSalesReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtSalesReturn = new DataTable();
        //        dtSalesReturn.TableName = "error";
        //        return dtSalesReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtSalesReturn;
        //}

        //internal DataTable SaveSalesReturnVoucher(SalesReturnModel objSalesRModel)
        //{            
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPSalesReturnVoucher";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", objSalesRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", objSalesRModel.VchType);
        //        ClsCon.cmd.Parameters.AddWithValue("@EntryType", objSalesRModel.EntryType);
        //        ClsCon.cmd.Parameters.AddWithValue("@User", objSalesRModel.User);
        //        ClsCon.cmd.Parameters.AddWithValue("@IP", objSalesRModel.IP);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);

        //        ClsCon.cmd.Parameters.AddWithValue("@TblSale", objSalesRModel.DtSales);
        //        ClsCon.cmd.Parameters.AddWithValue("@TblItems", objSalesRModel.DtItems);
        //        ClsCon.cmd.Parameters.AddWithValue("@TblSundries", objSalesRModel.DtSundries);


        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtSalesReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtSalesReturn);
        //        dtSalesReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtSalesReturn = new DataTable();
        //        dtSalesReturn.TableName = "error";
        //        return dtSalesReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtSalesReturn;
        //}

        //internal DataTable FillShippingAddress(SalesReturnModel objSalesRModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPSearchByAccount";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", objSalesRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@AccCode", objSalesRModel.AccCode);
        //        ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objSalesRModel.AccGst);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtSalesReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtSalesReturn);
        //        dtSalesReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtSalesReturn = new DataTable();
        //        dtSalesReturn.TableName = "error";
        //        return dtSalesReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtSalesReturn;
        //}

        //internal DataTable SearchItem(SalesReturnModel objSalesRModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPSalesReturn";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", objSalesRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@AccCode", objSalesRModel.AccCode);
        //        ClsCon.cmd.Parameters.AddWithValue("@AccGst", objSalesRModel.AccGst);
        //        ClsCon.cmd.Parameters.AddWithValue("@ItemID", objSalesRModel.ItemID);
        //        ClsCon.cmd.Parameters.AddWithValue("@RefNo", objSalesRModel.RefNo);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtSalesReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtSalesReturn);
        //        dtSalesReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtSalesReturn = new DataTable();
        //        dtSalesReturn.TableName = "error";
        //        return dtSalesReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtSalesReturn;
        //}

        //internal DataTable LastVoucherNo(SalesReturnModel objSalesRModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";

        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
        //        ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
        //        ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
        //        ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);
        //        ClsCon.cmd.Parameters.AddWithValue("@VchType", objSalesRModel.VchType);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtSalesReturn = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtSalesReturn);
        //        dtSalesReturn.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtSalesReturn = new DataTable();
        //        dtSalesReturn.TableName = "error";
        //        return dtSalesReturn;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtSalesReturn;   
        //}

        internal DataTable LoadNarration(SalesReturnModel objSalesRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objSalesRModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSalesReturn);
                dtSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtSalesReturn = new DataTable();
                dtSalesReturn.TableName = "error";
                return dtSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSalesReturn;
        }

        internal DataTable LoadIncomeHead(SalesReturnModel objSalesRModel) //IncomeHeadFill
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSalesReturn);
                dtSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtSalesReturn = new DataTable();
                dtSalesReturn.TableName = "error";
                return dtSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSalesReturn;
        }

        internal DataTable LoadSalesTo(SalesReturnModel objSalesRModel) // FillDropDownSalesTo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSalesReturn);
                dtSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtSalesReturn = new DataTable();
                dtSalesReturn.TableName = "error";
                return dtSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSalesReturn;
        }

        internal DataTable FillHeadName(SalesReturnModel objSalesRModel) //HeadName in Othertable
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSalesReturn);
                dtSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtSalesReturn = new DataTable();
                dtSalesReturn.TableName = "error";
                return dtSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSalesReturn;
        }

        internal DataTable Filllocation(SalesReturnModel objSalesRModel) //FillLocation in Othertable
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@GSTINID", objSalesRModel.GSTIN);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSalesReturn);
                dtSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtSalesReturn = new DataTable();
                dtSalesReturn.TableName = "error";
                return dtSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSalesReturn;
        }

        internal DataTable FillUnitName(SalesReturnModel objSalesRModel) //fill GistnNo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSalesReturn);
                dtSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtSalesReturn = new DataTable();
                dtSalesReturn.TableName = "error";
                return dtSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSalesReturn;
        }

        internal DataTable FillItemName(SalesReturnModel objSalesRModel) //fill GistnNo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSalesReturn);
                dtSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtSalesReturn = new DataTable();
                dtSalesReturn.TableName = "error";
                return dtSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSalesReturn;
        }

        internal DataTable FillItemSellingRate(SalesReturnModel objSalesRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objSalesRModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objSalesRModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", objSalesRModel.ItemID);

                ClsCon.cmd.Parameters.AddWithValue("@ByCash", objSalesRModel.ByCashSale);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSalesReturn);
                dtSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtSalesReturn = new DataTable();
                dtSalesReturn.TableName = "error";
                return dtSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSalesReturn;

        }

        internal DataTable FillGistnNo(SalesReturnModel objSalesRModel) //fill GistnNo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objSalesRModel.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSalesReturn);
                dtSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtSalesReturn = new DataTable();
                dtSalesReturn.TableName = "error";
                return dtSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSalesReturn;
        }

        internal DataTable FillShippingAddress(SalesReturnModel objSalesRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objSalesRModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objSalesRModel.GSTIN);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSalesReturn);
                dtSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtSalesReturn = new DataTable();
                dtSalesReturn.TableName = "error";
                return dtSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSalesReturn;
        }

        internal DataTable LastVoucherNo(SalesReturnModel objSalesRModel) // Pending
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objSalesRModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSalesReturn);
                dtSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtSalesReturn = new DataTable();
                dtSalesReturn.TableName = "error";
                return dtSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSalesReturn;
        }

        internal DataTable FillTransportation(SalesReturnModel objSalesRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSalesReturn);
                dtSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtSalesReturn = new DataTable();
                dtSalesReturn.TableName = "error";
                return dtSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSalesReturn;
        }

        internal DataTable InvoiceSeries(SalesReturnModel objSalesRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objSalesRModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSalesReturn);
                dtSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtSalesReturn = new DataTable();
                dtSalesReturn.TableName = "error";
                return dtSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSalesReturn;
        }

        internal DataSet FillItemSellRate(SalesReturnModel objSalesRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objSalesRModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objSalesRModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", objSalesRModel.ItemID);
                ClsCon.cmd.Parameters.AddWithValue("@ByCash", objSalesRModel.ByCashSale);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsSalesReturn = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsSalesReturn, "SuccessDataSet");
                dsSalesReturn.DataSetName = "success";
            }
            catch (Exception)
            {
                dsSalesReturn = new DataSet();
                dsSalesReturn.DataSetName = "error";
                return dsSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsSalesReturn;
        }

        internal DataSet BindAll(SalesReturnModel objSalesRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSalesReturnVoucher";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objSalesRModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsSalesReturn = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsSalesReturn);
                dsSalesReturn.DataSetName = "success";
            }
            catch (Exception)
            {
                dsSalesReturn = new DataSet();
                dsSalesReturn.DataSetName = "error";
                return dsSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsSalesReturn;
        }

        internal DataSet LoadSRBasicDetails(SalesReturnModel objSalesRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSalesReturnVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", objSalesRModel.InvoiceSeries);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceNo", objSalesRModel.InvoiceNo);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsSalesReturn = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsSalesReturn);
                dsSalesReturn.DataSetName = "success";
            }
            catch (Exception)
            {
                dsSalesReturn = new DataSet();
                dsSalesReturn.DataSetName = "error";
                return dsSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsSalesReturn;
        }

        internal DataTable SaveSalesReturnVoucher(SalesReturnModel objSalesRModel)
        {

            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSalesReturnVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objSalesRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSalesRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSalesRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSalesRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objSalesRModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objSalesRModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objSalesRModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objSalesRModel.IP);


                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", objSalesRModel.ByCashSale);
                ClsCon.cmd.Parameters.AddWithValue("@PartyName", objSalesRModel.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@PartyGSTIN", objSalesRModel.PartyGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@PartyAddress", objSalesRModel.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", objSalesRModel.WareHouseID);
                ClsCon.cmd.Parameters.AddWithValue("@TransName", objSalesRModel.TransName);
                ClsCon.cmd.Parameters.AddWithValue("@PONo", objSalesRModel.PONo);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", objSalesRModel.DocDate);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", objSalesRModel.InvoiceSeries);

                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objSalesRModel.CCCode);


                ClsCon.cmd.Parameters.AddWithValue("@OrgVoucherNo", objSalesRModel.OrgVoucherNo);
                ClsCon.cmd.Parameters.AddWithValue("@OrgVoucherDate", objSalesRModel.OrgVoucherDate);


                //ClsCon.cmd.Parameters.AddWithValue("@TblSale", JsonConvert.DeserializeObject<DataTable>(objSalesRModel.DtSales));
                //ClsCon.cmd.Parameters.AddWithValue("@TblItems", JsonConvert.DeserializeObject<DataTable>(objSalesRModel.DtItems));
                //ClsCon.cmd.Parameters.AddWithValue("@TblSundries", JsonConvert.DeserializeObject<DataTable>(objSalesRModel.DtSundries));

                ClsCon.cmd.Parameters.AddWithValue("@TblSale", objSalesRModel.DtSales);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", objSalesRModel.DtItems);
                ClsCon.cmd.Parameters.AddWithValue("@TblSundries", objSalesRModel.DtSundries);


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSalesReturn);
                dtSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtSalesReturn = new DataTable();
                dtSalesReturn.TableName = "error";
                return dtSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSalesReturn;
        }
    }
}