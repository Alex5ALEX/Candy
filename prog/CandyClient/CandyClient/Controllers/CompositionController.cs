using CandyClient.Models;
using System.Net.Http.Json;

namespace CandyClient.Controllers;

public class CompositionController
{
    private readonly HttpClient httpClient;
    private readonly Uri url;

    public CompositionController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        url = new Uri("https://localhost:7024/api/Composition");
    }

    public async Task<List<Composition>?> GetAllCompositions()
    {
        try
        {
            var response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode(); // Check for a successful status

            return await response.Content.ReadFromJsonAsync<List<Composition>>();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null;
        }
    }

    public async Task<Composition?> GetCompositionById(Guid Id_Candy, Guid Id_Component)
    {
        var response = await httpClient.GetAsync(url + $"/candy/{Id_Candy}/component/{Id_Component}");

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        return await response.Content.ReadFromJsonAsync<Composition>();
    }

    public async Task<List<Composition>?> GetCompositionByCandyId(Guid Id_Candy)
    {
        var response = await httpClient.GetAsync(url + $"/candy/{Id_Candy}");

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        return await response.Content.ReadFromJsonAsync<List<Composition>>();
    }

    public Task<HttpResponseMessage> PostComposition(Composition customer)
    {
        return httpClient.PostAsJsonAsync(url, customer);
    }

    public Task<HttpResponseMessage> PutCompositionById(Composition customer)
    {
        return httpClient.PutAsJsonAsync($"{url}/candy/{customer.CandyId}/component/{customer.ComponentId}", customer);
    }

    public Task<HttpResponseMessage> DelComposition(Composition customer)
    {
        return httpClient.DeleteAsync($"{url}/candy/{customer.CandyId}/component/{customer.ComponentId}");
    }

    public async Task<bool> CompositionExist(Guid Id_Candy, Guid Id_Component)
    {
        var response = await GetCompositionById(Id_Candy, Id_Component);

        if (response == null || response.CandyId == Guid.Empty)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
