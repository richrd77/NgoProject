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
            ddlTypeofuser.Source = service.TypeOfUser;
            MemberGridData.DataSource = service.GetAll();
            MemberGridData.DataBind();
        }

        protected void submitBtn_Click(object sender, EventArgs e)
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
            }
            else
            {
                errMsg.Style.Add(HtmlTextWriterStyle.Display, "block");
                succMsg.Style.Add(HtmlTextWriterStyle.Display, "none");

            }
        }

        protected void resetBtn_Click(object sender, EventArgs e)
        {
            //doAmount.Value = "";
            doName.Value = "";
        }
    }
}