using System.Net;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Interfaces; //Oberserve que não é preciso trazer aqui a pasta Repository
using PokemonReviewApp.Models;     // Pois o IPokemonRepository através dela já está trazendo o Repository
using PokemonReviewApp.Data;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;
        //private readonly DataContext _context;

        public PokemonController(IPokemonRepository pokemonRepository) // Os parâmetros estão trazendo as classes das pastas Interfaces e Repository
        {   
             _pokemonRepository = pokemonRepository;
        }


        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        
        public IActionResult GetPokemons() //Do Repository/PokemonRepository.cs
        {
            var pokemons = _pokemonRepository.GetPokemons();

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(pokemons);
        }
    }
}