using Application.Common.Enum;
using Domain.Models.Entity;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NgoProject
{
    public partial class Donar : BasePage
    {
        public IDonorService service { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            Money objMoney = new Money();
            objMoney.Amount = Convert.ToDouble(doAmount.Value);
            objMoney.Date = Convert.ToDateTime(dod.Value);
            objMoney.Name = doName.Value;
            objMoney.TransactionTypeId = 1;
            objMoney.TransactionType = new Transaction { Type = TransactionTypeEnum.Donation.ToString() };

            var result = service.Donate(objMoney);

            if (result)
            {
                errMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
                succMsg.Style.Add(HtmlTextWriterStyle.Display, "block");
            }
            else
            {
                errMsg.Style.Add(HtmlTextWriterStyle.Display, "block");
                succMsg.Style.Add(HtmlTextWriterStyle.Display, "none");

            }
        }

        protected void resetBtn_Click(object sender, EventArgs e)
        {
            doAmount.Value = "";
            dod.Value = string.Empty;
            doName.Value = "";
        }
    }
}