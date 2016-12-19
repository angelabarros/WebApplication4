using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class Home : System.Web.UI.Page
    {

        user logged;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user_logged"] != null)
            {

                logged =(user)Session["user_logged"];
                Label1.Text = logged.name_user;

              //  ((Label)(this.Master.FindControl("id_person_logged"))).Text = ((user)(Session["user_logged"])).name_user;



            }
            else
            {
                
                Response.Redirect("RedirectingToLogin.aspx");

            }
        }

        protected void xpto_function()
        {

           // Session["User_logged"] = logged;


        }



    }
}