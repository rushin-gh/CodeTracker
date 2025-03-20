using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTracker.Config
{
    public static class Database
    {
        public static string ConnectionString =>  ConfigurationManager.ConnectionStrings["CT-DB"].ToString();
    }
}
