using SummerPractice2023.DB;
using SummerPractice2023.DB.Js;
using SummerPractice2023.DB.Tables;
using SummerPractice2023.Models;
using SummerPractice2023.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using static SummerPractice2023.ViewModels.VMMainWindow;

namespace SummerPractice2023.ViewModels
{
    public class VMTicketSearch : INotifyPropertyChanged
    {
        public ICollectionView _LogEntriesStoreView;
        public ICollectionView LogEntriesStoreView
        {
            get
            {
                return _LogEntriesStoreView;
            }
            set { _LogEntriesStoreView = value;
                NotifyPropertyChanged("LogEntriesStoreView");
            }
        }
        
        public ObservableCollection<JsData> jsData { get; set; }
        structV structv;
        private string _StartCity;
        public string StartCity
        {
            get
            {
                return _StartCity;
            }
            set
            {
                _StartCity = value;
                NotifyPropertyChanged("StartCity");
            }
        }
        private string _EndCity;
        public string EndCity
        {
            get
            {
                return _EndCity;
            }
            set
            {
                _EndCity = value;
                NotifyPropertyChanged("EndCity");
            }
        }

        private JsData _jsDataItem;
        public JsData JsDataItem
        {
            get
            {
                return _jsDataItem;
            }
            set
            {
                _jsDataItem = value;
                NotifyPropertyChanged("JsDataItem");
            }
        }
        public VMTicketSearch(structV structv)
        {
            this.jsData = structv.jsData;
            this.structv = structv;
            LogEntriesStoreView = CollectionViewSource.GetDefaultView(structv.jsData);
            this.StartCity = "";
            this.EndCity = "";
        }
  
        #region Command
        private RelayCommand _Select;
        public RelayCommand Select
        {
            get
            {
                return _Select ?? new RelayCommand(obj =>
                {
                    LogEntriesStoreView.Filter = Filter;
                    LogEntriesStoreView.Refresh();
                });
            }
        }
        private RelayCommand _Clean;
        public RelayCommand Clean
        {
            get
            {
                return _Clean ?? new RelayCommand(obj =>
                {
                    StartCity = "";
                    EndCity = "";
                    LogEntriesStoreView.Filter = Filter;
                    LogEntriesStoreView.Refresh();
                });
            }
        }
        private RelayCommand _Update;
        public RelayCommand Update
        {
            get
            {
                return _Update ?? new RelayCommand(obj =>
                {
                    StartCity = "";
                    EndCity = "";
                    LogEntriesStoreView.Filter = Filter;
                    LogEntriesStoreView.Refresh();
                    structv.jsData = CommandJson.GetAir("https://pastebin.com/raw/BhAvx5UV");
                    LogEntriesStoreView = CollectionViewSource.GetDefaultView(structv.jsData);
                    LogEntriesStoreView.Refresh();
                });
            }
        }

        private RelayCommand _InfoJsDataItem;
        public RelayCommand InfoJsDataItem
        {
            get
            {
                return _InfoJsDataItem ?? new RelayCommand(obj =>
                {
                    DetailingTicketSearch detailingTicketSearch = new DetailingTicketSearch(JsDataItem);
                });
            }
        }

    

        #endregion

        #region Filter
        public bool Filter(object sender)
        {
            var obj = sender as JsData;
            if (obj != null)
            {
                if (StartCity != "" && EndCity != "")
                {
                    if (StartCityFilter(sender))
                        if (EndCityFilter(sender))
                            return true;
                }
                if (StartCity != "" && EndCity == "")
                {
                    if (StartCityFilter(sender))
                        return true;
                }
                if (StartCity == "" && EndCity != "")
                {
                    if (EndCityFilter(sender))
                        return true;
                }
                if (StartCity == "" && EndCity == "")
                {
                    return true;
                }
            }
            return false;
        }
        public bool StartCityFilter(object sender)
        {
            var obj = sender as JsData;
            if (obj != null)
            {
                if (obj.startCity.ToString().Contains(StartCity))
                    return true;
            }
            return false;
        }
        public bool EndCityFilter(object sender)
        {
            var obj = sender as JsData;
            if (obj != null)
            {
                if (obj.endCity.ToString().Contains(EndCity))
                    return true;
            }
            return false;
        }
        #endregion


        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
