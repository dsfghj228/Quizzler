using Back_Quiz.Dtos.Quiz;
using Back_Quiz.Interfaces;
using Back_Quiz.MediatR.Queries;
using MediatR;

namespace Back_Quiz.MediatR.Handlers;

public class GetUserQuizResultsQueryHandler : IRequestHandler<GetUserQuizResultsQuery, List<QuizResultDto>>
{
    private readonly IQuizResultRepository _resultRepository;
    
    public GetUserQuizResultsQueryHandler(IQuizResultRepository resultRepository)
    {
        _resultRepository = resultRepository;
    }
    
    public async Task<List<QuizResultDto>> Handle(GetUserQuizResultsQuery request, CancellationToken cancellationToken)
    {
        var results = await _resultRepository.GetQuizResults(request.UserId);
        
        var resultDtos = results.Select(r => new QuizResultDto
        {
            ResultId = r.Id,
            UserId = r.UserId,
            SessionId = r.SessionId,
            TotalQuestions = r.TotalQuestions,
            CorrectAnswers = r.CorrectAnswers,
            CompletedAt = r.CompletedAt
        }).ToList();
        
        return resultDtos;
    }
}
