namespace ClimateNetwork.Api.Dtos;

public class StoryResultDto
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string HtmlContent { get; set; }

    public List<string> Tags { get; set; }

    public string BannerFilePath { get; set; }

    public DateTime CreatedDate { get; set; }
}