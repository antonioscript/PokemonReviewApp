using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();

        Reviewer GetReviewer(int reviewerId);

        ICollection<Review> GetReviewsByReviewer(int reviewerId);

        bool ReviewerExists(int reviewerId);

        //Parte de Criação
        bool CreateReviewer(Reviewer reviewer);

        //Parte de Atualização
        bool UpdateReviewer(Reviewer reviewer);
        
        //Parte de Exclusão
        bool DeleteReviewer(Reviewer reviewer);
        
        bool Save();

       
    }
}