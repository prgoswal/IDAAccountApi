using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdateGroupTypeDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtUpdGroupTypMaster;
        internal DataTable FillGridView(UpdateGroupMasterModel ObjPlGroupTypeModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItemGroups";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPlGroupTypeModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPlGroupTypeModel.OrgID);

                ClsCon.cmd.Parameters.AddWithValue("@GrType", ObjPlGroupTypeModel.GrType);
                // ClsCon.cmd.Parameters.AddWithValue("@YrCD", ObjPlGroupTypeModel.YrCD);
                // ClsCon.cmd.Parameters.AddWithValue("@VchType", ObjWarehouseModel.VchType);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdGroupTypMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdGroupTypMaster);
                dtUpdGroupTypMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdGroupTypMaster = new DataTable();
                dtUpdGroupTypMaster.TableName = "error";
                return dtUpdGroupTypMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdGroupTypMaster;
        }

        internal DataTable SaveProcessGroupItem(UpdateGroupMasterModel ObjPlGroupTypeModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPItemGroups";

                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.Parameters.AddWithValue("@Ind", ObjPlGroupTypeModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", ObjPlGroupTypeModel.OrgID);

                ClsCon.cmd.Parameters.AddWithValue("@GrType", ObjPlGroupTypeModel.GrType);
                ClsCon.cmd.Parameters.AddWithValue("@GrDesc", ObjPlGroupTypeModel.GrDesc);
                ClsCon.cmd.Parameters.AddWithValue("@ItemGroupID", ObjPlGroupTypeModel.ItemGroupID);
                ClsCon.cmd.Parameters.AddWithValue("@IP", ObjPlGroupTypeModel.IP);

                ClsCon.cmd.Parameters.AddWithValue("@User", ObjPlGroupTypeModel.User);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdGroupTypMaster = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdGroupTypMaster);
                dtUpdGroupTypMaster.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdGroupTypMaster = new DataTable();
                dtUpdGroupTypMaster.TableName = "error";
                return dtUpdGroupTypMaster;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdGroupTypMaster;
        }
    }
}