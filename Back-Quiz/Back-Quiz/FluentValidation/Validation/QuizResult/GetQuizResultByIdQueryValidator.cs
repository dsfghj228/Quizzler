using Back_Quiz.MediatR.Queries;
using FluentValidation;

namespace Back_Quiz.FluentValidation.Validation.QuizResult;

public class GetQuizResultByIdQueryValidator : AbstractValidator<GetQuizResultByIdQuery>
{
    public GetQuizResultByIdQueryValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.QuizId).NotEmpty();
    }
}