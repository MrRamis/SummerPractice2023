using SummerPractice2023.DB.Js;
using SummerPractice2023.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace SummerPractice2023.Views.UserView
{
    public partial class Authorization : Window
    {
        public Authorization(structV structV)
        {
            InitializeComponent();
            DataContext = new UserAR(structV);
        }
    }
}
