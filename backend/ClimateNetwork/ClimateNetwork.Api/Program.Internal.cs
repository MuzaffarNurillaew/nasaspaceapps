using ClimateNetwork.Api.Service.Interfaces;
using ClimateNetwork.Api.Service.Services;

namespace ClimateNetwork.Api;

partial class Program
{
    private static void RegisterServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IStoryService, StoryService>();
        builder.Services.AddScoped<ITagService, TagService>();
        builder.Services.AddScoped<IAttachmentService, AttachmentService>();
    }
}