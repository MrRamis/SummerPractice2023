﻿using SummerPractice2023.DB.Js;
using SummerPractice2023.DB.Tables;
using System.Collections.ObjectModel;

namespace SummerPractice2023.Views
{
    public struct structV
    {
        public ObservableCollection<JsData> jsData;
        public User User;
        public ObservableCollection<SummerPractice2023.DB.Post> posts;
    }
}