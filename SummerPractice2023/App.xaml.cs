using Newtonsoft.Json;
using SummerPractice2023.DB.Js;
using SummerPractice2023.Models;
using SummerPractice2023.Views;
using SummerPractice2023.Views.User;
using System.Collections.ObjectModel;
using System.Windows;

namespace SummerPractice2023
{
    public partial class App : Application
    {
        public ObservableCollection<JsData> jsData { get; set; }
        public App()
        {
            Resource.PastTopic();
            Resource.LanguageChange();
            if (SummerPractice2023.Properties.Settings.Default.UserId == "")
            {
                Authorization authorization = new Authorization(jsData);
                authorization.Show();
            }
            else
            {
                MainWindow mainWindow = new MainWindow(jsData);
                mainWindow.Show();
            }


        }
    }
}