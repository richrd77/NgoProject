using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Application.Common.Enum;
using Domain.Models.Entity;
using Domain.Services;

namespace NgoProject
{
    public partial class FundRaise : BasePage
    {
        public IDonorService service { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //DateTime dt = DateTime.ParseExact(DateTime.Now.ToString(), "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);

            //dod.Value = dt.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            Money objMoney = new Money();
            objMoney.Amount = Convert.ToDouble(doAmount.Value);
            objMoney.Date = Convert.ToDateTime(dod.Value);
            objMoney.Name = doName.Value;
            objMoney.TransactionTypeId = 2;
            objMoney.TransactionType = new Transaction { Type = TransactionTypeEnum.FundRaise.ToString() };

            var result = service.Donate(objMoney);

            if (result)
            {
                errMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
            }
            else
            {
                errMsg.Style.Add(HtmlTextWriterStyle.Display, "block");
            }
        }

        protected void resetBtn_Click(object sender, EventArgs e)
        {
            doAmount.Value = "";
            doName.Value = "";
        }
    }
}