using ClimateNetwork.Api.Domain.Commons;

namespace ClimateNetwork.Api.Domain.Entities;

public class Attachment : IClimateNetworkEntity, IEntity
{
    public int Id { get; set; }

    public string Path { get; set; }
}
