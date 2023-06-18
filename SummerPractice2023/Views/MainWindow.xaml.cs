using SummerPractice2023.ViewModels;
using System.Windows;

namespace SummerPractice2023.Views
{
    public partial class MainWindow : Window
    {
        VMMainWindow vMMainWindow = new VMMainWindow();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vMMainWindow;
        }
    }
}
