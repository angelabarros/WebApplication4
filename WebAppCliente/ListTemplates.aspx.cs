using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class ListTemplates : System.Web.UI.Page
    {

        projetoEntities pe = new projetoEntities();
        user logged;
        Boolean ok = false;
        List<template> aux = new List<template>();
        protected void Page_Load(object sender, EventArgs e)
        {

           
            logged = (user)Session["User_logged"];

            if(logged == null)
            {
                Response.Redirect("RedirectingToLogin.aspx");
            }else
            {
                ok = true;
            }

            if (ok == true)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");
                dt.AcceptChanges();


                foreach (template temp in pe.templates)
                {
                    template t = new template();
                    t = temp;
                    aux.Add(t);
                    dt.Rows.Add(temp.name_template);
                    dt.AcceptChanges();

                }

                gd1.DataSource = dt;
                gd1.DataBind();
            }


        }

        protected void btn_uploadNewTemp_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}