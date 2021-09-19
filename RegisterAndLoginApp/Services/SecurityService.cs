using System;
using System.Collections.Generic;
using System.Linq;
using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Services
    //used to authenticate a user
{
    public class SecurityService
    {
        List<UserModel> knowUsers = new List<UserModel>();

        public SecurityService()
        {
            knowUsers.Add(new UserModel { Id = 0, UserName = "BillGates", Password = "bigbucks" });
            knowUsers.Add(new UserModel { Id = 1, UserName = "MarieCurie", Password = "radioactive" });
            knowUsers.Add(new UserModel { Id = 2, UserName = "WatsonCrick", Password = "dna" });
            knowUsers.Add(new UserModel { Id = 3, UserName = "AlexanderFlemming", Password = "peniciliin" });
        }
        //method to find out if it is a valid user login
        public bool IsValid(UserModel user)
        {
            //return true if the user is found in the list
            return knowUsers.Any(x => x.UserName == user.UserName && x.Password == user.Password);
        }
    }
 }
