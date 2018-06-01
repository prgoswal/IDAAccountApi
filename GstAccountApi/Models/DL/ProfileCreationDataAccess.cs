using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class ProfileCreationDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtProfileCreation;
        DataSet dsProfileCreation;

        //internal DataTable LoadOrgType(ProfileCreationModel objPCModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objPCModel.Ind);
                
        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtProfileCreation = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtProfileCreation);
        //        dtProfileCreation.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtProfileCreation = new DataTable();
        //        dtProfileCreation.TableName = "error";
        //        return dtProfileCreation;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtProfileCreation;
        //}

        //internal DataTable LoadBusinessNature(ProfileCreationModel objPCModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objPCModel.Ind);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtProfileCreation = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtProfileCreation);
        //        dtProfileCreation.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtProfileCreation = new DataTable();
        //        dtProfileCreation.TableName = "error";
        //        return dtProfileCreation;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtProfileCreation;
        //}

        //internal DataTable LoadBusinessType(ProfileCreationModel objPCModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objPCModel.Ind);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtProfileCreation = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtProfileCreation);
        //        dtProfileCreation.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtProfileCreation = new DataTable();
        //        dtProfileCreation.TableName = "error";
        //        return dtProfileCreation;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtProfileCreation;
        //}

        //internal DataTable LoadCopyType(ProfileCreationModel objPCModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objPCModel.Ind);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtProfileCreation = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtProfileCreation);
        //        dtProfileCreation.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtProfileCreation = new DataTable();
        //        dtProfileCreation.TableName = "error";
        //        return dtProfileCreation;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtProfileCreation;
        //}

        //internal DataTable LoadState(ProfileCreationModel objPCModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objPCModel.Ind);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtProfileCreation = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtProfileCreation);
        //        dtProfileCreation.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtProfileCreation = new DataTable();
        //        dtProfileCreation.TableName = "error";
        //        return dtProfileCreation;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtProfileCreation;
        //}

        //internal DataTable LoadReportFormats(ProfileCreationModel objPCModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPClientProfile";
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", objPCModel.Ind);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtProfileCreation = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtProfileCreation);
        //        dtProfileCreation.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtProfileCreation = new DataTable();
        //        dtProfileCreation.TableName = "error";
        //        return dtProfileCreation;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtProfileCreation;
        //}

        internal DataSet BindAllProfileCreationDDL(ProfileCreationModel objPCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPClientProfile";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objPCModel.Ind);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsProfileCreation = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsProfileCreation);
                dsProfileCreation.DataSetName = "success";
                dsProfileCreation.Tables[0].TableName = "OrganizationType";
                dsProfileCreation.Tables[1].TableName = "BusinessNature";
                dsProfileCreation.Tables[2].TableName = "BusinessType";
                dsProfileCreation.Tables[3].TableName = "CopyType";
                dsProfileCreation.Tables[4].TableName = "State";
                dsProfileCreation.Tables[5].TableName = "ReportFormats";
                dsProfileCreation.Tables[6].TableName = "CompositionCategory";
            }
            catch (Exception)
            {
                dsProfileCreation = new DataSet();
                dsProfileCreation.DataSetName = "error";
                return dsProfileCreation;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsProfileCreation;
        }

        internal DataTable SaveCompanyProfile(ProfileCreationModel objPCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPClientProfile";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objPCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@CompName", objPCModel.CompName);
                ClsCon.cmd.Parameters.AddWithValue("@ShortName", objPCModel.ShortName);
                ClsCon.cmd.Parameters.AddWithValue("@OrgType", objPCModel.OrgType);
                ClsCon.cmd.Parameters.AddWithValue("@BusiNature", objPCModel.BusiNature);
                ClsCon.cmd.Parameters.AddWithValue("@BusiType", objPCModel.BusiType);
                ClsCon.cmd.Parameters.AddWithValue("@Addr", objPCModel.Addr);
                ClsCon.cmd.Parameters.AddWithValue("@City", objPCModel.City);
                ClsCon.cmd.Parameters.AddWithValue("@State", objPCModel.State);
                ClsCon.cmd.Parameters.AddWithValue("@Pin", objPCModel.Pin);
                ClsCon.cmd.Parameters.AddWithValue("@Phone", objPCModel.Phone);
                ClsCon.cmd.Parameters.AddWithValue("@Fax", objPCModel.Fax);
                ClsCon.cmd.Parameters.AddWithValue("@EMail", objPCModel.EMail);
                ClsCon.cmd.Parameters.AddWithValue("@PAN", objPCModel.PAN);
                ClsCon.cmd.Parameters.AddWithValue("@TAN", objPCModel.TAN);
                ClsCon.cmd.Parameters.AddWithValue("@CIN", objPCModel.CIN);
                ClsCon.cmd.Parameters.AddWithValue("@IECode", objPCModel.IECode);
                ClsCon.cmd.Parameters.AddWithValue("@ExportCtg", objPCModel.ExportCtg);
                ClsCon.cmd.Parameters.AddWithValue("@ContactName", objPCModel.ContactName);
                ClsCon.cmd.Parameters.AddWithValue("@ContactDesg", objPCModel.ContactDesg);
                ClsCon.cmd.Parameters.AddWithValue("@ContactEmail", objPCModel.ContactEmail);
                ClsCon.cmd.Parameters.AddWithValue("@ContactMobile", objPCModel.ContactMobile);
                ClsCon.cmd.Parameters.AddWithValue("@AltPerson", objPCModel.AltPerson);
                ClsCon.cmd.Parameters.AddWithValue("@AltPersonDesg", objPCModel.AltPersonDesg);
                ClsCon.cmd.Parameters.AddWithValue("@AltPersonEmail", objPCModel.AltPersonEmail);
                ClsCon.cmd.Parameters.AddWithValue("@AltMobile", objPCModel.AltMobile);
                ClsCon.cmd.Parameters.AddWithValue("@Composition", objPCModel.Composition);
                ClsCon.cmd.Parameters.AddWithValue("@CompositionDate", objPCModel.CompositionDate);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objPCModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@RegDate", objPCModel.RegDate);
                ClsCon.cmd.Parameters.AddWithValue("@RegAddr", objPCModel.RegAddr);
                ClsCon.cmd.Parameters.AddWithValue("@RegCity", objPCModel.RegCity);
                ClsCon.cmd.Parameters.AddWithValue("@RegState", objPCModel.RegState);
                ClsCon.cmd.Parameters.AddWithValue("@RegPin", objPCModel.RegPin);
                ClsCon.cmd.Parameters.AddWithValue("@RegAuthPerson", objPCModel.RegAuthPerson);
                ClsCon.cmd.Parameters.AddWithValue("@RegAuthDesg", objPCModel.RegAuthDesg);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceNoSeries", objPCModel.InvoiceNoSeries);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceOnPrePrinted", objPCModel.InvoiceOnPrePrinted);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceNo", objPCModel.InvoiceNo);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objPCModel.YrCD);
                ClsCon.cmd.Parameters.AddWithValue("@User", objPCModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objPCModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCaption1", objPCModel.InvoiceCaption1);
                ClsCon.cmd.Parameters.AddWithValue("@InvoicePrint1", objPCModel.InvoicePrint1);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCaption2", objPCModel.InvoiceCaption2);
                ClsCon.cmd.Parameters.AddWithValue("@InvoicePrint2", objPCModel.InvoicePrint2);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCaption3", objPCModel.InvoiceCaption3);
                ClsCon.cmd.Parameters.AddWithValue("@InvoicePrint3", objPCModel.InvoicePrint3);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCaption4", objPCModel.InvoiceCaption4);
                ClsCon.cmd.Parameters.AddWithValue("@InvoicePrint4", objPCModel.InvoicePrint4);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCaption5", objPCModel.InvoiceCaption5);
                ClsCon.cmd.Parameters.AddWithValue("@InvoicePrint5", objPCModel.InvoicePrint5);
                ClsCon.cmd.Parameters.AddWithValue("@CompanyLogo", objPCModel.CompanyLogo);
                ClsCon.cmd.Parameters.AddWithValue("@ReportFormat", objPCModel.ReportFormat);

                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCopyNo", objPCModel.InvoiceCopyNo);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCopy1Header", objPCModel.InvoiceCopy1Header);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCopy2Header", objPCModel.InvoiceCopy2Header);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCopy3Header", objPCModel.InvoiceCopy3Header);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCopy4Header", objPCModel.InvoiceCopy4Header);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCopy5Header", objPCModel.InvoiceCopy5Header);

                ClsCon.cmd.Parameters.AddWithValue("@CompositionCategoryID", objPCModel.CompositionCategoryID);
                ClsCon.cmd.Parameters.AddWithValue("@CompositionTaxRate", objPCModel.CompositionTaxRate);
                ClsCon.cmd.Parameters.AddWithValue("@StcokMaintaneByMinorUnit", objPCModel.StcokMaintaneByMinorUnit);

                ClsCon.cmd.Parameters.AddWithValue("@CompanyType", objPCModel.CompanyType);
                ClsCon.cmd.Parameters.AddWithValue("@TurnoverID", objPCModel.TurnoverID);
                ClsCon.cmd.Parameters.AddWithValue("@TurnoverDescription", objPCModel.TurnoverDescription);
                ClsCon.cmd.Parameters.AddWithValue("@PrintHSNSACCode", objPCModel.PrintHSNSACCode);

                ClsCon.cmd.Parameters.AddWithValue("@BankName", objPCModel.BankName);
                ClsCon.cmd.Parameters.AddWithValue("@IFSCCode", objPCModel.IFSCCode);
                ClsCon.cmd.Parameters.AddWithValue("@AccountNumber", objPCModel.AccountNumber);
                ClsCon.cmd.Parameters.AddWithValue("@UnRegistered", objPCModel.UnRegistered);

                ClsCon.cmd.Parameters.AddWithValue("@SSIsTaken", objPCModel.SSIsTaken);
                ClsCon.cmd.Parameters.AddWithValue("@BSObtain", objPCModel.BSObtain);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objPCModel.CCCode);
                ClsCon.cmd.Parameters.AddWithValue("@BankPayChqSeriesInd", objPCModel.BankPayChqSeriesInd); 

                ClsCon.cmd.Parameters.AddWithValue("@TblTerms", objPCModel.DtTerms);
                ClsCon.cmd.Parameters.AddWithValue("@TblSeries", objPCModel.DtSeries);
                
                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtProfileCreation = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtProfileCreation);
                dtProfileCreation.TableName = "success";
            }
            catch (Exception)
            {
                dtProfileCreation = new DataTable();
                dtProfileCreation.TableName = "error";
                return dtProfileCreation;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtProfileCreation;
        }
    }
}