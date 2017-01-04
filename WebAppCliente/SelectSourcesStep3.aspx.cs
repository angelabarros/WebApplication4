using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
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
        DropDownList dp_columns = new DropDownList();
        int index_spreadsheet = 0;
        int number_of_rows = 1;
        column_excel column_selected;
        tag tagselected = null;
        int counter;
        //List<column_excel> aux_list = new List<column_excel>();

        public enum Operators
        {
            [Display(Name =  "=")]
            equal, //=
            [Display(Name = ">")]
            greater, // >
            [Display(Name = "<")]
            lesser, // <
            [Display(Name = ">=")]
            greater_eq, //>=
            [Display(Name = "<=")]
            less_eq, // <=
          


            
        }

        private List<string> ControlsList
        {
            get
            {
                if(ViewState["controls"] == null)
                {
                    ViewState["controls"] = new List<string>();
                }
                return (List < string >) ViewState["controls"];
            }
        }

        private List<string> ControlsListColumns
        {
            get
            {
                if (ViewState["controls_columns"] == null)
                {
                    ViewState["controls_columns"] = new List<string>();
                }
                return (List<string>)ViewState["controls_columns"];
            }
        }

        private List<string> ControlsListOpers
        {
            get
            {
                if (ViewState["controls_opers"] == null)
                {
                    ViewState["controls_opers"] = new List<string>();
                }
                return (List<string>)ViewState["controls_opers"];
            }
        }


        private List<string> ControlsListANDOR
        {
            get
            {
                if(ViewState["controls_andor"] == null)
                {
                    ViewState["controls_andor"] = new List<string>();
                }
                return (List<string>)ViewState["controls_andor"];
            }
        }


        private int nextID
        {
            get
            {
                return ControlsList.Count + 1;
            }
        }

        private int nextIDColumns
        {
            get
            {
                return ControlsListColumns.Count + 1;
            }
        }

        private int nextIDOper
        {
            get
            {
                return ControlsListOpers.Count + 1;
            }
        }

        private int nextANDOR
        {
            get
            {
                return ControlsListANDOR.Count + 1;
            }
        }


        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            
            foreach(string txtId in ControlsList)
            {
                TextBox txt = new TextBox();
                txt.ID = txtId;
                PlaceHolder1.Controls.Add(txt);
                PlaceHolder1.Controls.Add(new LiteralControl("<br>"));

            }
            foreach (string txtId in ControlsListColumns)
            {
                DropDownList dp = new DropDownList();
                dp.ID = txtId;
                PlaceHolder3.Controls.Add(dp);
                PlaceHolder3.Controls.Add(new LiteralControl("<br>"));

            }

            foreach (string txtId in ControlsListOpers)
            {
                DropDownList dp = new DropDownList();
                dp.ID = txtId;
                PlaceHolder2.Controls.Add(dp);
                PlaceHolder2.Controls.Add(new LiteralControl("<br>"));

            }

            foreach (string txtId in ControlsListANDOR)
            {
                DropDownList dp = new DropDownList();
                dp.ID = txtId;
                PlaceHolder4.Controls.Add(dp);
                PlaceHolder4.Controls.Add(new LiteralControl("<br>"));

            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                file_selected = (file)Session["file_selected"];
                template_selected = (template)Session["template_selected"];

                //Operations
                this.DropDownList1_base.Items.Add("Count");
                this.DropDownList1_base.Items.Add("Sum");

                //Operators
                this.DropDownList3_base.Items.Add("=");
                this.DropDownList3_base.Items.Add(">");
                this.DropDownList3_base.Items.Add("<");
                this.DropDownList3_base.Items.Add("=>");
                this.DropDownList3_base.Items.Add("<=");



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

                //datatable  -- ajax
                /*
                DataTable dt4 = new DataTable();
                dt4.Columns.Add("Name");
                dt4.AcceptChanges();
                */


                foreach (spreadsheet s in spreadsheets_from_file_selected)
                {
                    spreadsheet sp = new spreadsheet();
                    sp = s;
                    aux_spreadsheets.Add(sp);
                    dt3.Rows.Add(s.name_spreadsheet);
                    dt3.AcceptChanges();
                }


                foreach (tag ta in pe.tags)
                {
                    if (ta.id_template == template_selected.id_template && ta.status==1)
                    {
                        tag t = new tag();
                        t = ta;
                        aux.Add(t);
                        dt.Rows.Add(ta.name_tag);
                        dt.AcceptChanges();
                    }

                }
                /*
                foreach (column_excel ce in pe.column_excel)
                {
                    foreach (spreadsheet s in spreadsheets_from_file_selected)
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
                */
                this.GridView2.DataSource = dt3;
                this.GridView2.DataBind();

               // this.GridView1.DataSource = dt2;
                //this.GridView1.DataBind();

                //  this.GridView3.DataBind();

                gd1.DataSource = dt;
                gd1.DataBind();
            }
           else
            {
              
                template_selected = (template)Session["template_selected"];
                file_selected = (file)Session["file_selected"];
                spreadsheets_from_file_selected = file_selected.spreadsheets;

                counter = number_of_rows + 1;
                Session["number_of_rows"] = counter;


                foreach (spreadsheet s in spreadsheets_from_file_selected)
                {
                    spreadsheet sps = new spreadsheet();
                    sps = s;
                    aux_spreadsheets.Add(sps);
               
                }

                foreach (tag ta in pe.tags)
                {
                    if (ta.id_template == template_selected.id_template && ta.status == 1)
                    {
                        tag t = new tag();
                        t = ta;
                        aux.Add(t);
                    }
                }

               // int tag_selected = this.gd1.SelectedIndex;
               // tag tag_aux = this.aux.ElementAt(tag_selected);
               // tagselected = tag_aux;
              
            
                spreadsheet sp = null;
                sp = spreadsheets_from_file_selected.ElementAt(index_spreadsheet);
                foreach (column_excel ce in pe.column_excel)
                {

                    if (ce.spreadsheet == sp.id_spreadsheet)
                    {
                        column_excel c = new column_excel();
                        c = ce;
                        aux_columns.Add(c);

                       // dp_columns.Items.Add(c.name_column);
                    }

                }

                int index_of_column = this.DropDownList2_base.SelectedIndex;
                if (index_of_column != -1)
                {
                    column_selected = aux_columns.ElementAt(index_of_column);
                }

            }

        }

       
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

            int spreadsheet_selected = this.GridView2.SelectedIndex;

            //List<CheckBox> aux_checks = (CheckBox) this.GridView1.Columns[0];
            // GridViewRow fs = this.GridView2.SelectedRow;

    

            // int af = this.GridView2.SelectedIndex;

            int index_spread = this.GridView2.SelectedIndex;

            spreadsheet sp = null;

            sp = spreadsheets_from_file_selected.ElementAt(index_spread);

            DataTable dt5 = new DataTable();
            dt5.Columns.Add("Name");
            dt5.AcceptChanges();

            foreach (column_excel ce in pe.column_excel)
            {

                if (ce.spreadsheet == sp.id_spreadsheet)
                {
                    column_excel c = new column_excel();
                    c = ce;
                    aux_columns.Add(c);
                   
                    this.DropDownList2_base.Items.Add(c.name_column);
                }
            }

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //tag selected
             int tag_selected = this.gd1.SelectedIndex;

            int aux = number_of_rows + 1;
            Session["number_of_rows"] = aux;

            tag tag_aux = this.aux.ElementAt(tag_selected);
            tagselected = tag_aux;
            Session["tagselected"] = tagselected;

            //column selected for 1st row
            int index_of_column = this.DropDownList2_base.SelectedIndex;
            column_selected = aux_columns.ElementAt(index_of_column);

            //spreadsheet selected
            index_spreadsheet = this.GridView2.SelectedIndex;
            spreadsheet s = this.aux_spreadsheets.ElementAt(index_spreadsheet);

            //operation selected
            string operation = this.DropDownList1_base.SelectedValue;

            //disabling other components
            this.gd1.Enabled = false;
            this.GridView2.Enabled = false;
            this.DropDownList1_base.Enabled = false;


            //operator
            DropDownList dp_oper = new DropDownList();
            dp_oper.ID = "dp_oper" + nextIDOper.ToString();

            PlaceHolder2.Controls.Add(dp_oper);
            PlaceHolder2.Controls.Add(new LiteralControl("<br/>"));

            /*
            foreach (String op in Enum.GetNames(typeof(Operators)))
            {
                dp_oper.Items.Add(op);
            }
            */
            
            dp_oper.Items.Add("=");
            dp_oper.Items.Add(">");
            dp_oper.Items.Add("<");
            dp_oper.Items.Add("=>");
            dp_oper.Items.Add("<=");
            
            ControlsListOpers.Add(dp_oper.ID);


            //txtbox

           // PlaceHolder1.Controls.Add(new LiteralControl("<br/>"));
           // PlaceHolder1.Controls.Add(new LiteralControl("<br/>"));
            TextBox txt = new TextBox();
            txt.ID = "TextBox" + nextID.ToString();
            
            PlaceHolder1.Controls.Add(txt);
            PlaceHolder1.Controls.Add(new LiteralControl("<br/>"));
            ControlsList.Add(txt.ID);


            //columns

           // PlaceHolder3.Controls.Add(new LiteralControl("<br/>"));
            //PlaceHolder3.Controls.Add(new LiteralControl("<br/>"));

            spreadsheet sp = null;
            sp = spreadsheets_from_file_selected.ElementAt(index_spreadsheet);
            PlaceHolder3.Controls.Add(dp_columns);
            PlaceHolder3.Controls.Add(new LiteralControl("<br/>"));
            dp_columns.ID = "DropDownListColumns" + nextIDColumns.ToString();

            foreach (column_excel ce in pe.column_excel)
            {

                if (ce.spreadsheet == sp.id_spreadsheet)
                {
                    column_excel c = new column_excel();
                    c = ce;
                    aux_columns.Add(c);

                    dp_columns.Items.Add(c.name_column);
                }
            }

        
           
            ControlsListColumns.Add(dp_columns.ID);

            //and or or
            DropDownList dpd = new DropDownList();
            dpd.ID = "DropDownList_ANDOR" + nextANDOR.ToString();

            PlaceHolder4.Controls.Add(dpd);
            PlaceHolder4.Controls.Add(new LiteralControl("<br/>"));

            dpd.Items.Add("AND");
            dpd.Items.Add("OR");

           

            ControlsListANDOR.Add(dpd.ID);



        }

        protected void Button_submit_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();
            foreach(Control ctl in PlaceHolder1.Controls)
            {
                if(ctl is TextBox)
                {
                    TextBox txt = ctl as TextBox;

                    if(ctl != null)
                    {
                        sb.Append(txt.Text);
                        sb.Append("<br>");
                    }

                }
            }

            //operators
            foreach(Control ctl in PlaceHolder2.Controls)
            {
                if(ctl is DropDownList)
                {
                    DropDownList dp = ctl as DropDownList;

                    if(dp != null && dp.SelectedIndex != -1)
                    {
                        sb.Append(dp.SelectedValue);
                        sb.Append("<br>");
                    }
                }
            }

            //columns
            foreach(Control ctl in PlaceHolder3.Controls)
            {
                if(ctl is DropDownList)
                {
                    DropDownList dp = ctl as DropDownList;

                    if( dp != null && dp.SelectedIndex != -1)
                    {
                        sb.Append(dp.SelectedValue);
                        sb.Append("<br>");
                    }
                }
            }

            //operation
            foreach(Control ctl in PlaceHolder4.Controls)
            {
                if(ctl is DropDownList)
                {
                    DropDownList dp = ctl as DropDownList;

                    if(dp != null && dp.SelectedIndex != -1)
                    {
                        sb.Append(dp.SelectedValue);
                        sb.Append("<br>");
                    }
                }
            }

            LabelContent.Text = sb.ToString();
            int tag_selected = this.gd1.SelectedIndex;
            tag tag_aux = this.aux.ElementAt(tag_selected);
            tagselected = tag_aux;
            Session["tagselected"] = tagselected;


            formula f = new formula();
            tagselected = (tag)Session["tagselected"];
            f.id_tag = tagselected.id_tag;
            f.name_formula = "Formula of " + tagselected.name_tag;
            f.method = this.DropDownList1_base.SelectedValue;

            pe.formulae.Add(f);
            pe.SaveChanges();


            //condition_instruction ci = new condition_instruction();
            int nr =(int) Session["number_of_rows"];

            int number=0;
            foreach (Control ctl in PlaceHolder3.Controls)
            {
                if (ctl is DropDownList)
                {
                    number = number + 1;
                }
            }



            //first row
            int zero = 0;
            string nothing = "";

            condition_instruction ci = new condition_instruction();
            column_excel ce = column_selected;
            ci.and_or_condition = nothing;
            ci.number_order = zero;
            ci.condition_instruction1 = this.TextBox1_base.Text;
            ci.column_excel1 = ce;
            // ci.id_formula = f.id_formula;
            ci.formula = f;
            ci.@operator = this.DropDownList3_base.SelectedIndex;
            pe.condition_instruction.Add(ci);
            
               

            //lists of only the controls needed
            List<DropDownList> aux_drop_list = new List<DropDownList>();
            List<TextBox> aux_text_list = new List<TextBox>();
            List<DropDownList> aux_drop_list2 = new List<DropDownList>();

            //filtering
            foreach (Control ctl in PlaceHolder4.Controls)
            {
                if (ctl is DropDownList)
                {
                    aux_drop_list.Add((DropDownList)ctl);
                }
            }

            foreach(Control ctl in PlaceHolder1.Controls)
            {
                if(ctl is TextBox)
                {
                    aux_text_list.Add((TextBox)ctl);
                }
            }

            foreach (Control ctl in PlaceHolder2.Controls)
            {
                if (ctl is DropDownList)
                {
                    aux_drop_list2.Add((DropDownList)ctl);
                }
            }


            for (int i=0; i<number; i++)
                {
                condition_instruction cii = new condition_instruction();
            
                    column_excel cee = aux_columns.ElementAt(i);
                    cii.and_or_condition =aux_drop_list[i].SelectedValue;
                    cii.number_order = i+1;
                    cii.condition_instruction1 = aux_text_list[i].Text;
                    cii.column_excel1 = cee;
                    // ci.id_formula = f.id_formula;
                    cii.formula = f;
                    cii.@operator = aux_drop_list2[i].SelectedIndex;
                    pe.condition_instruction.Add(cii);
                  
                
            }

            pe.SaveChanges();
        }
    }
}