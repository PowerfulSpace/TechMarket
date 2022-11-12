using Game = Product.Domain.Electronics.VideoGames.Games;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Product.Application.Contracts;
using Product.Application.Errors;
using Product.Application.Features.GameFeatures.Requests.Commands;

namespace Product.Application.Features.GameFeatures.Handlers.Commands
{
    public class UpdateGameCommandHandler : IRequestHandler<UpdateGameCommand, Unit>
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;
        public UpdateGameCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateGameCommand request, CancellationToken cancellationToken)
        {
            if (await _unitOfWork.GameRepository.UpdateAsync(_mapper.Map<Game>(request.model), request.id))
                return Unit.Value;
            throw new BaseNotFoundException("Game", request.id.ToString());
        }
    }
}
