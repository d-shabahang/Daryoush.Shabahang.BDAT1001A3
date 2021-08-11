using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_3_BasicAuthenticationWEBAPI.Models
{
    public class UsersBL
    {
        public List<User> GetUsers()
        {
            // to keep focus on Basic Authentication
            // Here we are hardcoded the data
            List<User> userList = new List<User>();
            // usernames and passwords are based on the male gender
            userList.Add(new User()
            {
                ID = 101,
                UserName = "MaleUser",
                Password = "123456"
            });
            // usernames and passwords are based on the female gender
            userList.Add(new User()
            {
                ID = 102,
                UserName = "FemaleUser",
                Password = "abcdef"
            });
            // usernames and passwords are based on employees in the Marketing department
            userList.Add(new User()
            {
                ID = 103,
                UserName = "Marketing",
                Password = "1234mkt"
            });
            // usernames and passwords are based on employees in the IT department
            userList.Add(new User()
            {
                ID = 104,
                UserName = "IT",
                Password = "1234it"
            });
            // usernames and passwords are based on employees in the HR department
            userList.Add(new User()
            {
                ID = 105,
                UserName = "HR",
                Password = "1234hr"
            });
            // usernames and passwords are based on employees in the Technical department
            userList.Add(new User()
            {
                ID = 106,
                UserName = "Technical",
                Password = "1234tech"
            });
            return userList;
        }
    }
}