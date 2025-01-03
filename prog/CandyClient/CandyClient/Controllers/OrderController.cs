using CandyClient.Models;
using System.Net.Http.Json;

namespace CandyClient.Controllers;

public class OrderController
{
    private readonly HttpClient httpClient;
    private readonly Uri url;

    public OrderController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        url = new Uri("https://localhost:7024/api/Order");
    }

    public async Task<List<Order>> GetAllOrder()
    {
        try
        {
            var response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode(); // Check for a successful status

            return await response.Content.ReadFromJsonAsync<List<Order>>();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null;
        }
    }

    public async Task<Order?> GetOrderById(Guid Id)
    {
        var response = await httpClient.GetAsync(url + $"/{Id}");

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        return await response.Content.ReadFromJsonAsync<Order>();
    }

    public async Task<List<Order>> GetAllOrdersByIdCustomer(Guid Id)
    {
        var response = await httpClient.GetAsync(url + $"/customer/{Id}");

        if (!response.IsSuccessStatusCode)
        {
            return [];
        }

        return await response.Content.ReadFromJsonAsync<List<Order>>() ?? [];
    }

    public Task<HttpResponseMessage> PostOrder(Order customer)
    {
        return httpClient.PostAsJsonAsync(url, customer);
    }

    public Task<HttpResponseMessage> PutOrderById(Order customer)
    {
        return httpClient.PutAsJsonAsync($"{url}/{customer.Id.ToString()}", customer);
    }

    public Task<HttpResponseMessage> DelOrder(Order customer)
    {
        return httpClient.DeleteAsync($"{url}/{customer.Id.ToString()}");
    }

    public async Task<bool> OrderExist(Guid Id)
    {
        var response = await GetOrderById(Id);

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
