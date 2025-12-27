using Back_Quiz.MediatR.Commands;
using FluentValidation;

namespace Back_Quiz.FluentValidation.Validation.Account;

public class FinishQuizCommandValidator : AbstractValidator<FinishQuizCommand>
{
    public FinishQuizCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.SessionId).NotEmpty();
    }
}