using SummerPractice2023.DB.Js;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerPractice2023.ViewModels
{
    internal class VMTicketSearch : INotifyPropertyChanged
    {
        public ObservableCollection<JsData> jsData { get; set; }
        public VMTicketSearch(ObservableCollection<JsData> jsData)
        {
            this.jsData = jsData;
         
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
