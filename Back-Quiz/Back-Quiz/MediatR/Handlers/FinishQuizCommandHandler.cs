using Back_Quiz.Dtos.Quiz;
using Back_Quiz.Interfaces;
using Back_Quiz.MediatR.Commands;
using MediatR;

namespace Back_Quiz.MediatR.Handlers;

public class FinishQuizCommandHandler : IRequestHandler<FinishQuizCommand, QuizResultDto>
{
    private readonly IQuizService _quizService;
    
    public FinishQuizCommandHandler(IQuizService quizService)
    {
        _quizService = quizService;
    }
    
    public async Task<QuizResultDto> Handle(FinishQuizCommand request, CancellationToken cancellationToken)
    {
        return await _quizService.FinishQuizAsync(request.SessionId, request.UserId);
    }
}