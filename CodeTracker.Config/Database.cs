using System.Configuration;

namespace CodeTracker.Config
{
    public static class Database
    {
        public static string ConnectionString =>  ConfigurationManager.ConnectionStrings["CT-DB"].ToString();
    }
}
