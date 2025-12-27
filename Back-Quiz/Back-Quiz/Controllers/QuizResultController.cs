using System.Security.Claims;
using Back_Quiz.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Back_Quiz.Controllers;

[ApiController]
[Route("api/quiz-results")]
[Authorize]
public class QuizResultController : ControllerBase
{
    private readonly IMediator _mediator;
    
    public QuizResultController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetQuizResults()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (userId == null)
            throw new CustomExceptions.UnauthorizedUsernameException();
        
        var query = new MediatR.Queries.GetUserQuizResultsQuery
        {
            UserId = userId
        };
        
        var results = await _mediator.Send(query);
        return Ok(results);
    }
    
}