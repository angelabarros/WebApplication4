using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xl = Microsoft.Office.Interop.Excel;

namespace LerExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            DataSet ds = new DataSet();
            var excelConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0", path);
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = excelConnectionString;

            DataTable sheets = Excel.GetSchemaTable(excelConnectionString);
            
            foreach (DataRow r in sheets.Rows)
            {
                string query = "SELECT * FROM [" + r.Item(0).ToString + "]";
                ds.Clear();
                OleDbDataAdapter data = new OleDbDataAdapter(query, connection);
                data.Fill(ds);

            }
            */


            // ... this code under a button on my sample
            /*
            xl.Application xlapp = new xl.Application();
            xl.Workbook wb = xlapp.Workbooks.Open(@"C:\Users\angel\Documents\Exemplo.xls", 0, true, 5, "", "", true, xl.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xl.Worksheet ws = (xl.Worksheet)wb.Sheets[1];
            */


            string path = @"C:\Users\angel\OneDrive\Documentos\Visual Studio 2015\Projects\Livro1.xls";
            string connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\"";

            DataTable sheets = Excel.GetSchemaTable(connStr);

            string sql = string.Empty;
            DataSet ds = new DataSet();
            foreach (DataRow dr in sheets.Rows)
            {  //Print_Area
                string WorkSheetName = dr["TABLE_NAME"].ToString().Trim();

                    sql = "SELECT * FROM [" + WorkSheetName + "]";
                    ds.Clear();
                    OleDbDataAdapter data = new OleDbDataAdapter(sql, connStr);
                    data.Fill(ds);

                    DataTable dt1 = ds.Tables[0];

                Console.WriteLine(WorkSheetName.ToString());
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        Console.WriteLine(dr1.ToString());
                    }

                    foreach (DataColumn dc in dt1.Columns)
                {

                    Console.WriteLine(dc.ColumnName);

                }
                
            }
        }

    }

}