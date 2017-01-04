using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente.Account
{
    public partial class LogoutRedirecting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label1.Text = "Goodbye " + ((user)Session["user_logged"]).name_user + " !";
            Session.Abandon();
            System.Threading.Thread.Sleep(3000);
        }

    }
}