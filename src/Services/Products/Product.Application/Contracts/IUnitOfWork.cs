using Product.Application.Contracts.VideoGamesContracts;

namespace Product.Application.Contracts
{
    public interface IUnitOfWork
    {
        IGameRepository GameRepository { get; }
    }
}
