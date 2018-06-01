using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class ItemMasterDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtItemMaster;

        internal DataTable LoadItemGroup(ItemMasterModel objIMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItemGroups";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objIMModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objIMModel.OrgID);
                
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtItemMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtItemMaster);
                dtItemMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtItemMaster = new DataTable();
                dtItemMaster.TableName = "error";
                return dtItemMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtItemMaster;
        }

        internal DataTable LoadItemUnit(ItemMasterModel objIMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objIMModel.Ind);
                
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtItemMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtItemMaster);
                dtItemMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtItemMaster = new DataTable();
                dtItemMaster.TableName = "error";
                return dtItemMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtItemMaster;
        }

        internal DataTable LoadWarehouse(ItemMasterModel objIMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objIMModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objIMModel.OrgID);
                
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtItemMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtItemMaster);
                dtItemMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtItemMaster = new DataTable();
                dtItemMaster.TableName = "error";
                return dtItemMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtItemMaster;
        }

        internal DataTable LoadTaxRate(ItemMasterModel objIMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objIMModel.Ind);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtItemMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtItemMaster);
                dtItemMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtItemMaster = new DataTable();
                dtItemMaster.TableName = "error";
                return dtItemMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtItemMaster;
        }

        internal DataTable LoadHSNSCDesc(ItemMasterModel objIMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objIMModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@HSNSACCode", objIMModel.HSNSACCode1);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtItemMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtItemMaster);
                dtItemMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtItemMaster = new DataTable();
                dtItemMaster.TableName = "error";
                return dtItemMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtItemMaster;
        }

        internal DataTable SaveItem(ItemMasterModel objIMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItems";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objIMModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objIMModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objIMModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@ItemMainID", objIMModel.ItemMainID);
                ClsCon.cmd.Parameters.AddWithValue("@ItemSubID", objIMModel.ItemSubID);
                ClsCon.cmd.Parameters.AddWithValue("@ItemMinorID", objIMModel.ItemMinorID);
                ClsCon.cmd.Parameters.AddWithValue("@ItemGroupID", objIMModel.ItemGroupID);
                ClsCon.cmd.Parameters.AddWithValue("@ItemName", objIMModel.ItemName);
                ClsCon.cmd.Parameters.AddWithValue("@ItemShortName", objIMModel.ItemShortName);
                ClsCon.cmd.Parameters.AddWithValue("@ItemUnitID", objIMModel.ItemUnitID);
                ClsCon.cmd.Parameters.AddWithValue("@GoodServiceInd", objIMModel.GoodServiceInd);
                ClsCon.cmd.Parameters.AddWithValue("@ItemSellingRate", objIMModel.ItemSellingRate);
                ClsCon.cmd.Parameters.AddWithValue("@ItemDescription", objIMModel.ItemDesc);
                ClsCon.cmd.Parameters.AddWithValue("@HSNSACCode", objIMModel.HSNSACCode);
                ClsCon.cmd.Parameters.AddWithValue("@ItemCode", objIMModel.ItemCode);
                ClsCon.cmd.Parameters.AddWithValue("@User", objIMModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objIMModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@TaxRate", objIMModel.TaxRate);
                ClsCon.cmd.Parameters.AddWithValue("@TaxRateDesc", objIMModel.TaxRateDesc); 
                ClsCon.cmd.Parameters.AddWithValue("@ItemMinorUnitID", objIMModel.ItemMinorUnitID);
                ClsCon.cmd.Parameters.AddWithValue("@ItemMinorUnitQyt", objIMModel.ItemMinorUnitQyt);
                ClsCon.cmd.Parameters.AddWithValue("@StockMaintainInd", objIMModel.StockMaintainInd);
                ClsCon.cmd.Parameters.AddWithValue("@TblItemOpening", objIMModel.DtItemOpening);
                
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtItemMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtItemMaster);
                dtItemMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtItemMaster = new DataTable();
                dtItemMaster.TableName = "error";
                return dtItemMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtItemMaster;
        }
    }
}