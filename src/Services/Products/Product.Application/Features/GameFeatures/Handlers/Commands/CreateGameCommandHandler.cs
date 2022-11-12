using Game = Product.Domain.Electronics.VideoGames.Games;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Product.Application.Contracts;
using Product.Application.Features.GameFeatures.Requests.Commands;

namespace Product.Application.Features.GameFeatures.Handlers.Commands
{
    public class CreateGameCommandHandler : IRequestHandler<CreateGameCommand, Unit>
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;
        public CreateGameCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateGameCommand request, CancellationToken cancellationToken)
        {
            var game = _mapper.Map<Game>(request.model);
            await _unitOfWork.GameRepository.CreateAsync(game);
            return Unit.Value;
        }
    }
}
