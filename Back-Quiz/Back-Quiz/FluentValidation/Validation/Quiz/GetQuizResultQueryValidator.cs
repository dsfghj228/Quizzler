using Back_Quiz.MediatR.Queries;
using FluentValidation;

namespace Back_Quiz.FluentValidation.Validation.Account;

public class GetQuizResultQueryValidator : AbstractValidator<GetQuizResultQuery>
{
    public GetQuizResultQueryValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.SessionId).NotEmpty();
    }
}