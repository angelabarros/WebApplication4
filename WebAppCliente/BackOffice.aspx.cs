using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class BackOffice : System.Web.UI.Page
    {
        user logged;
  
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                logged = (user)Session["User_logged"];
                this.Label1.Text = logged.name_user;
            }
            catch(NullReferenceException x)
            {
                //does not work!
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script> alert('ola'); </script>");       
                Response.Redirect("RedirectingToLogin.aspx");
            
            }
       
        }

        protected void Button_users_Click(object sender, EventArgs e)
        {
            Session["User_logged"] = logged;
            Response.Redirect("ListUsers.aspx");
        }

        protected void Button_Clients_Click(object sender, EventArgs e)
        {
            Session["User_logged"] = logged;
            Response.Redirect("ListClients.aspx");
        }

        protected void Button_templates_Click(object sender, EventArgs e)
        {
           // Session["User_logged"] = logged;
            Response.Redirect("ListTemplates.aspx");
        }
    }
}