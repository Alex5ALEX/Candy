using CandyClient.Models;
using System.Net.Http.Json;

namespace CandyClient.Controllers;

public class SupplyCompaundController
{
    private readonly HttpClient httpClient;
    private readonly Uri url;

    public SupplyCompaundController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        url = new Uri("https://localhost:7024/api/SupplyCompaund");
    }

    public async Task<List<SupplyCompaund>?> GetAllSupplyCompaund()
    {
        try
        {
            var response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode(); // Check for a successful status

            return await response.Content.ReadFromJsonAsync<List<SupplyCompaund>>();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null;
        }
    }

    public async Task<SupplyCompaund?> GetSupplyCompaundById(Guid Id_Supply, Guid Id_Component)
    {
        var response = await httpClient.GetAsync(url + $"/supply/{Id_Supply}/component/{Id_Component}");

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        return await response.Content.ReadFromJsonAsync<SupplyCompaund>();
    }

    public async Task<List<SupplyCompaund>?> GetSupplyCompaundByIdSupply(Guid Id_Supply)
    {
        var response = await httpClient.GetAsync(url + $"/supply/{Id_Supply}");

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        return await response.Content.ReadFromJsonAsync<List<SupplyCompaund>>();
    }

    public Task<HttpResponseMessage> PostSupplyCompaund(SupplyCompaund customer)
    {
        return httpClient.PostAsJsonAsync(url, customer);
    }

    public Task<HttpResponseMessage> PutSupplyCompaundById(SupplyCompaund customer)
    {
        return httpClient.PutAsJsonAsync($"{url}/supply/{customer.SupplyId}/component/{customer.ComponentId}", customer);
    }

    public Task<HttpResponseMessage> DelSupplyCompaund(SupplyCompaund customer)
    {
        return httpClient.DeleteAsync($"{url}/supply/{customer.SupplyId}/component/{customer.ComponentId}");
    }

    public async Task<bool> SupplyCompaundExist(Guid Id_Supply, Guid Id_Component)
    {
        var response = await GetSupplyCompaundById(Id_Supply, Id_Component);

        if (response == null || response.SupplyId == Guid.Empty)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
