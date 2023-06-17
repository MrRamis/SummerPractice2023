using SummerPractice2023.Models;
using SummerPractice2023.ViewModels;
using System.Windows;

namespace SummerPractice2023.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new VMMainWindow();
        }
    }
}
