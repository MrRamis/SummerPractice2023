using SummerPractice2023.Models;
using SummerPractice2023.Views;
using SummerPractice2023.Views.User;
using System;
using System.Windows;

namespace SummerPractice2023
{
    public partial class App : Application
    {
        public App()
        {
               Resource.PastTopic();
               Resource.LanguageChange();
        
            if (SummerPractice2023.Properties.Settings.Default.UserId == "")
            {
                Authorization authorization = new Authorization();
                authorization.Show();
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
        }
    }
}