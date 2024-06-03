using Pokemones.Models;

namespace Pokemones.Services
{
    public interface InterfacePokemon
    {
        public Task <List<PokemonItem>> Obtener ();
    }
}
