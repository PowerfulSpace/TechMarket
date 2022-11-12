using System.Collections.Generic;
using MediatR;
using Product.Application.DTOs.VideoGames.GameDTOs;

namespace Product.Application.Features.GameFeatures.Requests.Queries
{
    public record GetAllGamesQuery : IRequest<IEnumerable<GameDto>>;
}
