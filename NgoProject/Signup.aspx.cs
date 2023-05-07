using Autofac.Integration.Web.Forms;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NgoProject
{
    public partial class Signup : BasePage
    {
        public ISignupService service { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ddlgender.Source = new Dictionary<string, string> { { "-1", "Select Gender" }, { "M", "Male" }, { "F", "Female" } };
            
        }

        protected void signBtn_Click(object sender, EventArgs e)
        {
            service.Signup();
        }
    }
}