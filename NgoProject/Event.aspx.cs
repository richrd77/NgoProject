using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domain.Models.Entity;
using Domain.Services;

namespace NgoProject
{
    public partial class Event : BasePage
    {
        public IEventService service { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            EventGridData.DataSource = service.GetAll();
            EventGridData.DataBind();
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            Domain.Models.Entity.Event objEvent = new Domain.Models.Entity.Event();
            objEvent.Detail = detail.Value;
            objEvent.Date = Convert.ToDateTime(doe.Value);
            objEvent.Name = name.Value;

            var result = service.Event(objEvent);

            if (result)
            {
                errMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
                succMsg.Style.Add(HtmlTextWriterStyle.Display, "block");
                EventGridData.DataSource = service.GetAll();
                EventGridData.DataBind();
            }
            else
            {
                errMsg.Style.Add(HtmlTextWriterStyle.Display, "block");
                succMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
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