using Ecommerce.Core.Models;
using MediatR;

namespace Ecommerce.Application.MediatRManagement.Commands;

public record UserSignInCommand(User User): IRequest;