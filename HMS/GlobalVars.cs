using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public static class GlobalVars
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0AIDSV1\SQLEXPRESS;Initial Catalog=hosysdb;Integrated Security=True");
    }
}
