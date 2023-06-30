using System;
using System.Windows;

namespace SummerPractice2023.Models
{
    internal class Resource
    {
        #region Command

        public static void ChangeTheTheme()
        {
            Uri? uri = null;
            if (SummerPractice2023.Properties.Settings.Default.Topics == "/Resources/Topics/dark")
            {
                uri = new Uri("Resources/Topics/light" + ".xaml", UriKind.Relative);
                SummerPractice2023.Properties.Settings.Default.Topics = "/Resources/Topics/light";
                SummerPractice2023.Properties.Settings.Default.Save();

                ResourceDictionary? resourceDict = Application.LoadComponent(uri) as ResourceDictionary;

                Uri? uri2 = new Uri("Resources/Topics/dark" + ".xaml", UriKind.Relative);
                ResourceDictionary? resourceDict2 = Application.LoadComponent(uri2) as ResourceDictionary;
                Application.Current.Resources.MergedDictionaries.Remove(resourceDict2);
                // Application.Current.Resources.
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            }
            else
            {
                uri = new Uri("Resources/Topics/dark" + ".xaml", UriKind.Relative);
                SummerPractice2023.Properties.Settings.Default.Topics = "/Resources/Topics/dark";
                SummerPractice2023.Properties.Settings.Default.Save();

                ResourceDictionary? resourceDict = Application.LoadComponent(uri) as ResourceDictionary;

                  Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            }
        }
        public static void DefaultTheme()
        {
            Uri uri = new Uri(SummerPractice2023.Properties.Settings.Default.TopicsDefault + ".xaml", UriKind.Relative);
            ResourceDictionary? resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
        public static void PastTopic()
        {
            Uri? uri = null;
            if (SummerPractice2023.Properties.Settings.Default.Topics == "/Resources/Topics/dark")
            {

                uri = new Uri("/Resources/Topics/dark" + ".xaml", UriKind.Relative);
                //    SummerPractice2023.Properties.Settings.Default.Topics = "/Resources/Topics/dark";
                //  SummerPractice2023.Properties.Settings.Default.Save();

                ResourceDictionary? resourceDict = Application.LoadComponent(uri) as ResourceDictionary;

                Uri? uri2 = new Uri("Resources/Topics/dark" + ".xaml", UriKind.Relative);
                ResourceDictionary? resourceDict2 = Application.LoadComponent(uri2) as ResourceDictionary;
                Application.Current.Resources.MergedDictionaries.Remove(resourceDict2);
                // Application.Current.Resources.
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            }
        }

        public static void LanguageChange()
        {
            Uri? uri = null;
            if (SummerPractice2023.Properties.Settings.Default.Language == "en")
            {
                uri = new Uri("Resources/Languages/lang.ru" + ".xaml", UriKind.Relative);
                SummerPractice2023.Properties.Settings.Default.Language = "ru";
                SummerPractice2023.Properties.Settings.Default.Save();

                ResourceDictionary? resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Remove("Resources/Languages/lang.en.xaml");
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            }
            else
            {
                uri = new Uri("Resources/Languages/lang.en" + ".xaml", UriKind.Relative);
                SummerPractice2023.Properties.Settings.Default.Language = "en";
                SummerPractice2023.Properties.Settings.Default.Save();

                ResourceDictionary? resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Remove("Resources/Languages/lang.ru.xaml");
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            }
        }
        #endregion
    }
}
