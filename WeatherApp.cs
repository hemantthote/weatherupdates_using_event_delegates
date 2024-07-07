// WeatherApp.cs
public class WeatherApp
{
    private readonly WeatherStation _weatherStation;

    public WeatherApp(WeatherStation weatherStation)
    {
        _weatherStation = weatherStation;
        _weatherStation.WeatherChanged += WeatherStation_WeatherChanged;
    }

    private void WeatherStation_WeatherChanged(object sender, WeatherChangedEventArgs e)
    {
        Console.WriteLine($"App Weather Update:");
        Console.WriteLine($"A Temperature: {e.Temperature}°C");
        Console.WriteLine($"A Humidity: {e.Humidity}%");
        Console.WriteLine($"A Wind Speed: {e.WindSpeed} m/s");
    }
}