using ClimateNetwork.Api.Domain.Commons;

namespace ClimateNetwork.Api.Domain.Entities;

public class StoryTag : IClimateNetworkEntity
{
    public int StoryId { get; set; }

    public Story Story { get; set; }

    public int TagId { get; set; }

    public Tag Tag { get; set; }
}