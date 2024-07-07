// Program.cs
class Program
{
    static void Main(string[] args)
    {
        var weatherStation = new WeatherStation();
        var weatherApp = new WeatherApp(weatherStation);
        var weatherSiteApp = new WeatherSiteApp(weatherStation);
        
        bool shouldContinue = true;
        while (shouldContinue)
        {
            Console.WriteLine("Enter weather parameters (temperature, humidity, wind speed):");
            string[] weatherParams = Console.ReadLine().Split(',');

            if (weatherParams.Length == 3 &&
                float.TryParse(weatherParams[0], out float temperature) &&
                float.TryParse(weatherParams[1], out float humidity) &&
                float.TryParse(weatherParams[2], out float windSpeed))
            {
                weatherStation.Temperature = temperature;
                weatherStation.Humidity = humidity;
                weatherStation.WindSpeed = windSpeed;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            Console.WriteLine("Do you want to enter more weather parameters? (y/n)");
            string input = Console.ReadLine().ToLower();
            shouldContinue = input == "y";
        }

        Console.ReadLine();
    }
}