using Newtonsoft.Json;
using SummerPractice2023.DB.Js;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SummerPractice2023.DB
{
    public class CommandJson
    {   
        public static ObservableCollection<JsData> GetAir()
        {
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
    },
    {
      ""startCity"": ""Москва"",
      ""startCityCode"": ""mow"",
      ""endCity"": ""Махачкала"",
      ""endCityCode"": ""mcx"",
      ""startDate"": ""2022-10-16T00:00:00Z"",
      ""endDate"": ""2022-10-20T00:00:00Z"",
      ""price"": 4570,
      ""searchToken"": ""MOW1610MCX2010Y100""
    },
    {
      ""startCity"": ""Москва"",
      ""startCityCode"": ""mow"",
      ""endCity"": ""Калининград"",
      ""endCityCode"": ""kgd"",
      ""startDate"": ""2022-10-10T00:00:00Z"",
      ""endDate"": ""2022-10-13T00:00:00Z"",
      ""price"": 4570,
      ""searchToken"": ""MOW1010KGD1310Y100""
    },
    {
      ""startCity"": ""Москва"",
      ""startCityCode"": ""mow"",
      ""endCity"": ""Казань"",
      ""endCityCode"": ""kzn"",
      ""startDate"": ""2022-06-21T00:00:00Z"",
      ""endDate"": ""2022-06-30T00:00:00Z"",
      ""price"": 4760,
      ""searchToken"": ""MOW2106KZN3006Y100""
    },
    {
      ""startCity"": ""Москва"",
      ""startCityCode"": ""mow"",
      ""endCity"": ""Самара"",
      ""endCityCode"": ""kuf"",
      ""startDate"": ""2022-09-06T00:00:00Z"",
      ""endDate"": ""2022-09-11T00:00:00Z"",
      ""price"": 4902,
      ""searchToken"": ""MOW0609KUF1109Y100""
    },
    {
      ""startCity"": ""Москва"",
      ""startCityCode"": ""mow"",
      ""endCity"": ""Краснодар"",
      ""endCityCode"": ""krr"",
      ""startDate"": ""2023-04-15T00:00:00Z"",
      ""endDate"": ""2023-04-23T00:00:00Z"",
      ""price"": 4914,
      ""searchToken"": ""MOW1504KRR2304Y100""
    },
    {
      ""startCity"": ""Москва"",
      ""startCityCode"": ""mow"",
      ""endCity"": ""Екатеринбург"",
      ""endCityCode"": ""svx"",
      ""startDate"": ""2022-06-20T00:00:00Z"",
      ""endDate"": ""2022-06-26T00:00:00Z"",
      ""price"": 5096,
      ""searchToken"": ""MOW2006SVX2606Y100""
    },
    {
      ""startCity"": ""Москва"",
      ""startCityCode"": ""mow"",
      ""endCity"": ""Волгоград"",
      ""endCityCode"": ""vog"",
      ""startDate"": ""2022-06-27T00:00:00Z"",
      ""endDate"": ""2022-07-10T00:00:00Z"",
      ""price"": 5140,
      ""searchToken"": ""MOW2706VOG1007Y100""
    },
    {
      ""startCity"": ""Москва"",
      ""startCityCode"": ""mow"",
      ""endCity"": ""Пермь"",
      ""endCityCode"": ""pee"",
      ""startDate"": ""2022-06-09T00:00:00Z"",
      ""endDate"": ""2022-06-16T00:00:00Z"",
      ""price"": 5140,
      ""searchToken"": ""MOW0906PEE1606Y100""
    }
  ]
}";


            JsFights account = JsonConvert.DeserializeObject<JsFights>(json);
            ObservableCollection<JsData> jsData = new ObservableCollection<JsData>();
            foreach(var  item in account.data)
            {
                jsData.Add(item);
            }
            return jsData;
        }
        public static ObservableCollection<JsData> GetAir(string uri)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(uri);
                JsFights account = JsonConvert.DeserializeObject<JsFights>(json);
                ObservableCollection<JsData> jsData = new ObservableCollection<JsData>();
                foreach (var item in account.data)
                {
                    jsData.Add(item);
                }
                return jsData;
            }
        }

    }
}
