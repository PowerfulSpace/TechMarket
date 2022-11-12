using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Product.Application.Contracts;
using Product.Application.DTOs.VideoGames.GameDTOs;
using Product.Application.Errors;
using Product.Application.Features.GameFeatures.Requests.Queries;

namespace Product.Application.Features.GameFeatures.Handlers.Queries
{
    public class GetGameByIdQueryHandler : IRequestHandler<GetGameByIdQuery, GameDto>
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;
        public GetGameByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GameDto> Handle(GetGameByIdQuery request, CancellationToken cancellationToken)
        {
            var game = await _unitOfWork.GameRepository.GetByIdAsync(request.id);
            if (game is null)
                throw new BaseNotFoundException("Game", request.id.ToString());
            return _mapper.Map<GameDto>(game);
        }
    }
}
