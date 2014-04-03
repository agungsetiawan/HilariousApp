using HilariousApp.BL;
using HilariousApp.UI.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HilariousApp.UI
{
    public partial class Contact : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_Click(object sender, EventArgs e)
        {
            string namex = name.InputValue;
            string emailx = email.InputValue;
            string messagex = message.InputValue;

            IGeneralService service = new GeneralService();
            service.SendMessage(namex, emailx, messagex);


            success.Text = "Thank you, your message has been sent";
            
        }
    }
}