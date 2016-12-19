using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class CreateTags : System.Web.UI.Page
    {
        projetoEntities_teste pe = new projetoEntities_teste();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            tag t = new tag();
            t.name_tag = TextBox_nameTag.ToString();

            String selected = DropDownList1.SelectedValue.ToString();
            int id_temp = 0;

            foreach (template temp in pe.templates)
            {

                if (temp.id_template.ToString().Equals(selected))
                {
                    id_temp = temp.id_template;
                }

            }

            t.id_template = id_temp;


            pe.tags.Add(t);
            pe.SaveChanges();

        }
    }
}