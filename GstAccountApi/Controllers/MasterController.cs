using GstAccountApi.Models.DL;
using GstAccountApi.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GstAccountApi.Controllers
{
    public class MasterController : ApiController
    {
        MasterDataAccess ObjMD = new MasterDataAccess();

        [HttpPost]
        public DataTable Master(MasterModel ObjMM)
        {
            DataTable AccHeadList = ObjMD.Master(ObjMM);
            return AccHeadList;
        }

        [HttpPost]
        public DataTable BranchAddress(MasterModel ObjMM)
        {
            DataTable dtBranchAddress = ObjMD.BranchAddress(ObjMM);
            return dtBranchAddress;
        }

        [HttpPost]
        public DataTable AccountHead(MasterModel ObjMM)
        {
            DataTable dtBranchAddress = ObjMD.AccountHead(ObjMM);
            return dtBranchAddress;
        }

        [HttpPost]
        public DataTable LastVoucherNo(MasterModel ObjMM)
        {
            DataTable LastVoucherNo = ObjMD.LastVoucherNo(ObjMM);
            return LastVoucherNo;
        }

        [HttpPost]
        public DataTable LoadNarration(MasterModel ObjMM)
        {
            DataTable NarrationList = ObjMD.LoadNarration(ObjMM);
            return NarrationList;
        }

        [HttpPost]
        public DataTable LoadBankAccount(MasterModel ObjMM)
        {
            DataTable lstbnkpay = ObjMD.LoadBankAccount(ObjMM);
            return lstbnkpay;
        }

        [HttpPost]
        public DataTable LoadCashAccount(MasterModel ObjMM)
        {
            DataTable lstcashpay = ObjMD.LoadCashAccount(ObjMM);
            return lstcashpay;
        }

        [HttpPost]
        public DataTable IncomeHead(MasterModel ObjMM)
        {
            DataTable IncomeHeadList = ObjMD.IncomeHead(ObjMM);
            return IncomeHeadList;
        }


        [HttpPost]
        public DataTable CheckGSTIN_Number(MasterModel ObjMM)
        {
            DataTable GSTINList = ObjMD.CheckGSTIN_Number(ObjMM);
            return GSTINList;
        }
    }
}
