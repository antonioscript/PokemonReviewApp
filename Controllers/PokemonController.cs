using System.Net;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Interfaces; //Oberserve que não é preciso trazer aqui a pasta Repository
using PokemonReviewApp.Models;     // Pois o IPokemonRepository através dela já está trazendo o Repository
using PokemonReviewApp.Data;
using AutoMapper;
using PokemonReviewApp.Dto;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly IMapper _mapper;

        public PokemonController(IPokemonRepository pokemonRepository, IMapper mapper) // Os parâmetros estão trazendo as classes das pastas Interfaces e Repository
        {   
             _pokemonRepository = pokemonRepository;
             _mapper = mapper;
        }

        //Pega todos os pokemons
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))] //Opcional
        
        //Aqui está retornando uma lista
        public IActionResult GetPokemons() //Do Repository/PokemonRepository.cs
        {
            var pokemons = _mapper.Map<List<PokemonDto>>(_pokemonRepository.GetPokemons());

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(pokemons);
        }

        //Pegar o Pokemon pelo Id        
        [HttpGet("{pokeId}")]
        [ProducesResponseType(200, Type = typeof(Pokemon))] //Opcional
        [ProducesResponseType(400)] //Opcional

        //Aqui está retornadno o Pokemon por Id
        public IActionResult GetPokemon(int pokeId) 
        {
            if (!_pokemonRepository.PokemonExists(pokeId))
                return NotFound();

            var pokemon = _mapper.Map<PokemonDto>(_pokemonRepository.GetPokemon(pokeId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemon);
        }

        //
        [HttpGet("{pokeId}/rating")]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400)]

        public IActionResult GetPokemonRating(int pokeId)
        {
            if (!_pokemonRepository.PokemonExists(pokeId))
                return NotFound();

            var rating = _pokemonRepository.GetPokemonRating(pokeId);

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(rating);
        }
    }
}