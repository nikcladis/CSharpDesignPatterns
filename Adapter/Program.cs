using Adapter;

Console.Title = "Adapter";

ICityAdapter adapter = new CityAdapter();
var city = adapter.GetCity();

Console.WriteLine($"City: {city.FullName}, Inhabitants: {city.Inhabitants}");
Console.ReadKey();