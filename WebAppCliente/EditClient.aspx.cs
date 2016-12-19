using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class EditClient : System.Web.UI.Page
    {

        projetoEntities pe = new projetoEntities();
        clientcompany cc;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cc = (clientcompany)Session["Client_Selected"];
                this.Label2.Text = cc.name_company;
                this.txtName.Text = cc.name_company;
                this.txtAddress.Text = cc.address;
                this.txtTelephone.Text = cc.telephone.ToString();
                this.txtEmail.Text = cc.email;

                if (cc.logotipo != null)
                {
                    this.Label1.Visible = true;
                    this.Label1.Text = cc.logotipo;

                }


                if (cc.Domain != null)
                {
                    this.txtDomain.Text = cc.Domain;
                }
                else
                {
                    this.txtDomain.Text = "-------------";
                }
            }
            else
            {
                cc = (clientcompany)Session["Client_Selected"];
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void Button_NEXT_Click(object sender, EventArgs e)
        {
            int j;
            if (Int32.TryParse(txtTelephone.Text, out j))
            {
                cc.telephone = j;
            }
                cc.name_company = this.txtName.Text;
                cc.email = this.txtEmail.Text;
                cc.Domain = this.txtDomain.Text;
                cc.address = this.txtAddress.Text;
                
            
                if (FileUpload_logo.HasFile && cc.logotipo!=null)
                {
                    string ext = System.IO.Path.GetExtension(FileUpload_logo.FileName);
                    
                    string path = Server.MapPath("logotipos//");


                    FileUpload_logo.SaveAs(cc.logotipo);
                    //Label1.Text = FileUpload_logo.PostedFile.ContentLength.ToString();
                    //Label2.Text = FileUpload1.PostedFile.ContentType;

                    //cc.logotipo = path + cc.logotipo + ".png";
                }

                if (FileUpload_logo.HasFile && cc.logotipo == null)
                {
                    string ext = System.IO.Path.GetExtension(FileUpload_logo.FileName);

                    string path = Server.MapPath("logotipos//");

                    Guid g;
                    g = new Guid();


                    FileUpload_logo.SaveAs(path + g + ".png");
                    //Label1.Text = FileUpload_logo.PostedFile.ContentLength.ToString();
                    //Label2.Text = FileUpload1.PostedFile.ContentType;

                    cc.logotipo = path + g + ".png";
                }


            //pe.clientcompanies.AddOrUpdate();
            //pe.SaveChanges();


            pe.clientcompanies.AddOrUpdate(cc);
            pe.SaveChanges();

        }

        protected void Button_BACK_Click(object sender, EventArgs e)
        {

        }
    }
}