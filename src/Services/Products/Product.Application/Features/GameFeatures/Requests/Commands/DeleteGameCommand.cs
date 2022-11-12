using System;
using MediatR;

namespace Product.Application.Features.GameFeatures.Requests.Commands
{
    public record DeleteGameCommand(Guid id) : IRequest;
}
