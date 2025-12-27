using Back_Quiz.Dtos.Quiz;
using Back_Quiz.Interfaces;
using Back_Quiz.MediatR.Queries;
using MediatR;

namespace Back_Quiz.MediatR.Handlers;

public class GetQuizResultQueryHandler : IRequestHandler<GetQuizResultQuery, QuizResultDto>
{
    private readonly IQuizService _quizService;

    public GetQuizResultQueryHandler(IQuizService quizService)
    {
        _quizService = quizService;
    }
    
    public async Task<QuizResultDto> Handle(GetQuizResultQuery request, CancellationToken cancellationToken)
    {
        return await _quizService.ReturnResults(request.SessionId, request.UserId);
    }
}