using ServicioAPI.Model;
using System.Text.Json;

namespace ServicioAPI.Util
{

    public class PersClient{
        public HttpClient Client { get; set; }

        public PersClient(HttpClient client)
        {
            this.Client = client;
        }
        public async Task<Personaje>? GetPersonaje(string id)
        {
            var response = await this.Client.GetAsync($"https://rickandmortyapi.com/api/character/{id}");

            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Personaje>(content);
        }
    }
}