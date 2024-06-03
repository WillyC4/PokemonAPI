using Pokemones.Models;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Pokemones.Services
{
    public class PokemonServices : InterfacePokemon
    {
        private string urlApi = "https://pokeapi.co/api/v2/pokemon/?limit=100&offset=20";
        public async Task<List<PokemonItem>> Obtener()
        {
            var clien= new HttpClient();
            var response = await clien.GetAsync(urlApi);
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode results = nodos["results"];

            var personajesData = JsonSerializer.Deserialize<List<PokemonItem>>(results.ToString());
            return personajesData;
        }
    }
}

