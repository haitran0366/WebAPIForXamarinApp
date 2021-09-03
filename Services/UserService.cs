using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIForXamarinApp.Models;

namespace WebAPIForXamarinApp.Services
{
    public class UserService
    {
        static List<UserModel> Users { get; }

        static UserService()
        {
            Users = new List<UserModel>
            {
                new UserModel { Id = 1, UserName = "hai123", Email = "haitran_usa@yahoo.com",Password="123456" },
                new UserModel { Id = 2, UserName = "hai321", Email = "haitran_usa@yahoo.com",Password="654321"}
            };
        }
        public static List<UserModel> GetAll() => Users;
        public static UserModel GetUser(string userName, string password) => Users.FirstOrDefault(p => p.UserName == userName & p.Password == password);

        public static void Add(UserModel user)
        {
            user.Id = Users.Count + 1;
            Users.Add(user);

        }

    }
}
