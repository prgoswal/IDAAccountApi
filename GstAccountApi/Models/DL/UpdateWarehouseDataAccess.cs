using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdateWarehouseDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtUpdWarehouse, dtSaveWarehouse;
        internal DataTable LoadWareHouse(UpdateWarehouseModel ObjUpdWarehouseModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjUpdWarehouseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjUpdWarehouseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjUpdWarehouseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjUpdWarehouseModel.YrCD);
                // ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjWarehouseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdWarehouse = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdWarehouse);
                dtUpdWarehouse.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdWarehouse = new DataTable();
                dtUpdWarehouse.TableName = "error";
                return dtUpdWarehouse;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdWarehouse;
        }

        internal DataTable LoadState(UpdateWarehouseModel ObjUpdWarehouseModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjUpdWarehouseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjUpdWarehouseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjUpdWarehouseModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjUpdWarehouseModel.YrCD);
                // ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjWarehouseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdWarehouse = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdWarehouse);
                dtUpdWarehouse.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdWarehouse = new DataTable();
                dtUpdWarehouse.TableName = "error";
                return dtUpdWarehouse;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdWarehouse;
        }

        internal DataTable SearchItem(UpdateWarehouseModel ObjUpdWarehouseModel)
       {
           try
           {
               ClsCon.cmd = new SqlCommand();
               ClsCon.cmd.CommandType = CommandType.StoredProcedure;
               ClsCon.cmd.CommandText = "SPWarehouse";

               ClsCon.cmd.CommandType = CommandType.StoredProcedure;
               ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjUpdWarehouseModel.Ind);
               ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjUpdWarehouseModel.OrgID);
              // ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjUpdWarehouseModel.BrID);
              // ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjUpdWarehouseModel.YrCD);
               ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", ObjUpdWarehouseModel.WareHouseID);
               // ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjWarehouseModel.VchType);

               con = ClsCon.SqlConn();
               ClsCon.cmd.Connection = con;
               dtUpdWarehouse = new DataTable();
               ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
               ClsCon.da.Fill(dtUpdWarehouse);
               dtUpdWarehouse.TableName = "success";
           }
           catch (Exception)
           {
               dtUpdWarehouse = new DataTable();
               dtUpdWarehouse.TableName = "error";
               return dtUpdWarehouse;
           }
           finally
           {
               con.Close();
               con.Dispose();
               ClsCon.da.Dispose();
               ClsCon.cmd.Dispose();
           }
           return dtUpdWarehouse;
       
       }

        internal DataTable SaveUpdWareHouse(UpdateWarehouseModel ObjUpdWarehouseModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPWarehouse";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjUpdWarehouseModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@User", ObjUpdWarehouseModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjUpdWarehouseModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@GSTINID", ObjUpdWarehouseModel.GSTINID);
                ClsCon.cmd.Parameters.AddWithValue("@Address", ObjUpdWarehouseModel.Address);
                ClsCon.cmd.Parameters.AddWithValue("@City", ObjUpdWarehouseModel.City);
                ClsCon.cmd.Parameters.AddWithValue("@StateID", ObjUpdWarehouseModel.StateID);
                ClsCon.cmd.Parameters.AddWithValue("@PinCode", ObjUpdWarehouseModel.PinCode);
                ClsCon.cmd.Parameters.AddWithValue("@IP", ObjUpdWarehouseModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@WareHouseID", ObjUpdWarehouseModel.WareHouseID);
                // ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjWarehouseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdWarehouse = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdWarehouse);
                dtUpdWarehouse.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdWarehouse = new DataTable();
                dtUpdWarehouse.TableName = "error";
                return dtUpdWarehouse;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdWarehouse;
        }
    }
}