using Back_Quiz.Quiz;
using MediatR;

namespace Back_Quiz.MediatR.Commands;

public class MakeMoveCommand : IRequest<StartQuizResponse>
{
    public string SessionId { get; set; }
    public string UserId { get; set; }
    public Guid SelectedOptionId { get; set; }
}