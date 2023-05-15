using Domain.Models.ViewModels;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
            if (!Page.IsPostBack)
            {
                ddlgender.Source = service.Genders;
                ddlrole.Source = service.Roles;
            }

            errMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
            successMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
        }

        protected void SignBtn_Click(object sender, EventArgs e)
        {
            if(ddlrole.Value == "-1")
                errRole.Style.Add(HtmlTextWriterStyle.Display, "block");
            else
                errRole.Style.Add(HtmlTextWriterStyle.Display, "none");

            if (ddlgender.Value == "-1")
                errGender.Style.Add(HtmlTextWriterStyle.Display, "block");
            else
                errGender.Style.Add(HtmlTextWriterStyle.Display, "none");

            if (mobile.Value == "")
                errMobile.Style.Add(HtmlTextWriterStyle.Display, "block");
            else
                errMobile.Style.Add(HtmlTextWriterStyle.Display, "none");

            if (name.Value == "")
                errName.Style.Add(HtmlTextWriterStyle.Display, "block");
            else
                errName.Style.Add(HtmlTextWriterStyle.Display, "none");

            if (address.Value == "")
                errAddress.Style.Add(HtmlTextWriterStyle.Display, "block");
            else
                errAddress.Style.Add(HtmlTextWriterStyle.Display, "none");

            if (dob.Value == "")
                errDOB.Style.Add(HtmlTextWriterStyle.Display, "block");
            else
                errDOB.Style.Add(HtmlTextWriterStyle.Display, "none");

            if (email.Value == "")
                errEmail.Style.Add(HtmlTextWriterStyle.Display, "block");
            else
                errEmail.Style.Add(HtmlTextWriterStyle.Display, "none");

            if (pwd.Value == "")
                errPassword.Style.Add(HtmlTextWriterStyle.Display, "block");
            else
                errPassword.Style.Add(HtmlTextWriterStyle.Display, "none");

            if (mobile.Value.Length > 10)
            {
                successMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
                errMsg.Style.Add(HtmlTextWriterStyle.Display, "block");
                errMsg.InnerText = "Enter valid mobile number";
            }
            else if (!Regex.IsMatch(email.Value.ToString(), @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                successMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
                errMsg.Style.Add(HtmlTextWriterStyle.Display, "block");
                errMsg.InnerText = "Enter valid email address";
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