using System;

namespace Backend
{
    public class WeatherForecast
    {
        //Data transfer object (DTO) describes “an object that carries data between processes”
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
