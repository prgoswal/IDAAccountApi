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
    public class InterBranchController : ApiController
    {
        InterBranchDataAccess InterBranchDA = new InterBranchDataAccess();
       

        [HttpPost]
        public DataTable AccountHead(InterBranchModel objInterBranch)
        {
            DataTable AccHeadList = InterBranchDA.AccountHead(objInterBranch);
            return AccHeadList;
        }

        [HttpPost]
        public DataTable LastVoucherNo(InterBranchModel objInterBranch)
        {
            DataTable LastVoucherNo = InterBranchDA.LastVoucherNo(objInterBranch);
            return LastVoucherNo;
        }

        [HttpPost]
        public DataTable LoadNarration(InterBranchModel objInterBranch)
        {
            DataTable NarrationList = InterBranchDA.LoadNarration(objInterBranch);
            return NarrationList;
        }

        [HttpPost]
        public DataTable LoadBankAccount(InterBranchModel objInterBranch)
        {
            DataTable lstbnkpay = InterBranchDA.LoadBankAccount(objInterBranch);
            return lstbnkpay;
        }


        [HttpPost]
        public DataSet LoadBranchList(InterBranchModel objInterBranch)
        {
            DataSet lstBranch = InterBranchDA.LoadBranchList(objInterBranch);
            return lstBranch;
        }

        [HttpPost]
        public DataSet PartySelect(InterBranchModel objInterBranch)
        {
            DataSet dsPartySelect = new DataSet();

            objInterBranch.Ind = 2;
            DataTable SecondaryParty = InterBranchDA.PartySelect(objInterBranch);
            if (SecondaryParty.Rows.Count > 0)
            {
                SecondaryParty.TableName = "SecondaryParty";
                dsPartySelect.Tables.Add(SecondaryParty);
                return dsPartySelect;
            }

            objInterBranch.Ind = 3;
            DataTable OutstandingBill = InterBranchDA.PartySelect(objInterBranch);
            if (SecondaryParty.Rows.Count > 0)
            {
                SecondaryParty.TableName = "OutstandingBill";
                dsPartySelect.Tables.Add(OutstandingBill);
                return dsPartySelect;
            }

            return dsPartySelect;
        }

        [HttpPost]
        public DataTable SaveInterBranch(InterBranchModel objInterBranch)
        {
            DataTable dtInterBranch = InterBranchDA.SaveInterBranch(objInterBranch);
            return dtInterBranch;
        }

        
    }
}
