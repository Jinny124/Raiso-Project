﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_PSD.Factories;
using Project_PSD.Models;

namespace Project_PSD.Repository
{
    public class UserRepository
    {
        static RAisoEntities1 db = Singleton.GetInstance();

        public List<MsUser> GetUsers()
        {
            return(from MsUser in db.MsUsers select MsUser).ToList();
        }

        public MsUser findId_User(int userId)
        {
           return(from MsUser in db.MsUsers
                  where MsUser.UserID == userId
                  select MsUser).FirstOrDefault();
        }

        public static void InsertUsers(int id, string username, string userGender, DateTime userDOB, string userPhone, string userAddress, string userPassword, string userRole)
        {
            MsUser temp = UserFactory.Create(id, username, userGender, userDOB, userPhone, userAddress, userPassword, userRole);
            db.MsUsers.Add(temp);
            db.SaveChanges();
        }

        public  void updateUser(int id, string username, string userGender, DateTime userDOB, string userPhone, string userAddress, string userPassword, string userRole)
        {
            MsUser updateUser = findId_User(id);
            updateUser.UserName = username;
            updateUser.UserGender = userGender;
            updateUser.UserDOB = userDOB;
            updateUser.UserPhone = userPhone;
            updateUser.UserAddress = userAddress;
            updateUser.UserPassword = userPassword;
            updateUser.UserRole = userRole;
            db.SaveChanges();
        }
    }
}