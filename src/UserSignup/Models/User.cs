using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class User
    {
        // TODO 1: Add UserId, CreateDate and a few more properties of your choosing.  Update the Add and Index views 
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
        private DateTime Created; 
        
        // add a constructor to set the CreateDate when a new user is instantiated      
        public User(string uname,string email,string pword)
        {
            Email = email;
            Username = uname;
            Password = pword;
            Created = DateTime.Now;

        }

        public User() { }


    }
}
