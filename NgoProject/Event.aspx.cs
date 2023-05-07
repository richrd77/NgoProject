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
    public partial class Volunteer : BasePage
    {
        public IEventService service { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            Event objEvent = new Event();
            objEvent.Detail = detail.Value;
            objEvent.Date = Convert.ToDateTime(doe.Value);
            objEvent.Name = name.Value;

            var result = service.Event(objEvent);

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
            detail.Value = "";
            name.Value = "";
            doe.Value = "";
        }
    }
}