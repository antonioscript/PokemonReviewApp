using PokemonReviewApp.Models;
//using PokemonReviewApp.Repository; Deveria ter isso

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}