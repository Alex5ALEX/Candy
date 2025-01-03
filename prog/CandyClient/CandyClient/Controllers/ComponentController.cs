using CandyClient.Models;
using System.Net.Http.Json;

namespace CandyClient.Controllers;

public class ComponentController
{
    private readonly HttpClient httpClient;
    private readonly Uri url;

    public ComponentController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        url = new Uri("https://localhost:7024/api/Component");
    }

    public async Task<List<Component>?> GetAllComponents()
    {
        try
        {
            var response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode(); // Check for a successful status

            return await response.Content.ReadFromJsonAsync<List<Component>>();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null;
        }
    }

    public async Task<Component?> GetComponentById(Guid Id)
    {
        var response = await httpClient.GetAsync(url + $"/{Id}");

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        return await response.Content.ReadFromJsonAsync<Component>();
    }

    public Task<HttpResponseMessage> PostComponent(Component customer)
    {
        return httpClient.PostAsJsonAsync(url, customer);
    }

    public Task<HttpResponseMessage> PutComponentById(Component customer)
    {
        return httpClient.PutAsJsonAsync($"{url}/{customer.Id.ToString()}", customer);
    }

    public Task<HttpResponseMessage> DelComponent(Component customer)
    {
        return httpClient.DeleteAsync($"{url}/{customer.Id.ToString()}");
    }

    public async Task<bool> ComponentExist(Guid Id)
    {
        var response = await GetComponentById(Id);

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
