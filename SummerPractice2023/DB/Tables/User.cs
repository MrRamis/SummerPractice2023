using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SummerPractice2023.DB.Tables
{
    public class User
    {
        [Key]
        public string IdUser { get; set; }
        public string Lodin { get; set; }
        public string Password { get; set; }
      //  public Image? Image { get; set; }
        public string? Name { get; set; }
        public string? Lastname { get; set; }
        public string? Surname { get; set; }
        public string? Status { get; set; }
    }
}
