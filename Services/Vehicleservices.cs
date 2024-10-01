using API_Service.Data;
using API_Service.Models;
using API_Service.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API_Service.Services;

public class VehicleServices : IVehicleRepository
{

    private readonly ApplicationDbContext Context;
    public VehicleServices(ApplicationDbContext Context)
    {
        this.Context = Context;
    }

    public Task<IEnumerable<Vehicle>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Vehicle?> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task Add(Vehicle vehicle)
    {
        if (vehicle == null)
        {
            throw new ArgumentNullException(nameof(vehicle), "El vehículo no puede ser nulo.");
        }

        try
        {
            await Context.Vehicles.AddAsync(vehicle); 
            await Context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception("Error al agregar el vehículo a la base de datos.", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocurrió un error inesperado al agregar el vehículo.", ex);
        }
    }

    public Task Update(Vehicle student)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CheckExistence(int id)
    {
        throw new NotImplementedException();
    }
}