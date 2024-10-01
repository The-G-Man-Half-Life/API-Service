using API_Service.Data;
using API_Service.Dtos;
using API_Service.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sprache;

namespace API_Service.Controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
public class VehiclesGetController : ControllerBase
{
    private readonly ApplicationDbContext Context;

    public VehiclesGetController(ApplicationDbContext Context)
    {
        this.Context = Context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles()
    {
        return await Context.Vehicles.ToListAsync();
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Vehicle>> GetVehicle(int id)
    {
        var vehicle = await Context.Vehicles.FindAsync(id);

        if (vehicle == null)
        {
            return NotFound();
        }

        return vehicle;
    }

    [HttpGet("search/{keyword}")]
    public async Task<ActionResult<IEnumerable<Vehicle>>> SearchByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return BadRequest("La palabra clave no puede estar vacía.");
        }

        var vehicles = await Context.Vehicles
            .Where(v => v.Make.Contains(keyword) ||
                        v.Model.Contains(keyword) ||
                        v.Color.Contains(keyword))
            .ToListAsync();

        if (!vehicles.Any())
        {
            return NotFound("No se encontraron vehículos que coincidan con la palabra clave proporcionada.");
        }

        return Ok(vehicles);
    }
}