using CarExplorer.Application.Interfaces;
using CarExplorer.Domain.Entities;
using CarExplorer.Infrastructure.ExternalModels;
using Microsoft.Extensions.Caching.Memory;
using System.Net.Http.Json;

namespace CarExplorer.Infrastructure.Services
{
    public class VehicleService : IvehicleService
    {
        private readonly HttpClient _httpClient;
        private readonly IMemoryCache _cache;

        public VehicleService(HttpClient httpClient, IMemoryCache cache)
        {
            _httpClient = httpClient;
            _cache = cache;
        }
        public async Task<IEnumerable<Make>> GetMakesAsync()
        {
            return await _cache.GetOrCreateAsync("makes", async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
                var response = await _httpClient.GetFromJsonAsync<MakeResponse>("getallmakes?format=json");
                
                if (response?.Results == null)
                    return Enumerable.Empty<Make>();

                return response.Results.Select(x => new Make {
                    Id = x.Make_ID,
                    Name = x.Make_Name
                });
            });
        }

        public async Task<IEnumerable<Model>> GetModelsAsync(int makeId, int year)
        {
            var cacheKey = $"models-{makeId}-{year}";

            return await _cache.GetOrCreateAsync(cacheKey, async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);

                var response = await _httpClient
                    .GetFromJsonAsync<ModelResponse>(
                        $"GetModelsForMakeIdYear/makeId/{makeId}/modelyear/{year}?format=json");

                return response.Results.Select(x => new Model
                {
                    Name = x.Model_Name
                });
            });
        }

        public async Task<IEnumerable<VehicleType>> GetVehicleTypesAsync(int makeId)
        {
            var cacheKey = $"vehicle-types-{makeId}";

            return await _cache.GetOrCreateAsync(cacheKey, async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);

                var response = await _httpClient
                    .GetFromJsonAsync<VehicleTypeResponse>($"GetVehicleTypesForMakeId/{makeId}?format=json");

                return response.Results.Select(x => new VehicleType
                {
                    Name = x.VehicleTypeName
                });
            });
        }
    }
}
