using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HilariousApp.UI.Controls
{
    public partial class CustomField : System.Web.UI.UserControl
    {

        public string LabelValue
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public string InputValue
        {
            get { return text.Text; }
            set { text.Text = value; }
        }

        public TextBoxMode InputMode
        {
            get { return text.TextMode; }
            set { text.TextMode = value; }
        }

        public bool IsRequired
        {
            get { return validator.Enabled; }
            set { validator.Enabled = value; }
        }

        public string Message
        {
            get { return validator.Text; }
            set { validator.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}