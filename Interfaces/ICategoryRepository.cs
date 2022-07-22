using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        //Parte de Visualização (Get)
        ICollection<Category> GetCategories();

        Category GetCategory(int id);

        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
        
        bool CategoryExists(int id);

        //Parte de Criação (Post)
        bool CreateCategory(Category category);

        //Parte de Ataulização
        bool UpdateCategory(Category category);

        //Parte de Exclusão
        bool DeleteCategory(Category category);

        bool Save();

    }
}