using CodeTracker.Models.User;
using CodeTracker.Config;
using System.Data.SqlClient;
using System.Data;

namespace CodeTracker.Workflow
{
    public static class UserRetrieval
    {
        public static EndUser GetUserFromDB(EndUser endUser)
        {
            int userId = -1;
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
            endUser.EndUserUserid = userId;
            return endUser;
        }
    }
}
