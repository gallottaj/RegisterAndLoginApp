using System;
using System.Collections.Generic;
using System.Linq;
using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Services
    //used to authenticate a user
{
    public class SecurityService
    {

        UsersDAO usersDAO = new UsersDAO();

        public SecurityService()
        {
        }

        public bool IsValid(UserModel user)
        {
            //passing in user object
            return usersDAO.FindUserByNameAndPassowrd(user);
            //return true if the user is found in the list
        }
    }
 }
