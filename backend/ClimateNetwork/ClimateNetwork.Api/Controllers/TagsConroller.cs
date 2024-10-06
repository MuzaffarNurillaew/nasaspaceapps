using ClimateNetwork.Api.Dtos;
using ClimateNetwork.Api.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClimateNetwork.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TagsConroller(ITagService tagService) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<TagResultDto>> Create(TagCreationDto Tag, CancellationToken cancellationToken = default)
    {
        return Ok();
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<TagResultDto>> GetById(int id, CancellationToken cancellationToken)
    {
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TagResultDto>>> GetAll(CancellationToken cancellationToken)
    {
        return Ok();
    }

    [HttpPut]
    public async Task<ActionResult<TagResultDto>> Update(TagUpdateDto Tag, CancellationToken cancellationToken)
    {
        return Ok();
    }
}