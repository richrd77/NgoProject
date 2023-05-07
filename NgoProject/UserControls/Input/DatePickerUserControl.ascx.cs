using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NgoProject.UserControls.Input
{
    public partial class DatePickerUserControl : System.Web.UI.UserControl
    {
        private string _lblText;
        private bool _required;

        public string LblText
        {
            get
            {
                return this._lblText;
            }
            set
            {
                this._lblText = value;
                lbl.InnerText = value;
            }
        }

        public string Value
        {
            get
            {
                return txt1.Text;
            }
            set
            {
                txt1.Text = value;
            }
        }

        public string ErrorMessage
        {
            set
            {
                er.InnerText = value;
            }
        }

        public bool RequiredField
        {
            get
            {
                return _required;
            }
            set
            {
                txt1.Attributes.Add("data-required", value.ToString());
                _required = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}