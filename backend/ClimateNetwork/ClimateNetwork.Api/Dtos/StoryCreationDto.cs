namespace ClimateNetwork.Api.Dtos;

public class StoryCreationDto
{
    public string Title { get; set; }

    public string HtmlContent { get; set; }

    public List<string> Tags { get; set; }

    public IFormFile BannerFile { get; set; }
}