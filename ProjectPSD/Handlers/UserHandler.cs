using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_PSD.Models;
using Project_PSD.Factories;
using Project_PSD.Repository;

namespace Project_PSD.Handlers
{
    public class UserHandler
    {
        UserRepository userrepo = new UserRepository();

        public List<MsUser> getAllUser(int userId)
        {
            return userrepo.GetUsers();
        }

        public MsUser getUserBYid(int userId) 
        {
            return userrepo.findId_User(userId);
        }

        public void insertUser(int UserID, String UserName, String UserGender, DateTime UserDOB, String UserPhone, String UserAddress, String UserPassword, String UserRole)
        {
            
            UserRepository.InsertUsers(UserID, UserName, UserGender, UserDOB, UserPhone, UserAddress, UserPassword, UserRole);
        }
    }
}