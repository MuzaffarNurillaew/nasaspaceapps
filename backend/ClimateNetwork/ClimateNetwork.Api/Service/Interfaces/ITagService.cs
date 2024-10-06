using ClimateNetwork.Api.Domain.Entities;

namespace ClimateNetwork.Api.Service.Interfaces;

public interface ITagService
{
    Task<Tag> CreateAsync(Tag Tag, CancellationToken cancellationToken = default);

    Task<Tag> UpdateAsync(Tag Tag, CancellationToken cancellationToken = default);

    Task<List<Tag>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<Tag> GetAsync(int id, CancellationToken cancellationToken = default);
}