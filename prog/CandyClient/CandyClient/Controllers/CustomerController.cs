using CandyClient.Models;
using System.Net.Http.Json;

namespace CandyClient.Controllers;

public class CustomerController
{
    private readonly HttpClient httpClient;
    private readonly Uri url;

    public CustomerController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        url = new Uri("https://localhost:7024/api/Customer");
    }

    public async Task<List<Customer>?> GetAllCustomer()
    {
        try
        {
            var response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode(); // Check for a successful status

            return await response.Content.ReadFromJsonAsync<List<Customer>>();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null;
        }
    }

    public async Task<Customer?> GetCustomerById(Guid Id)
    {
        var response = await httpClient.GetAsync(url + $"/{Id}");

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        return await response.Content.ReadFromJsonAsync<Customer>();
    }

    public async Task<Customer?> GetByIdPerson(Guid Id)
    {
        var response = await httpClient.GetAsync(url + $"/person/{Id}");

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        return await response.Content.ReadFromJsonAsync<Customer>();
    }

    public Task<HttpResponseMessage> PostCustomer(Customer customer)
    {
        return httpClient.PostAsJsonAsync(url, customer);
    }

    public Task<HttpResponseMessage> PutCustomerById(Customer customer)
    {
        return httpClient.PutAsJsonAsync($"{url}/{customer.Id.ToString()}", customer);
    }

    public Task<HttpResponseMessage> DelCustomer(Customer customer)
    {
        return httpClient.DeleteAsync($"{url}/{customer.Id.ToString()}");
    }

    public async Task<bool> CustomerExist(Guid Id)
    {
        var response = await GetCustomerById(Id);

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
