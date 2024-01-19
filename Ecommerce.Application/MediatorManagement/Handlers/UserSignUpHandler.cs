using Ecommerce.Application.Interfaces;
using Ecommerce.Application.MediatorManagement.Commands;
using MediatR;

namespace Ecommerce.Application.MediatorManagement.Handlers;

public class UserSignUpHandler : IRequestHandler<UserSignUpCommand>
{
    private readonly IUserService _userService;

    public UserSignUpHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task Handle(UserSignUpCommand request, CancellationToken cancellationToken)
    {
        await _userService.SignUp(request.User);
        return;
    }
}