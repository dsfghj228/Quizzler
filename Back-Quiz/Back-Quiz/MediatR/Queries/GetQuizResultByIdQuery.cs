using Back_Quiz.Dtos.Quiz;
using MediatR;

namespace Back_Quiz.MediatR.Queries;

public class GetQuizResultByIdQuery : IRequest<QuizResultDto>
{
    public string UserId { get; set; }
    public Guid QuizId { get; set; }
}