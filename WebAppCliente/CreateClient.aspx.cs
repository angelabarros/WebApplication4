using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class CreateClient : System.Web.UI.Page
    {

        projetoEntities pe = new projetoEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void Button_NEXT_Click(object sender, EventArgs e)
        {
            int j;
            if (Int32.TryParse(txtTelephone.Text, out j))
            {
                //ok
            }
            else
            {
                Console.WriteLine("String could not be parsed.");
            }
                


            clientcompany new_client = new clientcompany();
            new_client.name_company = txtName.Text;
            new_client.address = txtAddress.Text;
            new_client.Domain = txtDomain.Text;
            new_client.email = txtEmail.Text;
            new_client.telephone = j;
           // new_client.logotipo = FileUpload_logo.

             if (FileUpload_logo.HasFile)
            {
                string ext = System.IO.Path.GetExtension(FileUpload_logo.FileName);

                string path = Server.MapPath("logotipos//");

                Guid g;
              
                g = Guid.NewGuid();


                FileUpload_logo.SaveAs(path + g + ".png");
                Label1.Text = FileUpload_logo.PostedFile.ContentLength.ToString();
                //Label2.Text = FileUpload1.PostedFile.ContentType;

                new_client.logotipo = path + g + ".png";
            }
            else
            {

                Response.Write("<h3> Please select a file</h3>");
            }


            int control = pe.clientcompanies.Count();
            pe.clientcompanies.Add(new_client);
            pe.SaveChanges();

            if(pe.clientcompanies.Count() == control + 1)
            {
                //clear fields
                
                txtName.Text = "";
                txtAddress.Text = "";
                txtEmail.Text = "";
                txtTelephone.Text = "";
                Label1.Text = "Client created with success";
                
            }
        }

        protected void Button_BACK_Click(object sender, EventArgs e)
        {

        }
    }
}