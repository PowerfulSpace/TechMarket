using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Product.Application.Contracts;
using Product.Application.Errors;
using Product.Application.Features.GameFeatures.Requests.Commands;

namespace Product.Application.Features.GameFeatures.Handlers.Commands
{
    public class DeleteGameCommandHandler : IRequestHandler<DeleteGameCommand, Unit>
    {
        readonly IUnitOfWork _unitOfWork;
        public DeleteGameCommandHandler(IUnitOfWork unitOfWork)
            => _unitOfWork = unitOfWork;
        public async Task<Unit> Handle(DeleteGameCommand request, CancellationToken cancellationToken)
        {
            if (await _unitOfWork.GameRepository.DeleteAsync(request.id))
                return Unit.Value;
            throw new BaseNotFoundException("Game", request.id.ToString());
        }
    }
}
