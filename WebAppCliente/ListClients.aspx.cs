using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class ListClients : System.Web.UI.Page
    {
        projetoEntities pet = new projetoEntities();
        List<clientcompany> aux = new List<clientcompany>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var aux = (from m in pet.clientcompanies select m.name_company);

            //Table1.Rows.AddRange(aux.ToArray());
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Email");
            dt.AcceptChanges();





            foreach (clientcompany cc in pet.clientcompanies)
            {
                clientcompany c = new clientcompany();
                c = cc;
                aux.Add(c);
                dt.Rows.Add(cc.name_company, cc.email);
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
            clientcompany c = aux.ElementAt(y);



            Session["Client_Selected"] = c;

            Response.Redirect("EditClient.aspx");

        }

        protected void btn_newClient_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateClient.aspx");
        }
    }
}