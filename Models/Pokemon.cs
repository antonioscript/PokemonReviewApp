using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<PokemonOwner> PokemonOwners { get; set; } //Many_to_many

        public ICollection<PokemonCategory> PokemonCategories { get; set; } //Many_to_many
    }
}