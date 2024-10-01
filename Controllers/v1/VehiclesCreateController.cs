using API_Service.Dtos;
using API_Service.Models;
using API_Service.Repositories;
using API_Service.Data;
using Microsoft.AspNetCore.Mvc;

namespace API_Service.Services.Controllers.V1.Vehicles;

[ApiController]
[Route("api/v1/[controller]")]
public class VehiclesCreateController : ControllerBase
{
    private readonly VehicleServices VehicleServices;

    public VehiclesCreateController(VehicleServices VehicleServices)
    {
        this.VehicleServices = VehicleServices;
    }

    [HttpPost]
    public async Task<ActionResult<Vehicle>> Create(VehicleDTO inputVehicle)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var newVehicle = new Vehicle(inputVehicle.Make, inputVehicle.Model, inputVehicle.Year, inputVehicle.Price, inputVehicle.Color);

        return Ok(newVehicle);
    }
}