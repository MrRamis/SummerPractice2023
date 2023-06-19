using SummerPractice2023.Models;
using SummerPractice2023.Views.User;
using System.ComponentModel;
using System.Windows;

namespace SummerPractice2023.ViewModels
{
    internal class VMMainWindow : INotifyPropertyChanged
    {
       
        #region Command
        private RelayCommand _ChangeTheTheme;
        public RelayCommand ChangeTheTheme
        {
            get
            {
                return _ChangeTheTheme ?? new RelayCommand(obj =>
                {
                    Resource.ChangeTheTheme();
                });
            }
        }
        private RelayCommand _LanguageChange;
        public RelayCommand LanguageChange
        {
            get
            {
                return _LanguageChange ?? new RelayCommand(obj =>
                {
                    Resource.LanguageChange();
                });
            }
        }

        private RelayCommand _EndUser;
        public RelayCommand EndUser
        {
            get
            {
                return _EndUser ?? new RelayCommand(obj =>
                {
                    Window? win = obj as Window;
                    SummerPractice2023.Properties.Settings.Default.Reset();
                    Authorization authorization = new Authorization();
                    authorization.Show();
                    win.Close();
                });
            }
        }

        /*
          private RelayCommand _AuthorizationUser;
          public RelayCommand AuthorizationUser
          {
              get
              {
                  return _AuthorizationUser ?? new RelayCommand(obj =>
                  {

                  });
              }
          }*/
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
