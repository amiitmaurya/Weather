namespace Weather.Server.Models
{
    public class WeatherModel
    {
        public required string name { get; set; }
        public required Main main { get; set; }
        public required List<Weather> weather { get; set; }
    }
    public class Main
    {
        public required double temp { get; set; }
        public required int humidity { get; set; }
    }

    public class Weather
    {
        public required string description { get; set; }
    }
}
