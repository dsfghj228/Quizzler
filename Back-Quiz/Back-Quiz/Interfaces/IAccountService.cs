using Back_Quiz.Dtos.Account;
using Back_Quiz.MediatR.Commands;
using Back_Quiz.Models;

namespace Back_Quiz.Interfaces;

public interface IAccountService
{
    Task CheckUser(RegisterNewUserCommand command);
    Task<AppUser> DoesUserExist(LoginUserCommand command);
}