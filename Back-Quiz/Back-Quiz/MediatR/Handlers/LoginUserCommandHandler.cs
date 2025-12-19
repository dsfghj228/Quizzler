using Back_Quiz.Dtos.Account;
using Back_Quiz.Interfaces;
using Back_Quiz.MediatR.Commands;
using MediatR;

namespace Back_Quiz.MediatR.Handlers;

public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, ReturnUserDto>
{
    private readonly IAccountService _accountService;
    private readonly ITokenService _tokenService;
    
    public LoginUserCommandHandler(IAccountService accountService, ITokenService tokenService)
    {
        _accountService = accountService;
        _tokenService = tokenService;
    }
    
    public async Task<ReturnUserDto> Handle(LoginUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _accountService.DoesUserExist(request);

        return new ReturnUserDto
        {
            UserName = user.UserName,
            Email = user.Email,
            Token = _tokenService.GenerateToken(user)
        };
    }
}