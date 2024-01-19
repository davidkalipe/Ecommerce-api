using MediatR;

namespace Ecommerce.Application.MediatorManagement.Commands;

public record UserSignInCommand(string PhoneNumber, string Password): IRequest;