using BlazingPizza.Contexts;
using BlazingPizza.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza;

[Route("specials")]
[ApiController]
public class SpecialsController : Controller
{
    private readonly PizzaStoreContext _db;

    public SpecialsController(PizzaStoreContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        var specials = await _db.Specials.ToListAsync();
        return new ActionResult<List<PizzaSpecial>>(specials.OrderByDescending(s => s.BasePrice).ToList());
    }
}

