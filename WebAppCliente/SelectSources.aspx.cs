using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
namespace WebAppCliente
{
    public partial class SelectSources : System.Web.UI.Page
    {
        projetoEntities pe = new projetoEntities();
        List<file> aux = new List<file>();
        List<template> aux_templates = new List<template>();
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.AcceptChanges();

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Name");
            dt2.AcceptChanges();


            foreach (file ff in pe.files)
            {
                file f = new file();
                f = ff;
                aux.Add(f);
                dt.Rows.Add(ff.name_file);
                dt.AcceptChanges();

            }

            foreach(template t in pe.templates)
            {
                template te = new template();
                te = t;
                aux_templates.Add(te);
                dt2.Rows.Add(t.name_template);
                dt2.AcceptChanges();

            }


            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();

            this.GridView2.DataSource = dt2;
            this.GridView2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int file_selected = this.GridView1.SelectedIndex;
            //List<CheckBox> aux_checks = (CheckBox) this.GridView1.Columns[0];
            GridViewRow fs = this.GridView1.SelectedRow;

            // Object t = this.GridView1.SelectedValue;

            //file f = aux.ElementAt(file_selected);  //error
            // int qwe;

            //while ((GridView1.Rows[0].Cells[0].Controls[0] as CheckBox).Checked)
            //  qwe = 0;

            int af = this.GridView1.SelectedIndex;

            int index_temp = this.GridView2.SelectedIndex;

            file f=null;
            template t=null;

            try
            {
                f = aux.ElementAt(af);
                t = aux_templates.ElementAt(index_temp);
            }catch(ArgumentOutOfRangeException aer)
            {
                Response.Write("You need to select a file and a template!");
            }
           

            Session["file_selected"] = f;
            Session["template_selected"] = t;

            if (f != null && t != null)
            {
                Response.Redirect("SelectSourcesStep2.aspx");
            }
            else
            {
                Response.Write("You need to choose a file and a template!");
                
            }

        }

    }
}