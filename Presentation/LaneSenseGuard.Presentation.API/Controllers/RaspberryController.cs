using LaneSenseGuard.Core.Application.Raspberries.CQRS.Queries.GetRaspberry;
using LaneSenseGuard.Core.Application.Raspberries.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LaneSenseGuard.Presentation.API.Controllers;

[ApiController]
[Route("api/raspberries")]
public class RaspberryController : ControllerBase
{
    private readonly IMediator _mediator;

    public RaspberryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<RaspberryDto>> GetAsync()
    {
        return Ok(await _mediator.Send(new GetRaspberryQuery()));
    }
}