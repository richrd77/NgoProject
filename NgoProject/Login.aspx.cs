using Autofac.Integration.Web.Forms;
using Domain.Services;
using System;
using System.Web.UI;

namespace NgoProject
{
    [InjectProperties]
    public partial class Login : BasePage
    {
        public ILoginService service { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            loginBtn.Click += LoginBtn_Click;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var result = service.Login(uname.Value, pwd.Value);
            if (result.Item1)
            {
                errMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
            }
            else
            {
                errMsg.Style.Add(HtmlTextWriterStyle.Display, "block");
            }
        }
    }
}