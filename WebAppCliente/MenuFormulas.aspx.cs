using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class MenuFormulas : System.Web.UI.Page
    {
        user logged;
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                logged = (user)Session["User_logged"];
  
            }
            catch (NullReferenceException x)
            {
                  Response.Redirect("RedirectingToLogin.aspx");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UploadExcel.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectSources.aspx");
        }
    }
}