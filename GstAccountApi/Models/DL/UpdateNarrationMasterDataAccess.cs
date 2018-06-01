using GstAccountApi.Models;
using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace GstAccountApi.Controllers
{
    class UpdateNarrationMasterDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtNarrationVoucherType, dtUpdateNarration;
        internal DataTable LoadVoucherType(UpdateNarrationModel ObjUpdNrraMastModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", ObjUpdNrraMastModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjUpdNrraMastModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjUpdNrraMastModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjUpdNrraMastModel.YrCD);
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

        internal DataTable FillGridView(UpdateNarrationModel ObjUpdNrraMastModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPNarration";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjUpdNrraMastModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjUpdNrraMastModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjUpdNrraMastModel.DocTypeID);
             
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

        internal DataTable UpdateNarration(UpdateNarrationModel ObjUpdNrraMastModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPNarration";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjUpdNrraMastModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjUpdNrraMastModel.OrgID);
             
                ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjUpdNrraMastModel.DocTypeID);
                ClsCon.cmd.Parameters.AddWithValue("@NarrDesc", ObjUpdNrraMastModel.NarrDesc);

                ClsCon.cmd.Parameters.AddWithValue("@NarrationID", ObjUpdNrraMastModel.NarrationID);
                ClsCon.cmd.Parameters.AddWithValue("@User", ObjUpdNrraMastModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", ObjUpdNrraMastModel.IP);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdateNarration = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdateNarration);
                dtUpdateNarration.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdateNarration = new DataTable();
                dtUpdateNarration.TableName = "error";
                return dtUpdateNarration;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdateNarration;
        } 
    }
}
