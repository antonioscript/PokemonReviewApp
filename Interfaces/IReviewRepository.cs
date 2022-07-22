using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();

        Review GetReview(int reviewId);

        //Comentários de um pokemon específico
        ICollection<Review> GetReviewsOfAPokemon(int pokeId);

        bool ReviewExists(int reviewId);

        //Parte de Criação
        bool CreateReview(Review review);

        //Parte de Visualização
        bool UpdateReview(Review review);
        
        //Parte de Exclusão
        bool DeleteReview(Review review);
        bool DeleteReviews(List<Review> reviews);
        
        bool Save();
    }
}