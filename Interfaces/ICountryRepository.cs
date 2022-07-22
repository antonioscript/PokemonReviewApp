using PokemonReviewApp.Models;


namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        //Parte de Visualizaçaõ
        ICollection<Country> GetCountries();

        Country GetCountry(int id);

        Country GetCountryByOwner(int ownerId);

        ICollection<Owner> GetOwnersFromACountry(int countryId);
        
        bool CountryExists(int id);

        //Parte de Criação
        bool CreateCountry(Country country);

        //Parte de Atualização
        bool UpdateCountry(Country country);
        
        bool Save();
    }
}