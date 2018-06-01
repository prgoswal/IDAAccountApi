using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdateItemMasterDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtUpdItemMaster;

        internal DataTable LoadItems(UpdateItemMasterModel objUIMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateItems";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUIMModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUIMModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUIMModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUIMModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdItemMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdItemMaster);
                dtUpdItemMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdItemMaster = new DataTable();
                dtUpdItemMaster.TableName = "error";
                return dtUpdItemMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdItemMaster;
        }

        internal DataTable LoadItemGroup(UpdateItemMasterModel objUIMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItemGroups";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUIMModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUIMModel.OrgID);
                //ClsCon.cmd.Parameters.AddWithValue("@BrID", objUIMModel.BrID);
                //ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUIMModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdItemMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdItemMaster);
                dtUpdItemMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdItemMaster = new DataTable();
                dtUpdItemMaster.TableName = "error";
                return dtUpdItemMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdItemMaster;
        }

        internal DataTable LoadItemUnit(UpdateItemMasterModel objUIMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUIMModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUIMModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUIMModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUIMModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdItemMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdItemMaster);
                dtUpdItemMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdItemMaster = new DataTable();
                dtUpdItemMaster.TableName = "error";
                return dtUpdItemMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdItemMaster;
        }

        internal DataTable LoadWarehouse(UpdateItemMasterModel objUIMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUIMModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUIMModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUIMModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUIMModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdItemMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdItemMaster);
                dtUpdItemMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdItemMaster = new DataTable();
                dtUpdItemMaster.TableName = "error";
                return dtUpdItemMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdItemMaster;
        }
        internal DataTable LoadTaxRate(UpdateItemMasterModel objUIMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUIMModel.Ind);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdItemMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdItemMaster);
                dtUpdItemMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdItemMaster = new DataTable();
                dtUpdItemMaster.TableName = "error";
                return dtUpdItemMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdItemMaster;
        }

        internal DataTable LoadHSNSCDesc(UpdateItemMasterModel objUIMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUIMModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@HSNSACCode", objUIMModel.HSNSACCode1);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUIMModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUIMModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUIMModel.YrCD);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdItemMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdItemMaster);
                dtUpdItemMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdItemMaster = new DataTable();
                dtUpdItemMaster.TableName = "error";
                return dtUpdItemMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdItemMaster;
        }

        internal DataTable LoadItemInfo(UpdateItemMasterModel objUIMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateItems";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUIMModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", objUIMModel.ItemID);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUIMModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUIMModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUIMModel.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdItemMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdItemMaster);
                dtUpdItemMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdItemMaster = new DataTable();
                dtUpdItemMaster.TableName = "error";
                return dtUpdItemMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdItemMaster;
        }

        internal DataTable UpdateItem(UpdateItemMasterModel objUIMModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateItems";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUIMModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUIMModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUIMModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUIMModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@ItemID", objUIMModel.ItemID);
                ClsCon.cmd.Parameters.AddWithValue("@ItemName", objUIMModel.ItemName);
                ClsCon.cmd.Parameters.AddWithValue("@ItemShortName", objUIMModel.ItemShortName);
                ClsCon.cmd.Parameters.AddWithValue("@ItemUnitID", objUIMModel.ItemUnitID);
                ClsCon.cmd.Parameters.AddWithValue("@GoodServiceInd", objUIMModel.GoodServiceInd);
                ClsCon.cmd.Parameters.AddWithValue("@ItemSellingRate", objUIMModel.ItemSellingRate);
                ClsCon.cmd.Parameters.AddWithValue("@ItemDescription", objUIMModel.ItemDesc); 

                ClsCon.cmd.Parameters.AddWithValue("@HSNSACCode", objUIMModel.HSNSACCode);

                ClsCon.cmd.Parameters.AddWithValue("@TaxRate", objUIMModel.TaxRate);
                ClsCon.cmd.Parameters.AddWithValue("@TaxRateType", objUIMModel.TaxRateDesc);
                ClsCon.cmd.Parameters.AddWithValue("@ItemMinorUnitID", objUIMModel.ItemMinorUnitID);
                ClsCon.cmd.Parameters.AddWithValue("@ItemMinorUnitQyt", objUIMModel.ItemMinorUnitQyt);
                //ClsCon.cmd.Parameters.AddWithValue("@StockMaintainInd", objUIMModel.StockMaintainInd);
                

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdItemMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdItemMaster);
                dtUpdItemMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdItemMaster = new DataTable();
                dtUpdItemMaster.TableName = "error";
                return dtUpdItemMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdItemMaster;
        }
    }
}