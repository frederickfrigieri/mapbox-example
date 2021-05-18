namespace ConsoleAppMauro
{
    class Program
    {
        static void Main(string[] args)
        {
            var endpoint = "geocoding/v5/mapbox.places/Los%20Angeles.json";
            var client = new HttpClientCustom();
            var data = client.GetExample<Root>(endpoint);
        }
    }
}
