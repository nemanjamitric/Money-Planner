using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stedex
{
    internal class SQLConn
    {
        private string conn = @"Data Source=DESKTOP-3R0CLGN;Initial Catalog=Cvetko4;Integrated Security=True";
        public string GetConn()
        {
            return conn;
        }
    }
}
