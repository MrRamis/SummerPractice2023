using SummerPractice2023.ViewModels;
using System.Windows;

namespace SummerPractice2023.Views.UserView
{
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            DataContext = new UserAR();
        }
    }
}
