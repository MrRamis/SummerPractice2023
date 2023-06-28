using System.ComponentModel.DataAnnotations;

namespace SummerPractice2023.DB.Tables
{
    public class User
    {
        [Key]
        public string IdUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public string? Status { get; set; }
        public string? Mail { get; set; }
    }
}