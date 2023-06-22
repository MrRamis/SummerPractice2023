﻿using SummerPractice2023.DB.Js;
using SummerPractice2023.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SummerPractice2023.Views
{
    public partial class TicketSearch : Page
    {
        public TicketSearch(ObservableCollection<JsData> jsData)
        {
            InitializeComponent();
            DataContext = new VMTicketSearch(jsData);
        }
    }
}
