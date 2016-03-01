using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoverTree.Framework
{
    public class SQLTools
    {
        public static string GetQuotes(string sql)
        {
            if (string.IsNullOrEmpty(sql))
                return "''";
            return "'" + sql.Replace("'", "''") + "'";
        }
    }
}