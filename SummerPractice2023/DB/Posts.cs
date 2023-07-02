using System.ComponentModel.DataAnnotations;

namespace SummerPractice2023.DB
{
    public class Posts
    {
        [Key]
        public string IdPosts { get; set; }
        public string? Author { get; set; }
        public string? Imade { get; set; }
        public string? Description { get; set; }
        public string? NumberOfViews { get; set; }//количество просмотров
        public string? Category { get; set; }//категория
    }
}
