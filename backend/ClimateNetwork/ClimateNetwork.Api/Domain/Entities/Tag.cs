using ClimateNetwork.Api.Domain.Commons;

namespace ClimateNetwork.Api.Domain.Entities;

public class Tag : IClimateNetworkEntity, IEntity
{
    public int Id { get; set; }

    public string Name { get; set; }

    public List<StoryTag> StoryTags { get; set; } = [];
}