using ClimateNetwork.Api.Domain.Entities;
using ClimateNetwork.Api.Service.Interfaces;

namespace ClimateNetwork.Api.Service.Services;

public class TagService : ITagService
{
    public Task<Tag> CreateAsync(Tag Tag, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<List<Tag>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Tag> GetAsync(int id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Tag> UpdateAsync(Tag Tag, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}