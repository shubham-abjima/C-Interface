using PersonReader.Interface;
using System.Net;
using System.Text.Json;

namespace PersonReader.Service;

public class ServiceReader : IPersonReader
{
    private static readonly WebClient webClient = new WebClient();
    WebClient client = webClient;
    string baseUri = "http://localhost:5490";
    JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

    public IEnumerable<Person> GetPeople()
    {
        string address = $"{baseUri}/people";
        string reply = client.DownloadString(address);
        return JsonSerializer.Deserialize<IEnumerable<Person>>(reply, options) ?? new List<Person>();
    }

    public Person GetPerson(int id)
    {
        string address = $"{baseUri}/people/{id}";
        string reply = client.DownloadString(address);
        return JsonSerializer.Deserialize<Person>(reply, options) ?? new Person();
    }
}
