using SummerPractice2023.DB.Tables;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SummerPractice2023.DB
{
    public class EFCommandModel
    {
        public static void AddUser(string login, string password)
        {
            User user = new User()
            {
                IdUser = Convert.ToString(Guid.NewGuid()),
                Login = login,
                Password = password
            };
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        public static User UpdateUser(User user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // Редактирование
                User userN = GetUserId(user.IdUser);
                db.Attach(userN);
                if (userN != null)
                {
                    userN.Name = user.Name;
                    userN.Status = user.Status;
                    userN.Surname = user.Surname;
                    userN.Login = user.Login;
                    userN.Password = user.Password;
                    userN.Patronymic = user.Patronymic;
                    userN.Image = user.Image;
                }
                db.SaveChanges();
                return userN;
            }
        }
        public static void DelettUser(User user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
        public static User GetUser(string login, string password)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var user = db.Users.FirstOrDefault(p => p.Login == login && p.Password == password);
                if (user != null)
                {
                    SummerPractice2023.Properties.Settings.Default.UserId = user.IdUser;
                    SummerPractice2023.Properties.Settings.Default.Save();
                    return user;
                }
                else
                    return null;
            }
        }
        public static User GetUserId(string Id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User user = null;
                user = db.Users.FirstOrDefault(p => p.IdUser == Id);
                return user;
            }
        }
        public static User GetUser(string login)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User user = null;
                user = db.Users.FirstOrDefault(p => p.Login == login);
                return user;
            }
        }
        public static List<User> GetUsers()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Users.ToList();
            }
        }
    }
}
