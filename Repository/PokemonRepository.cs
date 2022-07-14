using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList(); 
            
            // Está retornando a tabela "Pokemon" do banco de dados
            // Este comando está entrando no arquivo DataContext:
            //"public DbSet<Pokemon> Pokemon { get; set; }
        }
    }
}