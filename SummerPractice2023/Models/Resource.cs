using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Application.Current.Resources.Remove("Resources/Topics/dark.xaml");
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            }
            else
            {
                uri = new Uri("Resources/Topics/dark" + ".xaml", UriKind.Relative);
                SummerPractice2023.Properties.Settings.Default.Topics = "/Resources/Topics/dark";
                SummerPractice2023.Properties.Settings.Default.Save();

                ResourceDictionary? resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Remove("Resources/Topics/light.xaml");
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
                uri = new Uri("Resources/Topics/dark" + ".xaml", UriKind.Relative);
                ResourceDictionary? resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Remove("Resources/Topics/light.xaml");
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            }
            else
            {
                uri = new Uri("Resources/Topics/light" + ".xaml", UriKind.Relative);
                ResourceDictionary? resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Remove("Resources/Topics/dark.xaml");
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            }
        }




        #endregion
    }
}
