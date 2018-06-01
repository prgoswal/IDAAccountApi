using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UserDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtCUDA;
        DataSet dsMatchLoginDetails;

        internal DataSet BindUCBranch(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUCModel.OrgID);

                con = ClsCon.SqlConn();
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsMatchLoginDetails = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsMatchLoginDetails);
                dsMatchLoginDetails.DataSetName = "success";
            }
            catch (Exception)
            {
                dsMatchLoginDetails = new DataSet();
                dsMatchLoginDetails.DataSetName = "error";
                return dsMatchLoginDetails;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsMatchLoginDetails;
        }

        internal DataTable BindUCGrid(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUCModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUCModel.BrID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception ex)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }

        internal DataTable SaveUser(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUCModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUCModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@AcessName", objUCModel.AcessName);
                ClsCon.cmd.Parameters.AddWithValue("@ContactNo", objUCModel.ContactNo);
                ClsCon.cmd.Parameters.AddWithValue("@ContactAddr", objUCModel.ContactAddr);
                ClsCon.cmd.Parameters.AddWithValue("@DesignationID", objUCModel.DesignationID);
                ClsCon.cmd.Parameters.AddWithValue("@Designation", objUCModel.Designation);
                ClsCon.cmd.Parameters.AddWithValue("@ExpiryDate", objUCModel.ExpiryDate);
                ClsCon.cmd.Parameters.AddWithValue("@AdminLevel", objUCModel.AdminLevel);
                ClsCon.cmd.Parameters.AddWithValue("@Remark", objUCModel.Remark);
                ClsCon.cmd.Parameters.AddWithValue("@LoginID", objUCModel.LoginID);
                ClsCon.cmd.Parameters.AddWithValue("@LoginPass", objUCModel.LoginPass);
                ClsCon.cmd.Parameters.AddWithValue("@DepartmentID", objUCModel.DepartmentID);
                ClsCon.cmd.Parameters.AddWithValue("@SubDeptID", objUCModel.SubDeptID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }

        internal DataTable MatchLoginDetails(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@LoginID", objUCModel.LoginID);
                ClsCon.cmd.Parameters.AddWithValue("@LoginPass", objUCModel.LoginPass);
                ClsCon.cmd.Parameters.AddWithValue("@GUID", objUCModel.GUID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }

        internal DataTable ChangeUserStatus(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUCModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUCModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", objUCModel.UserID);
                ClsCon.cmd.Parameters.AddWithValue("@ActiveInd", objUCModel.ActiveInd);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }

        internal DataTable LoadBranch(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPMasters";
                ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUCModel.OrgID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }

        internal DataTable ChangePassword(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", objUCModel.UserID);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUCModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUCModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@ChangePass", objUCModel.ChangePass);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }

        internal DataTable UserLoginDetails(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@LoginID", objUCModel.LoginID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }

        internal DataTable Logout(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@LoginID", objUCModel.LoginID);
                ClsCon.cmd.Parameters.AddWithValue("@LoginPass", objUCModel.LoginPass);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }

        internal DataTable CheckGuidDetails(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUCModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUCModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", objUCModel.UserID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }

        internal DataTable SaveLogDetails(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", objUCModel.UserID);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUCModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUCModel.BrID);
                ClsCon.cmd.Parameters.AddWithValue("@GUID", objUCModel.GUID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }

        internal DataTable GetUserDetails(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUCModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@BrID", objUCModel.BrID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;

        }

        internal DataTable SaveUserRightsDetails(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUCModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", objUCModel.UserID);
                ClsCon.cmd.Parameters.AddWithValue("@MenuID", objUCModel.MenuID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }

        internal DataTable DeleteUserRights(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUCModel.OrgID);
                ClsCon.cmd.Parameters.AddWithValue("@UserID", objUCModel.UserID);


                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }

        internal DataTable GetAllottedUserDetails(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUCModel.OrgID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }

        internal DataTable GetAllottedMenuDetails(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);

                ClsCon.cmd.Parameters.AddWithValue("@UserID", objUCModel.UserID);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUCModel.OrgID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }

        internal DataSet CheckUserRights(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@LoginID", objUCModel.LoginID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsMatchLoginDetails = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsMatchLoginDetails);
                dsMatchLoginDetails.DataSetName = "success";
            }
            catch (Exception)
            {
                dsMatchLoginDetails = new DataSet();
                dsMatchLoginDetails.DataSetName = "error";
                return dsMatchLoginDetails;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsMatchLoginDetails;
        }

        internal DataTable GetBudgetFinancialYear(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPBudgetFinancialYear";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }

        internal DataTable LoadNewFinancialYear(UserModel objUCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUser";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@OrgID", objUCModel.OrgID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtCUDA = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtCUDA);
                dtCUDA.TableName = "success";
            }
            catch (Exception)
            {
                dtCUDA = new DataTable();
                dtCUDA.TableName = "error";
                return dtCUDA;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtCUDA;
        }
    }
}