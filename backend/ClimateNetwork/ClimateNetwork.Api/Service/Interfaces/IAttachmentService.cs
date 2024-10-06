using ClimateNetwork.Api.Domain.Entities;

namespace ClimateNetwork.Api.Service.Interfaces;

public interface IAttachmentService
{
    Task<Attachment> CreateAsync(Attachment Attachment, CancellationToken cancellationToken = default);

    Task<Attachment> UpdateAsync(Attachment Attachment, CancellationToken cancellationToken = default);

    Task<List<Attachment>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<Attachment> GetAsync(int id, CancellationToken cancellationToken = default);
}