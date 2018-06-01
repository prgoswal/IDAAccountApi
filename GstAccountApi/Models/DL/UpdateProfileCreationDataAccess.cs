using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GstAccountApi.Models.DL
{
    public class UpdateProfileCreationDataAccess
    {
        SqlConnection con = new SqlConnection();
        DataTable dtUpdProfileCreation;
        DataSet dsUpdProfileCreation;

        //internal DataTable LoadOrgType(UpdateProfileCreationModel objUPCModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUPCModel.Ind);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtUpdProfileCreation = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtUpdProfileCreation);
        //        dtUpdProfileCreation.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtUpdProfileCreation = new DataTable();
        //        dtUpdProfileCreation.TableName = "error";
        //        return dtUpdProfileCreation;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtUpdProfileCreation;
        //}

        //internal DataTable LoadBusinessNature(UpdateProfileCreationModel objUPCModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUPCModel.Ind);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtUpdProfileCreation = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtUpdProfileCreation);
        //        dtUpdProfileCreation.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtUpdProfileCreation = new DataTable();
        //        dtUpdProfileCreation.TableName = "error";
        //        return dtUpdProfileCreation;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtUpdProfileCreation;
        //}

        //internal DataTable LoadBusinessType(UpdateProfileCreationModel objUPCModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUPCModel.Ind);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtUpdProfileCreation = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtUpdProfileCreation);
        //        dtUpdProfileCreation.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtUpdProfileCreation = new DataTable();
        //        dtUpdProfileCreation.TableName = "error";
        //        return dtUpdProfileCreation;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtUpdProfileCreation;
        //}

        //internal DataTable LoadCopyType(UpdateProfileCreationModel objUPCModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUPCModel.Ind);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtUpdProfileCreation = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtUpdProfileCreation);
        //        dtUpdProfileCreation.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtUpdProfileCreation = new DataTable();
        //        dtUpdProfileCreation.TableName = "error";
        //        return dtUpdProfileCreation;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtUpdProfileCreation;
        //}

        //internal DataTable LoadState(UpdateProfileCreationModel objUPCModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPMasters";
        //        ClsCon.cmd.Parameters.AddWithValue("@DataInd", objUPCModel.Ind);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtUpdProfileCreation = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtUpdProfileCreation);
        //        dtUpdProfileCreation.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtUpdProfileCreation = new DataTable();
        //        dtUpdProfileCreation.TableName = "error";
        //        return dtUpdProfileCreation;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtUpdProfileCreation;
        //}

        //internal DataTable LoadReportFormats(UpdateProfileCreationModel objUPCModel)
        //{
        //    try
        //    {
        //        ClsCon.cmd = new SqlCommand();
        //        ClsCon.cmd.CommandType = CommandType.StoredProcedure;
        //        ClsCon.cmd.CommandText = "SPClientProfile";
        //        ClsCon.cmd.Parameters.AddWithValue("@Ind", objUPCModel.Ind);

        //        con = ClsCon.SqlConn();
        //        ClsCon.cmd.Connection = con;
        //        dtUpdProfileCreation = new DataTable();
        //        ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
        //        ClsCon.da.Fill(dtUpdProfileCreation);
        //        dtUpdProfileCreation.TableName = "success";
        //    }
        //    catch (Exception)
        //    {
        //        dtUpdProfileCreation = new DataTable();
        //        dtUpdProfileCreation.TableName = "error";
        //        return dtUpdProfileCreation;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        ClsCon.da.Dispose();
        //        ClsCon.cmd.Dispose();
        //    }
        //    return dtUpdProfileCreation;
        //}

        internal DataSet BindAllUpdProfileCreationDDL(UpdateProfileCreationModel objUPCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateClientProfile";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUPCModel.Ind);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dsUpdProfileCreation = new DataSet();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsUpdProfileCreation);
                dsUpdProfileCreation.DataSetName = "success";
                dsUpdProfileCreation.Tables[0].TableName = "OrganizationType";
                dsUpdProfileCreation.Tables[1].TableName = "BusinessNature";
                dsUpdProfileCreation.Tables[2].TableName = "BusinessType";
                dsUpdProfileCreation.Tables[3].TableName = "CopyType";
                dsUpdProfileCreation.Tables[4].TableName = "State";
                dsUpdProfileCreation.Tables[5].TableName = "ReportFormats";
                dsUpdProfileCreation.Tables[6].TableName = "CompositionCategory";
            }
            catch (Exception)
            {
                dsUpdProfileCreation = new DataSet();
                dsUpdProfileCreation.DataSetName = "error";
                return dsUpdProfileCreation;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsUpdProfileCreation;
        }

        internal DataSet LoadProfileCreationInfo(UpdateProfileCreationModel objUPCModel)
        {
            DataSet dsLoadPCInfo = new DataSet();
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPClientProfile";
                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUPCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@CompanyID", objUPCModel.CompanyID);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dsLoadPCInfo);
                dsLoadPCInfo.Tables[0].TableName = "ProfileCreationInfo";
                dsLoadPCInfo.Tables[1].TableName = "Terms";
            }
            catch (Exception)
            {
                dtUpdProfileCreation = new DataTable();
                dtUpdProfileCreation.TableName = "error";
                dsLoadPCInfo.Tables.Add(dtUpdProfileCreation);
                return dsLoadPCInfo;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dsLoadPCInfo;
        }

        internal DataTable UpdateCompanyProfile(UpdateProfileCreationModel objUPCModel)
        {
            try
            {
                ClsCon.cmd = new SqlCommand();
                ClsCon.cmd.CommandType = CommandType.StoredProcedure;
                ClsCon.cmd.CommandText = "SPUpdateClientProfile";

                ClsCon.cmd.Parameters.AddWithValue("@Ind", objUPCModel.Ind);
                ClsCon.cmd.Parameters.AddWithValue("@CompanyID", objUPCModel.CompanyID);
                ClsCon.cmd.Parameters.AddWithValue("@CompName", objUPCModel.CompName);
                ClsCon.cmd.Parameters.AddWithValue("@ShortName", objUPCModel.ShortName);
                ClsCon.cmd.Parameters.AddWithValue("@OrgType", objUPCModel.OrgType);
                ClsCon.cmd.Parameters.AddWithValue("@BusiNature", objUPCModel.BusiNature);
                ClsCon.cmd.Parameters.AddWithValue("@BusiType", objUPCModel.BusiType);
                ClsCon.cmd.Parameters.AddWithValue("@Addr", objUPCModel.Addr);
                ClsCon.cmd.Parameters.AddWithValue("@City", objUPCModel.City);
                ClsCon.cmd.Parameters.AddWithValue("@State", objUPCModel.State);
                ClsCon.cmd.Parameters.AddWithValue("@Pin", objUPCModel.Pin);

                ClsCon.cmd.Parameters.AddWithValue("@Phone", objUPCModel.Phone);
                ClsCon.cmd.Parameters.AddWithValue("@Fax", objUPCModel.Fax);
                ClsCon.cmd.Parameters.AddWithValue("@EMail", objUPCModel.EMail);
                ClsCon.cmd.Parameters.AddWithValue("@PAN", objUPCModel.PAN);
                ClsCon.cmd.Parameters.AddWithValue("@TAN", objUPCModel.TAN);
                ClsCon.cmd.Parameters.AddWithValue("@CIN", objUPCModel.CIN);
                ClsCon.cmd.Parameters.AddWithValue("@IECode", objUPCModel.IECode);
                ClsCon.cmd.Parameters.AddWithValue("@ExportCtg", objUPCModel.ExportCtg);
                ClsCon.cmd.Parameters.AddWithValue("@ContactName", objUPCModel.ContactName);
                ClsCon.cmd.Parameters.AddWithValue("@ContactDesg", objUPCModel.ContactDesg);

                ClsCon.cmd.Parameters.AddWithValue("@ContactEmail", objUPCModel.ContactEmail);
                ClsCon.cmd.Parameters.AddWithValue("@ContactMobile", objUPCModel.ContactMobile);
                ClsCon.cmd.Parameters.AddWithValue("@AltPerson", objUPCModel.AltPerson);
                ClsCon.cmd.Parameters.AddWithValue("@AltPersonDesg", objUPCModel.AltPersonDesg);
                ClsCon.cmd.Parameters.AddWithValue("@AltPersonEmail", objUPCModel.AltPersonEmail);
                ClsCon.cmd.Parameters.AddWithValue("@AltMobile", objUPCModel.AltMobile);
                ClsCon.cmd.Parameters.AddWithValue("@Composition", objUPCModel.Composition);
                ClsCon.cmd.Parameters.AddWithValue("@CompositionDate", objUPCModel.CompositionDate);
                ClsCon.cmd.Parameters.AddWithValue("@GSTIN", objUPCModel.GSTIN);
                ClsCon.cmd.Parameters.AddWithValue("@RegDate", objUPCModel.RegDate);

                ClsCon.cmd.Parameters.AddWithValue("@RegAddr", objUPCModel.RegAddr);
                ClsCon.cmd.Parameters.AddWithValue("@RegCity", objUPCModel.RegCity);
                ClsCon.cmd.Parameters.AddWithValue("@RegState", objUPCModel.RegState);
                ClsCon.cmd.Parameters.AddWithValue("@RegPin", objUPCModel.RegPin);
                ClsCon.cmd.Parameters.AddWithValue("@RegAuthPerson", objUPCModel.RegAuthPerson);
                ClsCon.cmd.Parameters.AddWithValue("@RegAuthDesg", objUPCModel.RegAuthDesg);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceNoSeries", objUPCModel.InvoiceNoSeries);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceOnPrePrinted", objUPCModel.InvoiceOnPrePrinted);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceNo", objUPCModel.InvoiceNo);
                ClsCon.cmd.Parameters.AddWithValue("@YrCD", objUPCModel.YrCD);

                ClsCon.cmd.Parameters.AddWithValue("@User", objUPCModel.User);
                ClsCon.cmd.Parameters.AddWithValue("@IP", objUPCModel.IP);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCaption1", objUPCModel.InvoiceCaption1);
                ClsCon.cmd.Parameters.AddWithValue("@InvoicePrint1", objUPCModel.InvoicePrint1);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCaption2", objUPCModel.InvoiceCaption2);
                ClsCon.cmd.Parameters.AddWithValue("@InvoicePrint2", objUPCModel.InvoicePrint2);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCaption3", objUPCModel.InvoiceCaption3);
                ClsCon.cmd.Parameters.AddWithValue("@InvoicePrint3", objUPCModel.InvoicePrint3);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCaption4", objUPCModel.InvoiceCaption4);
                ClsCon.cmd.Parameters.AddWithValue("@InvoicePrint4", objUPCModel.InvoicePrint4);

                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCaption5", objUPCModel.InvoiceCaption5);
                ClsCon.cmd.Parameters.AddWithValue("@InvoicePrint5", objUPCModel.InvoicePrint5);
                ClsCon.cmd.Parameters.AddWithValue("@CompanyLogo", objUPCModel.CompanyLogo);
                ClsCon.cmd.Parameters.AddWithValue("@ReportFormat", objUPCModel.ReportFormat);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCopyNo", objUPCModel.InvoiceCopyNo);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCopy1Header", objUPCModel.InvoiceCopy1Header);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCopy2Header", objUPCModel.InvoiceCopy2Header);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCopy3Header", objUPCModel.InvoiceCopy3Header);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCopy4Header", objUPCModel.InvoiceCopy4Header);
                ClsCon.cmd.Parameters.AddWithValue("@InvoiceCopy5Header", objUPCModel.InvoiceCopy5Header);

                ClsCon.cmd.Parameters.AddWithValue("@CompositionCategoryID", objUPCModel.CompositionCategoryID);
                ClsCon.cmd.Parameters.AddWithValue("@CompositionTaxRate", objUPCModel.CompositionTaxRate);
                ClsCon.cmd.Parameters.AddWithValue("@StcokMaintaneByMinorUnit", objUPCModel.StcokMaintaneByMinorUnit);
                ClsCon.cmd.Parameters.AddWithValue("@CompanyType", objUPCModel.CompanyType);
                ClsCon.cmd.Parameters.AddWithValue("@TurnoverID", objUPCModel.TurnoverID);
                ClsCon.cmd.Parameters.AddWithValue("@TurnoverDescription", objUPCModel.TurnoverDescription);
                ClsCon.cmd.Parameters.AddWithValue("@PrintHSNSACCode", objUPCModel.PrintHSNSACCode);
                ClsCon.cmd.Parameters.AddWithValue("@BankName", objUPCModel.BankName);
                ClsCon.cmd.Parameters.AddWithValue("@IFSCCode", objUPCModel.IFSCCode);
                ClsCon.cmd.Parameters.AddWithValue("@AccountNumber", objUPCModel.AccountNumber);

                ClsCon.cmd.Parameters.AddWithValue("@ColumnNumber", objUPCModel.ColumnNumber);
                ClsCon.cmd.Parameters.AddWithValue("@HeadingColumn1", objUPCModel.HeadingColumn1);
                ClsCon.cmd.Parameters.AddWithValue("@HeadingColumn2", objUPCModel.HeadingColumn2);
                ClsCon.cmd.Parameters.AddWithValue("@HeadingColumn3", objUPCModel.HeadingColumn3);
                ClsCon.cmd.Parameters.AddWithValue("@HeadingColumn4", objUPCModel.HeadingColumn4);
                ClsCon.cmd.Parameters.AddWithValue("@HeadingColumn5", objUPCModel.HeadingColumn5);
                ClsCon.cmd.Parameters.AddWithValue("@BudgetAmount", objUPCModel.BudgetAmount);
                ClsCon.cmd.Parameters.AddWithValue("@UnRegistered", objUPCModel.UnRegistered);
                ClsCon.cmd.Parameters.AddWithValue("@SSIsTaken", objUPCModel.SSIsTaken);
                ClsCon.cmd.Parameters.AddWithValue("@BSObtain", objUPCModel.BSObtain);
                ClsCon.cmd.Parameters.AddWithValue("@CCCode", objUPCModel.CCCode);
                ClsCon.cmd.Parameters.AddWithValue("@BudgetConcept", objUPCModel.BudgetConcept);
                ClsCon.cmd.Parameters.AddWithValue("@BankPayChqSeriesInd", objUPCModel.BankPayChqSeriesInd); 
                ClsCon.cmd.Parameters.AddWithValue("@TblTerms", objUPCModel.DtTerms);
                ClsCon.cmd.Parameters.AddWithValue("@TblSeries", objUPCModel.DtSeries);

                con = ClsCon.SqlConn();
                ClsCon.cmd.Connection = con;
                dtUpdProfileCreation = new DataTable();
                ClsCon.da = new SqlDataAdapter(ClsCon.cmd);
                ClsCon.da.Fill(dtUpdProfileCreation);
                dtUpdProfileCreation.TableName = "success";
            }
            catch (Exception)
            {
                dtUpdProfileCreation = new DataTable();
                dtUpdProfileCreation.TableName = "error";
                return dtUpdProfileCreation;
            }
            finally
            {
                con.Close();
                con.Dispose();
                ClsCon.da.Dispose();
                ClsCon.cmd.Dispose();
            }
            return dtUpdProfileCreation;
        }
    }
}