using CandyClient.Models;
using System.Net.Http.Json;

namespace CandyClient.Controllers;

public class CandyController
{
    private readonly HttpClient httpClient;
    private readonly Uri url;

    public CandyController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        url = new Uri("https://localhost:7024/api/Candy");
    }

    public async Task<List<Candy>?> GetAllCandy()
    {
        try
        {
            var response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode(); // Check for a successful status

            return await response.Content.ReadFromJsonAsync<List<Candy>>();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null;
        }
    }

    public async Task<Candy?> GetCandyById(Guid Id)
    {
        var response = await httpClient.GetAsync(url + $"/{Id}");

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        return await response.Content.ReadFromJsonAsync<Candy>();
    }

    public Task<HttpResponseMessage> PostCandy(Candy customer)
    {
        return httpClient.PostAsJsonAsync(url, customer);
    }

    public Task<HttpResponseMessage> PutCandyById(Candy customer)
    {
        return httpClient.PutAsJsonAsync($"{url}/{customer.Id.ToString()}", customer);
    }

    public Task<HttpResponseMessage> DelCandy(Candy customer)
    {
        return httpClient.DeleteAsync($"{url}/{customer.Id.ToString()}");
    }

    public async Task<bool> CandyExist(Guid Id)
    {
        var response = await GetCandyById(Id);

        if (response == null || response.Id == Guid.Empty)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
