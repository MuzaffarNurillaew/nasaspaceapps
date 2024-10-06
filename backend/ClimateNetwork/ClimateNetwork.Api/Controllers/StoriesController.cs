using ClimateNetwork.Api.Dtos;
using ClimateNetwork.Api.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClimateNetwork.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StoriesController(IStoryService storyService) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<StoryResultDto>> Create(StoryCreationDto story, CancellationToken cancellationToken = default)
    {
        return Ok();
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<StoryResultDto>> GetById(int id, CancellationToken cancellationToken)
    {
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<StoryResultDto>>> GetAll(CancellationToken cancellationToken)
    {
        return Ok();
    }

    [HttpPut]
    public async Task<ActionResult<StoryResultDto>> Update(StoryUpdateDto story, CancellationToken cancellationToken)
    {
        return Ok();
    }
}
