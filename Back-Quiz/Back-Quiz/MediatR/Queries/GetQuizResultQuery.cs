using Back_Quiz.Dtos.Quiz;
using MediatR;

namespace Back_Quiz.MediatR.Queries;

public class GetQuizResultQuery : IRequest<QuizResultDto>
{
    public string SessionId { get; set; }
    public string UserId { get; set; }
}