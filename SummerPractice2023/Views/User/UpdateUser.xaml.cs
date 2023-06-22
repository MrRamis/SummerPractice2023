using SummerPractice2023.ViewModels;
using System.Windows.Controls;

namespace SummerPractice2023.Views.User
{
    public partial class UpdateUser : Page
    {
        public UpdateUser()
        {
            DataContext = new UserAR();
            InitializeComponent();
        }
    }
}
