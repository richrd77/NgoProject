using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domain.Services;

namespace NgoProject
{
    public partial class Volunteer : BasePage
    {
        public IEventService service { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            successMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
            EventGridData.DataSource = service.GetAll();
            EventGridData.DataBind();
        }
        protected void EventGridData_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            successMsg.Style.Add(HtmlTextWriterStyle.Display, "block");
        }
    }
}