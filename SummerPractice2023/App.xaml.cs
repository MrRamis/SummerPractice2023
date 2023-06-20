using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SummerPractice2023.DB.Js;
using SummerPractice2023.Models;
using SummerPractice2023.Views;
using SummerPractice2023.Views.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace SummerPractice2023
{
    public partial class App : Application
    {
        public App()
        {
               Resource.PastTopic();
               Resource.LanguageChange();
        
            if (SummerPractice2023.Properties.Settings.Default.UserId == "")
            {
                Authorization authorization = new Authorization();
                authorization.Show();
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            string json = @"
  {
  ""meta"": {},
  ""data"":
[
    {
      ""startCity"": ""Москва"",
      ""startCityCode"": ""mow"",
      ""endCity"": ""Санкт-Петербург"",
      ""endCityCode"": ""led"",
      ""startDate"": ""2022-07-20T00:00:00Z"",
      ""endDate"": ""2022-07-25T00:00:00Z"",
      ""price"": 2690,
      ""searchToken"": ""MOW2007LED2507Y100""
    },
    {
      ""startCity"": ""Москва"",
      ""startCityCode"": ""mow"",
      ""endCity"": ""Нижний Новгород"",
      ""endCityCode"": ""goj"",
      ""startDate"": ""2022-08-07T00:00:00Z"",
      ""endDate"": ""2022-08-13T00:00:00Z"",
      ""price"": 3140,
      ""searchToken"": ""MOW0708GOJ1308Y100""
    }
  ]
}";

            JsFights account = JsonConvert.DeserializeObject<JsFights>(json);
        }
    }
}