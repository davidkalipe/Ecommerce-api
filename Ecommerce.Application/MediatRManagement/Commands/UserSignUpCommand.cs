using Ecommerce.Core.Models;
using MediatR;

namespace Ecommerce.Application.MediatRManagement.Commands;

public record UserSignUpCommand(User User) : IRequest;