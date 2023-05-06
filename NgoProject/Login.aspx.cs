using Autofac.Integration.Web.Forms;
using Domain.Services;
using System;
using System.Web.UI;

namespace NgoProject
{
    [InjectProperties]
    public partial class Login : Page
    {
        public ILoginService service { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            loginBtn.Click += LoginBtn_Click;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            service.Login(uname.Value, pwd.Value);
        }
    }
}