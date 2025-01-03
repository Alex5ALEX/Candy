using CandyClient.Models;
using System.Net.Http.Json;

namespace CandyClient.Controllers;

public class SupplyController
{
    private readonly HttpClient httpClient;
    private readonly Uri url;

    public SupplyController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        url = new Uri("https://localhost:7024/api/Supply");
    }

    public async Task<List<Supply>?> GetAllSupply()
    {
        try
        {
            var response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode(); // Check for a successful status

            return await response.Content.ReadFromJsonAsync<List<Supply>>();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null;
        }
    }

    public async Task<Supply?> GetSupplyById(Guid Id)
    {
        var response = await httpClient.GetAsync(url + $"/{Id}");

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        return await response.Content.ReadFromJsonAsync<Supply>();
    }

    public Task<HttpResponseMessage> PostSupply(Supply customer)
    {
        return httpClient.PostAsJsonAsync(url, customer);
    }

    public Task<HttpResponseMessage> PutSupplyById(Supply customer)
    {
        return httpClient.PutAsJsonAsync($"{url}/{customer.Id.ToString()}", customer);
    }

    public Task<HttpResponseMessage> DelSupply(Supply customer)
    {
        return httpClient.DeleteAsync($"{url}/{customer.Id.ToString()}");
    }

    public async Task<bool> SupplyExist(Guid Id)
    {
        var response = await GetSupplyById(Id);

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
