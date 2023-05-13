using Domain.Models.ViewModels;
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
            ddlgender.Source = service.Genders;
            ddlrole.Source = service.Roles;

            errMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
            successMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
        }

        protected void SignBtn_Click(object sender, EventArgs e)
        {
            if(mobile.Value.Length > 10)
            {
                successMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
                errMsg.Style.Add(HtmlTextWriterStyle.Display, "block");
                errMsg.InnerText = "Enter valid mobile number";
            }
            else
            {

                var vm = new SignupViewModel()
                {
                    Address = address.Value,
                    BirthDate = dob.Value,
                    Email = email.Value,
                    Gender = ddlgender.Value,
                    Mobile = mobile.Value,
                    Name = name.Value,
                    Password = pwd.Value,
                    Role = ddlrole.Value
                };
                if (this.IsModelValid<SignupViewModel>(vm))
                {
                    var r = service.Signup(vm);

                    if (r.Item1)
                    {
                        successMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
                        errMsg.Style.Add(HtmlTextWriterStyle.Display, "block");
                    }
                    else
                    {
                        errMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
                        successMsg.Style.Add(HtmlTextWriterStyle.Display, "block");
                    }
                }
            }
        }
    }
}