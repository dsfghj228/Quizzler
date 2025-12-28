using Back_Quiz.Dtos.Quiz;
using Back_Quiz.Interfaces;
using Back_Quiz.MediatR.Queries;
using MediatR;

namespace Back_Quiz.MediatR.Handlers;

public class GetQuizResultByIdQueryHandler : IRequestHandler<GetQuizResultByIdQuery, QuizResultDto>
{
    private readonly IQuizResultRepository _resultRepository;
    
    public GetQuizResultByIdQueryHandler(IQuizResultRepository resultRepository)
    {
        _resultRepository = resultRepository;
    }
    
    public async Task<QuizResultDto> Handle(GetQuizResultByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _resultRepository.GetQuizResultById(request.UserId, request.QuizId);
        
        var resultDto = new QuizResultDto
        {
            ResultId = result.Id,
            UserId = result.UserId,
            SessionId = result.SessionId,
            TotalQuestions = result.TotalQuestions,
            CorrectAnswers = result.CorrectAnswers,
            CompletedAt = result.CompletedAt
        };
        
        return resultDto;
    }
}