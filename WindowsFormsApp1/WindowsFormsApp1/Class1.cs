using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Class1
    {
        string conn;

        public string connection()
        {
            conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ravindu\\Desktop\\HC1.accdb";
            return conn;
        }
    }
}
