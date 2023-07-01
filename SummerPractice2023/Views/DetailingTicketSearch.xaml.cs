using SummerPractice2023.DB.Js;
using SummerPractice2023.ViewModels;
using System.Windows;

namespace SummerPractice2023.Views
{
    public partial class DetailingTicketSearch : Window
    {
        public DetailingTicketSearch(JsData jsData)
        {
            DataContext = new VMTicketSearch(jsData);
            InitializeComponent();
        }
    }
}