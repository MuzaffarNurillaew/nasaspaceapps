using ClimateNetwork.Api.Domain.Entities;
using ClimateNetwork.Api.Service.Interfaces;

namespace ClimateNetwork.Api.Service.Services;

public class AttachmentService : IAttachmentService
{
    public Task<Attachment> CreateAsync(Attachment Attachment, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<List<Attachment>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachment> GetAsync(int id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Attachment> UpdateAsync(Attachment Attachment, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}