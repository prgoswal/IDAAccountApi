using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class StockTransferDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtStockTransfer;
        DataSet dsStockTransfer;

        internal DataSet BindStockTransferDDL(StockTransferModel objSTModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPStockTransfer";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objSTModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSTModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSTModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSTModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objSTModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsStockTransfer = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsStockTransfer);
                dsStockTransfer.DataSetName = "success";
            }
            catch (Exception)
            {
                dsStockTransfer = new DataSet();
                dsStockTransfer.DataSetName = "error";
                return dsStockTransfer;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsStockTransfer;
        }

        internal DataSet BindItemAndUnitDDL(StockTransferModel objSTModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPStockTransfer";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objSTModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSTModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSTModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@TransferFromWarehouseID", objSTModel.WarehouseID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsStockTransfer = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsStockTransfer, "SuccessDataSet");
                dsStockTransfer.DataSetName = "success";
            }
            catch (Exception)
            {
                dsStockTransfer = new DataSet();
                dsStockTransfer.DataSetName = "error";
                return dsStockTransfer;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsStockTransfer;
        }

        internal DataTable SaveStockTransfer(StockTransferModel objSTModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPStockTransfer";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objSTModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objSTModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objSTModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objSTModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", objSTModel.VchType);

                ClsCon.cmd.Parameters.AddWithValue("@TransferNo", objSTModel.TransferNo);
                ClsCon.cmd.Parameters.AddWithValue("@TransferDate", objSTModel.TransferDate);
                ClsCon.cmd.Parameters.AddWithValue("@Narration", objSTModel.Narration);
                ClsCon.cmd.Parameters.AddWithValue("@TransferFromWarehouseID", objSTModel.TransferFromWarehouseID);
                ClsCon.cmd.Parameters.AddWithValue("@TransferToWarehouseID", objSTModel.TransferToWarehouseID);

                ClsCon.cmd.Parameters.AddWithValue("@CCCodeTransferFrom", objSTModel.CCCodeTransferFrom);
                ClsCon.cmd.Parameters.AddWithValue("@CCCodeTransferTo", objSTModel.CCCodeTransferTo);

                ClsCon.cmd.Parameters.AddWithValue("@UserID", objSTModel.UserID);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objSTModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@TblStockTransferItems", objSTModel.DtItemDetail);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtStockTransfer = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtStockTransfer);
                dtStockTransfer.TableName = "success";
            }
            catch (Exception)
            {
                dtStockTransfer = new DataTable();
                dtStockTransfer.TableName = "error";
                return dtStockTransfer;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtStockTransfer;
        }
    }
}