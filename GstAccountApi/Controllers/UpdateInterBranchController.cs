using GstAccountApi.Models;
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
    public class UpdateInterBranchController : ApiController
    {
        UpdateInterBranchDataAccess ObjUpdateInterBranchDA = new UpdateInterBranchDataAccess();


        [HttpPost]
        public DataTable AccountHead(UpdateInterBranchModel objUpdateInterBranch)
        {
            DataTable AccHeadList = ObjUpdateInterBranchDA.AccountHead(objUpdateInterBranch);
            return AccHeadList;
        }

        [HttpPost]
        public DataTable LastVoucherNo(UpdateInterBranchModel objUpdateInterBranch)
        {
            DataTable LastVoucherNo = ObjUpdateInterBranchDA.LastVoucherNo(objUpdateInterBranch);
            return LastVoucherNo;
        }

        [HttpPost]
        public DataTable LoadNarration(UpdateInterBranchModel objUpdateInterBranch)
        {
            DataTable NarrationList = ObjUpdateInterBranchDA.LoadNarration(objUpdateInterBranch);
            return NarrationList;
        }

        [HttpPost]
        public DataTable LoadBankAccount(UpdateInterBranchModel objUpdateInterBranch)
        {
            DataTable lstbnkpay = ObjUpdateInterBranchDA.LoadBankAccount(objUpdateInterBranch);
            return lstbnkpay;
        }



        [HttpPost]
        public DataSet SearchInterBranch(UpdateInterBranchModel objUpdateInterBranch)
        {
            DataSet InterBranch = ObjUpdateInterBranchDA.SearchInterBranch(objUpdateInterBranch);
            return InterBranch;
        }


        [HttpPost]
        public DataSet LoadBranchList(UpdateInterBranchModel objUpdateInterBranch)
        {
            DataSet lstBranch = ObjUpdateInterBranchDA.LoadBranchList(objUpdateInterBranch);
            return lstBranch;
        }

        [HttpPost]
        public DataSet PartySelect(UpdateInterBranchModel objUpdateInterBranch)
        {
            DataSet dsPartySelect = new DataSet();

            objUpdateInterBranch.Ind = 2;
            DataTable SecondaryParty = ObjUpdateInterBranchDA.PartySelect(objUpdateInterBranch);
            if (SecondaryParty.Rows.Count > 0)
            {
                SecondaryParty.TableName = "SecondaryParty";
                dsPartySelect.Tables.Add(SecondaryParty);
                return dsPartySelect;
            }

            objUpdateInterBranch.Ind = 3;
            DataTable OutstandingBill = ObjUpdateInterBranchDA.PartySelect(objUpdateInterBranch);
            if (SecondaryParty.Rows.Count > 0)
            {
                SecondaryParty.TableName = "OutstandingBill";
                dsPartySelect.Tables.Add(OutstandingBill);
                return dsPartySelect;
            }

            return dsPartySelect;
        }

        [HttpPost]
        public DataTable UpdateInterBranch(UpdateInterBranchModel objUpdateInterBranch)
        {
            DataTable dtInterBranch = ObjUpdateInterBranchDA.UpdateInterBranch(objUpdateInterBranch);
            return dtInterBranch;
        }



        [HttpPost]
        public DataTable CancelVoucher(UpdateInterBranchModel objUpdateInterBranch)
        {
            DataTable dtCancelVoucher = ObjUpdateInterBranchDA.CancelVoucher(objUpdateInterBranch);
            return dtCancelVoucher;
        }

    }
}
