using MediatR;
using Product.Application.DTOs.VideoGames.GameDTOs;

namespace Product.Application.Features.GameFeatures.Requests.Commands
{
    public record CreateGameCommand(CreateGameDto model) : IRequest;
}
