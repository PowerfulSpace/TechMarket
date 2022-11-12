using System.Collections.Generic;
using MediatR;
using Product.Application.Features.GameFeatures.Requests.Queries;
using Product.Application.DTOs.VideoGames.GameDTOs;
using System.Threading.Tasks;
using System.Threading;
using Product.Application.Contracts;
using AutoMapper;

namespace Product.Application.Features.GameFeatures.Handlers.Queries
{
    public class GetAllGamesQueryHandler : IRequestHandler<GetAllGamesQuery, IEnumerable<GameDto>>
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;
        public GetAllGamesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GameDto>> Handle(GetAllGamesQuery request, CancellationToken cancellationToken)
            => _mapper.Map<IEnumerable<GameDto>>(await _unitOfWork.GameRepository.GetAllAsync());
    }
}
