namespace Clima_API.Modelos;
public class WeatherResponse
{
    public Location? location { get; set; }
    public Current? current { get; set; }

    public void ExibirClima()
    {
        Console.Clear();
        Console.WriteLine($"Cidade: {location!.name} - {location.region}");
        Console.WriteLine($"País: {location.country}");
        Console.WriteLine($"Horário: {location.localtime}");
        Console.WriteLine($"Temperatura: {current!.temp_c}");
        Console.WriteLine($"Humidade: {current.humidity}%");
        Console.WriteLine($"Condição: {current.condition!.text}");
    }
}