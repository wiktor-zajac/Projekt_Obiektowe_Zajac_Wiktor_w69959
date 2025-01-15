using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebAPI.Pages.Commands.Create;
using WebAPI.Pages.Commands.Delete;
using WebAPI.Pages.Commands.Update;
using WebAPI.Pages.Queries.Get;
using WebAPI.Pages.Queries.GetAll;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class PagesController : ControllerBase
{
    private readonly IMediator _mediator;

    public PagesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreatePage([FromBody] CreatePageCommand command)
    {
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (Guid.TryParse(userIdClaim, out Guid userId))
            command.CreatedBy = userId;
        else
            return Unauthorized("Invalid user ID.");

        var pageGuid = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetPage), new { guid = pageGuid }, null);
    }

    [HttpGet("{guid}")]
    public async Task<IActionResult> GetPage(Guid guid)
    {
        var query = new GetPageQuery(guid);
        var page = await _mediator.Send(query);

        if (page == null)
            return NotFound();

        return Ok(page);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllPages()
    {
        var query = new GetAllPagesQuery();
        var pages = await _mediator.Send(query);
        return Ok(pages);
    }

    [HttpPut("{guid}")]
    public async Task<IActionResult> UpdatePage(Guid guid, [FromBody] UpdatePageCommand command)
    {
        command.Guid = guid;
        var result = await _mediator.Send(command);
        if (!result)
            return NotFound();

        return NoContent();
    }

    [HttpDelete("{guid}")]
    public async Task<IActionResult> DeletePage(Guid guid)
    {
        var command = new DeletePageCommand(guid);
        var result = await _mediator.Send(command);
        if (!result)
            return NotFound();

        return NoContent();
    }
}
