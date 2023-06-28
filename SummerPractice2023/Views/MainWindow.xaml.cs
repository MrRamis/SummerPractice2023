using SummerPractice2023.DB.Js;
using SummerPractice2023.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace SummerPractice2023.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow(structV structV)
        {
            InitializeComponent();
           
            DataContext = new VMMainWindow(structV, this.MainWindowX);
        }
    }
}
