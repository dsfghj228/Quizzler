using Back_Quiz.MediatR.Queries;
using FluentValidation;

namespace Back_Quiz.FluentValidation.Validation.Account;

public class GetCurrentQuestionQueryValidator : AbstractValidator<GetCurrentQuestionQuery>
{
    public GetCurrentQuestionQueryValidator()
    {
        RuleFor(x => x.SessionId).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
    }
}