using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class SelectSourcesStep2 : System.Web.UI.Page
    {
       
        projetoEntities pe = new projetoEntities();
        List<tag> all_tags = new List<tag>();
        template selected;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                selected =(template) Session["template_selected"];
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("Status");
                dt.AcceptChanges();

                foreach (tag t in pe.tags)
                {
                    if(t.id_template == selected.id_template)
                    {
                        tag test = new tag();
                        test = t;
                        all_tags.Add(test);
                        dt.Rows.Add(t.name_tag, t.status);
                    }

                  
                    dt.AcceptChanges();
                }




                this.gd1.DataSource = dt;
                this.gd1.DataBind();
            }

            foreach(tag t in pe.tags)
            {
                all_tags.Add(t);
                
            }
          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in gd1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);

                    if (chkRow.Checked)
                    {
                        string name = row.Cells[1].Text;
                        int index = row.RowIndex;
                        //string country = (row.Cells[2].FindControl("lblCountry") as Label).Text;
                       // tag x = pe.tags.ElementAt(index);
                        tag t = all_tags.ElementAt(index);

                        t.status = 2;
                        pe.tags.AddOrUpdate();
                        pe.SaveChanges();
                        
                    }
                }
            }
        }
    }
}