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
    public class UpdateJournalVoucherController : ApiController
    {
        UpdateJournalVoucherDataAccess objUJVDA = new UpdateJournalVoucherDataAccess();

        [HttpPost]
        public DataTable AccountHead(UpdateJournalVoucherModel objUJVModel)
        {
            DataTable dtAccHeadList = objUJVDA.AccountHead(objUJVModel);
            return dtAccHeadList;
        }

        [HttpPost]
        public DataTable LastVoucherNo(UpdateJournalVoucherModel objUJVModel)
        {
            DataTable dtLastVoucherNo = objUJVDA.LastVoucherNo(objUJVModel);
            return dtLastVoucherNo;
        }

        [HttpPost]
        public DataTable LoadNarration(UpdateJournalVoucherModel objUJVModel)
        {
            DataTable dtNarrationList = objUJVDA.LoadNarration(objUJVModel);
            return dtNarrationList;
        }

        [HttpPost]
        public DataSet BindAllUpdJVDDL(UpdateJournalVoucherModel objUJVModel)
        {
            DataSet dsBindAllUpdJVDDL = objUJVDA.BindAllUpdJVDDL(objUJVModel);
            return dsBindAllUpdJVDDL;
        }

        [HttpPost]
        public DataTable LoadControlAccount(UpdateJournalVoucherModel objUJVModel)
        {
            DataTable dtControlAccount = objUJVDA.LoadControlAccount(objUJVModel);
            return dtControlAccount;
        }

        [HttpPost]
        public DataTable SearchJV(UpdateJournalVoucherModel objUJVModel)
        {
            DataTable dtSearch = objUJVDA.SearchJV(objUJVModel);
            return dtSearch;
        }

        [HttpPost]
        public DataTable UpdateJV(UpdateJournalVoucherModel objUJVModel)
        {
            DataTable dtSaveJV = objUJVDA.UpdateJV(objUJVModel);
            return dtSaveJV;
        }

        [HttpPost]
        public DataTable CancelVoucher(UpdateJournalVoucherModel objUJVModel)
        {
            DataTable dtCancelVoucher = objUJVDA.CancelVoucher(objUJVModel);
            return dtCancelVoucher;
        }


        [HttpPost]
        public DataTable CheckBudgetHead(UpdateJournalVoucherModel objUJVModel)
        {
            DataTable dtAccHeadList = objUJVDA.CheckBudgetHead(objUJVModel);
            return dtAccHeadList;
        }
    }
}
