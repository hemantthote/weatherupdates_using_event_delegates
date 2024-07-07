// WeatherApp.cs
public class WeatherSiteApp
{
    private readonly WeatherStation _weatherStation;

    public WeatherSiteApp(WeatherStation weatherStation)
    {
        _weatherStation = weatherStation;
        _weatherStation.WeatherChanged += WeatherStation_WeatherChanged;
    }

    private void WeatherStation_WeatherChanged(object sender, WeatherChangedEventArgs e)
    {
        Console.WriteLine($"Site Weather Update:");
        Console.WriteLine($"B Temperature: {e.Temperature}°C");
        Console.WriteLine($"B Humidity: {e.Humidity}%");
        Console.WriteLine($"B Wind Speed: {e.WindSpeed} m/s");
    }
}