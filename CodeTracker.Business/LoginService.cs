using CodeTracker.Workflow;
using CodeTracker.Models.User;

namespace CodeTracker.Business
{
    public class LoginService
    {
        public int GetUserID(EndUser endUser)
        {
            return UserRetrieval.GetUserIdFromDB(endUser);
        }
    }
}
