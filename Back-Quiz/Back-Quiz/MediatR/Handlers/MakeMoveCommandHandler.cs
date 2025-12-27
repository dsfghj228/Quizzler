using Back_Quiz.Interfaces;
using Back_Quiz.MediatR.Commands;
using Back_Quiz.Quiz;
using MediatR;

namespace Back_Quiz.MediatR.Handlers;

public class MakeMoveCommandHandler : IRequestHandler<MakeMoveCommand, StartQuizResponse>
{
    private readonly IQuizService _quizService;
    
    public MakeMoveCommandHandler(IQuizService quizService)
    {
        _quizService = quizService;
    }
    
    public async Task<StartQuizResponse> Handle(MakeMoveCommand request, CancellationToken cancellationToken)
    {
        return await _quizService.MakeMoveAsync(request.SessionId, request.UserId, request.SelectedOptionId);
    }
}