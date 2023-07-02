using System.ComponentModel.DataAnnotations;

namespace SummerPractice2023.DB
{
    public class Post
    {
        [Key]
        public string IdPosts { get; set; }
        public string? Heading { get; set; }
        public string? Author { get; set; }
        public string? Imade { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public int? NumberOfViews { get; set; }//количество просмотров
        public string? Category { get; set; }//категория
    }
}
