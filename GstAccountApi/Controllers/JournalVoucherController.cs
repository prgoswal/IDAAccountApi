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
    public class JournalVoucherController : ApiController
    {
        JournalVoucherDataAccess objJVDA = new JournalVoucherDataAccess();

        [HttpPost]
        public DataTable AccountHead(JournalVoucherModel objJVModel)
        {
            DataTable dtAccHeadList = objJVDA.AccountHead(objJVModel);
            return dtAccHeadList;
        }

        [HttpPost]
        public DataTable LastVoucherNo(JournalVoucherModel objJVModel)
        {
            DataTable dtLastVoucherNo = objJVDA.LastVoucherNo(objJVModel);
            return dtLastVoucherNo;
        }

        [HttpPost]
        public DataTable LoadNarration(JournalVoucherModel objJVModel)
        {
            DataTable dtNarrationList = objJVDA.LoadNarration(objJVModel);
            return dtNarrationList;
        }

        [HttpPost]
        public DataSet BindAllJVDDL(JournalVoucherModel objJVModel)
        {
            DataSet dsBindAllJVDDL = objJVDA.BindAllJVDDL(objJVModel);
            return dsBindAllJVDDL;
        }

        [HttpPost]
        public DataTable LoadControlAccount(JournalVoucherModel objJVModel)
        {
            DataTable dtControlAccount = objJVDA.LoadControlAccount(objJVModel);
            return dtControlAccount;
        }

        [HttpPost]
        public DataTable SaveJV(JournalVoucherModel objJVModel)
        {
            DataTable dtSaveJV = objJVDA.SaveJV(objJVModel);
            return dtSaveJV;
        }


        [HttpPost]
        public DataTable CheckBudgetHead(JournalVoucherModel objJVModel)
        {
            DataTable dtSaveJV = objJVDA.CheckBudgetHead(objJVModel);
            return dtSaveJV;
        }
    }
}
