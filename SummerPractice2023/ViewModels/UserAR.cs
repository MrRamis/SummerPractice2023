using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Logging;
using SummerPractice2023.DB;
using SummerPractice2023.Models;
using SummerPractice2023.Views;
using SummerPractice2023.Views.User;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml.Linq;

namespace SummerPractice2023.ViewModels
{
    internal class UserAR : INotifyPropertyChanged
    {
        #region Variables
/*        private string _IdUser;
        public string IdUser
        {
            get
            {
                return _IdUser;
            }
            set
            {
                _IdUser = value;
                NotifyPropertyChanged("IdUser");
            }
        }*/

        private string _Lodin;
        public string Lodin
        {
            get
            {
                return _Lodin;
            }
            set
            {
                _Lodin = value;
                NotifyPropertyChanged("Lodin");
            }
        }

        private string _Password;
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
                NotifyPropertyChanged("Password");
            }
        }

 /*       private string _Image;
        public string Image
        {
            get
            {
                return _Image;
            }
            set
            {
                _Image = value;
                NotifyPropertyChanged("Image");
            }
        }

        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                NotifyPropertyChanged("Name");
            }
        }

        private string _Lastname;
        public string Lastname
        {
            get
            {
                return _Lastname;
            }
            set
            {
                _Lastname = value;
                NotifyPropertyChanged("Lastname");
            }
        }

        private string _Surname;
        public string Surname
        {
            get
            {
                return _Surname;
            }
            set
            {
                _Surname = value;
                NotifyPropertyChanged("Surname");
            }
        }

        private string _Status;
        public string Status
        {
            get
            {
                return _Status;
            }
            set
            {
                _Status = value;
                NotifyPropertyChanged("Status");
            }
        }*/
        #endregion
        #region Command
        private RelayCommand _RegistrationUser;
        public RelayCommand RegistrationUser
        {
            get
            {
                return _RegistrationUser ?? new RelayCommand(obj =>
                {
                    Window? wnd = obj as Window;
                   
                    if (EFCommandModel.GetUser(Lodin) != null)
                    {
                        MessageBox.Show("lodin");
                    }
                    else
                    {
                        EFCommandModel.AddUser(Lodin, Hash.hashPassword(Password));
                    }
                    wnd.Close();
                });
            }
        }
        private RelayCommand _RegistrationUserWindow;
        public RelayCommand RegistrationUserWindow
        {
            get
            {
                return _RegistrationUserWindow ?? new RelayCommand(obj =>
                {
                    Registration registration = new Registration();
                    registration.ShowDialog();
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
                    Window? wnd = obj as Window;
                    if (EFCommandModel.GetUser(Lodin, Hash.hashPassword(Password)) == null && Lodin.Length < 3 && Password.Length < 3)
                    {
                        TextBox? TextBoxLodin = wnd.FindName("Lodin") as TextBox;
                        TextBox? TextBoxPassword = wnd.FindName("Password") as TextBox;
                        TextBoxLodin.Background = Brushes.Red;
                        TextBoxPassword.Background = Brushes.Red;
                    }
                    else
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        wnd.Close();
                    }
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
