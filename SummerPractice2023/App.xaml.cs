using SummerPractice2023.Models;
using SummerPractice2023.Views;
using SummerPractice2023.Views.User;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SummerPractice2023
{
    public partial class App : Application
    {
        public App()
        {
            Resource.PastTopic();
            if (SummerPractice2023.Properties.Settings.Default.UserLodin == "")
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
