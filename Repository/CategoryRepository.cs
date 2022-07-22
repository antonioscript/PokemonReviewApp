using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{

    public class CategoryRepository : ICategoryRepository
    {
        private DataContext _context; 
        public CategoryRepository(DataContext context)
        {
            _context = context;
        }
        

        //Parte de Criação
        public bool CreateCategory(Category category)
        {
            //Change Tracker
            _context.Add(category);
            return Save();
        }


        //Parte de Exclusão
        public bool DeleteCategory(Category category)
        {
            _context.Remove(category);
            return Save();
        }

        //Parte de Visualização
        public bool CategoryExists(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList(); //Antes de To List poderia colocar alguma coisa
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Where(e => e.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return _context.PokemonCategories.Where(e => e.CategoryId == categoryId).Select(c => c.Pokemon).ToList();
        }
        
        //Parte de Atualização
        public bool UpdateCategory(Category category)
        {
            _context.Update(category);
            return Save();
        }
        

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        
    }
}