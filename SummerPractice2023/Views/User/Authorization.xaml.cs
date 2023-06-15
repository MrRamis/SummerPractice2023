using SummerPractice2023.ViewModels;
using System.Windows;

namespace SummerPractice2023.Views.User
{
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
            DataContext = new UserAR();
        }
    }
}
