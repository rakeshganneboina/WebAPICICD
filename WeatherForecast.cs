namespace WenAPITest1
{
    //git init
    //git add.
    //git commit -m "Initial commit"
    //git remote add origin <repository-url>
    //git branch -M main
    //git push -u origin main

    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
