using Back_Quiz.Interfaces;
using Back_Quiz.MediatR.Queries;
using Back_Quiz.Quiz;
using MediatR;

namespace Back_Quiz.MediatR.Handlers;

public class GetCurrentQuestionQueryHandler : IRequestHandler<GetCurrentQuestionQuery, StartQuizResponse>
{
    private readonly IQuizService _quizService;
    
    public GetCurrentQuestionQueryHandler(IQuizService quizService)
    {
        _quizService = quizService;
    }
    
    public async Task<StartQuizResponse> Handle(GetCurrentQuestionQuery request, CancellationToken cancellationToken)
    {
        return await _quizService.GetCurrentQuestionAsync(request.SessionId, request.UserId);
    }
}