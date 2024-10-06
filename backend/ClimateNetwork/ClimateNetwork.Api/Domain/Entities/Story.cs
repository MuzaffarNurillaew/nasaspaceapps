using ClimateNetwork.Api.Domain.Commons;

namespace ClimateNetwork.Api.Domain.Entities;

public class Story : IClimateNetworkEntity, IEntity
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string HtmlContent { get; set; }

    public int BannerId { get; set; }

    public Attachment Banner { get; set; }

    public DateTime CreatedDate { get; set; }

    public List<StoryTag> StoryTags { get; set; } = [];
}