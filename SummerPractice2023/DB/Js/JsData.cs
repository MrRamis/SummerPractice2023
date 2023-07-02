using System;

namespace SummerPractice2023.DB.Js
{
    public class JsData
    {
        public string startCity { get; set; }
        public string startCityCode { get; set; }
        public string endCity { get; set; }
        public string endCityCode { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int price { get; set; }
        public string searchToken { get; set; }
        private bool _Like { get; set; }
        public bool Like
        {
            get { return _Like; }
            set { _Like = value;
                if(_Like == true)
                EFCommandModel.AddData(this);
                if (_Like == false)
                    EFCommandModel.DeletData(this);
            }
        }
    }
}
