using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NgoProject.UserControls.Input
{
    public partial class SelectUserControl : UserControl
    {
        private string _lblText;

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
                return ddl.SelectedValue;
            }
            set
            {
                ddl.SelectedValue = value;
            }
        }

        public Dictionary<string, string> Source
        {
            set
            {
                value.ToList().ForEach(kvp => ddl.Items.Add(new ListItem(kvp.Value, kvp.Key)));
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}