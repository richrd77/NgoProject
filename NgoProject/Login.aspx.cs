using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NgoProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loginBtn.Click += LoginBtn_Click;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}