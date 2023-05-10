using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domain.Services;

namespace NgoProject
{
    public partial class Donar_Admin : BasePage
    {
        public IDonorService service { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            DonarGridData.DataSource = service.GetAll();
            DonarGridData.DataBind();
        }
    }
}