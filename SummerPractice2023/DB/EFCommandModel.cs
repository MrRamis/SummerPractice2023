using SummerPractice2023.DB.Js;
using SummerPractice2023.DB.Tables;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public static void AddData(JsData jsData)
        {
            if (GetData(jsData.searchToken, SummerPractice2023.Properties.Settings.Default.UserId) == null)
            {
                Data data = new Data();
                data.startDate = jsData.startDate;
                data.endDate = jsData.endDate;
                data.searchToken = jsData.searchToken;
                data.startCity = jsData.startCity;
                data.endCity = jsData.endCity;
                data.price = jsData.price;
                data.startCityCode = jsData.startCityCode;
                data.endCityCode = jsData.endCityCode;
                data.IdUser = SummerPractice2023.Properties.Settings.Default.UserId;
                using (ApplicationContext db = new ApplicationContext())
                {
                    db.Datas.Add(data);
                    db.SaveChanges();
                }
            }
        }

        public static ObservableCollection<JsData> JsDataAndDataLice(ObservableCollection<JsData> jsDatas)
        {
            foreach (var item in jsDatas)
            {
                var data = GetData(item.searchToken, SummerPractice2023.Properties.Settings.Default.UserId);
                if (data != null)
                    item.Like = true;
                else
                    item.Like = false;
            }
            return jsDatas;
        }

        public static Data GetData(string searchToken, string IdUser)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var data = db.Datas.FirstOrDefault(p => p.searchToken == searchToken && p.IdUser == IdUser);
                if (data != null)
                {
                    return data;
                }
                else
                    return null;
            }
        }
        public static void DeletData(Data data)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Datas.Remove(data);
                db.SaveChanges();
            }
        }
        public static void DeletData(JsData Jsdata)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var data = GetData(Jsdata.searchToken, SummerPractice2023.Properties.Settings.Default.UserId);
                if (data != null)
                {
                    db.Datas.Remove(data);
                    db.SaveChanges();
                }
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
