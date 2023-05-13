using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domain.Models.Entity;
using Domain.Services;

namespace NgoProject
{
    public partial class Member_Admin : BasePage
    {
        public IMemberService service { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlTypeofuser.Source = service.TypeOfUser;
            }

            MemberGridData.DataSource = service.GetAll();
            MemberGridData.DataBind();
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            if (doName.Value == "")
                errdoName.Style.Add(HtmlTextWriterStyle.Display, "block");
            else
                errdoName.Style.Add(HtmlTextWriterStyle.Display, "none");

            if (ddlTypeofuser.Value == "-1")
                errddlTypeofuser.Style.Add(HtmlTextWriterStyle.Display, "block");
            else
                errddlTypeofuser.Style.Add(HtmlTextWriterStyle.Display, "none");

            if (dor.Value == "")
                errdor.Style.Add(HtmlTextWriterStyle.Display, "block");
            else
                errdor.Style.Add(HtmlTextWriterStyle.Display, "none");

            if (doj.Value == "")
                errdoj.Style.Add(HtmlTextWriterStyle.Display, "block");
            else
                errdoj.Style.Add(HtmlTextWriterStyle.Display, "none");

            if (doj.Value != "" && dor.Value != "" && doName.Value != "" && ddlTypeofuser.Value != "")
            {
                Member objMember = new Member();
                objMember.JoinDate = Convert.ToDateTime(doj.Value);
                objMember.EndDate = Convert.ToDateTime(dor.Value);
                objMember.Name = doName.Value;
                objMember.TypeOfUser = Convert.ToInt32(ddlTypeofuser.Value);

                var result = service.Member(objMember);

                if (result)
                {
                    errMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
                    succMsg.Style.Add(HtmlTextWriterStyle.Display, "block");

                    MemberGridData.DataSource = service.GetAll();
                    MemberGridData.DataBind();

                    doj.Value = "";
                    dor.Value = "";
                    doName.Value = "";
                    ddlTypeofuser.Value = "";
                }
                else
                {
                    errMsg.Style.Add(HtmlTextWriterStyle.Display, "block");
                    succMsg.Style.Add(HtmlTextWriterStyle.Display, "none");
                }
            }
            else
            {
            }            
        }

        protected void resetBtn_Click(object sender, EventArgs e)
        {
            doj.Value = "";
            dor.Value = "";
            doName.Value = "";
            ddlTypeofuser.Value = "";
        }
    }
}