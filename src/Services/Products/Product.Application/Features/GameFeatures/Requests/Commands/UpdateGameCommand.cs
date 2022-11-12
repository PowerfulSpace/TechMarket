using System;
using MediatR;
using Product.Application.DTOs.VideoGames.GameDTOs;

namespace Product.Application.Features.GameFeatures.Requests.Commands
{
    public record UpdateGameCommand(UpdateGameDto model, Guid id) : IRequest;
}
