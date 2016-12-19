using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;

namespace WebAppCliente
{
    public partial class Login : System.Web.UI.Page
    {
        projetoEntities pe = new projetoEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
           // Label5.Visible = false;
           //this.Master.
        }
            /*
        protected void LoginButton_Click(object sender, EventArgs e)
        {
           List<user> aux =  pe.users.Where(u => u.name_user == Login1.UserName && u.password_user == Login1.Password).ToList<user>();
                
            if (aux.Count == 1)
            {
                
               // Label5.Text = "ok";
                // Session["name"] = TextBox2.Text;
                // Response.Redirect("Home.aspx");
                
                Session["name"] = Login1.UserName.ToString();
                Response.Redirect("Home.aspx");
            }else
            {
                //Label5.Text = "nao ok";
            }
       
        }
        */
        protected void Button1_Click(object sender, EventArgs e)
        {

        }



        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonLOGIN_Click(object sender, EventArgs e)
        {
            List<user> aux = pe.users.Where(u => u.name_user == Login1.UserName && u.password_user == Login1.Password).ToList<user>();

            if (aux.Count == 1)
            {

                // Label5.Text = "ok";
                // Session["name"] = TextBox2.Text;
                // Response.Redirect("Home.aspx");

                int y = 0;
                user c = aux.ElementAt(y);



                Session["user_logged"] = c;
                //Session["name"] = Login1.UserName.ToString();
                Response.Redirect("Home.aspx");
            }
            else
            {
                //Label5.Text = "nao ok";
            }

        }
    }
}