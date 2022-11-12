using System;
using MediatR;
using Product.Application.DTOs.VideoGames.GameDTOs;

namespace Product.Application.Features.GameFeatures.Requests.Queries
{
    public record GetGameByIdQuery(Guid id) : IRequest<GameDto>;
}
