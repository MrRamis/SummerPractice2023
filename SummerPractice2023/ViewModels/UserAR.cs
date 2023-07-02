using SummerPractice2023.DB;
using SummerPractice2023.DB.Tables;
using SummerPractice2023.Models;
using SummerPractice2023.Views;
using SummerPractice2023.Views.UserView;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SummerPractice2023.ViewModels
{
    public class UserAR : INotifyPropertyChanged
    {
        #region Variables
        public ObservableCollection<DB.Post> posts { get; set; }
        private DB.Post _ItemPosts;
        public DB.Post ItemPosts
        {
            get
            {
                return _ItemPosts;
            }

            set
            {
                _ItemPosts = value;
                if (ItemPosts != null)
                {

                    foreach (var post in structv.posts)
                    {
                        if (post.IdPosts == _ItemPosts.IdPosts)
                        {
                            post.IdPosts = EFCommandModel.AddPostNumberOfViews(ItemPosts).IdPosts;
                        }
                    }
                    Views.DetailingPosts detailingPosts = new Views.DetailingPosts(ItemPosts);
                    detailingPosts.ShowDialog();
                    _ItemPosts = null;
                }
            }
        }
        public User User
        {
            get
            {
                return structv.User;
            }
            set
            {
                structv.User = value;
                NotifyPropertyChanged("User");
            }
        }
        structV structv;
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
                _Password = Hash.hashPassword(value);
                NotifyPropertyChanged("Password");
            }
        }

        private string _Image;
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

        private string _Family;
        public string Surname
        {
            get
            {
                return _Family;
            }
            set
            {
                _Family = value;
                NotifyPropertyChanged("Surname");
            }
        }

        private string _Patronymic;
        public string Patronymic
        {
            get
            {
                return _Patronymic;
            }
            set
            {
                _Patronymic = value;
                NotifyPropertyChanged("Patronymic");
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
        }
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
                        if (!(Password == null) || !(Lodin == null) || !Lodin.Contains(" ") || !Password.Contains(" ") || !Lodin.Contains("") || !Password.Contains(""))
                        {
                            if (EFCommandModel.GetUser(Lodin, Hash.hashPassword(Password)) == null)
                            {
                                EFCommandModel.AddUser(Lodin, Hash.hashPassword(Password));
                            }
                            else
                            {
                                TextBox? TextBoxLodin = wnd.FindName("Lodin") as TextBox;
                                TextBox? TextBoxPassword = wnd.FindName("Password") as TextBox;
                                TextBoxLodin.Background = Brushes.Red;
                                TextBoxPassword.Background = Brushes.Red;
                            }
                        }
                        else
                        {
                            TextBox? TextBoxLodin = wnd.FindName("Lodin") as TextBox;
                            TextBox? TextBoxPassword = wnd.FindName("Password") as TextBox;
                            TextBoxLodin.Background = Brushes.Red;
                            TextBoxPassword.Background = Brushes.Red;
                        }
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
        private RelayCommand _UpdateStatus;
        public RelayCommand UpdateStatus
        {
            get
            {
                return _UpdateStatus ?? new RelayCommand(obj =>
                {
                    User user = structv.User;
                    user.Status = Status;
                    structv.User = EFCommandModel.UpdateUser(user);
                });
            }
        }
        private RelayCommand _DeleteUser;
        public RelayCommand DeleteUser
        {
            get
            {
                return _DeleteUser ?? new RelayCommand(obj =>
                {
                    EFCommandModel.DelettUser(structv.User);
                    SummerPractice2023.Properties.Settings.Default.Reset();
                });
            }
        }
        private RelayCommand _UpdateUser;
        public RelayCommand UpdateUser
        {
            get
            {
                return _UpdateUser ?? new RelayCommand(obj =>
                {
                    User user = structv.User;
                    user.Status = Status;
                    user.Image = Image;
                    user.Login = Lodin;
                    user.Password = Password;
                    user.Name = Name;
                    user.Surname = Surname;
                    user.Patronymic = Patronymic;
                    structv.User = EFCommandModel.UpdateUser(user);
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

                    if (!Lodin.Contains(" ") || !Password.Contains(" ") || !Lodin.Contains("") || !Password.Contains(""))
                    {
                        if (EFCommandModel.GetUser(Lodin, Hash.hashPassword(Password)) != null)
                        {
                            MainWindow mainWindow = new MainWindow(structv);
                            mainWindow.Show();
                            wnd.Close();
                        }
                        else
                        {
                            TextBox? TextBoxLodin = wnd.FindName("Lodin") as TextBox;
                            TextBox? TextBoxPassword = wnd.FindName("Password") as TextBox;
                            TextBoxLodin.Background = Brushes.Red;
                            TextBoxPassword.Background = Brushes.Red;
                        }
                    }
                    else
                    {
                        TextBox? TextBoxLodin = wnd.FindName("Lodin") as TextBox;
                        TextBox? TextBoxPassword = wnd.FindName("Password") as TextBox;
                        TextBoxLodin.Background = Brushes.Red;
                        TextBoxPassword.Background = Brushes.Red;
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

        private RelayCommand _DetailingPosts;
        public RelayCommand DetailingPosts
        {
            get
            {
                return _DetailingPosts ?? new RelayCommand(obj =>
                {
                    if (ItemPosts != null)
                    {
                        Views.DetailingPosts detailingPosts = new Views.DetailingPosts(ItemPosts);
                        detailingPosts.ShowDialog();
                        EFCommandModel.AddPostNumberOfViews(ItemPosts);
                    }
                });
            }
        }
        #endregion
        public UserAR(structV structV)
        {
            this.structv = structV;
            this.Status = "";
            if (structv.User != null)
            {
                structv.jsData = EFCommandModel.JsDataAndDataLice(structv.jsData);
                this.Status = "";
                this.Image = structV.User.Image;
                this.Lodin = structV.User.Login;
                this.Password = structV.User.Password;
                this.Status = structV.User.Status;
                this.Name = structV.User.Name;
                this.Surname = structV.User.Surname;
                this.Patronymic = structV.User.Patronymic;
            }
            posts = structV.posts;
        }

        public UserAR()
        {
            this.Status = "";
        }

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
