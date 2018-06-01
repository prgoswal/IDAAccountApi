using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{ 
     

    public class NarrationMasterDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtNarrationVoucherType, dtSaveNarration;
        internal DataTable LoadVoucherType(NarrationMasterModel ObjNrrationMastModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjNrrationMastModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjNrrationMastModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjNrrationMastModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjNrrationMastModel.YrCD);
                // ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjWarehouseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtNarrationVoucherType = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtNarrationVoucherType);
                dtNarrationVoucherType.TableName = "success";
            }
            catch (Exception)
            {
                dtNarrationVoucherType = new DataTable();
                dtNarrationVoucherType.TableName = "error";
                return dtNarrationVoucherType;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtNarrationVoucherType;
        }


        internal DataTable FillGridView(NarrationMasterModel ObjNrrationMastModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPNarration";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjNrrationMastModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjNrrationMastModel.OrgID);
               // ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjNrrationMastModel.BrID);
              // ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjNrrationMastModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjNrrationMastModel.DocTypeID);
                // ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjWarehouseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtNarrationVoucherType = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtNarrationVoucherType);
                dtNarrationVoucherType.TableName = "success";
            }
            catch (Exception)
            {
                dtNarrationVoucherType = new DataTable();
                dtNarrationVoucherType.TableName = "error";
                return dtNarrationVoucherType;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtNarrationVoucherType;
        }


        internal DataTable SaveNarration(NarrationMasterModel ObjNrrationMastModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPNarration";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjNrrationMastModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjNrrationMastModel.OrgID);
                // ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjNrrationMastModel.BrID);
               // ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjNrrationMastModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjNrrationMastModel.DocTypeID);
                ClsCon.cmd.Parameters.AddWithValue("@NarrDesc", ObjNrrationMastModel.NarrDesc);
                ClsCon.cmd.Parameters.AddWithValue("@IP", ObjNrrationMastModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@User", ObjNrrationMastModel.User);

                // ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjWarehouseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtSaveNarration = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtSaveNarration);
                dtSaveNarration.TableName = "success";
            }
            catch (Exception)
            {
                dtSaveNarration = new DataTable();
                dtSaveNarration.TableName = "error";
                return dtSaveNarration;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtSaveNarration;
        } 


        }
    }
