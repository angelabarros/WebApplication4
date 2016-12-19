using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        projetoEntities pe = new projetoEntities();
        template temp;
        List<tag> aux = new List<tag>();
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
                temp = new template();
                temp.name_template = FileUpload_templates.FileName;
                temp.URL_template = path + FileUpload_templates.FileName;
                pe.templates.Add(temp);
                pe.SaveChanges();
                
                store_tags_database();

            }
            else
            {

                Response.Write("<h3> Please select a file</h3>");
            }

        }


        protected void store_tags_database()
        {

            var application = new Microsoft.Office.Interop.Word.Application();
            var document = new Microsoft.Office.Interop.Word.Document();

            string path = Server.MapPath("templates//");
            document = application.Documents.Open(path + FileUpload_templates.FileName);

            application.Visible = true;
            var myHashMap = new Dictionary<string, tag>();
            
            foreach (Microsoft.Office.Interop.Word.Field f in document.Fields)
            {
                //int count_tags = pe.tags.Count();
                if (f.Code.Text.Contains("MERGEFIELD")){    

                    tag t = new tag();
                    t.name_tag = f.Code.Text.ToString();
                    t.id_template = temp.id_template;
                    t.status = 1;
                   // t.id_tag = count_tags + 1;
                   // pe.tags.Add(t);
                    aux.Add(t);
                    if (!myHashMap.ContainsKey(t.name_tag))
                    {
                        myHashMap.Add(t.name_tag, t);
                    }
                 
                }
            }



            //var uniqueValues = myHashMap.GroupBy(pair => pair.Value)
            //             .Select(group => group.First())
            //             .ToDictionary(pair => pair.Key, pair => pair.Value);

            int control = 0;

            foreach(tag t in myHashMap.Values)
             {
                pe.tags.Add(t);
             }

            //HashSet<string> hs = new HashSet<string>();

            //foreach (string name_of_tag in myHashMap.Values)
            //{
            //    if (!hs.Contains(name_of_tag))
            //    {
            //        hs.Add(name_of_tag);
            //    }
                
            //}

            //foreach (tag t in aux)
            //{
            //    foreach(Microsoft.Office.Interop.Word.Field f in document.Fields)
            //    {
            //        if (t.name_tag.Equals(f.Code.Text) && control==0)
            //        {
            //            control = 1;
            //            pe.tags.Add(t);
            //        }
            //    }
            //}


            pe.SaveChanges();

        }



    }
}
