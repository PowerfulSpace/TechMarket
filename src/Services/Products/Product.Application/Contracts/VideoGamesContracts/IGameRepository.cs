using Game = Product.Domain.Electronics.VideoGames.Games;

namespace Product.Application.Contracts.VideoGamesContracts
{
    public interface IGameRepository : IGenericRepository<Game>
    {
        
    }
}
