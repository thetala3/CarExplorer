using CarExplorer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarExplorer.Application.Interfaces
{
    public interface IvehicleService
    {
        Task<IEnumerable<Make>> GetMakesAsync();
        Task<IEnumerable<VehicleType>> GetVehicleTypesAsync(int makeId);
        Task<IEnumerable<Model>> GetModelsAsync(int makeId, int year);
    }
}
