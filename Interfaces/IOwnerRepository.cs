using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();

        Owner GetOwner(int ownerId);
        
        ICollection<Owner> GetOwnerOfAPokemon(int pokeId); //Pelo que entendi não usa esse (Porque ele achou desnecessário)

        ICollection<Pokemon> GetPokemonByOwner(int ownerId);

        bool OwnerExists(int ownerId);

        //Parte de Criação
        bool CreateOwner(Owner owner);

        //Parte de Atualização
        bool UpdateOwner(Owner owner);

        //Parte de Exclusão
        bool DeleteOwner(Owner owner);
        
        bool Save();

    }
}