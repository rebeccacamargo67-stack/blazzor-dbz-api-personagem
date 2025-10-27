using System.Net.Http.Json;
using BlazorDbzPersonagem.Models;

namespace BlazorDbzPersonagem.Services
{
    public class DragonBallService
    {
        private readonly HttpClient _http;

        public DragonBallService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Personagem> GetPersonagemAsync(int id)
        {
            string url = $"https://dragonball-api.com/api/characters/{id}";
            return await _http.GetFromJsonAsync<Personagem>(url);
        }
    }
}
