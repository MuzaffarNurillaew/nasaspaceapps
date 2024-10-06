using ClimateNetwork.Api.Domain.Entities;
using ClimateNetwork.Api.Service.Interfaces;

namespace ClimateNetwork.Api.Service.Services;

public class StoryService : IStoryService
{
    public Task<Story> CreateAsync(Story story, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<List<Story>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Story> GetAsync(int id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Story> UpdateAsync(Story story, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
