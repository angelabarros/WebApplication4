using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace ConsoleApplication1
{
    public class Excel
    {
        public static List<String> read_excel(string path)
        {
            List<String> rows = new List<string>();
            string con =
      @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";" +
      @"Extended Properties='Excel 8.0;HDR=Yes;'";
            //@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\angel\Documents\Exemplo.xls;" +
            //@"Extended Properties='Excel 8.0;HDR=Yes;'";

            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [Folha1$]", connection);


                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        for (var i = 0; i < dr.FieldCount; i++)
                        {

                            var row1Col0 = dr[i];
                            rows.Add(row1Col0.ToString());
                            // Console.WriteLine(row1Col0);
                        }




                    }
                }

                return rows;


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




public static void read_column(String Column)
        {
            List<String> rows = new List<string>();
            string con =
      @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\angel\Documents\Exemplo.xls;" +
      @"Extended Properties='Excel 8.0;HDR=Yes;'";


            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("select * from [Folha1$" + Column + "]", connection);


                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        for (var i = 0; i < dr.FieldCount; i++)
                        {

                            var row1Col0 = dr[i];
                            rows.Add(row1Col0.ToString());
                            Console.WriteLine(row1Col0);
                        }

                    }
                }




            }

        }


        /*

        public static void teste()
        {

            Query = "Select * from [Folha1$]";
            //Create OleDbCommand to fetch data from Excel
            OleDbCommand cmd = new OleDbCommand(Query, excelCon);
            //System.Data.OleDb.OleDbDataReader dReader;              
            DataSet ds = new DataSet();
            OleDbDataAdapter oda = new OleDbDataAdapter(Query, excelCon);
            excelCon.Close();
            oda.Fill(ds);
            DataTable Exceldt = ds.Tables[0];

            foreach (DataRow dr in Exceldt.Rows)
            {
                // ExampleModel NewModel = new ExampleModel();
                //Pass values to model whatever your model is.
                //Add to your dbContext
                //dbContext.tableName.Add(NewModel);
                //dbContext.SaveChanges();
                Console.WriteLine(dr[["nome_coluna");
            }
            return RedirectToAction("Import");


        }
        */
    }
}