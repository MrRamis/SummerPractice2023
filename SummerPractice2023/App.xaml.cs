using SummerPractice2023.DB;
using SummerPractice2023.Models;
using SummerPractice2023.Views;
using System.Windows;

namespace SummerPractice2023
{
    public partial class App : Application
    {
        public structV structv;
        public App()
        {
            structv = new structV
            {
                jsData = CommandJson.GetAir("https://pastebin.com/raw/BhAvx5UV"),
                User = null,
                posts = EFCommandModel.GetPots()

            };

            if (SummerPractice2023.Properties.Settings.Default.UserId == "")
            {
                Views.UserView.Authorization authorization = new Views.UserView.Authorization(structv);
                authorization.Show();
            }
            else
            {
                structv.jsData = EFCommandModel.JsDataAndDataLice(structv.jsData);
                structv.User = EFCommandModel.GetUserId(SummerPractice2023.Properties.Settings.Default.UserId);
                MainWindow mainWindow = new MainWindow(structv);
                mainWindow.Show();
            }
             Resource.LanguageChange();
        }
    }
}