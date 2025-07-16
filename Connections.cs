using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal static class Connections
    {
        public const string sqlConStr = """
               Server=LAPTOP-RC6D5TQC\SQL2019;
               Database=dbToDoList;
               User Id=sa;
               Password=123456;
               TrustServerCertificate=True;
            """;
    }
}
