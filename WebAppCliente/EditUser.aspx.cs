using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class EditUser : System.Web.UI.Page
    {
        projetoEntities pet = new projetoEntities();
        user u;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                u = (user)Session["User_selected"];
                this.Label_name_user.Text = u.name_user;

                //fields
                this.txtName.Text = u.name_user;
                this.txtEmail.Text = u.email;
                this.txtPass.Text = u.password_user.ToString();
                this.RadioButtonList1.SelectedValue = u.role;

            }
            else
            {
                u = (user)Session["User_selected"];

            }
        }

        protected void Button_createUser_Click(object sender, EventArgs e)
        {
            /*
            user u = new user();
            u.email = txtEmail.Text;
            u.name_user = txtName.Text;
            //u.role = "Employee";
            u.role = this.RadioButtonList1.SelectedValue;
            u.status_user = "Active";
            u.password_user = txtPass.Text;

            pet.users.Add(u);
            pet.SaveChanges();

    */

            u.role = this.RadioButtonList1.SelectedValue;
            u.password_user = this.txtPass.Text;
            u.name_user = this.txtName.Text;
            u.email = this.txtEmail.Text;

            pet.users.AddOrUpdate(u);
            pet.SaveChanges();

        }
    }
}