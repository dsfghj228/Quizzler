using Back_Quiz.Dtos.Quiz;
using MediatR;

namespace Back_Quiz.MediatR.Queries;

public class GetUserQuizResultsQuery : IRequest<List<QuizResultDto>>
{
    public string UserId { get; set; }
}