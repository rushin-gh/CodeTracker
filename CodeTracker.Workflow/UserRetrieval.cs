using System.Data;
using System.Data.SqlClient;
using CodeTracker.Config;
using CodeTracker.Models.User;

namespace CodeTracker.Workflow
{
    public static class UserRetrieval
    {
        public static int GetUserIdFromDB(EndUser endUser)
        {
            int userId = 0;

            string connectionString = Database.ConnectionString;
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand("GetUser", sqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", endUser.EndUserUsername);
                    cmd.Parameters.AddWithValue("@password", endUser.EndUserPassword);

                    var cmdResult = cmd.ExecuteScalar();
                    if (cmdResult != null)
                    {
                        userId = (int)cmdResult;
                    }
                }
                sqlConnection.Close();
            }

            return userId;
        }
    }
}
