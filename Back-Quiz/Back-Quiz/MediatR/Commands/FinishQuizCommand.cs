using Back_Quiz.Dtos.Quiz;
using MediatR;

namespace Back_Quiz.MediatR.Commands;

public class FinishQuizCommand : IRequest<QuizResultDto>
{
    public string UserId { get; set; }
    public string SessionId { get; set; }
}