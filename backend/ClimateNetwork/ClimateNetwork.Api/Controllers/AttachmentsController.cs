using ClimateNetwork.Api.Dtos;
using ClimateNetwork.Api.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClimateNetwork.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AttachmentsController(IAttachmentService attachmentService) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<AttachmentResultDto>> Create(AttachmentCreationDto Attachment, CancellationToken cancellationToken = default)
    {
        return Ok();
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<AttachmentResultDto>> GetById(int id, CancellationToken cancellationToken)
    {
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AttachmentResultDto>>> GetAll(CancellationToken cancellationToken)
    {
        return Ok();
    }

    [HttpPut]
    public async Task<ActionResult<AttachmentResultDto>> Update(AttachmentUpdateDto Attachment, CancellationToken cancellationToken)
    {
        return Ok();
    }
}