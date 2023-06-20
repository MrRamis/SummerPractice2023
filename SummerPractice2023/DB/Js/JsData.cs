using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Interop;

namespace SummerPractice2023.DB.Js
{
    internal class JsData
    {
        public string startCity { get; set; }
        public string startCityCode { get; set; }
        public string endCity { get; set; }
        public string endCityCode { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int price { get; set; }
        public string searchToken { get; set; }
    }
}
