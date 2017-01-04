using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using WebAppCliente.Models;

namespace WebAppCliente.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.Label1.Text = "Goodbye " + ((user)Session["user_logged"]).name_user;
            Session.Abandon();
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx"); //not working
        }
    }
}