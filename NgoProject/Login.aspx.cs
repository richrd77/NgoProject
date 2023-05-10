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
                if (result.Item2 != null)
                {
                    if(result.Item2.RoleId == 1)//Member
                    {
                        Response.Redirect("Member.aspx");
                    }
                    else if (result.Item2.RoleId == 2)//Volunteer
                    {
                        Response.Redirect("Volunteer.aspx");
                    }
                    else if (result.Item2.RoleId == 3)//Administrator
                    {
                        Response.Redirect("AdminHomePage.aspx");
                    }
                    else if (result.Item2.RoleId == 4)//Fund raiser
                    {
                        Response.Redirect("FundRaise.aspx");
                    }
                    else if (result.Item2.RoleId == 5)//Donar
                    {
                        Response.Redirect("Donar.aspx");
                    }
                    else
                    {
                        Response.Redirect("Member.aspx");
                    }
                }
                errMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
            }
            else
            {
                errMsg.Style.Add(HtmlTextWriterStyle.Display, "block");
            }
        }
    }
}