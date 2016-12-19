using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class SelectSourcesStep3 : System.Web.UI.Page
    {
        projetoEntities pe = new projetoEntities();
        List<tag> aux = new List<tag>();
        List<column_excel> aux_columns = new List<column_excel>();
        file file_selected;
        template template_selected;
        ICollection<spreadsheet> spreadsheets_from_file_selected;
        List<spreadsheet> aux_spreadsheets = new List<spreadsheet>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            file_selected = (file)Session["file_selected"];
            template_selected = (template)Session["template_selected"];

            this.DropDownList1.Items.Add("Count");
            this.DropDownList1.Items.Add("Sum");
            spreadsheets_from_file_selected = file_selected.spreadsheets;

            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.AcceptChanges();

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Name");
            dt2.AcceptChanges();

            //datatable for spreadsheets
            DataTable dt3 = new DataTable();
            dt3.Columns.Add("Name");
            dt3.AcceptChanges();

            foreach(spreadsheet s in spreadsheets_from_file_selected)
            {
                spreadsheet sp = new spreadsheet();
                sp = s;
                aux_spreadsheets.Add(sp);
                dt3.Rows.Add(s.name_spreadsheet);
                dt3.AcceptChanges();
            }


            foreach (tag ta in pe.tags)
            {
                if(ta.id_template == template_selected.id_template)
                {
                    tag t = new tag();
                    t = ta;
                    aux.Add(t);
                    dt.Rows.Add(ta.name_tag);
                    dt.AcceptChanges();
                }
               
            }

            foreach(column_excel ce in pe.column_excel)
            {
                foreach(spreadsheet s in spreadsheets_from_file_selected)
                {
                    if (ce.spreadsheet == s.id_spreadsheet)
                    {
                        column_excel c = new column_excel();
                        c = ce;
                        aux_columns.Add(c);
                        dt2.Rows.Add(ce.name_column);
                        dt2.AcceptChanges();
                    }
                }

            }

            this.GridView2.DataSource = dt3;
            this.GridView2.DataBind();

            this.GridView1.DataSource = dt2;
            this.GridView1.DataBind();

            gd1.DataSource = dt;
            gd1.DataBind();
        }
    }
}