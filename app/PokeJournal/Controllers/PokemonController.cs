// using Microsoft.AspNetCore.Mvc;
// using PokeJournal.Models;
// using PokeJournal.Data;
// using PokeJournal.DTO;
// using PokeTeam = PokeJournal.Usecases.PokeTeam;
// using User = PokeJournal.Usecases.User;

// namespace PokeJournal.Controllers;

// [ApiController]
// [Route("[controller]")]
// public class PokemonController : ControllerBase
// {
//   private readonly ApplicationDbContext _context;

//   public PokemonController(ApplicationDbContext context){
//     _context = context;
//   }

//   [HttpPost]
//   public async Task<ActionResult<PokeTeamModel>> Favorite(Guid pokemonId)
//   {
//       var user = new User.Select(_context).FromId(teamDTO.userId);
//       var inserted = new Pokemon.Favorite(_context, user, 1).Execute();
//   }

//   [HttpPost]
//   [Route("New")]
//   public async Task<ActionResult<PokeTeamModel>> CreateTeam(PokeTeamDTO teamDTO)
//   {
//       var user = new User.Select(_context).FromId(teamDTO.userId);
//       var team = new PokeTeam.Create(_context, user, teamDTO.pokemonIndex, teamDTO.name, teamDTO.description).Execute();

//       return CreatedAtAction(
//           nameof(ShowTeam),
//           new { id = team.Id },
//           team);
//   }

//   [HttpPost]
//   [Route("AddPokemon")]
//   public async Task<ActionResult<PokemonListDTO>> AddPokemonToTeam(AddPokemonDTO addpokemonDTO)
//   {
//       var team = new PokeTeam.Select(_context).FromId(addpokemonDTO.teamId);

//       var pokemon = new PokeTeam.AddPokemon(_context, addpokemonDTO.pokemonIndex, addpokemonDTO.customName, team).Execute();

//       return new PokemonListDTO(pokemon.DefaultName, pokemon.CustomName, pokemon.ImgURL, pokemon.PokeTeamId, pokemon.PokemonIndex);
//   }
// }
