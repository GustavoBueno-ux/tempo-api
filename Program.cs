using System.Text.Json;
using Clima_API.Modelos;


using (HttpClient client = new HttpClient())
{
    Console.Write("Digite a cidade: ");
    string cidade = Console.ReadLine()!;

    try
    {
        string resposta = await client.GetStringAsync($"https://api.weatherapi.com/v1/current.json?key=9ae387d9b0934c86afb150001262301&q={cidade}");
        WeatherResponse clima = JsonSerializer.Deserialize<WeatherResponse>(resposta)!;
        clima.ExibirClima();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}