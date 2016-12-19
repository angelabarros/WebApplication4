using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class ListUsers : System.Web.UI.Page
    {

        projetoEntities pet = new projetoEntities();
        List<user> aux = new List<user>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var aux = (from m in pet.clientcompanies select m.name_company);

            //Table1.Rows.AddRange(aux.ToArray());
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Email");
            dt.Columns.Add("Role");
            dt.AcceptChanges();





            foreach (user cc in pet.users)
            {
                user c = new user();
                c = cc;
                aux.Add(c);
                dt.Rows.Add(cc.name_user, cc.email, cc.role);
                dt.AcceptChanges();




            }




            gd1.DataSource = dt;
            gd1.DataBind();



        }

        protected void RowEditing(object sender, GridViewEditEventArgs e)
        {

            //Response.Redirect("Home.aspx");
            //int i = this.gd1.SelectedRow;
            int y = e.NewEditIndex;
            user c = aux.ElementAt(y);



            Session["User_Selected"] = c;

            Response.Redirect("EditUser.aspx");

            //Response.Redirect("Home.aspx");
        }

        protected void btn_createUser_Click(object sender, EventArgs e)
        {

            Response.Redirect("CreateUser_mp.aspx");
        }
    }
}