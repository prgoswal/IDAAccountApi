using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class ItemOpenningStockDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtopenStock; 
        DataSet DsOpenStock;

        internal DataTable FillItemName(ItemOpenningStockModel ObjopenStockModel) //fill GistnNo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjopenStockModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjopenStockModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjopenStockModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjopenStockModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtopenStock = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtopenStock);
                dtopenStock.TableName = "success";
            }
            catch (Exception)
            {
                dtopenStock = new DataTable();
                dtopenStock.TableName = "error";
                return dtopenStock;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtopenStock;
        }

        internal DataSet FillUnit(ItemOpenningStockModel ObjopenStockModel) //fill GistnNo
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjopenStockModel.Ind);
                //ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjopenStockModel.OrgID);
                //ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjopenStockModel.BrID);
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjopenStockModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                DsOpenStock = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(DsOpenStock);
               // DsOpenStock.TableName = "success";
            }
            catch (Exception)
            {
                DsOpenStock = new DataSet();
               // dtopenStock.TableName = "error";
                return DsOpenStock;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return DsOpenStock;
        }

        internal DataTable FillIWareHouseName(ItemOpenningStockModel ObjopenStockModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjopenStockModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjopenStockModel.OrgID);
               // ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjopenStockModel.BrID);
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjopenStockModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtopenStock = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtopenStock);
                dtopenStock.TableName = "success";
            }
            catch (Exception)
            {
                dtopenStock = new DataTable();
                dtopenStock.TableName = "error";
                return dtopenStock;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtopenStock;
        }

        internal DataTable SaveEntry(ItemOpenningStockModel ObjopenStockModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjopenStockModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjopenStockModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjopenStockModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", ObjopenStockModel.ItemID);
                ClsCon.cmd.Parameters.AddWithValue("@User", ObjopenStockModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", ObjopenStockModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@TblItemOpening", ObjopenStockModel.DtItem); 


                // ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjopenStockModel.BrID);
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjopenStockModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtopenStock = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtopenStock);
                dtopenStock.TableName = "success";
            }
            catch (Exception)
            {
                dtopenStock = new DataTable();
                dtopenStock.TableName = "error";
                return dtopenStock;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtopenStock;
        }
        internal DataTable FillGridItemName(ItemOpenningStockModel ObjopenStockModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjopenStockModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjopenStockModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", ObjopenStockModel.ItemID);
                // ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjopenStockModel.BrID);
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjopenStockModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtopenStock = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtopenStock);
                dtopenStock.TableName = "success";
            }
            catch (Exception)
            {
                dtopenStock = new DataTable();
                dtopenStock.TableName = "error";
                return dtopenStock;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtopenStock;
        }
    }
}