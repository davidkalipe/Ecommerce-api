using Ecommerce.Core.Models;
using MediatR;

namespace Ecommerce.Application.MediatorManagement.Commands;

public record UserSignUpCommand(User User) : IRequest;