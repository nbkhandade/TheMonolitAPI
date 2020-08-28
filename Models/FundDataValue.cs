using System;

namespace TheMonolit.API.Models
{
    public class FundDataValue
    {
        public int Id { get; set; }
        public string FundName { get; set; }
        public string Ticker { get; set; }
        public float Rating { get; set; }
        public float Month1 { get; set; }
        public float Month3 { get; set; }
        public float Year { get; set; }
        public float Year3 { get; set; }
        public float Year5 { get; set; }
        public float InceptionToDate { get; set; }

    }
}