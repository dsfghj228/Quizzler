using Back_Quiz.Dtos.Account;
using MediatR;

namespace Back_Quiz.MediatR.Commands;

public class LoginUserCommand : IRequest<ReturnUserDto>
{
    public string Username { get; set; }
    public string Password { get; set; }
}