using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class CreateUser_mp : System.Web.UI.Page
    {

        projetoEntities pet = new projetoEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_createUser_Click(object sender, EventArgs e)
        {
            user u = new user();
            u.email = txtEmail.Text;
            u.name_user = txtName.Text;
            //u.role = "Employee";
            u.role = this.RadioButtonList1.SelectedValue;
            u.status_user = "Active";
            u.password_user = txtPass.Text;

            pet.users.Add(u);
            pet.SaveChanges();
        }
    }
}