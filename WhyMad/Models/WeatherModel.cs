using System.Collections.Generic;

namespace WhyMad.Models
{
    public class WeatherModel
    {
        public string region { get; set; }
        public CurrentConditions currentConditions { get; set; }
        public List<NextDay> next_days { get; set; }
        public ContactAuthor contact_author { get; set; }
        public string data_source { get; set; }
    }
    public class ContactAuthor
    {
        public string email { get; set; }
        public string auth_note { get; set; }
    }

    public class CurrentConditions
    {
        public string dayhour { get; set; }
        public Temp temp { get; set; }
        public string precip { get; set; }
        public string humidity { get; set; }
        public Wind wind { get; set; }
        public string iconURL { get; set; }
        public string comment { get; set; }
    }

    public class MaxTemp
    {
        public int c { get; set; }
        public int f { get; set; }
    }

    public class MinTemp
    {
        public int c { get; set; }
        public int f { get; set; }
    }

    public class NextDay
    {
        public string day { get; set; }
        public string comment { get; set; }
        public MaxTemp max_temp { get; set; }
        public MinTemp min_temp { get; set; }
        public string iconURL { get; set; }
    }

    

    public class Temp
    {
        public int c { get; set; }
        public int f { get; set; }
    }

    public class Wind
    {
        public int km { get; set; }
        public int mile { get; set; }
    }


}