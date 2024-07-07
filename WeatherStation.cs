// WeatherStation.cs
public class WeatherStation
{
    private float _temperature;
    private float _humidity;
    private float _windSpeed;

    public event WeatherChangedEventHandler WeatherChanged;

    public float Temperature
    {
        get { return _temperature; }
        set
        {
            if (_temperature != value)
            {
                _temperature = value;
                OnWeatherChanged(new WeatherChangedEventArgs(Temperature, Humidity, WindSpeed));
            }
        }
    }

    public float Humidity
    {
        get { return _humidity; }
        set
        {
            if (_humidity != value)
            {
                _humidity = value;
                OnWeatherChanged(new WeatherChangedEventArgs(Temperature, Humidity, WindSpeed));
            }
        }
    }

    public float WindSpeed
    {
        get { return _windSpeed; }
        set
        {
            if (_windSpeed != value)
            {
                _windSpeed = value;
                OnWeatherChanged(new WeatherChangedEventArgs(Temperature, Humidity, WindSpeed));
            }
        }
    }

    protected virtual void OnWeatherChanged(WeatherChangedEventArgs e)
    {
        WeatherChanged?.Invoke(this, e);
    }
}

public delegate void WeatherChangedEventHandler(object sender, WeatherChangedEventArgs e);

public class WeatherChangedEventArgs : EventArgs
{
    public float Temperature { get; }
    public float Humidity { get; }
    public float WindSpeed { get; }

    public WeatherChangedEventArgs(float temperature, float humidity, float windSpeed)
    {
        Temperature = temperature;
        Humidity = humidity;
        WindSpeed = windSpeed;
    }
}