using SummerPractice2023.DB.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerPractice2023.DB
{
    public interface IEFCommandModel : IDisposable
    {
        Task<List<User>> GetUsers();
        Task<User> GetUser(string login, string password);
        Task<User> GetUser(string Id);
        Task AddUser(string login, string password);


    }
}
