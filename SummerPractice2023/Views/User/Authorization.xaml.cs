using SummerPractice2023.DB.Js;
using SummerPractice2023.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace SummerPractice2023.Views.User
{
    public partial class Authorization : Window
    {
        public Authorization(ObservableCollection<JsData> jsData)
        {
            InitializeComponent();
            DataContext = new UserAR(jsData);
        }
    }
}
