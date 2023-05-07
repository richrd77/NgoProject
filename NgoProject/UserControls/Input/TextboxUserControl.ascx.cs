using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NgoProject.UserControls.Input
{
    public partial class TextboxUserControl : UserControl
    {
        private string _lblText;
        private TextBoxMode? _type;
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

        public TextBoxMode? Type
        {
            get
            {
                return this._type;
            }
            set
            {
                if (value != null)
                {
                    txt1.TextMode = value.Value;
                    this._type = value;
                }
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
            this.Type = null;
        }
    }
}