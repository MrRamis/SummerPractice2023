using SummerPractice2023.ViewModels;
using System.Windows.Controls;

namespace SummerPractice2023.Views.UserView
{
    public partial class UpdateUser : Page
    {
        public UpdateUser(structV structv)
        {
            DataContext = new UserAR(structv);
            InitializeComponent();
        }
    }
}
