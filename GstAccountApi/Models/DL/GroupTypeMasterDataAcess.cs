using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class GroupTypeMasterDataAcess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtGroupTypMaster;
        internal DataTable FillMainGrpddl(GroupTypeMasterModel ObjPlGroupTypeModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItemGroups";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPlGroupTypeModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPlGroupTypeModel.OrgID);
                //ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPlGroupTypeModel.BrID);
               // ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPlGroupTypeModel.YrCD);
                // ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjWarehouseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtGroupTypMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtGroupTypMaster);
                dtGroupTypMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtGroupTypMaster = new DataTable();
                dtGroupTypMaster.TableName = "error";
                return dtGroupTypMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtGroupTypMaster;
        }

        internal DataTable SaveProcessGroupItem(GroupTypeMasterModel ObjPlGroupTypeModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItemGroups";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPlGroupTypeModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPlGroupTypeModel.OrgID);
               // ClsCon.cmd.Parameters.AddWithValue("@BrID", ObjPlGroupTypeModel.BrID);
               // ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPlGroupTypeModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@GrType", ObjPlGroupTypeModel.GrType);
                ClsCon.cmd.Parameters.AddWithValue("@GrDesc", ObjPlGroupTypeModel.GrDesc);
                ClsCon.cmd.Parameters.AddWithValue("@ParentID", ObjPlGroupTypeModel.ParentID);
                ClsCon.cmd.Parameters.AddWithValue("@IP", ObjPlGroupTypeModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@User", ObjPlGroupTypeModel.User);
                // ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjWarehouseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtGroupTypMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtGroupTypMaster);
                dtGroupTypMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtGroupTypMaster = new DataTable();
                dtGroupTypMaster.TableName = "error";
                return dtGroupTypMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtGroupTypMaster;
        }
    }
}