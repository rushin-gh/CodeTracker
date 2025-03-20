using CodeTracker.Models.User;
using CodeTracker.Workflow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTracker.Business
{
    public class LoginActivities
    {
        public EndUser GetUser(EndUser endUser)
        {
            return UserRetrieval.GetUserFromDB(endUser);
        }
    }
}
