using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTracker.Models.User
{
    public class EndUser
    {
        [DisplayName("UserID")]
        public int EndUserUserid {  get; set; }

        [DisplayName("Username")]
        public string EndUserUsername { get; set; }

        [DisplayName("Password")]
        public string EndUserPassword { get; set; }

        public EndUser()
        {
            EndUserUserid = 0;
            EndUserUsername = string.Empty;
            EndUserPassword = string.Empty;
        }

        public EndUser(string endUserUsername, string endUserPassword)
        {
            EndUserUsername = endUserUsername;
            EndUserPassword = endUserPassword;
        }

        public EndUser(int endUserId, string endUserUsername, string endUserPassword) 
            : this(endUserUsername, endUserPassword)
        {
            EndUserUserid = endUserId;
        }
    }
}
