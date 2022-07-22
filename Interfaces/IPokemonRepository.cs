using System;
using PokemonReviewApp.Models;
//using PokemonReviewApp.Repository; Deveria ter isso

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        //ENDPOINTS
        //Obs: ICollection você usa quando quer ver tudo
        // Já quando começa com "Pokemon" e tem parâmetros,
        //Significa que você quer apenas algo específico

        ICollection<Pokemon> GetPokemons(); //Pega a lista de todos os pokemons

        Pokemon GetPokemon(int id);

        Pokemon GetPokemon(string name);

        decimal GetPokemonRating(int pokeId);

        bool PokemonExists(int pokeId);

        //Parte de Criação
        bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);

        bool Save();
         
    }
}