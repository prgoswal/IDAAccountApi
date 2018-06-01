using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{ 
    public class WarehouseDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtWarehouse, dtSaveWarehouse;
        internal DataTable LoadState(WarehouseModel ObjWarehouseModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjWarehouseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjWarehouseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjWarehouseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjWarehouseModel.YrCD);
               // ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjWarehouseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtWarehouse = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtWarehouse);
                dtWarehouse.TableName = "success";
            }
            catch (Exception)
            {
                dtWarehouse = new DataTable();
                dtWarehouse.TableName = "error";
                return dtWarehouse;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtWarehouse;
        }

        internal DataTable LoadCity(WarehouseModel ObjWarehouseModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjWarehouseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjWarehouseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjWarehouseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjWarehouseModel.YrCD);
                // ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjWarehouseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtWarehouse = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtWarehouse);
                dtWarehouse.TableName = "success";
            }
            catch (Exception)
            {
                dtWarehouse = new DataTable();
                dtWarehouse.TableName = "error";
                return dtWarehouse;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtWarehouse;
        }

        internal DataTable LoadGSTINNo(WarehouseModel ObjWarehouseModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjWarehouseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjWarehouseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjWarehouseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjWarehouseModel.YrCD);
                // ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjWarehouseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtWarehouse = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtWarehouse);
                dtWarehouse.TableName = "success";
            }
            catch (Exception)
            {
                dtWarehouse = new DataTable();
                dtWarehouse.TableName = "error";
                return dtWarehouse;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtWarehouse;

        } 
        internal DataTable SaveWareHouse(WarehouseModel ObjWarehouseModel)
          {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPWarehouse";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjWarehouseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@User", ObjWarehouseModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjWarehouseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjWarehouseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@GSTINID", ObjWarehouseModel.GSTINID);
                ClsCon.cmd.Parameters.AddWithValue("@Address", ObjWarehouseModel.Address);
                ClsCon.cmd.Parameters.AddWithValue("@City", ObjWarehouseModel.City);
                ClsCon.cmd.Parameters.AddWithValue("@StateID", ObjWarehouseModel.StateID);
                ClsCon.cmd.Parameters.AddWithValue("@PinCode", ObjWarehouseModel.PinCode);
                ClsCon.cmd.Parameters.AddWithValue("@IP", ObjWarehouseModel.IP);
                // ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjWarehouseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSaveWarehouse = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSaveWarehouse);
                dtSaveWarehouse.TableName = "success";
            }
            catch (Exception)
            {
                dtSaveWarehouse = new DataTable();
                dtSaveWarehouse.TableName = "error";
                return dtSaveWarehouse;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSaveWarehouse;
        }

    }
}
