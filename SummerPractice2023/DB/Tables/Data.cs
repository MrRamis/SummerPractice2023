using System;
using System.ComponentModel.DataAnnotations;

namespace SummerPractice2023.DB.Tables
{
    public class Data
    {
        public string searchToken { get; set; }
        public string IdUser { get; set; }
        public string? startCity { get; set; }
        public string? startCityCode { get; set; }
        public string? endCity { get; set; }
        public string? endCityCode { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int price { get; set; }
    }
}
