using Ecommerce.Application.Interfaces;
using Ecommerce.Application.MediatRManagement.Commands;
using MediatR;

namespace Ecommerce.Application.MediatRManagement.Handlers;

public class UserSignInHandler : IRequestHandler<UserSignInCommand>
{
    private readonly IUserService _userService;

    public UserSignInHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task Handle(UserSignInCommand request, CancellationToken cancellationToken)
    {
        await _userService.SignIn(request.PhoneNumber, request.Password);
        return;
    }
}