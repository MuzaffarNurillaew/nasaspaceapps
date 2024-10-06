using ClimateNetwork.Api.Domain.Entities;

namespace ClimateNetwork.Api.Service.Interfaces;

public interface IStoryService
{
    Task<Story> CreateAsync(Story story, CancellationToken cancellationToken = default);

    Task<Story> UpdateAsync(Story story, CancellationToken cancellationToken = default);

    Task<List<Story>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<Story> GetAsync(int id, CancellationToken cancellationToken = default);
}
