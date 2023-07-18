using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokedexAPI.Data;
using PokedexAPI.Models;


[ApiController]
[Route("[controller]")]
public class PokemonController : ControllerBase
{
    private readonly PokedexContext _context;

    public PokemonController(PokedexContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Pokemon>>> GetAll()
    {
        var pokemon = await _context.Pokemon.ToListAsync();

        return Ok(pokemon);
    }
}