using SummerPractice2023.ViewModels;
using System.Windows.Controls;

namespace SummerPractice2023.Views.UserView
{
    public partial class InfoUser : Page
    {
        public InfoUser(structV structv)
        {
            DataContext = new UserAR(structv);
            InitializeComponent();
        }
    }
}
