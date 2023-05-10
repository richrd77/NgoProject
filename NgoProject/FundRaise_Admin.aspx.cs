using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domain.Services;

namespace NgoProject
{
    public partial class FundRaise_Admin : BasePage
    {
        public IDonorService service { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            FundRaiserGridData.DataSource = service.GetAll();
            FundRaiserGridData.DataBind();
        }
    }
}