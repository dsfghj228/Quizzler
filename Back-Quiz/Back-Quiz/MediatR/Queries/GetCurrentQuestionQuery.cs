using Back_Quiz.Quiz;
using MediatR;

namespace Back_Quiz.MediatR.Queries;

public class GetCurrentQuestionQuery : IRequest<StartQuizResponse>
{
    public string SessionId { get; set; }
    public string UserId { get; set; }
}