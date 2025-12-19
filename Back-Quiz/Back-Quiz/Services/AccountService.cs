using Back_Quiz.Dtos.Account;
using Back_Quiz.Exceptions;
using Back_Quiz.Interfaces;
using Back_Quiz.MediatR.Commands;
using Back_Quiz.Models;
using Microsoft.AspNetCore.Identity;

namespace Back_Quiz.Services;

public class AccountService : IAccountService
{
    private readonly UserManager<AppUser> _userManager;
    
    public AccountService(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }
    
    public async Task CheckUser(RegisterNewUserCommand command)
    {
        var existingUser = await _userManager.FindByNameAsync(command.Username);
        if (existingUser != null)
        {
            throw new CustomExceptions.UserAlreadyExistsException();
        }
    }

    public async Task<AppUser> DoesUserExist(LoginUserCommand command)
    {
        var user = _userManager.Users.FirstOrDefault(u => u.UserName == command.Username);
        
        if (user == null)
        {
            throw new CustomExceptions.UnauthorizedUsernameException();
        }
        
        if(!await _userManager.CheckPasswordAsync(user, command.Password))
        {
            throw new CustomExceptions.UnauthorizedPasswordException();
        }
        
        return user;
    }
}