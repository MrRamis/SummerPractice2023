using SummerPractice2023.ViewModels;
using System.Windows.Controls;

namespace SummerPractice2023.Views
{
    public partial class TicketSearch : Page
    {
        public TicketSearch(structV structv)
        {
            DataContext = new VMTicketSearch(structv);
            InitializeComponent();
        }
    }
}