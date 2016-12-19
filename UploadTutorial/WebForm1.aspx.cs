using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UploadTutorial
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string ext = System.IO.Path.GetExtension(FileUpload1.FileName);

                string path = Server.MapPath("documents//");
                FileUpload1.SaveAs(path + FileUpload1.FileName);
                Label1.Text = FileUpload1.PostedFile.ContentLength.ToString();
                Label2.Text = FileUpload1.PostedFile.ContentType;

            }else
            {

                Response.Write("<h3> Please select a file</h3>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<String> rows = new List<string>();
            rows = Excel.read_excel(Server.MapPath("~/documents/Exemplo.xls"));
            

            foreach (String r in rows) {
                Response.Write(r);
            }
            
        }
    }
}