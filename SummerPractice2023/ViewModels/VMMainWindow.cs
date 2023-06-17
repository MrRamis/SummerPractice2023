using SummerPractice2023.Models;
using System.ComponentModel;

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
        

        /*  private RelayCommand _RegistrationUser;
          public RelayCommand RegistrationUser
          {
              get
              {
                  return _RegistrationUser ?? new RelayCommand(obj =>
                  {

                  });
              }
          }

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
