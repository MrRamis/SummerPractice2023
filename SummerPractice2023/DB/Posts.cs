using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerPractice2023.DB
{
    public class Posts
    {
        public string? Author { get ; set; }
        public string? Imade { get; set; }
        public string? Description { get; set; }
        public string? NumberOfViews { get; set; }//количество просмотров
        public string? Category { get; set; }//категория
    }
}
