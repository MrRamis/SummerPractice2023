using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerPractice2023.DB.Js
{
    internal class JsFights
    {
       public JsMeta meta { get; set; }
        public IList<JsData> data { get; set; }
    }
}
