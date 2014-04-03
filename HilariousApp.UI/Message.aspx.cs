using HilariousApp.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HilariousApp.UI
{
    public partial class Message : System.Web.UI.Page
    {
        private IGeneralService service = new GeneralService();

        protected void Page_Load(object sender, EventArgs e)
        {
            dgMessage.DataSource = service.FindAllMessage();
            dgMessage.DataBind();
        }
    }
}