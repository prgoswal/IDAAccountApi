using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdateSalesReturnDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtUpdSalesReturn;
        DataSet dsUpdSalesReturn;

        internal DataTable LoadNarration(UpdateSalesReturnModel objUpdSRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdSRModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdSalesReturn);
                dtUpdSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdSalesReturn = new DataTable();
                dtUpdSalesReturn.TableName = "error";
                return dtUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdSalesReturn;
        }

        internal DataTable LoadIncomeHead(UpdateSalesReturnModel objUpdSRModel) //IncomeHeadFill
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSRModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdSalesReturn);
                dtUpdSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdSalesReturn = new DataTable();
                dtUpdSalesReturn.TableName = "error";
                return dtUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdSalesReturn;
        }

        internal DataTable LoadSalesTo(UpdateSalesReturnModel objUpdSRModel) // FillDropDownSalesTo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSRModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdSalesReturn);
                dtUpdSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdSalesReturn = new DataTable();
                dtUpdSalesReturn.TableName = "error";
                return dtUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdSalesReturn;
        }

        internal DataTable FillHeadName(UpdateSalesReturnModel objUpdSRModel) //HeadName in Othertable
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSRModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdSalesReturn);
                dtUpdSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdSalesReturn = new DataTable();
                dtUpdSalesReturn.TableName = "error";
                return dtUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdSalesReturn;
        }

        internal DataTable Filllocation(UpdateSalesReturnModel objUpdSRModel) //FillLocation in Othertable
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@GSTINID", objUpdSRModel.GSTIN);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdSalesReturn);
                dtUpdSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdSalesReturn = new DataTable();
                dtUpdSalesReturn.TableName = "error";
                return dtUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdSalesReturn;
        }

        internal DataTable FillUnitName(UpdateSalesReturnModel objUpdSRModel) //fill GistnNo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSRModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdSalesReturn);
                dtUpdSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdSalesReturn = new DataTable();
                dtUpdSalesReturn.TableName = "error";
                return dtUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdSalesReturn;
        }

        internal DataTable FillItemName(UpdateSalesReturnModel objUpdSRModel) //fill GistnNo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSRModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdSalesReturn);
                dtUpdSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdSalesReturn = new DataTable();
                dtUpdSalesReturn.TableName = "error";
                return dtUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdSalesReturn;
        }

        internal DataTable FillItemSellingRate(UpdateSalesReturnModel objUpdSRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSRModel.BrID);
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objUpdSRModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objUpdSRModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", objUpdSRModel.ItemID);

                ClsCon.cmd.Parameters.AddWithValue("@ByCash", objUpdSRModel.ByCashSale);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdSalesReturn);
                dtUpdSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdSalesReturn = new DataTable();
                dtUpdSalesReturn.TableName = "error";
                return dtUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdSalesReturn;

        }

        internal DataTable FillGistnNo(UpdateSalesReturnModel objUpdSRModel) //fill GistnNo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUpdSRModel.AccCode);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdSalesReturn);
                dtUpdSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdSalesReturn = new DataTable();
                dtUpdSalesReturn.TableName = "error";
                return dtUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdSalesReturn;
        }

        internal DataTable FillShippingAddress(UpdateSalesReturnModel objUpdSRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@AccCode", objUpdSRModel.AccCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objUpdSRModel.GSTIN);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdSalesReturn);
                dtUpdSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdSalesReturn = new DataTable();
                dtUpdSalesReturn.TableName = "error";
                return dtUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdSalesReturn;
        }

        internal DataTable LastVoucherNo(UpdateSalesReturnModel objUpdSRModel) // Pending
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdSRModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdSalesReturn);
                dtUpdSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdSalesReturn = new DataTable();
                dtUpdSalesReturn.TableName = "error";
                return dtUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdSalesReturn;
        }

        internal DataTable FillTransportation(UpdateSalesReturnModel objUpdSRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdSRModel.Ind);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdSalesReturn);
                dtUpdSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdSalesReturn = new DataTable();
                dtUpdSalesReturn.TableName = "error";
                return dtUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdSalesReturn;
        }

        internal DataTable InvoiceSeries(UpdateSalesReturnModel objUpdSRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdSRModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdSalesReturn);
                dtUpdSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdSalesReturn = new DataTable();
                dtUpdSalesReturn.TableName = "error";
                return dtUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdSalesReturn;
        }

        internal DataSet FillItemSellRate(UpdateSalesReturnModel objUpdSRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@PartyCode", objUpdSRModel.PartyCode);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objUpdSRModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", objUpdSRModel.ItemID);
                ClsCon.cmd.Parameters.AddWithValue("@ByCash", objUpdSRModel.ByCashSale);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdSalesReturn = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdSalesReturn, "SuccessDataSet");
                dsUpdSalesReturn.DataSetName = "success";
            }
            catch (Exception)
            {
                dsUpdSalesReturn = new DataSet();
                dsUpdSalesReturn.DataSetName = "error";
                return dsUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdSalesReturn;
        }

        internal DataSet BindAll(UpdateSalesReturnModel objUpdSRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateSalesReturnVoucher";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdSRModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdSalesReturn = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdSalesReturn);
                dsUpdSalesReturn.DataSetName = "success";
            }
            catch (Exception)
            {
                dsUpdSalesReturn = new DataSet();
                dsUpdSalesReturn.DataSetName = "error";
                return dsUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdSalesReturn;
        }

        internal DataSet LoadSRBasicDetails(UpdateSalesReturnModel objUpdSRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateSalesReturnVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdSRModel.DocNo);
                
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdSalesReturn = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdSalesReturn);
                dsUpdSalesReturn.DataSetName = "success";
            }
            catch (Exception)
            {
                dsUpdSalesReturn = new DataSet();
                dsUpdSalesReturn.DataSetName = "error";
                return dsUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdSalesReturn;
        }

        internal DataTable UpdateSalesReturnVoucher(UpdateSalesReturnModel objUpdSRModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateSalesReturnVoucher";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdSRModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSRModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSRModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSRModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdSRModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@EntryType", objUpdSRModel.EntryType);
                ClsCon.cmd.Parameters.AddWithValue("@User", objUpdSRModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objUpdSRModel.IP);

                ClsCon.cmd.Parameters.AddWithValue("@ByCashSale", objUpdSRModel.ByCashSale);
                ClsCon.cmd.Parameters.AddWithValue("@PartyName", objUpdSRModel.PartyName);
                ClsCon.cmd.Parameters.AddWithValue("@PartyGSTIN", objUpdSRModel.PartyGSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@PartyAddress", objUpdSRModel.PartyAddress);
                ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", objUpdSRModel.WareHouseID);
                ClsCon.cmd.Parameters.AddWithValue("@TransName", objUpdSRModel.TransName);
                ClsCon.cmd.Parameters.AddWithValue("@PONo", objUpdSRModel.PONo);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdSRModel.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@DocDate", objUpdSRModel.DocDate);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceSeries", objUpdSRModel.InvoiceSeries);
                ClsCon.cmd.Parameters.AddWithValue("@PurchaseSalesRecordID", objUpdSRModel.PurchaseSalesRecordID);

                ClsCon.cmd.Parameters.AddWithValue("@OrgVoucherNo", objUpdSRModel.OrgVoucherNo);
                ClsCon.cmd.Parameters.AddWithValue("@OrgVoucherDate", objUpdSRModel.OrgVoucherDate);

                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objUpdSRModel.CCCode);


                ClsCon.cmd.Parameters.AddWithValue("@TblSale", objUpdSRModel.DtSales);
                ClsCon.cmd.Parameters.AddWithValue("@TblItems", objUpdSRModel.DtItems);
                ClsCon.cmd.Parameters.AddWithValue("@TblSundries", objUpdSRModel.DtSundries);


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdSalesReturn = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdSalesReturn);
                dtUpdSalesReturn.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdSalesReturn = new DataTable();
                dtUpdSalesReturn.TableName = "error";
                return dtUpdSalesReturn;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdSalesReturn;
        }
    }
}