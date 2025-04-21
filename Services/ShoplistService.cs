using System.Net.Http.Json;
using MauiBlazorShopping.Models;

namespace MauiBlazorShopping.Services;

public class ShoplistService
{
    private readonly HttpClient _httpClient;

    public ShoplistService(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("ShoppingApi");
    }

    public async Task<List<Shoplist>> GetShoplistAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Shoplist>>("api/shoplist") ?? new List<Shoplist>();
    }

    public async Task AddShoplistItemAsync(Shoplist newItem)
    {
        await _httpClient.PostAsJsonAsync("api/shoplist", newItem);
    }

    public async Task UpdateShoplistItemAsync(Shoplist updatedItem)
    {
        await _httpClient.PutAsJsonAsync($"api/shoplist/{updatedItem.Id}", updatedItem);
    }

    public async Task DeleteShoplistItemAsync(int id)
    {
        await _httpClient.DeleteAsync($"api/shoplist/{id}");
    }
}
