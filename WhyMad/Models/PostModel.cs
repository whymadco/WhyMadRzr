using System;
using System.Collections.Generic;

namespace WhyMad.Models
{
    public class PostModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime dateTime { get; set; }
        public string author { get; set; }
        public string content { get; set; }
    }
}