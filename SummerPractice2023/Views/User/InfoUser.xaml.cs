using SummerPractice2023.ViewModels;
using System.Windows.Controls;

namespace SummerPractice2023.Views.User
{
    public partial class InfoUser : Page
    {
        public InfoUser()
        {
            DataContext = new UserAR();
            InitializeComponent();
        }
    }
}
