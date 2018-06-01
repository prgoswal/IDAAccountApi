using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class MasterDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtMaster;
        DataTable dtStatePanNoList;

        internal DataTable Master(MasterModel ObjMM)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjMM.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjMM.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjMM.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjMM.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjMM.VchType);
                ClsCon.cmd.Parameters.AddWithValue("@GSTINID", ObjMM.GSTINID);
                ClsCon.cmd.Parameters.AddWithValue("@IsAdmin", ObjMM.IsAdmin);
                ClsCon.cmd.Parameters.AddWithValue("@WarehouseID", ObjMM.WarehouseID);
                ClsCon.cmd.Parameters.AddWithValue("@HSNSACCode", ObjMM.HSNSACCode);
                
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtMaster);
                dtMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtMaster = new DataTable();
                dtMaster.TableName = "error";
                return dtMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtMaster;
        }
        
        internal DataTable BranchAddress(MasterModel ObjMM)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjMM.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjMM.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjMM.BrID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtMaster);
                dtMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtMaster = new DataTable();
                dtMaster.TableName = "error";
                return dtMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtMaster;
        }

        internal DataTable AccountHead(MasterModel ObjMM)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjMM.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjMM.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjMM.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjMM.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjMM.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtMaster);
                dtMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtMaster = new DataTable();
                dtMaster.TableName = "error";
                return dtMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtMaster;
        }
        
        internal DataTable LastVoucherNo(MasterModel ObjMM)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjMM.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjMM.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjMM.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjMM.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjMM.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtMaster);
                dtMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtMaster = new DataTable();
                dtMaster.TableName = "error";
                return dtMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtMaster;
        }

        internal DataTable LoadNarration(MasterModel ObjMM)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjMM.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjMM.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjMM.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjMM.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjMM.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtMaster);
                dtMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtMaster = new DataTable();
                dtMaster.TableName = "error";
                return dtMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtMaster;
        }

        internal DataTable LoadBankAccount(MasterModel ObjMM)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjMM.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjMM.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjMM.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjMM.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjMM.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtMaster);
                dtMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtMaster = new DataTable();
                dtMaster.TableName = "error";
                return dtMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtMaster;
        }

        internal DataTable LoadCashAccount(MasterModel ObjMM)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjMM.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjMM.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjMM.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjMM.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjMM.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtMaster);
                dtMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtMaster = new DataTable();
                dtMaster.TableName = "error";
                return dtMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtMaster;
        }

        internal DataTable IncomeHead(MasterModel ObjMM)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjMM.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjMM.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjMM.YrCD);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtMaster);
                dtMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtMaster = new DataTable();
                dtMaster.TableName = "error";
                return dtMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtMaster;
        }

        internal DataTable CheckGSTIN_Number(MasterModel ObjMM)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPSearchByAccount";
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjMM.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjMM.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjMM.BrID);
                //ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjMM.accco);


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtStatePanNoList = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtStatePanNoList);
                dtStatePanNoList.TableName = "success";
            }
            catch (Exception)
            {
                dtStatePanNoList = new DataTable();
                dtStatePanNoList.TableName = "error";
                return dtStatePanNoList;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtStatePanNoList;
        }
    }
}