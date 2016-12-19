using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static List<String> rows_read;
        private static Boolean stop;
        private static List<String> aux;

        static void Main(string[] args)
        {
           rows_read = Excel.read_excel("/Exemplo.xls");

          // Excel.read_column("B0:B6");

          
           
        }
    }
}
