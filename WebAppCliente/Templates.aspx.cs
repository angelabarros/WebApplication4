using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class Templates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_UPLOAD_Click(object sender, EventArgs e)
        {
            if (FileUpload_templates.HasFile)
            {

             

                string ext = System.IO.Path.GetExtension(FileUpload_templates.FileName);

                string path = Server.MapPath("templates//");
                FileUpload_templates.SaveAs(path + FileUpload_templates.FileName);
                //Label1.Text = FileUpload1.PostedFile.ContentLength.ToString();
                //Label2.Text = FileUpload1.PostedFile.ContentType;

            }
            else
            {

                Response.Write("<h3> Please select a file</h3>");
            }
        
    }
    }
}