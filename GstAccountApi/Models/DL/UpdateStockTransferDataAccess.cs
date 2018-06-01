using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdateStockTransferDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtUpdStockTransfer, dtCancelVoucher;
        DataSet dsUpdStockTransfer;

        internal DataSet BindStockTransferDDL(UpdateStockTransferModel objUpdSTModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateStockTransfer";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdSTModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSTModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSTModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSTModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdSTModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdStockTransfer = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdStockTransfer);
                dsUpdStockTransfer.DataSetName = "success";
            }
            catch (Exception)
            {
                dsUpdStockTransfer = new DataSet();
                dsUpdStockTransfer.DataSetName = "error";
                return dsUpdStockTransfer;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdStockTransfer;
        }

        internal DataSet BindItemAndUnitDDL(UpdateStockTransferModel objUpdSTModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateStockTransfer";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdSTModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSTModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSTModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@TransferFromWarehouseID", objUpdSTModel.WarehouseID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdStockTransfer = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdStockTransfer, "SuccessDataSet");
                dsUpdStockTransfer.DataSetName = "success";
            }
            catch (Exception)
            {
                dsUpdStockTransfer = new DataSet();
                dsUpdStockTransfer.DataSetName = "error";
                return dsUpdStockTransfer;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdStockTransfer;
        }

        internal DataSet SearchForUpdateStockTransfer(UpdateStockTransferModel objUpdSTModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateStockTransfer";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdSTModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSTModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSTModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSTModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdSTModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdSTModel.DocNo);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdStockTransfer = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdStockTransfer, "SuccessDataSet");
                dsUpdStockTransfer.DataSetName = "success";
            }
            catch (Exception)
            {
                dsUpdStockTransfer = new DataSet();
                dsUpdStockTransfer.DataSetName = "error";
                return dsUpdStockTransfer;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdStockTransfer;
        }

        internal DataTable UpdateStockTransfer(UpdateStockTransferModel objUpdSTModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateStockTransfer";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdSTModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSTModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSTModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSTModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objUpdSTModel.VchType);

                ClsCon.cmd.Parameters.AddWithValue("@TransferNo", objUpdSTModel.TransferNo);
                ClsCon.cmd.Parameters.AddWithValue("@TransferDate", objUpdSTModel.TransferDate);
                ClsCon.cmd.Parameters.AddWithValue("@Narration", objUpdSTModel.Narration);
                ClsCon.cmd.Parameters.AddWithValue("@TransferFromWarehouseID", objUpdSTModel.TransferFromWarehouseID);
                ClsCon.cmd.Parameters.AddWithValue("@TransferToWarehouseID", objUpdSTModel.TransferToWarehouseID);


                ClsCon.cmd.Parameters.AddWithValue("@CCCodeTransferFrom", objUpdSTModel.CCCodeTransferFrom);
                ClsCon.cmd.Parameters.AddWithValue("@CCCodeTransferTo", objUpdSTModel.CCCodeTransferTo);

                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdSTModel.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", objUpdSTModel.UserID);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objUpdSTModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@TblStockTransferItems", objUpdSTModel.DtItemDetail);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdStockTransfer = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdStockTransfer);
                dtUpdStockTransfer.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdStockTransfer = new DataTable();
                dtUpdStockTransfer.TableName = "error";
                return dtUpdStockTransfer;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdStockTransfer;
        }

        internal DataTable CancelVoucher(UpdateStockTransferModel objUpdSTModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateStockTransfer";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUpdSTModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUpdSTModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUpdSTModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@DocNo", objUpdSTModel.DocNo);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUpdSTModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VChType", objUpdSTModel.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@CancelReason", objUpdSTModel.CancelReason);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCancelVoucher = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCancelVoucher);
                dtCancelVoucher.TableName = "success";
            }
            catch (Exception)
            {
                dtCancelVoucher = new DataTable();
                dtCancelVoucher.TableName = "error";
                return dtCancelVoucher;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCancelVoucher;
        }
    }
}