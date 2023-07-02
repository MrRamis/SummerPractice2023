using SummerPractice2023.ViewModels;
using System.Windows;

namespace SummerPractice2023.Views
{
    public partial class DetailingPosts : Window
    {
        public DetailingPosts(DB.Posts posts)
        {
            DataContext = new VMPosts(posts);
            InitializeComponent();
        }
    }
}
