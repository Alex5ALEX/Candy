using CandyClient.Models;
using System.Net.Http.Json;

namespace CandyClient.Controllers;

public class OrderCompaundController
{
    private readonly HttpClient httpClient;
    private readonly Uri url;

    public OrderCompaundController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        url = new Uri("https://localhost:7024/api/OrderCompaund");
    }

    public async Task<List<OrderCompaund>?> GetAllOrderCompaund()
    {
        try
        {
            var response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode(); // Check for a successful status

            return await response.Content.ReadFromJsonAsync<List<OrderCompaund>>();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null;
        }
    }

    public async Task<OrderCompaund?> GetOrderCompaundById(Guid Id_Candy, Guid Id_Order)
    {
        var response = await httpClient.GetAsync(url + $"/candy/{Id_Candy}/order/{Id_Order}");

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        return await response.Content.ReadFromJsonAsync<OrderCompaund>();
    }

    public async Task<List<OrderCompaund>?> GetOrderCompaundByOrderId(Guid Id_Order)
    {
        var response = await httpClient.GetAsync(url + $"/order/{Id_Order}");

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        return await response.Content.ReadFromJsonAsync<List<OrderCompaund>>();
    }

    public Task<HttpResponseMessage> PostOrderCompaund(OrderCompaund customer)
    {
        return httpClient.PostAsJsonAsync(url, customer);
    }

    public Task<HttpResponseMessage> PutOrderCompaundById(OrderCompaund customer)
    {
        return httpClient.PutAsJsonAsync($"{url}/candy/{customer.CandyId}/order/{customer.OrderId}", customer);
    }

    public Task<HttpResponseMessage> DelOrderCompaund(OrderCompaund customer)
    {
        return httpClient.DeleteAsync($"{url}/candy/{customer.CandyId}/order/{customer.OrderId}");
    }

    public async Task<bool> OrderCompaundExist(Guid Id_Candy, Guid Id_Order)
    {
        var response = await GetOrderCompaundById(Id_Candy, Id_Order);

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
