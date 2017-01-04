using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConsoleApplication1;

namespace WebAppCliente
{

    public partial class UploadExcel : System.Web.UI.Page
    {

        projetoEntities pe = new projetoEntities();
        user logged;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                logged = (user)Session["User_logged"];

            }
            catch (NullReferenceException x)
            {
                Response.Redirect("RedirectingToLogin.aspx");
            }

        }


        public static DataTable GetSchemaTable(string connectionString)
        {
            using (OleDbConnection connection = new
                       OleDbConnection(connectionString))
            {
                connection.Open();
                DataTable schemaTable = connection.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });
                connection.Close();
                return schemaTable;

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            

            string pathserver = Server.MapPath("~/coisas//");
            FileUpload1.SaveAs(pathserver + FileUpload1.FileName);
            //string fileExtension = FileUpload1.FileName;

            string path = @"C:\Users\angel\OneDrive\Documentos\Visual Studio 2015\Projects\Livro2.xls";
            string connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathserver + FileUpload1.FileName + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\"";

            DataTable sheets = Excel.GetSchemaTable(connStr);

            string sql = string.Empty;
            DataSet ds = new DataSet();
            file f = new file();
            f.name_file = FileUpload1.FileName;
            pe.files.Add(f);
            pe.SaveChanges();

            foreach (DataRow dr in sheets.Rows)
            {  //Print_Area
                string WorkSheetName = dr["TABLE_NAME"].ToString().Trim();

                sql = "SELECT * FROM [" + WorkSheetName + "]";
                ds.Clear();
                OleDbDataAdapter data = new OleDbDataAdapter(sql, connStr);
                data.Fill(ds);
                
                spreadsheet s = new spreadsheet();
                s.name_spreadsheet = WorkSheetName;
                s.file = f.id_file;


                pe.spreadsheets.Add(s);
                pe.SaveChanges();

                DataTable dt1 = ds.Tables[0];

                Console.WriteLine(WorkSheetName.ToString());
                /*foreach (DataRow dr1 in dt1.Rows)
                {
                    Console.WriteLine(dr1.ToString());
                }
                */

                //int count = dt1.Columns.Count;

                foreach (DataColumn dc in dt1.Columns)
                {


                    // this.Label1.Text = (dc.ColumnName);
                    column_excel ce = new column_excel();
                    ce.name_column = dc.ColumnName;
                    ce.spreadsheet = s.id_spreadsheet;
                    
                    pe.column_excel.Add(ce);
                    pe.SaveChanges();

                }

            }

            }
        }
}
