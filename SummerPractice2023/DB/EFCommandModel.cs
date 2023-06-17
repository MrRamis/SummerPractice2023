using SummerPractice2023.DB.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace SummerPractice2023.DB
{
    public class EFCommandModel
    {
        public static void AddUser(string login, string password)
        {
            User user = new User()
            {
                IdUser = Convert.ToString(Guid.NewGuid()),
                Lodin = login,
                Password = password
            };
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public static User GetUser(string login, string password)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var user = db.Users.Where(p => p.Lodin == login && p.Password == password);
                if (user.Count() > 0)
                {
                    SummerPractice2023.Properties.Settings.Default.UserId = user.ToList()[0].IdUser;
                    SummerPractice2023.Properties.Settings.Default.Save();
                    return user.ToList()[0];
                }
                else
                    return null;
            }
        }
        public static User GetUser(string Id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User user = null;
                user = db.Users.Find(Id);
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
