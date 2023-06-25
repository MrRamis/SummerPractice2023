using SummerPractice2023.DB;
using SummerPractice2023.DB.Js;
using SummerPractice2023.Models;
using SummerPractice2023.Views;
using SummerPractice2023.Views.UserView;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace SummerPractice2023.ViewModels
{
    internal class VMMainWindow : INotifyPropertyChanged
    {
        ObservableCollection<JsData> jsData { get; set; }
        structV structv;
        UpdateUser updateUser { get; set; }
        InfoUser infoUser { get; set; }
        TicketSearch ticketSearch { get; set; }
        public VMMainWindow(structV structV)
        {
            this.jsData = jsData;
           // jsData = CommandJson.GetAir();
            this.updateUser = new UpdateUser();
            this.infoUser = new InfoUser();
            this.ticketSearch = new TicketSearch(jsData);
        }
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
                    Authorization authorization = new Authorization(structv);
                    authorization.Show();
                    win.Close();
                });
            }
        }

        private RelayCommand _TicketSearch;
        public RelayCommand TicketSearch
        {
            get
            {
                return _TicketSearch ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    Frame block = wnd.FindName("Fram") as Frame;
                    block.Content = ticketSearch;
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
                    Window wnd = obj as Window;
                    Frame block = wnd.FindName("Fram") as Frame;
                    block.Content = updateUser;
                });
            }
        }
        private RelayCommand _InfoUser;
        public RelayCommand InfoUser
        {
            get
            {
                return _InfoUser ?? new RelayCommand(obj =>
                {
                    Window? wnd = obj as Window;
                    Frame? block = (Frame)wnd.FindName("Fram");
                    block.Content = infoUser;
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
