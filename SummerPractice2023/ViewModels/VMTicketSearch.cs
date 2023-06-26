using SummerPractice2023.DB.Js;
using SummerPractice2023.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SummerPractice2023.ViewModels
{
    internal class VMTicketSearch : INotifyPropertyChanged
    {
        public ICollectionView LogEntriesStoreView { get; private set; }


        public ObservableCollection<JsData> jsData { get; set; }
        structV structv { get; set; }
        public VMTicketSearch(structV structv)
        {
            this.jsData = structv.jsData;
            this.structv = structv;

            LogEntriesStoreView = CollectionViewSource.GetDefaultView(jsData);

        }





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
