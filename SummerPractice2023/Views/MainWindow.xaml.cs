using SummerPractice2023.Models;
using SummerPractice2023.ViewModels;
using System;
using System.Windows;

namespace SummerPractice2023.Views
{
    public partial class MainWindow : Window
    {
        VMMainWindow vMMainWindow = new VMMainWindow();
        public MainWindow()
        {
            InitializeComponent();
            Loaded += vMMainWindow.Loaded1;
            DataContext = vMMainWindow;
        }

    
    }
}
